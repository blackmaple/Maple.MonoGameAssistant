using BlazorComponent;
using Maple.MonoGameAssistant.GameCore;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Components;
using Maple.MonoGameAssistant.Model;
using Masa.Blazor;
using System.Collections.Generic;

namespace Maple.MonoGameAssistant.GameShared.Service
{
    public class GameCoreService(GameHttpClientService gameHttp, IPopupService popupService)
    {
        #region Service
        GameHttpClientService Http { get; } = gameHttp;
        IPopupService PopupService { get; } = popupService;
        #endregion
        private List<GameCurrencyDisplayDTO> ListCurrency_All { get; } = new List<GameCurrencyDisplayDTO>(32);
        public List<GameCurrencyDisplayDTO> ListCurrency_Search { get; } = new List<GameCurrencyDisplayDTO>(32);

        private List<GameInventoryDisplayDTO> ListInventory_All { get; } = new List<GameInventoryDisplayDTO>(1024);
        public List<GameInventoryDisplayDTO> ListInventory_Search { get; } = new List<GameInventoryDisplayDTO>(1024);

        private List<GameCharacterDisplayDTO> ListCharacter_All { get; } = new List<GameCharacterDisplayDTO>(32);
        public List<GameCharacterDisplayDTO> ListCharacter_Search { get; } = new List<GameCharacterDisplayDTO>(32);






        private List<GameMonsterDisplayDTO> ListMonster_All { get; } = new List<GameMonsterDisplayDTO>(512);
        public List<GameMonsterDisplayDTO> ListMonster_Search { get; } = new List<GameMonsterDisplayDTO>(512);


        private List<GameSkillDisplayDTO> ListSkill_All { get; } = new List<GameSkillDisplayDTO>(128);
        public List<GameSkillDisplayDTO> ListSkill_Search { get; } = new List<GameSkillDisplayDTO>(128);

        public List<GameSwitchDisplayDTO> ListSwitch_Search { get; } = new List<GameSwitchDisplayDTO>(32);

        public GameSessionInfoDTO? GameSessionInfo { get; set; }


        public async Task<EnumGameServiceStatus> OnInitializedAsync()
        {
            var gameSessionDTO = await this.Http.GetGameSessionInfoAsync();
            if (false == gameSessionDTO.TryGet(out var gameSession))
            {
                await this.ShowErrorAsync(gameSessionDTO.MSG);
                return EnumGameServiceStatus.ERROR;
            }
            this.GameSessionInfo = gameSession;

            await this.GetListCurrencyDisplayAsync();
            await this.GetListInventoryDisplayAsync();
            await this.GetListCharacterDisplayAsync();
            await this.GetListMonsterDisplayAsync();
            await this.GetListSkillDisplayAsync();
            await this.GetListSwitchDisplayAsync();

            return EnumGameServiceStatus.OK;
        }

