﻿using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidJNI;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Text.Json;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public class AndroidApiService<T_ARG>
        : IAndroidTaskScheduler<AndroidApiService<T_ARG>>
        where T_ARG : AndroidJniArgs
    {
        static JsonSerializerOptions JsonSerializer { get; }
        static AndroidApiService()
        {
            JsonSerializer = new JsonSerializerOptions();
            JsonSerializer.AddMonoJsonContext();
            JsonSerializer.TypeInfoResolverChain.Insert(0, GameJsonContext.Default);
        }

        public ILogger Logger { get; }
        public AndroidApiContext<T_ARG> Api { get; }
        public TaskScheduler AndroidScheduler { get; }

        public JavaVirtualMachineContext VirtualMachineContext => Api.VirtualMachineContext;
        public AndroidApiService<T_ARG> Context => this;


        public AndroidApiService(ILogger<AndroidApiService<T_ARG>> logger,
        AndroidApiContext<T_ARG> apiContext,
        AndroidTaskScheduler androidTaskScheduler)
        {
            Logger = logger;
            Api = apiContext;
            AndroidScheduler = androidTaskScheduler;
            CreateTasks(Environment.ProcessorCount);
        }

        void CreateTasks(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                _ = Task.Run(ExecTaskProc);
            }

            async ValueTask ExecTaskProc()
            {
                await foreach (var arg in Api.ReadAllAsync().ConfigureAwait(false))
                {
                    try
                    {
                        var actionName = await GetApiActionNameAsync(arg).ConfigureAwait(false);
                        Logger.Info($"actionName:{actionName}");
                        var exec = actionName switch
                        {
                            "test" => await ExecuteApiAsync<MonoPointerRequestDTO, string>(arg, p => TestApi(p)).ConfigureAwait(false),
                            _ => await ExecuteApiAsync(actionName, arg).ConfigureAwait(false),
                        };
                        Logger.Info($"ExecuteApiAsync:{exec}");
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(ex);
                    }
                    finally
                    {
                        await TryReleaseAsync(arg).ConfigureAwait(false);
                    }
                }
            }

        }

        string? GetApiActionName(T_ARG arg)
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return default;
            }
            return jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(arg.Action);

        }
        Task<string?> GetApiActionNameAsync(T_ARG arg)
        {
            return this.AndroidTaskAsync(static (p, args) => p.GetApiActionName(args), arg);
        }

        public T? GetApiJson<T>(T_ARG arg)
            where T : class
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return default;
            }

            var pString = jniEnvironmentContext.JNI_ENV.GetStringChars(arg.Json);
            try
            {
                return System.Text.Json.JsonSerializer.Deserialize<T>(pString.AsReadOnlySpan(), JsonSerializer);
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.ReleaseStringChars(arg.Json, pString);
            }

        }
        Task<T?> GetApiJsonAsync<T>(T_ARG arg) where T : class
        {
            return this.AndroidTaskAsync(static (p, args) => p.GetApiJson<T>(args), arg);
        }

        bool TryCallbackApiJson<T>(T_ARG arg, T data) where T : class
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return false;
            }
            var jsonData = System.Text.Json.JsonSerializer.Serialize(data, JsonSerializer);
            var pString = jniEnvironmentContext.JNI_ENV.CreateStringUnicode(jsonData);
            try
            {
                return jniEnvironmentContext.JNI_ENV.CallBooleanMethod(arg.Instance.Value, arg.MethodId, [new JVALUE(pString)]);
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.DeleteLocalRef(pString);
            }
        }
        Task<bool> TryCallbackApiJsonAsync<T>(T_ARG arg, T data) where T : class
        {
            return this.AndroidTaskAsync(static (p, args) => p.TryCallbackApiJson(args.arg, args.data), (arg, data));
        }

        bool TryRelease(T_ARG arg)
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return false;
            }
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Action);
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Json);
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Class);
            jniEnvironmentContext.JNI_ENV.DeleteWeakGlobalRef(arg.Instance);
            return true;
        }
        Task<bool> TryReleaseAsync(T_ARG arg)
        {
            return this.AndroidTaskAsync(static (p, args) => p.TryRelease(args), arg);
        }

        protected async ValueTask<bool> ExecuteApiAsync<TRequest, TResult>(T_ARG arg, Func<TRequest, ValueTask<TResult>> func)
              where TRequest : class
              where TResult : class
        {
            try
            {
                var requestData = await GetApiJsonAsync<TRequest>(arg).ConfigureAwait(false);
                if (requestData is null)
                {
                    return AndroidJNIException.Throw<bool>("json is null");
                }
                var resData = await func(requestData).ConfigureAwait(false);
                return await TryCallbackApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("api err:{ex}", ex);
                await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("jni err:{ex}", ex);
                await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(new MonoCommonException(ex.Message))).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("system err:{ex}", ex);
                await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }
            return false;

        }
        protected virtual ValueTask<bool> ExecuteApiAsync(string? action, T_ARG arg)
        {
            return ValueTask.FromResult(false);
        }
        public ValueTask<string> TestApi(MonoPointerRequestDTO requestDTO)
        {
            return new ValueTask<string>(requestDTO.Pointer.ToString("X8"));
        }
    }
}