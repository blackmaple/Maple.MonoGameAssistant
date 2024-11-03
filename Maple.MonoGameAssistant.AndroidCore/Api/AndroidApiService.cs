using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
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
        public TaskScheduler AndroidScheduler { get; } = androidTaskScheduler;

        public JavaVirtualMachineContext VirtualMachineContext => Api.VirtualMachineContext;
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
                    await TryReleaseAsync(arg).ConfigureAwait(false);
                }
            }
        }

        public ValueTask StopAsync()
        {
            this.Api.TryComplete();
            return ValueTask.CompletedTask;
        }





        public T? GetApiJson<T>(AndroidApiArgs arg)
            where T : class
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return default;
            }
            if (!JsonSerializer.TryGetTypeInfo(typeof(T), out var jsonTypeInfo))
            {
                return default;
            }
            var pString = jniEnvironmentContext.JNI_ENV.GetStringChars(arg.Json);
            try
            {

                return System.Text.Json.JsonSerializer.Deserialize(pString.AsReadOnlySpan(), jsonTypeInfo) as T;
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
                return AndroidJNIException.Throw<T>("json is null");
            }
            return requestData;
        }

        bool TryCallbackApiJson<T>(AndroidApiArgs arg, T data) where T : class
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return false;
            }

            var callback = VirtualActionApiCallbackInstance.Create(jniEnvironmentContext, arg.Instance.Value);

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
        Task<bool> TryCallbackApiJsonAsync<T>(AndroidApiArgs arg, T data) where T : class
        {
            return this.AndroidTaskAsync(static (p, args) => p.TryCallbackApiJson(args.arg, args.data), (arg, data));
        }

        bool TryRelease(AndroidApiArgs arg)
        {
            if (!VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                return false;
            }
            //jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Action);
            jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Json);
            //     jniEnvironmentContext.JNI_ENV.DeleteGlobalRef(arg.Class);
            jniEnvironmentContext.JNI_ENV.DeleteWeakGlobalRef(arg.Instance);
            return true;
        }
        Task<bool> TryReleaseAsync(AndroidApiArgs arg)
        {
            return this.AndroidTaskAsync(static (p, args) => p.TryRelease(args), arg);
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
                Logger.LogError("api err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("jni err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<TResult>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("system err:{ex}", ex);
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
                Logger.LogError("api err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("jni err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<TRequest>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("system err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }


        }

        protected virtual async ValueTask<bool> ExecuteApiAsync(int action, AndroidApiArgs arg)
        {
            try
            {
                var requestData = await GetRequiredApiJsonAsync<GameSessionObjectDTO>(arg).ConfigureAwait(false);
                return await TryCallbackApiJsonAsync(arg, requestData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("api err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("jni err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetBizError<bool>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("system err:{ex}", ex);
                return await TryCallbackApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }
        }

    }


    public sealed class VirtualActionApiCallbackReference : JavaClassReference<VirtualActionApiCallbackReference, VirtualActionApiCallbackMetadata>
    {


        public JBOOLEAN None(JOBJECT @this, JSTRING json) => this.Metadata.Callback_None(this.Jni, @this, json);


        public JBOOLEAN EnumImages(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumImages(this.Jni, @this, json);
        public JBOOLEAN EnumClasses(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClasses(this.Jni, @this, json);
        public JBOOLEAN EnumObjects(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumObjects(this.Jni, @this, json);
        public JBOOLEAN EnumClassDetail(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClassDetail(this.Jni, @this, json);


        public JBOOLEAN INFO(JOBJECT @this, JSTRING json) => this.Metadata.Callback_INFO(this.Jni, @this, json);
        public JBOOLEAN LoadResource(JOBJECT @this, JSTRING json) => this.Metadata.Callback_LoadResource(this.Jni, @this, json);
        public JBOOLEAN GetListCurrencyDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCurrencyDisplay(this.Jni, @this, json);
        public JBOOLEAN GetCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCurrencyInfo(this.Jni, @this, json);
        public JBOOLEAN UpdateCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCurrencyInfo(this.Jni, @this, json);
        public JBOOLEAN GetListInventoryDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListInventoryDisplay(this.Jni, @this, json);
        public JBOOLEAN GetInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetInventoryInfo(this.Jni, @this, json);
        public JBOOLEAN UpdateInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateInventoryInfo(this.Jni, @this, json);
        public JBOOLEAN GetListCharacterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCharacterDisplay(this.Jni, @this, json);
        public JBOOLEAN GetCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterStatus(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterStatus(this.Jni, @this, json);
        public JBOOLEAN GetCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterEquipment(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterEquipment(this.Jni, @this, json);
        public JBOOLEAN GetCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterSkill(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterSkill(this.Jni, @this, json);
        public JBOOLEAN GetListMonsterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListMonsterDisplay(this.Jni, @this, json);
        public JBOOLEAN AddMonsterMember(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddMonsterMember(this.Jni, @this, json);
        public JBOOLEAN GetListSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSkillDisplay(this.Jni, @this, json);
        public JBOOLEAN AddSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddSkillDisplay(this.Jni, @this, json);
        public JBOOLEAN GetListSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSwitchDisplay(this.Jni, @this, json);
        public JBOOLEAN UpdateSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateSwitchDisplay(this.Jni, @this, json);

    }

    public sealed class VirtualActionApiCallbackMetadata : JavaClassMetadata<VirtualActionApiCallbackMetadata>
    {
        JMETHODID Method_None;
        //MONO
        JMETHODID Method_EnumImages;
        JMETHODID Method_EnumClasses;
        JMETHODID Method_EnumObjects;
        JMETHODID Method_EnumClassDetail;
        //GAME
        JMETHODID Method_INFO;
        JMETHODID Method_LoadResource;
        JMETHODID Method_GetListCurrencyDisplay;
        JMETHODID Method_GetCurrencyInfo;
        JMETHODID Method_UpdateCurrencyInfo;
        JMETHODID Method_GetListInventoryDisplay;
        JMETHODID Method_GetInventoryInfo;
        JMETHODID Method_UpdateInventoryInfo;
        JMETHODID Method_GetListCharacterDisplay;
        JMETHODID Method_GetCharacterStatus;
        JMETHODID Method_UpdateCharacterStatus;
        JMETHODID Method_GetCharacterEquipment;
        JMETHODID Method_UpdateCharacterEquipment;
        JMETHODID Method_GetCharacterSkill;
        JMETHODID Method_UpdateCharacterSkill;
        JMETHODID Method_GetListMonsterDisplay;
        JMETHODID Method_AddMonsterMember;
        JMETHODID Method_GetListSkillDisplay;
        JMETHODID Method_AddSkillDisplay;
        JMETHODID Method_GetListSwitchDisplay;
        JMETHODID Method_UpdateSwitchDisplay;

        protected override void FindMethods(in JniEnvironmentContext context)
        {
            //boolean Method( String json)

            var methodDesc = "(Ljava/lang/String;)Z\0"u8;

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "None\0"u8, methodDesc, out Method_None);

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumImages\0"u8, methodDesc, out Method_EnumImages);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumClasses\0"u8, methodDesc, out Method_EnumClasses);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumObjects\0"u8, methodDesc, out Method_EnumObjects);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumClassDetail\0"u8, methodDesc, out Method_EnumClassDetail);

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "INFO\0"u8, methodDesc, out Method_INFO);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "LoadResource\0"u8, methodDesc, out Method_LoadResource);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListCurrencyDisplay\0"u8, methodDesc, out Method_GetListCurrencyDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCurrencyInfo\0"u8, methodDesc, out Method_GetCurrencyInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCurrencyInfo\0"u8, methodDesc, out Method_UpdateCurrencyInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListInventoryDisplay\0"u8, methodDesc, out Method_GetListInventoryDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetInventoryInfo\0"u8, methodDesc, out Method_GetInventoryInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateInventoryInfo\0"u8, methodDesc, out Method_UpdateInventoryInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListCharacterDisplay\0"u8, methodDesc, out Method_GetListCharacterDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterStatus\0"u8, methodDesc, out Method_GetCharacterStatus);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterStatus\0"u8, methodDesc, out Method_UpdateCharacterStatus);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterEquipment\0"u8, methodDesc, out Method_GetCharacterEquipment);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterEquipment\0"u8, methodDesc, out Method_UpdateCharacterEquipment);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterSkill\0"u8, methodDesc, out Method_GetCharacterSkill);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterSkill\0"u8, methodDesc, out Method_UpdateCharacterSkill);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListMonsterDisplay\0"u8, methodDesc, out Method_GetListMonsterDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "AddMonsterMember\0"u8, methodDesc, out Method_AddMonsterMember);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListSkillDisplay\0"u8, methodDesc, out Method_GetListSkillDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "AddSkillDisplay\0"u8, methodDesc, out Method_AddSkillDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListSwitchDisplay\0"u8, methodDesc, out Method_GetListSwitchDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateSwitchDisplay\0"u8, methodDesc, out Method_UpdateSwitchDisplay);
        }

        public JBOOLEAN Callback_None(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_None, json);
        public JBOOLEAN Callback_EnumImages(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_EnumImages, json);
        public JBOOLEAN Callback_EnumClasses(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_EnumClasses, json);
        public JBOOLEAN Callback_EnumObjects(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_EnumObjects, json);
        public JBOOLEAN Callback_EnumClassDetail(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_EnumClassDetail, json);
        public JBOOLEAN Callback_INFO(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_INFO, json);
        public JBOOLEAN Callback_LoadResource(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_LoadResource, json);
        public JBOOLEAN Callback_GetListCurrencyDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListCurrencyDisplay, json);
        public JBOOLEAN Callback_GetCurrencyInfo(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetCurrencyInfo, json);
        public JBOOLEAN Callback_UpdateCurrencyInfo(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateCurrencyInfo, json);
        public JBOOLEAN Callback_GetListInventoryDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListInventoryDisplay, json);
        public JBOOLEAN Callback_GetInventoryInfo(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetInventoryInfo, json);
        public JBOOLEAN Callback_UpdateInventoryInfo(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateInventoryInfo, json);
        public JBOOLEAN Callback_GetListCharacterDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListCharacterDisplay, json);
        public JBOOLEAN Callback_GetCharacterStatus(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetCharacterStatus, json);
        public JBOOLEAN Callback_UpdateCharacterStatus(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateCharacterStatus, json);
        public JBOOLEAN Callback_GetCharacterEquipment(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetCharacterEquipment, json);
        public JBOOLEAN Callback_UpdateCharacterEquipment(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateCharacterEquipment, json);
        public JBOOLEAN Callback_GetCharacterSkill(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetCharacterSkill, json);
        public JBOOLEAN Callback_UpdateCharacterSkill(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateCharacterSkill, json);
        public JBOOLEAN Callback_GetListMonsterDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListMonsterDisplay, json);
        public JBOOLEAN Callback_AddMonsterMember(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_AddMonsterMember, json);
        public JBOOLEAN Callback_GetListSkillDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListSkillDisplay, json);
        public JBOOLEAN Callback_AddSkillDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_AddSkillDisplay, json);
        public JBOOLEAN Callback_GetListSwitchDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_GetListSwitchDisplay, json);
        public JBOOLEAN Callback_UpdateSwitchDisplay(in JniEnvironmentContext context, JOBJECT @this, JSTRING json) => context.JNI_ENV.CallBooleanMethod(@this, Method_UpdateSwitchDisplay, json);

    }

    public sealed class VirtualActionApiCallbackInstance(JOBJECT ptr, VirtualActionApiCallbackReference reference)
        : JavaClassInstance<VirtualActionApiCallbackReference>(ptr, reference)
    {

        public static VirtualActionApiCallbackInstance Create(in JniEnvironmentContext jniEnvironmentContext, JOBJECT ptr)
        {
            var classObj = jniEnvironmentContext.JNI_ENV.GetObjectClass(ptr);
            return new VirtualActionApiCallbackInstance(ptr, VirtualActionApiCallbackReference.CreateReference(jniEnvironmentContext, classObj));
        }


        public JBOOLEAN None(JSTRING json) => this.Reference.None(this.Instance, json);


        public JBOOLEAN EnumImages(JSTRING json) => this.Reference.EnumImages(this.Instance, json);
        public JBOOLEAN EnumClasses(JSTRING json) => this.Reference.EnumClasses(this.Instance, json);
        public JBOOLEAN EnumObjects(JSTRING json) => this.Reference.EnumObjects(this.Instance, json);
        public JBOOLEAN EnumClassDetail(JSTRING json) => this.Reference.EnumClassDetail(this.Instance, json);


        public JBOOLEAN INFO(JSTRING json) => this.Reference.INFO(this.Instance, json);
        public JBOOLEAN LoadResource(JSTRING json) => this.Reference.LoadResource(this.Instance, json);
        public JBOOLEAN GetListCurrencyDisplay(JSTRING json) => this.Reference.GetListCurrencyDisplay(this.Instance, json);
        public JBOOLEAN GetCurrencyInfo(JSTRING json) => this.Reference.GetCurrencyInfo(this.Instance, json);
        public JBOOLEAN UpdateCurrencyInfo(JSTRING json) => this.Reference.UpdateCurrencyInfo(this.Instance, json);
        public JBOOLEAN GetListInventoryDisplay(JSTRING json) => this.Reference.GetListInventoryDisplay(this.Instance, json);
        public JBOOLEAN GetInventoryInfo(JSTRING json) => this.Reference.GetInventoryInfo(this.Instance, json);
        public JBOOLEAN UpdateInventoryInfo(JSTRING json) => this.Reference.UpdateInventoryInfo(this.Instance, json);
        public JBOOLEAN GetListCharacterDisplay(JSTRING json) => this.Reference.GetListCharacterDisplay(this.Instance, json);
        public JBOOLEAN GetCharacterStatus(JSTRING json) => this.Reference.GetCharacterStatus(this.Instance, json);
        public JBOOLEAN UpdateCharacterStatus(JSTRING json) => this.Reference.UpdateCharacterStatus(this.Instance, json);
        public JBOOLEAN GetCharacterEquipment(JSTRING json) => this.Reference.GetCharacterEquipment(this.Instance, json);
        public JBOOLEAN UpdateCharacterEquipment(JSTRING json) => this.Reference.UpdateCharacterEquipment(this.Instance, json);
        public JBOOLEAN GetCharacterSkill(JSTRING json) => this.Reference.GetCharacterSkill(this.Instance, json);
        public JBOOLEAN UpdateCharacterSkill(JSTRING json) => this.Reference.UpdateCharacterSkill(this.Instance, json);
        public JBOOLEAN GetListMonsterDisplay(JSTRING json) => this.Reference.GetListMonsterDisplay(this.Instance, json);
        public JBOOLEAN AddMonsterMember(JSTRING json) => this.Reference.AddMonsterMember(this.Instance, json);
        public JBOOLEAN GetListSkillDisplay(JSTRING json) => this.Reference.GetListSkillDisplay(this.Instance, json);
        public JBOOLEAN AddSkillDisplay(JSTRING json) => this.Reference.AddSkillDisplay(this.Instance, json);
        public JBOOLEAN GetListSwitchDisplay(JSTRING json) => this.Reference.GetListSwitchDisplay(this.Instance, json);
        public JBOOLEAN UpdateSwitchDisplay(JSTRING json) => this.Reference.UpdateSwitchDisplay(this.Instance, json);

    }

}
