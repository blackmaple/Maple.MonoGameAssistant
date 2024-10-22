using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.AndroidCore.GameContext
{
    public abstract class GameContextService<T_CONTEXT>(
           ILogger logger,
           MonoGameSettings gameSettings,
           MonoRuntimeContext runtimeContext,
           MonoTaskScheduler monoTaskScheduler)
        : IGameContextService,
        IMonoTaskScheduler<T_CONTEXT>
        where T_CONTEXT : MonoCollectorContext
    {

        #region props

        public ILogger Logger { get; } = logger;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public TaskScheduler Scheduler { get; } = monoTaskScheduler;
        public MonoGameSettings GameSettings { get; } = gameSettings;


        public required T_CONTEXT Context { get; set; }

        public required GameSwitchDisplayDTO[] ListGameSwitch { get; set; }

        #endregion

        #region Host Service



        public ValueTask StopAsync()
        {
            return ValueTask.CompletedTask;
        }
        public async ValueTask StartAsync()
        {
            using (Logger.Running())
            {
                try
                {
                    await LoadGameServiceAsync().ConfigureAwait(false);
                    await LoadGameDataAsync().ConfigureAwait(false);
                    LoadListGameSwitch();
                }
                catch (Exception ex)
                {
                    Logger.LogError("LoadService Error:{ex}", ex);
                }

            }




        }
        #endregion

        #region Init Service

        private async ValueTask LoadGameServiceAsync()
        {
            using (Logger.Running())
            {
                Context = await this.MonoTaskAsync((p, host) => host.LoadGameContext(), this).ConfigureAwait(false);
                Logger.LogInformation("LoadGameContext=>{ver}=>{api}", Context.TypeVersion, Context.ApiVersion);
            }

        }
        protected abstract T_CONTEXT LoadGameContext();
        //protected virtual UnityEngineContext? LoadUnityEngineContext() => UnityEngineContext.LoadUnityContext(this.RuntimeContext, this.Logger);
        //protected UnityEngineContext? TryLoadUnityEngineContext()
        //{
        //    try
        //    {
        //        return LoadUnityEngineContext();
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Logger.LogError("{ex}", ex);
        //    }
        //    return default;
        //}

        protected virtual GameSwitchDisplayDTO[] InitListGameSwitch()
            => [];
        private void LoadListGameSwitch()
        {
            ListGameSwitch = InitListGameSwitch();
        }

        protected GameSwitchDisplayDTO? FindGameSwitch(string objectId)
            => ListGameSwitch.Where(p => p.ObjectId == objectId).FirstOrDefault();







        protected virtual ValueTask LoadGameDataAsync()
        {
            return ValueTask.CompletedTask;
        }
        #endregion


        #region WebApi

        public virtual ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {

            var api = Context is not null ? Context.ApiVersion : "???";
            var data = GameSettings.GetGameSessionInfo(api);
            return ValueTask.FromResult(data);
        }

        public virtual ValueTask<GameSessionInfoDTO> LoadResourceAsync()
            => GetSessionInfoAsync();

        public virtual ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");

        public virtual ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.ThrowUIHide<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        public virtual ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");



        public virtual ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");
        public virtual ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
            => GameException.Throw<ValueTask<GameSkillDisplayDTO>>("NotImplemented");


        public virtual ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");




        public virtual ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
            => GameException.ThrowUIHide<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        public virtual ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return new ValueTask<GameSwitchDisplayDTO[]>(ListGameSwitch);
        }

        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");






        #endregion
    }

    public sealed class DefGameContextService(
        ILogger<DefGameContextService> logger, 
        MonoGameSettings gameSettings, 
        MonoRuntimeContext runtimeContext, 
        MonoTaskScheduler monoTaskScheduler) 
        : GameContextService<DefGameCollectorContext>(logger, gameSettings, runtimeContext, monoTaskScheduler)
    {
        protected override DefGameCollectorContext LoadGameContext()
        {
            return default!;
        }
    }

    public class DefGameCollectorContext : MonoCollectorContext
    {
        public DefGameCollectorContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger, string apiVer = "202407222030") : base(runtimeContext, typeVersion, logger, apiVer)
        {
        }
    }

}
