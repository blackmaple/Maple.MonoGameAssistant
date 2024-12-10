using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
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
        static JsonTypeInfo GetJsonTypeInfoThrowIfNotFound<T>() where T : class
        {
            if (JsonSerializer.TryGetTypeInfo(typeof(T), out var jsonTypeInfo))
            {
                return jsonTypeInfo;
            }
            return AndroidServiceException.Throw<JsonTypeInfo>($"{typeof(T).FullName}:NOT FOUND JSON METADATA");
        }
        static T Json2Object<T>(ReadOnlySpan<char> json) where T : class
        {
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<T>();
            if (System.Text.Json.JsonSerializer.Deserialize(json, jsonTypeInfo) is T jsonObject)
            {
                return jsonObject;
            }
            return AndroidServiceException.Throw<T>($"{typeof(T).FullName}:FROM JSON IS NULL");
        }
        static string Json4Object<T>(T obj) where T : class
        {
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<T>();
            return System.Text.Json.JsonSerializer.Serialize(obj, jsonTypeInfo);
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
                    bool b = await ExecActionApiAsync(actionIndex, arg).ConfigureAwait(false);
                    this.Logger.LogInformation("ExecActionApi:{api} EXEC:{e}", actionIndex, b);
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


        ValueTask<bool> ExecActionApiAsync(int actionIndex, AndroidApiArgs arg)
        {
            return actionIndex switch
            {
                (int)EnumApiActionIndex.EnumImages
                => ExecuteApiAsync<MonoCollectorApiService, MonoImageInfoDTO[]>(arg, static (api) => new(api.EnumMonoImagesAsync())),

                (int)EnumApiActionIndex.EnumClasses
                => ExecuteApiAsync<MonoCollectorApiService, MonoPointerRequestDTO, MonoClassInfoDTO[]>(arg, static (api, req) => new(api.EnumMonoClassesAsync(req.Pointer))),

                (int)EnumApiActionIndex.EnumObjects
                => ExecuteApiAsync<MonoCollectorApiService, MonoPointerRequestDTO, MonoObjectInfoDTO[]>(arg, static (api, req) => new(api.EnumMonoObjectsAsync(req.Pointer))),

                (int)EnumApiActionIndex.EnumClassDetail
                => ExecuteApiAsync<MonoCollectorApiService, MonoClassDetailRequestDTO, MonoClassDetailDTO>(arg, static (api, req) => new(api.EnumMonoClassDetailAsync(req.Pointer, req.FieldOptions))),

                (int)EnumApiActionIndex.INFO
                => ExecuteApiAsync<IGameWebApiControllers, GameSessionInfoDTO>(arg, static (api) => api.GetSessionInfoAsync()),

                (int)EnumApiActionIndex.LoadResource
                => ExecuteApiAsync<IGameWebApiControllers, GameSessionInfoDTO>(arg, static (api) => api.LoadResourceAsync()),

                (int)EnumApiActionIndex.GetListCurrencyDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameCurrencyDisplayDTO[]>(arg, static (api) => api.GetListCurrencyDisplayAsync()),

                (int)EnumApiActionIndex.GetCurrencyInfo
                => ExecuteApiAsync<IGameWebApiControllers, GameCurrencyObjectDTO, GameCurrencyInfoDTO>(arg, static (api, req) => api.GetCurrencyInfoAsync(req)),

                (int)EnumApiActionIndex.UpdateCurrencyInfo
                => ExecuteApiAsync<IGameWebApiControllers, GameCurrencyModifyDTO, GameCurrencyInfoDTO>(arg, static (api, req) => api.UpdateCurrencyInfoAsync(req)),

                (int)EnumApiActionIndex.GetListInventoryDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameInventoryDisplayDTO[]>(arg, static (api) => api.GetListInventoryDisplayAsync()),

                (int)EnumApiActionIndex.GetInventoryInfo
                => ExecuteApiAsync<IGameWebApiControllers, GameInventoryObjectDTO, GameInventoryInfoDTO>(arg, static (api, req) => api.GetInventoryInfoAsync(req)),
               
                (int)EnumApiActionIndex.UpdateInventoryInfo
                => ExecuteApiAsync<IGameWebApiControllers, GameInventoryModifyDTO, GameInventoryInfoDTO>(arg, static (api, req) => api.UpdateInventoryInfoAsync(req)),

                (int)EnumApiActionIndex.GetListCharacterDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterDisplayDTO[]>(arg, static (api) => api.GetListCharacterDisplayAsync()),

                (int)EnumApiActionIndex.GetCharacterStatus
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterStatusDTO>(arg, static (api, req) => api.GetCharacterStatusAsync(req)),

                (int)EnumApiActionIndex.UpdateCharacterStatus
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterStatusDTO>(arg, static (api, req) => api.UpdateCharacterStatusAsync(req)),

                (int)EnumApiActionIndex.GetCharacterEquipment
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterEquipmentDTO>(arg, static (api, req) => api.GetCharacterEquipmentAsync(req)),

                (int)EnumApiActionIndex.UpdateCharacterEquipment
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterEquipmentDTO>(arg, static (api, req) => api.UpdateCharacterEquipmentAsync(req)),

                (int)EnumApiActionIndex.GetCharacterSkill
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterObjectDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.GetCharacterSkillAsync(req)),

                (int)EnumApiActionIndex.UpdateCharacterSkill
                => ExecuteApiAsync<IGameWebApiControllers, GameCharacterModifyDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.UpdateCharacterSkillAsync(req)),

                (int)EnumApiActionIndex.GetListMonsterDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameMonsterDisplayDTO[]>(arg, static (api) => api.GetListMonsterDisplayAsync()),

                (int)EnumApiActionIndex.AddMonsterMember
                => ExecuteApiAsync<IGameWebApiControllers, GameMonsterObjectDTO, GameCharacterSkillDTO>(arg, static (api, req) => api.AddMonsterMemberAsync(req)),

                (int)EnumApiActionIndex.GetListSkillDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameSkillDisplayDTO[]>(arg, static (api) => api.GetListSkillDisplayAsync()),

                (int)EnumApiActionIndex.AddSkillDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameSkillObjectDTO, GameSkillDisplayDTO>(arg, static (api, req) => api.AddSkillDisplayAsync(req)),

                (int)EnumApiActionIndex.GetListSwitchDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameSwitchDisplayDTO[]>(arg, static (api) => api.GetListSwitchDisplayAsync()),


                (int)EnumApiActionIndex.UpdateSwitchDisplay
                => ExecuteApiAsync<IGameWebApiControllers, GameSwitchModifyDTO, GameSwitchDisplayDTO>(arg, static (api, req) => api.UpdateSwitchDisplayAsync(req)),

                _ => ExecuteApiAsync(actionIndex, arg),
            };
        }


        public ValueTask StopAsync()
        {
            this.Api.TryComplete();
            return ValueTask.CompletedTask;
        }





        T AndroidTask_GetRequiredData4ApiJson<T>(AndroidApiArgs arg)
            where T : class
        {

            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            var javaJson = arg.Json;
            var pString = jniEnvironmentContext.JNI_ENV.GetStringChars(javaJson);
            var strSize = jniEnvironmentContext.JNI_ENV.GetStringLength(javaJson);
            try
            {
                return Json2Object<T>(pString.AsReadOnlySpan(strSize));
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.ReleaseStringChars(javaJson, pString);
            }
        }
        Task<T> GetRequiredData4ApiJsonAsync<T>(AndroidApiArgs arg) where T : class
        {
            return this.AndroidTaskAsync(static (p, args) => p.AndroidTask_GetRequiredData4ApiJson<T>(args), arg);
        }

        bool AndroidTask_Callback2ApiJson<T>(AndroidApiArgs arg, T data) where T : class
        {

            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            if (false == VirtualActionApiCallbackInstance.TryCreate(jniEnvironmentContext, arg.Instance, out var callback))
            {
                return AndroidJNIException.Throw<bool>($"{nameof(VirtualActionApiCallbackInstance)}:CREATE ERROR");
            }
            using (callback)
            {
                var jsonData = Json4Object(data);
                var javaJson = jniEnvironmentContext.JNI_ENV.CreateStringUnicode(jsonData);
                try
                {
                    var actionIndex = (int)arg.Action;
                    return actionIndex switch
                    {
                        (int)EnumApiActionIndex.EnumImages => callback.EnumImages(javaJson),
                        (int)EnumApiActionIndex.EnumClasses => callback.EnumClasses(javaJson),
                        (int)EnumApiActionIndex.EnumObjects => callback.EnumObjects(javaJson),
                        (int)EnumApiActionIndex.EnumClassDetail => callback.EnumClassDetail(javaJson),
                        (int)EnumApiActionIndex.INFO => callback.INFO(javaJson),
                        (int)EnumApiActionIndex.LoadResource => callback.LoadResource(javaJson),
                        (int)EnumApiActionIndex.GetListCurrencyDisplay => callback.GetListCurrencyDisplay(javaJson),
                        (int)EnumApiActionIndex.GetCurrencyInfo => callback.GetCurrencyInfo(javaJson),
                        (int)EnumApiActionIndex.UpdateCurrencyInfo => callback.UpdateCurrencyInfo(javaJson),
                        (int)EnumApiActionIndex.GetListInventoryDisplay => callback.GetListInventoryDisplay(javaJson),
                        (int)EnumApiActionIndex.GetInventoryInfo => callback.GetInventoryInfo(javaJson),
                        (int)EnumApiActionIndex.UpdateInventoryInfo => callback.UpdateInventoryInfo(javaJson),
                        (int)EnumApiActionIndex.GetListCharacterDisplay => callback.GetListCharacterDisplay(javaJson),
                        (int)EnumApiActionIndex.GetCharacterStatus => callback.GetCharacterStatus(javaJson),
                        (int)EnumApiActionIndex.UpdateCharacterStatus => callback.UpdateCharacterStatus(javaJson),
                        (int)EnumApiActionIndex.GetCharacterEquipment => callback.GetCharacterEquipment(javaJson),
                        (int)EnumApiActionIndex.UpdateCharacterEquipment => callback.UpdateCharacterEquipment(javaJson),
                        (int)EnumApiActionIndex.GetCharacterSkill => callback.GetCharacterSkill(javaJson),
                        (int)EnumApiActionIndex.UpdateCharacterSkill => callback.UpdateCharacterSkill(javaJson),
                        (int)EnumApiActionIndex.GetListMonsterDisplay => callback.GetListMonsterDisplay(javaJson),
                        (int)EnumApiActionIndex.AddMonsterMember => callback.AddMonsterMember(javaJson),
                        (int)EnumApiActionIndex.GetListSkillDisplay => callback.GetListSkillDisplay(javaJson),
                        (int)EnumApiActionIndex.AddSkillDisplay => callback.AddSkillDisplay(javaJson),
                        (int)EnumApiActionIndex.GetListSwitchDisplay => callback.GetListSwitchDisplay(javaJson),
                        (int)EnumApiActionIndex.UpdateSwitchDisplay => callback.UpdateSwitchDisplay(javaJson),
                        _ => callback.None(javaJson)
                    };
                }
                finally
                {
                    jniEnvironmentContext.JNI_ENV.DeleteLocalRef(javaJson);
                }
            }



        }
        async Task<bool> TryCallback2ApiJsonAsync<T>(AndroidApiArgs arg, T data) where T : class
        {
            try
            {
                return await this.AndroidTaskAsync(static (p, args) => p.AndroidTask_Callback2ApiJson(args.arg, args.data), (arg, data));
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
            return false;
        }

        void AndroidTask_Release(AndroidApiArgs arg)
        {
            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            arg.Release(jniEnvironmentContext);
        }
        Task<bool> ReleaseAsync(AndroidApiArgs arg)
        {
            return this.AndroidTaskAsync(static (p, args) => p.AndroidTask_Release(args), arg);
        }


        protected async ValueTask<bool> ExecuteApiAsync<TService, TResult>(AndroidApiArgs arg, Func<TService, ValueTask<TResult>> func)
            where TService : notnull
            where TResult : class
        {
            try
            {
                var actionApiService = this.ServiceProvider.GetRequiredService<TService>();
                var resData = await func(actionApiService).ConfigureAwait(false);
                return await TryCallback2ApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError<TResult>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} /system err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
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
                var requestData = await GetRequiredData4ApiJsonAsync<TRequest>(arg).ConfigureAwait(false);
                var resData = await func(actionApiService, requestData).ConfigureAwait(false);
                return await TryCallback2ApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError<TResult>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} / system err:{ex}", (int)arg.Action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }



        }
        protected async ValueTask<bool> ExecuteApiAsync(int action, AndroidApiArgs arg)
        {
            try
            {
                //  var requestData = await GetRequiredData4ApiJsonAsync<GameSessionObjectDTO>(arg).ConfigureAwait(false);
                var resData = new GameSessionInfoDTO() { ObjectId = Environment.ProcessId.ToString(), DisplayName = "Android", DisplayDesc = "Android Test", ApiVer = "202411172000" }.GetOk();
                return await TryCallback2ApiJsonAsync(arg, resData).ConfigureAwait(false);
            }
            catch (MonoCommonException ex)
            {
                Logger.LogError("action:{action} / api err:{ex}", action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
            }
            catch (AndroidCommonException ex)
            {
                Logger.LogError("action:{action} / jni err:{ex}", action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError<bool>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Logger.LogError("action:{action} / system err:{ex}", action, ex);
                return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
            }


        }

    }

}
