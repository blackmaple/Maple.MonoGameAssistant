using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public abstract class GameContextAndroidService<T_CONTEXT>(ILogger logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings)
    : IGameContextService,
    IGameWebApiControllers,
    IMonoTaskScheduler<T_CONTEXT>
    where T_CONTEXT : MonoCollectorContext
    {
        public ILogger Logger { get; } = logger;

        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoGameSettings GameSettings { get; } = gameSettings;
        public TaskScheduler Scheduler { get; } = monoTaskScheduler;
        public required T_CONTEXT Context { get; set; }


        public required GameSwitchDisplayDTO[] ListGameSwitch { get; set; }

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

        private async ValueTask LoadGameServiceAsync()
        {
            using (Logger.Running())
            {
                Context = await this.MonoTaskAsync((T_CONTEXT p, GameContextAndroidService<T_CONTEXT> host) => host.LoadGameContext(), this).ConfigureAwait(continueOnCapturedContext: false);
                Logger.LogInformation("LoadGameContext=>{ver}=>{api}", Context.TypeVersion, Context.ApiVersion);
            }
        }

        protected abstract T_CONTEXT LoadGameContext();

        protected virtual GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return [];
        }

        private void LoadListGameSwitch()
        {
            ListGameSwitch = InitListGameSwitch();
        }

        protected GameSwitchDisplayDTO? FindGameSwitch(string objectId)
        {
            string objectId2 = objectId;
            return ListGameSwitch.Where((GameSwitchDisplayDTO p) => p.ObjectId == objectId2).FirstOrDefault();
        }




        protected virtual ValueTask LoadGameDataAsync()
        {
            return ValueTask.CompletedTask;
        }


        public virtual ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            string ver = ((Context != null) ? Context.ApiVersion : "???");
            return ValueTask.FromResult(GameSettings.GetGameSessionInfo(ver));
        }

        public virtual ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            return GetSessionInfoAsync();
        }

        public virtual ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            return GameException.ThrowUIHide<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            return GameException.ThrowUIHide<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            return GameException.ThrowUIHide<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");
        }

        public virtual ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            return GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return GameException.ThrowUIHide<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");
        }

        public virtual ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
        {
            return GameException.Throw<ValueTask<GameSkillDisplayDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return GameException.ThrowUIHide<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");
        }

        public virtual ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            return GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            return GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return GameException.ThrowUIHide<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");
        }

        public virtual ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            return GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            return GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");
        }

        public virtual ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return new ValueTask<GameSwitchDisplayDTO[]>(ListGameSwitch);
        }

        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        {
            return GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");
        }




    }

}
