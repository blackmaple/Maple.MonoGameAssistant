using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Text.Json;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public class AndroidApiService(
        ILogger<AndroidApiService> logger,
        AndroidApiContext apiContext,
        AndroidTaskScheduler androidTaskScheduler,
        IServiceProvider serviceProvider,
        MonoGameSettings gameSettings)
                : IAndroidTaskScheduler<AndroidApiService>
    {
        static JsonSerializerOptions JsonSerializer { get; }
        static AndroidApiService()
        {

            JsonSerializer = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            JsonSerializer.AddMonoJsonContext();
            JsonSerializer.TypeInfoResolverChain.Insert(0, GameJsonContext.Default);
        }

        IServiceProvider ServiceProvider { get; } = serviceProvider;
        public ILogger Logger { get; } = logger;
        public AndroidApiContext Api { get; } = apiContext;
        public TaskScheduler AndroidScheduler => Scheduler;
        public AndroidTaskScheduler Scheduler { get; } = androidTaskScheduler;

        //    public JavaVirtualMachineContext VirtualMachineContext => Api.VirtualMachineContext;
        public AndroidApiService Context => this;

        public MonoGameSettings GameSettings { get; } = gameSettings;

        public ValueTask StartAsync()
        {
            CreateTasks(Environment.ProcessorCount);

            return ValueTask.CompletedTask;
            void CreateTasks(int count)
            {
                for (int i = 0; i < count; ++i)
                {
                    _ = Task.Run(ExecTaskProc);
                }


            }

        }

        async ValueTask ExecTaskProc()
        {
            await foreach (var arg in Api.ReadAllAsync().ConfigureAwait(false))
            {
                try
                {
                    var actionIndex = (int)arg.Action;

                    //if ((int)EnumApiActionIndex.None == actionIndex)
                    //{
                    //    await ExecuteApiAsync<IGameWebApiControllers, GameSessionInfoDTO>(arg, static (api) => api.GetSessionInfoAsync()).ConfigureAwait(false);
                    //}

                    if (GameSettings.MonoDataCollector)
                    {
                        //mono
                        if ((int)EnumApiActionIndex.EnumImages == actionIndex)
                        {
                            await ExecuteApiAsync<MonoCollectorApiService, MonoImageInfoDTO[]>(arg, static (api) => new(api.EnumMonoImagesAsync())).ConfigureAwait(false);
                        }
                        else if ((int)EnumApiActionIndex.EnumClasses == actionIndex)
                        {
                            await ExecuteApiAsync<MonoCollectorApiService, MonoPointerRequestDTO, MonoClassInfoDTO[]>(arg, static (api, req) => new(api.EnumMonoClassesAsync(req.Pointer))).ConfigureAwait(false);
                        }
                        else if ((int)EnumApiActionIndex.EnumObjects == actionIndex)
                        {
                            await ExecuteApiAsync<MonoCollectorApiService, MonoPointerRequestDTO, MonoObjectInfoDTO[]>(arg, static (api, req) => new(api.EnumMonoObjectsAsync(req.Pointer))).ConfigureAwait(false);
                        }
                        else if ((int)EnumApiActionIndex.EnumClassDetail == actionIndex)
                        {
                            await ExecuteApiAsync<MonoCollectorApiService, MonoClassDetailRequestDTO, MonoClassDetailDTO>(arg, static (api, req) => new(api.EnumMonoClassDetailAsync(req.Pointer, req.FieldOptions))).ConfigureAwait(false);
                        }
                    }

                    //game
                    if ((int)EnumApiActionIndex.INFO == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSessionInfoDTO>(arg, static (api) => api.GetSessionInfoAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.LoadResource == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSessionInfoDTO>(arg, static (api) => api.LoadResourceAsync()).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListCurrencyDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCurrencyDisplayDTO[]>(arg, static (api) => api.GetListCurrencyDisplayAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.GetCurrencyInfo == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCurrencyObjectDTO, GameCurrencyInfoDTO>(arg, static (api, req) => api.GetCurrencyInfoAsync(req)).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateCurrencyInfo == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCurrencyModifyDTO, GameCurrencyInfoDTO>(arg, static (api, req) => api.UpdateCurrencyInfoAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListInventoryDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameInventoryDisplayDTO[]>(arg, static (api) => api.GetListInventoryDisplayAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.GetInventoryInfo == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameInventoryObjectDTO, GameInventoryInfoDTO>(arg, static (api, req) => api.GetInventoryInfoAsync(req)).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateInventoryInfo == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameInventoryModifyDTO, GameInventoryInfoDTO>(arg, static (api, req) => api.UpdateInventoryInfoAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListCharacterDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterDisplayDTO[]>(arg, static (api) => api.GetListCharacterDisplayAsync()).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetCharacterStatus == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterStatusDTO>(arg, static (api, req) => api.GetCharacterStatusAsync(req)).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateCharacterStatus == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterStatusDTO>(arg, static (api, req) => api.UpdateCharacterStatusAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetCharacterEquipment == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterEquipmentDTO>(arg, static (api, req) => api.GetCharacterEquipmentAsync(req)).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateCharacterEquipment == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterEquipmentDTO>(arg, static (api, req) => api.UpdateCharacterEquipmentAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetCharacterSkill == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.GetCharacterSkillAsync(req)).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateCharacterSkill == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.UpdateCharacterSkillAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListMonsterDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameMonsterDisplayDTO[]>(arg, static (api) => api.GetListMonsterDisplayAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.AddMonsterMember == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameMonsterObjectDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.AddMonsterMemberAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListSkillDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSkillDisplayDTO[]>(arg, static (api) => api.GetListSkillDisplayAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.AddSkillDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSkillObjectDTO, GameSkillDisplayDTO>(arg, static (api, req) => api.AddSkillDisplayAsync(req)).ConfigureAwait(false);
                    }

                    else if ((int)EnumApiActionIndex.GetListSwitchDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSwitchDisplayDTO[]>(arg, static (api) => api.GetListSwitchDisplayAsync()).ConfigureAwait(false);
                    }
                    else if ((int)EnumApiActionIndex.UpdateSwitchDisplay == actionIndex)
                    {
                        await ExecuteApiAsync<IGameWebApiControllers, GameSwitchModifyDTO, GameSwitchDisplayDTO>(arg, static (api, req) => api.UpdateSwitchDisplayAsync(req)).ConfigureAwait(false);
                    }
                    else
                    {
                        await ExecuteApiAsync(actionIndex, arg).ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                }
                finally
                {
                    await ReleaseAsync(arg).ConfigureAwait(false);
                }
            }
        }

        public ValueTask StopAsync()
        {
            this.Api.TryComplete();
            return ValueTask.CompletedTask;
        }





        T? GetApiJson<T>(AndroidApiArgs arg)
          where T : class
        {
            //if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            //{
            //    return default;
            //}
            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;

            if (!JsonSerializer.TryGetTypeInfo(typeof(T), out var jsonTypeInfo))
            {
                return default;
            }

            var pString = jniEnvironmentContext.JNI_ENV.GetStringChars(arg.Json);
            var strSize = jniEnvironmentContext.JNI_ENV.GetStringLength(arg.Json);
            try
            {
                return System.Text.Json.JsonSerializer.Deserialize(pString.AsReadOnlySpan(strSize), jsonTypeInfo) as T;
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.ReleaseStringChars(arg.Json, pString);
            }

        }
        async Task<T> GetRequiredApiJsonAsync<T>(AndroidApiArgs arg) where T : class
        {
            var requestData = await this.AndroidTaskAsync(static (p, args) => p.GetApiJson<T>(args), arg).ConfigureAwait(false);
            if (requestData is null)
            {
                return AndroidJNIException.Throw<T>($"{typeof(T).FullName}:JSON IS NULL");
            }
            return requestData;
        }

        bool TryCallbackApiJson<T>(AndroidApiArgs arg, T data) where T : class
        {
            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;

 
            VirtualActionApiCallbackInstance callback;
            callback = VirtualActionApiCallbackInstance.Create(jniEnvironmentContext, arg.Instance.Value);
            if (!JsonSerializer.TryGetTypeInfo(typeof(T), out var jsonTypeInfo))
            {
                return false;
            }

            var jsonData = System.Text.Json.JsonSerializer.Serialize(data, jsonTypeInfo);
            this.Logger.Info(jsonData);
            var javaJson = jniEnvironmentContext.JNI_ENV.CreateStringUnicode(jsonData);
            try
            {
                var actionIndex = (int)arg.Action;
                if ((int)EnumApiActionIndex.EnumImages == actionIndex)
                {
                    return callback.EnumImages(javaJson);
                }
                else if ((int)EnumApiActionIndex.EnumClasses == actionIndex)
                {
                    return callback.EnumClasses(javaJson);
                }
                else if ((int)EnumApiActionIndex.EnumObjects == actionIndex)
                {
                    return callback.EnumObjects(javaJson);
                }
                else if ((int)EnumApiActionIndex.EnumClassDetail == actionIndex)
                {
                    return callback.EnumClassDetail(javaJson);
                }

                //game
                else if ((int)EnumApiActionIndex.INFO == actionIndex)
                {
                    return callback.INFO(javaJson);
                }
                else if ((int)EnumApiActionIndex.LoadResource == actionIndex)
                {
                    return callback.LoadResource(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListCurrencyDisplay == actionIndex)
                {
                    return callback.GetListCurrencyDisplay(javaJson);
                }
                else if ((int)EnumApiActionIndex.GetCurrencyInfo == actionIndex)
                {
                    return callback.GetCurrencyInfo(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateCurrencyInfo == actionIndex)
                {
                    return callback.UpdateCurrencyInfo(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListInventoryDisplay == actionIndex)
                {
                    return callback.GetListInventoryDisplay(javaJson);
                }
                else if ((int)EnumApiActionIndex.GetInventoryInfo == actionIndex)
                {
                    return callback.GetInventoryInfo(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateInventoryInfo == actionIndex)
                {
                    return callback.UpdateInventoryInfo(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListCharacterDisplay == actionIndex)
                {
                    return callback.GetListCharacterDisplay(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetCharacterStatus == actionIndex)
                {
                    return callback.GetCharacterStatus(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateCharacterStatus == actionIndex)
                {
                    return callback.UpdateCharacterStatus(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetCharacterEquipment == actionIndex)
                {
                    return callback.GetCharacterEquipment(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateCharacterEquipment == actionIndex)
                {
                    return callback.UpdateCharacterEquipment(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetCharacterSkill == actionIndex)
                {
                    return callback.GetCharacterSkill(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateCharacterSkill == actionIndex)
                {
                    return callback.UpdateCharacterSkill(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListMonsterDisplay == actionIndex)
                {
                    return callback.GetListMonsterDisplay(javaJson);
                }
                else if ((int)EnumApiActionIndex.AddMonsterMember == actionIndex)
                {
                    return callback.AddMonsterMember(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListSkillDisplay == actionIndex)
                {
                    return callback.GetListSkillDisplay(javaJson);
                }
                else if ((int)EnumApiActionIndex.AddSkillDisplay == actionIndex)
                {
                    return callback.AddSkillDisplay(javaJson);
                }

                else if ((int)EnumApiActionIndex.GetListSwitchDisplay == actionIndex)
                {
                    return callback.GetListSwitchDisplay(javaJson);
                }
                else if ((int)EnumApiActionIndex.UpdateSwitchDisplay == actionIndex)
                {
                    return callback.UpdateSwitchDisplay(javaJson);
                }
                else
                {
                    return callback.None(javaJson);
                }
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.DeleteLocalRef(javaJson);
            }

        }
        async Task<bool> TryCallbackApiJsonAsync<T>(AndroidApiArgs arg, T data) where T : class
        {
            try
            {
                this.Logger.Info($"TryCallbackApiJsonAsync=>{typeof(T).FullName}");
                return await this.AndroidTaskAsync(static (p, args) => p.TryCallbackApiJson(args.arg, args.data), (arg, data));
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
            return false;
        }

        void Release(AndroidApiArgs arg)
        {
            //if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            //{
            //    return false;
            //}
            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            arg.Release(jniEnvironmentContext);
        }
        Task<bool> ReleaseAsync(AndroidApiArgs arg)
        {
            return this.AndroidTaskAsync(static (p, args) => p.Release(args), arg);
        }


        protected async ValueTask<bool> ExecuteApiAsync<TService, TResult>(AndroidApiArgs arg, Func<TService, ValueTask<TResult>> func)
            where TService : notnull
            where TResult : class
        {
            try
            {
                var actionApiService = this.ServiceProvider.GetRequiredService<TService>();
                var resData = await func(actionApiService).ConfigureAwait(false);
                return await TryCallbackApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<TResult>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} /system err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }

        }

        protected async ValueTask<bool> ExecuteApiAsync<TService, TRequest, TResult>(AndroidApiArgs arg, Func<TService, TRequest, ValueTask<TResult>> func)
            where TService : notnull
            where TRequest : class
            where TResult : class
        {
            try
            {
                var actionApiService = this.ServiceProvider.GetRequiredService<TService>();
                var requestData = await GetRequiredApiJsonAsync<TRequest>(arg).ConfigureAwait(false);

                var resData = await func(actionApiService, requestData).ConfigureAwait(false);
                return await TryCallbackApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<TResult>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} / system err:{ex}", (int)arg.Action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }



        }

        protected async ValueTask<bool> ExecuteApiAsync(int action, AndroidApiArgs arg)
        {
            try
            {
                var requestData = await GetRequiredApiJsonAsync<GameSessionObjectDTO>(arg).ConfigureAwait(false);
                return await TryCallbackApiJsonAsync(arg, requestData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<bool>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} / system err:{ex}", action, ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }


        }

    }

}
