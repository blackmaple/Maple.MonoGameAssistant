using Maple.MonoGameAssistant.GameCore;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Components;
using Maple.MonoGameAssistant.Model;
using Masa.Blazor;

namespace Maple.MonoGameAssistant.GameShared.Service
{


    public class GameCoreService(GameHttpClientService gameHttp, IPopupService popupService)
    {
        const string ShellUI_Ver = "0.1";

        #region Service
        GameHttpClientService Http { get; } = gameHttp;
        public IPopupService PopupService { get; } = popupService;
        #endregion

        #region List Data

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

        public List<GameSwitchDisplayDTO> ListSwitch_All { get; } = new List<GameSwitchDisplayDTO>(32);
        public List<GameSwitchDisplayDTO> ListSwitch_Search { get; } = new List<GameSwitchDisplayDTO>(32);
        #endregion

        public GameSessionInfoDTO? GameSessionInfo { get; set; }
        public string? GameName => this.GameSessionInfo?.DisplayName;
        public string? ApiVer => $"{nameof(GameSessionInfo.ApiVer)}:{this.GameSessionInfo?.ApiVer}";
        public string? ShellUI => $"{nameof(ShellUI)}:{ShellUI_Ver}";

        public Task ShowVersionInfo()
        {
            return this.PopupService.ConfirmAsync(this.GameName!, $"{ApiVer}\t{ShellUI}", AlertTypes.Info);
        }
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


        #region Game Resource
        public async ValueTask LoadGameResourceAsync()
        {
            if (this.GameSessionInfo is null)
            {
                return;
            }
            var load = await this.PopupService.ConfirmAsync("GameReource", "Load Game Resource?", AlertTypes.Warning);
            if (!load)
            {
                return;
            }
            using (this.ShowWait())
            {
                var dto = await this.Http.LoadResourceAsync(this.GameSessionInfo).ConfigureAwait(false);
                if (false == dto.TryGet(out _))
                {
                    await this.ShowErrorAsync(dto.MSG);
                    return;
                }
            }
            await this.ShowInfoAsync("Load Ok");
        }
        #endregion

        #region Currency
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
            if (false == dto.TryGet(out var currencyInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }

            selectedData.DisplayValue = currencyInfo.DisplayValue;
            await this.ShowInfoAsync($"Update:{currencyInfo.DisplayValue}");
        }

        #endregion

        #region Inventory
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
            if (false == dto.TryGet(out var inventoryInfo))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }

            selectedData.DisplayValue = inventoryInfo.DisplayValue;
            await this.ShowInfoAsync($"Update:{selectedData.DisplayValue}");
        }

        #endregion

        #region Character
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

            var dto = await this.Http.GetCharacterSkillAsync(this.GameSessionInfo, selectedData.ObjectId);
            if (false == dto.TryGet(out var characterSkill))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
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
        public async ValueTask OnUpdateCharacteStatus(GameCharacterStatusDTO gameCharacterStatus, GameValueInfoDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }

            var dto = await this.Http.UpdateCharacterStatusAsync(this.GameSessionInfo, gameCharacterStatus.ObjectId, selectedData);
            if (false == dto.TryGet(out var characterStatus))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            if (gameCharacterStatus.CharacterAttributes is not null && characterStatus.CharacterAttributes is not null)
            {
                foreach (var att in gameCharacterStatus.CharacterAttributes)
                {
                    var newAtt = characterStatus.CharacterAttributes.Where(p => p.ObjectId == att.ObjectId).FirstOrDefault();
                    if (newAtt is not null)
                    {
                        att.DisplayValue = newAtt.DisplayValue;
                    }
                }

            }
            await this.ShowInfoAsync($"Update:{selectedData.DisplayValue}");
        }

        #endregion

        #region Monster
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
        public async ValueTask OnAddMonsterMember(GameMonsterDisplayDTO? selectedData)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }

            var confirmed = await PopupService.ConfirmAsync("Add Monster", $"Add Monster:{selectedData.DisplayName}", AlertTypes.Warning);
            if (confirmed == false)
            {
                return;
            }


            var dto = await this.Http.AddMonsterMemberAsync(this.GameSessionInfo, selectedData.ObjectId);
            if (false == dto.TryGet(out var characterSkill))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }

            await PopupService.OpenAsync(typeof(UICharacterSkillDialog), new Dictionary<string, object?>()
            {
                { nameof(UICharacterSkillDialog.CharacterDisplay), new GameCharacterDisplayDTO(){
                    ObjectId = characterSkill.ObjectId,
                   DisplayName = selectedData.DisplayName,
                   DisplayDesc = selectedData.DisplayDesc,
                   DisplayCategory= selectedData.DisplayCategory,
                   DisplayImage = selectedData.DisplayImage,
                } },
                { nameof(UICharacterSkillDialog.CharacterSkill), characterSkill }
            });

            await this.GetListCharacterDisplayAsync();

        }

        #endregion

        #region Skill
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
        public void OnSearchSkill(string? searchText)
        {
            this.ListSkill_Search.Clear();
            IEnumerable<GameSkillDisplayDTO> searchDatas = this.ListSkill_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, p.DisplayCategory));
            }
            this.ListSkill_Search.AddRange(searchDatas);

        }
        public async ValueTask AddSkillDisplayAsync(GameSkillDisplayDTO? gameSkillDisplay)
        {
            if (this.GameSessionInfo is null || gameSkillDisplay is null)
            {
                return;
            }

            var dto = await this.Http.AddSkillDisplayAsync(this.GameSessionInfo, gameSkillDisplay);
            if (false == dto.TryGet(out var skillDisplayDTO))
            {
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            await this.ShowInfoAsync($"Update {skillDisplayDTO.DisplayName}");
        }
        public async ValueTask OnUpdateCharacterSkill(GameCharacterDisplayDTO characterDisplayDTO, GameSkillInfoDTO? selectedData, bool remove)
        {
            if (this.GameSessionInfo is null || selectedData is null)
            {
                return;
            }
            MonoResultDTO<GameCharacterSkillDTO> dto;
            if (remove)
            {
                var dialog = await this.PopupService.ConfirmAsync("Remove Skill", $"Remove Skill:{selectedData.DisplayName}", AlertTypes.Warning);
                if (false == dialog)
                {
                    return;
                }
                dto = await this.Http.UpdateCharacterSkillAsync(this.GameSessionInfo, characterDisplayDTO.ObjectId, selectedData.ObjectId, string.Empty);
                if (false == dto.TryGet(out var _))
                {
                    await this.ShowErrorAsync(dto.MSG);
                    return;
                }

                selectedData.ObjectId = string.Empty;
                selectedData.DisplayName = string.Empty;
                selectedData.DisplayDesc = string.Empty;
                selectedData.DisplayImage = string.Empty;
                selectedData.SkillAttributes = default;

            }
            else
            {

                if (await PopupService.OpenAsync(typeof(UISelectedSkillDialog),
                   new Dictionary<string, object?>()
                   {
                       [nameof(UISelectedSkillDialog.ListSkill_All)] =
                       this.ListSkill_All.Where(p => p.DisplayCategory == selectedData.DisplayCategory).ToList()
                   }
                    ) is not GameSkillDisplayDTO newSkill)
                {
                    return;
                }


                dto = await this.Http.UpdateCharacterSkillAsync(this.GameSessionInfo, characterDisplayDTO.ObjectId, selectedData.ObjectId, newSkill.ObjectId);
                if (false == dto.TryGet(out _))
                {
                    await this.ShowErrorAsync(dto.MSG);
                    return;
                }

                selectedData.ObjectId = newSkill.ObjectId;
                selectedData.DisplayName = newSkill.DisplayName;
                selectedData.DisplayDesc = newSkill.DisplayDesc;
                selectedData.DisplayImage = newSkill.DisplayImage;
                selectedData.DisplayCategory = newSkill.DisplayCategory;
                selectedData.SkillAttributes = newSkill.SkillAttributes;



            }

        }
        #endregion

        #region Switch
        public void OnSearchSwitch(string? searchText)
        {
            this.ListSwitch_Search.Clear();

            IEnumerable<GameSwitchDisplayDTO> searchDatas = this.ListSwitch_All;

            if (string.IsNullOrEmpty(searchText) == false)
            {
                searchDatas = searchDatas.Where(p => p.ContainsGameDisplay(searchText, default));
            }
            this.ListSwitch_Search.AddRange(searchDatas);

        }
        public async Task<bool> GetListSwitchDisplayAsync()
        {
            this.ListSwitch_Search.Clear();
            this.ListSwitch_All.Clear();

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
            this.ListSwitch_Search.AddRange(listGameSwitch);
            this.ListSwitch_All.AddRange(listGameSwitch);
            return true;

        }
        public async ValueTask UpdateSwitchDisplay(GameSwitchDisplayDTO switchDisplayDTO, bool mSwitch = false)
        {
            if (this.GameSessionInfo is null)
            {
                return;
            }
            var dto = await this.Http.UpdateSwitchDisplayAsync(this.GameSessionInfo, switchDisplayDTO);
            if (false == dto.TryGet(out var gameSwitchDisplay))
            {
                if (mSwitch)
                {
                    switchDisplayDTO.SwitchValue = !switchDisplayDTO.SwitchValue;
                }
                await this.ShowErrorAsync(dto.MSG);
                return;
            }
            switchDisplayDTO.ContentValue = gameSwitchDisplay?.ContentValue ?? string.Empty;
        }

        #endregion

        #region Msg

        private Task ShowErrorAsync(string? error)
        {
            return this.PopupService.EnqueueSnackbarAsync(new Masa.Blazor.Presets.SnackbarOptions(error ?? "Error", AlertTypes.Error, true));
        }
        private Task ShowInfoAsync(string msg)
        {
            return this.PopupService.EnqueueSnackbarAsync(new Masa.Blazor.Presets.SnackbarOptions(msg, AlertTypes.Success, true));
        }

        public UIProgressCircular ShowWait()
        {
            return this.PopupService.ShowWait();
        }
        #endregion


    }
}