        public async Task<bool> GetListCurrencyDisplayAsync()
        {
            this.ListCurrency_All.Clear();
            this.ListCurrency_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }
            var gameCurrencyDTO = await this.Http.GetListCurrencyDisplayAsync(this.GameSessionInfo);
            if (false == gameCurrencyDTO.TryGet(out var listGameCurrency))
            {
                await this.ShowErrorAsync(gameCurrencyDTO.MSG);
                return false;
            }
            this.ListCurrency_All.AddRange(listGameCurrency);
            this.ListCurrency_Search.AddRange(listGameCurrency);
            return true;
        }
        public async Task<bool> GetListInventoryDisplayAsync()
        {
            this.ListInventory_All.Clear();
            this.ListInventory_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }
            var gameInventoryDTO = await this.Http.GetListInventoryDisplayAsync(this.GameSessionInfo);
            if (false == gameInventoryDTO.TryGet(out var listGameInventory))
            {
                await this.ShowErrorAsync(gameInventoryDTO.MSG);
                return false;
            }
            this.ListInventory_All.AddRange(listGameInventory);
            this.ListInventory_Search.AddRange(listGameInventory);
            return true;
        }
        public async Task<bool> GetListCharacterDisplayAsync()
        {
            this.ListCharacter_All.Clear();
            this.ListCharacter_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }
            var gameCharacterDTO = await this.Http.GetListCharacterDisplayAsync(this.GameSessionInfo);
            if (false == gameCharacterDTO.TryGet(out var listGameCharacter))
            {
                await this.ShowErrorAsync(gameCharacterDTO.MSG);
                return false;
            }
            this.ListCharacter_All.AddRange(listGameCharacter);
            this.ListCharacter_Search.AddRange(listGameCharacter);
            return true;




        }
        public async Task<bool> GetListMonsterDisplayAsync()
        {
            this.ListMonster_All.Clear();
            this.ListMonster_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }
            var gameMonsterDTO = await this.Http.GetListMonsterDisplayAsync(this.GameSessionInfo);
            if (false == gameMonsterDTO.TryGet(out var listGameMonster))
            {
                await this.ShowErrorAsync(gameMonsterDTO.MSG);
                return false;
            }
            this.ListMonster_All.ReplaceRange(listGameMonster);
            this.ListMonster_Search.ReplaceRange(listGameMonster);
            return true;
        }
        public async Task<bool> GetListSkillDisplayAsync()
        {
            this.ListSkill_All.Clear();
            this.ListSkill_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }

            var gameSkillDTO = await this.Http.GetListSkillDisplayAsync(this.GameSessionInfo);
            if (false == gameSkillDTO.TryGet(out var listGameSkill))
            {
                await this.ShowErrorAsync(gameSkillDTO.MSG);
                return true;
            }
            this.ListSkill_All.ReplaceRange(listGameSkill);
            this.ListSkill_Search.ReplaceRange(listGameSkill);
            return false;

        }
        public async Task<bool> GetListSwitchDisplayAsync()
        {
            this.ListSwitch_Search.Clear();
            if (this.GameSessionInfo is null)
            {
                return false;
            }

            var gameSwitchDTO = await this.Http.GetListSwitchDisplayAsync(this.GameSessionInfo);
            if (false == gameSwitchDTO.TryGet(out var listGameSwitch))
            {
                await this.ShowErrorAsync(gameSwitchDTO.MSG);
                return false;
            }
            this.ListSwitch_Search.ReplaceRange(listGameSwitch);
            return true;

        }


        public void OnSearchMonster(string? searchText)
        {
            this.ListMonster_Search.Clear();
            IEnumerable<GameMonsterDisplayDTO> searchDatas = this.ListMonster_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, p.DisplayCategory));
            }
            this.ListMonster_Search.AddRange(searchDatas);

        }
        public async ValueTask OnSelectedMonster(GameMonsterDisplayDTO? selectedData)
        {
            if (selectedData is null)
            {
                return;
            }



            await PopupService.OpenAsync(typeof(UIMonsterDialog), new Dictionary<string, object?>()
            {
                { nameof(UIMonsterDialog.MonsterDisplayDTO), selectedData },

            });


        }


        public void OnSearchCharacter(string? searchText)
        {
            this.ListCharacter_Search.Clear();
            IEnumerable<GameCharacterDisplayDTO> searchDatas = this.ListCharacter_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, p.DisplayCategory));
            }
            this.ListCharacter_Search.AddRange(searchDatas);

        }
        public async ValueTask OnSelectedCharacterStatus(GameCharacterDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }


            var dto = await this.Http.GetCharacterStatusAsync(this.GameSessionInfo, selectedData.ObjectId);
            if (false == dto.TryGet(out var characterStatus))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            await PopupService.OpenAsync(typeof(UICharacterStatusDialog), new Dictionary<string, object?>()
            {
                { nameof(UICharacterStatusDialog.CharacterDisplay), selectedData },
                { nameof(UICharacterStatusDialog.CharacterStatus), characterStatus }
            });


        }
        public async ValueTask OnSelectedCharacterSkill(GameCharacterDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }
            GameCharacterSkillDTO? characterSkill;
            try
            {
                this.PopupService.ShowProgressCircular();
                var dto = await this.Http.GetCharacterSkillAsync(this.GameSessionInfo, selectedData.ObjectId);
                if (false == dto.TryGet(out characterSkill))
                {
                    await this.ShowErrorAsync(dto.MSG);
                    return;
                }
            }
            finally
            {
                this.PopupService.HideProgressCircular();

            }

            await PopupService.OpenAsync(typeof(UICharacterSkillDialog), new Dictionary<string, object?>()
            {
                { nameof(UICharacterSkillDialog.CharacterDisplay), selectedData },
                { nameof(UICharacterSkillDialog.CharacterSkill), characterSkill }
            });

        }
        public async ValueTask OnSelectedCharacterEquipment(GameCharacterDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }


            var dto = await this.Http.GetCharacterEquipmentAsync(this.GameSessionInfo, selectedData.ObjectId);
            if (false == dto.TryGet(out var characterEquipment))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            await PopupService.OpenAsync(typeof(UICharacterEquipmentDialog), new Dictionary<string, object?>()
            {
                { nameof(UICharacterEquipmentDialog.CharacterDisplay), selectedData },
                { nameof(UICharacterEquipmentDialog.CharacterEquipment), characterEquipment }
            });


        }
        public async ValueTask OnUpdateCharacteStatus(GameCharacterDisplayDTO displayDTO, GameValueInfoDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }
            var dto = await this.Http.UpdateCharacterStatusAsync(this.GameSessionInfo, displayDTO.ObjectId, selectedData);
            if (false == dto.TryGet(out var newInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            selectedData.DisplayValue = newInfo.NewValue;
            await this.ShowInfoAsync($"Update:{selectedData.DisplayValue}");
        }

        public GameInventoryDisplayDTO SearchGameInventory(GameValueInfoDTO gameValue)
        {
            var value = gameValue.DisplayValue;

            var data = this.ListInventory_All.Where(p => p.ObjectId == value).FirstOrDefault();
            if (data is not null)
            {
                return data;
            }
            var monster = this.ListMonster_All.Where(p => p.ObjectId == value).FirstOrDefault();
            if (monster is not null)
            {
                return new GameInventoryDisplayDTO()
                {
                    ObjectId = monster.ObjectId,
                    DisplayCategory = monster.DisplayCategory,
                    DisplayDesc = monster.DisplayDesc,
                    DisplayImage = monster.DisplayImage,
                    ItemAttributes = monster.MonsterAttributes,
                };
            }
            return new GameInventoryDisplayDTO()
            {
                ObjectId = string.Empty,
                DisplayName = gameValue.DisplayName,
                DisplayDesc = gameValue.DisplayValue,
            };
        }
        public GameObjectDisplayDTO? SearchGameSkill(GameValueInfoDTO gameValue)
        {
            var value = gameValue.DisplayValue;
            if (string.IsNullOrEmpty(value))
            {
                return default;
            }
            GameObjectDisplayDTO? data = this.ListSkill_All.Where(p => p.ObjectId == value).FirstOrDefault();

            return data;
        }




        public void OnSearchInventory(string? searchText)
        {
            this.ListInventory_Search.Clear();
            IEnumerable<GameInventoryDisplayDTO> searchDatas = this.ListInventory_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, p.DisplayCategory));
            }
            this.ListInventory_Search.AddRange(searchDatas);

        }
        public async ValueTask OnSelectedInventory(GameInventoryDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }


            var dto = await this.Http.GetInventoryInfoAsync(this.GameSessionInfo, selectedData.ObjectId, selectedData.DisplayCategory);
            if (false == dto.TryGet(out var inventoryInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            await PopupService.OpenAsync(typeof(UIInventoryDialog), new Dictionary<string, object?>()
            {
                { nameof(UIInventoryDialog.InventoryDisplay), selectedData },
                { nameof(UIInventoryDialog.InventoryInfo), inventoryInfo }
            });

        }
        public async ValueTask OnUpdateInventory(string? category, GameInventoryInfoDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }
            var dto = await this.Http.UpdateInventoryInfoAsync(this.GameSessionInfo, category, selectedData);
            if (false == dto.TryGet(out var newInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            selectedData.DisplayValue = newInfo.DisplayValue;
            await this.ShowInfoAsync($"Update:{selectedData.DisplayValue}");
        }


        public void OnSearchCurrency(string? searchText)
        {
            this.ListCurrency_Search.Clear();
            IEnumerable<GameCurrencyDisplayDTO> searchDatas = this.ListCurrency_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, p.DisplayCategory));
            }
            this.ListCurrency_Search.AddRange(searchDatas);


        }
        public async ValueTask OnSelectedCurrency(GameCurrencyDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }

            var dto = await this.Http.GetCurrencyInfoAsync(this.GameSessionInfo, selectedData.ObjectId);
            if (false == dto.TryGet(out var currencyInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            await PopupService.OpenAsync(typeof(UICurrencyDialog), new Dictionary<string, object?>()
            {
                { nameof(UICurrencyDialog.CurrencyDisplay), selectedData },
                { nameof(UICurrencyDialog.CurrencyInfo), currencyInfo }
            });
        }
        public async ValueTask OnUpdateCurrency(GameCurrencyInfoDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }
            var dto = await this.Http.UpdateCurrencyInfoAsync(this.GameSessionInfo, selectedData);
            if (false == dto.TryGet(out var newInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            selectedData.DisplayValue = newInfo.DisplayValue;
            await this.ShowInfoAsync($"Update:{selectedData.DisplayValue}");
        }

        private Task ShowErrorAsync(string? error)
        {
            return this.PopupService.EnqueueSnackbarAsync(new Masa.Blazor.Presets.SnackbarOptions(error ?? "Error", AlertTypes.Error, true));
        }
        private Task ShowInfoAsync(string msg)
        {
            return this.PopupService.EnqueueSnackbarAsync(new Masa.Blazor.Presets.SnackbarOptions(msg, AlertTypes.Success, true));
        }
    }
}
