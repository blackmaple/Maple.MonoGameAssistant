using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.HookTask;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.HotKey.Abstractions;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UITask;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Maple.MonoGameAssistant.WinApi;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.GameContext
{
    public abstract class GameContextService<T_CONTEXT>(
           ILogger logger,
           MonoRuntimeContext runtimeContext,
           MonoTaskScheduler monoTaskScheduler,
           MonoGameSettings gameSettings,
           HookWinMsgFactory hookWinMsgFactory)
        : IGameContextService,
        IWinMsgNotifyService,
        IHookTaskScheduler<T_CONTEXT>,
        IMonoTaskScheduler<T_CONTEXT>,
        IUITaskScheduler<T_CONTEXT>
        where T_CONTEXT : MonoCollectorContext
    {

        #region props


        public ILogger Logger { get; } = logger;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoGameSettings GameSettings { get; } = gameSettings;
        public TaskScheduler Scheduler { get; } = monoTaskScheduler;
        public IHookWinMsgService Hook { get; } = hookWinMsgFactory.Create();

        public required T_CONTEXT Context { get; set; }
        public required UnityEngineContext? UnityEngineContext { get; set; }
        public required GameSwitchDisplayDTO[] ListGameSwitch { get; set; }

        #endregion

        #region Host Service



        public ValueTask StopAsync()
        {
            return ValueTask.CompletedTask;
        }
        public async ValueTask StartAsync()
        {
            using (this.Logger.Running())
            {
                try
                {
                    await this.LoadGameServiceAsync().ConfigureAwait(false);

                    this.HookWindowMessage();

                    await this.LoadGameDataAsync().ConfigureAwait(false);

                    this.LoadListGameSwitch();

                    this.TryAutoOpenUrl();
                }
                catch (Exception ex)
                {
                    this.Logger.LogError("LoadService Error:{ex}", ex);
                }

            }




        }
        #endregion

        #region Init Service

        private async ValueTask LoadGameServiceAsync()
        {
            using (this.Logger.Running())
            {
                this.Context = await this.MonoTaskAsync((p, host) => host.LoadGameContext(), this).ConfigureAwait(false);
                this.Logger.LogInformation("LoadGameContext=>{ver}=>{api}", this.Context.TypeVersion, this.Context.ApiVersion);
                this.UnityEngineContext = await this.MonoTaskAsync((p, host) => host.TryLoadUnityEngineContext(), this).ConfigureAwait(false);
                this.Logger.LogInformation("LoadUnityEngineContext=>{load}=>{ver}=>{api}",
                    this.UnityEngineContext is not null,
                    this.UnityEngineContext?.TypeVersion,
                    this.UnityEngineContext?.ApiVersion);
                //using (this.RuntimeContext.CreateAttachContext())
                //{
                //    this.Context = this.LoadGameContext();
                //    this.Logger.LogInformation("LoadGameContext=>{ver}=>{api}", this.Context.TypeVersion, this.Context.ApiVersion);
                //    this.UnityEngineContext = this.TryLoadUnityEngineContext();
                //    this.Logger.LogInformation("LoadUnityEngineContext=>{load}=>{ver}=>{api}",
                //        this.UnityEngineContext is not null,
                //        this.UnityEngineContext?.TypeVersion,
                //        this.UnityEngineContext?.ApiVersion);

                //}
            }

        }
        protected abstract T_CONTEXT LoadGameContext();
        protected virtual UnityEngineContext? LoadUnityEngineContext() => UnityEngineContext.LoadUnityContext(this.RuntimeContext, this.Logger);
        protected UnityEngineContext? TryLoadUnityEngineContext()
        {
            try
            {
                return LoadUnityEngineContext();
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }
            return default;
        }
        protected virtual GameSwitchDisplayDTO[] InitListGameSwitch()
            => [];
        private void LoadListGameSwitch()
        {
            this.ListGameSwitch = this.InitListGameSwitch();
        }

        protected GameSwitchDisplayDTO? FindGameSwitch(string objectId)
            => this.ListGameSwitch.Where(p => p.ObjectId == objectId).FirstOrDefault();



        protected virtual void HookWindowMessage()
        {
            using (this.Logger.Running())
            {
                var hookStatus = this.Hook.SetHook(this);
                this.Logger.LogInformation("HookWindowMessage=>{hookStatus}", hookStatus);
            }
        }
        protected virtual bool TryAutoOpenUrl()
        {
            using (this.Logger.Running())
            {
                var open = false;
                if (this.GameSettings.TryGetOpenUrl(out var url))
                {
                    open = WindowsRuntime.RunBrowser(url);
                }
                this.Logger.LogInformation("{method}=>{url}=>{open}", nameof(TryAutoOpenUrl), url, open);
                return open;
            }
        }


        protected virtual ValueTask LoadGameDataAsync()
        {
            return ValueTask.CompletedTask;
        }
        #endregion

        #region KeyDown
        public ValueTask NotifyAsync(WinMsgNotifyDTO msgNotify)
        {
            return msgNotify.KeyCode switch
            {
                EnumVirtualKeyCode.VK_Q => Q_KeyDown(),

                EnumVirtualKeyCode.VK_F1 => F1_KeyDown(),
                EnumVirtualKeyCode.VK_F2 => F2_KeyDown(),
                EnumVirtualKeyCode.VK_F3 => F3_KeyDown(),
                EnumVirtualKeyCode.VK_F4 => F4_KeyDown(),
                EnumVirtualKeyCode.VK_F5 => F5_KeyDown(),
                EnumVirtualKeyCode.VK_F6 => F6_KeyDown(),
                EnumVirtualKeyCode.VK_F7 => F7_KeyDown(),
                EnumVirtualKeyCode.VK_F8 => F8_KeyDown(),
                EnumVirtualKeyCode.VK_F9 => F9_KeyDown(),
                EnumVirtualKeyCode.VK_F10 => F10_KeyDown(),
                EnumVirtualKeyCode.VK_F11 => F11_KeyDown(),
                EnumVirtualKeyCode.VK_F12 => F12_KeyDown(),

                EnumVirtualKeyCode.VK_1 => Num1_KeyDown(),
                EnumVirtualKeyCode.VK_2 => Num2_KeyDown(),
                EnumVirtualKeyCode.VK_3 => Num3_KeyDown(),
                EnumVirtualKeyCode.VK_4 => Num4_KeyDown(),
                EnumVirtualKeyCode.VK_5 => Num5_KeyDown(),
                EnumVirtualKeyCode.VK_6 => Num6_KeyDown(),
                EnumVirtualKeyCode.VK_7 => Num7_KeyDown(),
                EnumVirtualKeyCode.VK_8 => Num8_KeyDown(),
                EnumVirtualKeyCode.VK_9 => Num9_KeyDown(),
                EnumVirtualKeyCode.VK_0 => Num0_KeyDown(),

                EnumVirtualKeyCode.VK_NUMPAD1 => Num1_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD2 => Num2_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD3 => Num3_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD4 => Num4_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD5 => Num5_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD6 => Num6_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD7 => Num7_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD8 => Num8_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD9 => Num9_KeyDown(),
                EnumVirtualKeyCode.VK_NUMPAD0 => Num0_KeyDown(),

                EnumVirtualKeyCode.VK_UP => Up_KeyDown(),
                EnumVirtualKeyCode.VK_DOWN => Down_KeyDown(),
                EnumVirtualKeyCode.VK_LEFT => Left_KeyDown(),
                EnumVirtualKeyCode.VK_RIGHT => Right_KeyDown(),



                _ => ValueTask.CompletedTask
            }; ;
        }

        protected virtual ValueTask Q_KeyDown()
        {
            return ValueTask.CompletedTask;
        }

        protected virtual ValueTask F1_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F2_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F3_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F4_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask F5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F10_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F11_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask F12_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num1_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num2_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num3_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num4_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num5_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num6_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num7_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num8_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num9_KeyDown()
        {
            return ValueTask.CompletedTask;

        }
        protected virtual ValueTask Num0_KeyDown()
        {
            return ValueTask.CompletedTask;

        }


        protected virtual ValueTask Up_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Down_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Left_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask Right_KeyDown()
        {
            return ValueTask.CompletedTask;
        }
        #endregion

        #region WebApi

        public virtual ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {

            var api = this.Context is not null ? this.Context.ApiVersion : "???";
            var data = this.GameSettings.GetGameSessionInfo(api);
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
            return new ValueTask<GameSwitchDisplayDTO[]>(this.ListGameSwitch);
        }



        public virtual ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");


        public void UpdateListGameImage<T>(IReadOnlyList<T> datas) where T : GameObjectDisplayDTO
            => UpdateListGameImage(datas, static p => $"{p.ObjectId}.png");

        public void UpdateListGameImage<T>(IReadOnlyList<T> datas, Func<T, string> func) where T : GameObjectDisplayDTO
        {
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, func(data), out var url))
                {
                    data.DisplayImage = url;
                }
            }
        }



        #endregion
    }
}
