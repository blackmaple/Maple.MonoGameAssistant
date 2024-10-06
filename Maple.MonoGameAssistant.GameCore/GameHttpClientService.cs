using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using System.Net.Http.Json;

namespace Maple.MonoGameAssistant.GameCore
{
    public class GameHttpClientService
    {

        public HttpClient Client { get; }
        public GameHttpClientService(HttpClient httpClient)
        {
            this.Client = httpClient;
            this.Client.Timeout = TimeSpan.FromSeconds(30D);
            this.Client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("br"));
        }

        #region HttpCore

        async Task<MonoResultDTO<T_RESPONSE>> SendAsync<T_REQUEST, T_RESPONSE>(string url, T_REQUEST? req)
            where T_RESPONSE : class
            where T_REQUEST : class
        {
            using var reqMsg = req is null ? new HttpRequestMessage(HttpMethod.Get, url) :
                   new HttpRequestMessage(HttpMethod.Post, url)
                   {
                       Content = JsonContent.Create(req, mediaType: default, GameJsonContext.Default.Options)
                   };

            using var httpMsg = await this.Client.SendAsync(reqMsg).ConfigureAwait(false);
            if (false == httpMsg.IsSuccessStatusCode)
            {
                GameException.Throw($"Http StatusCode Error:{httpMsg.StatusCode}");
            }


            var jsonDTO = await httpMsg.Content.ReadFromJsonAsync<MonoResultDTO<T_RESPONSE>>(GameJsonContext.Default.Options).ConfigureAwait(false);
            return jsonDTO ?? GameException.Throw<MonoResultDTO<T_RESPONSE>>("Serivce Error");
        }
        public async Task<MonoResultDTO<T_RESPONSE>> TrySendAsync<T_REQUEST, T_RESPONSE>(string url, T_REQUEST? req = default)
            where T_RESPONSE : class
            where T_REQUEST : class
        {
            try
            {
                return await this.SendAsync<T_REQUEST, T_RESPONSE>(url, req).ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                return MonoResultDTO.GetBizError<T_RESPONSE>(0, ex.Message);
            }
            catch (Exception ex)
            {
                return MonoResultDTO.GetSystemError<T_RESPONSE>(ex.Message);
            }
        }
        #endregion

        #region Game

        /// <summary>
        /// Api.获取游戏Session
        /// 以下Api都需要Session
        /// App初始化后可以获取
        /// </summary>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSessionInfoDTO>> GetGameSessionInfoAsync()
        {
            return this.TrySendAsync<GameUniqueIndexDTO, GameSessionInfoDTO>("game/info");
        }

        /// <summary>
        /// Api.加载游戏资源
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSessionInfoDTO>> LoadResourceAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSessionInfoDTO>("game/LoadResource", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        #endregion

        #region Currency
        /// <summary>
        /// Api.加载游戏货币类列表
        /// App初始化后可以获取
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCurrencyDisplayDTO[]>> GetListCurrencyDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameCurrencyDisplayDTO[]>("game/GetListCurrencyDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        /// <summary>
        /// Api.获取指定游戏货币数量
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCurrencyId"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCurrencyInfoDTO>> GetCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameCurrencyId)
        {
            return this.TrySendAsync<GameCurrencyObjectDTO, GameCurrencyInfoDTO>("game/GetCurrencyInfo", new GameCurrencyObjectDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrencyId });
        }
        /// <summary>
        /// Api.修改指定的游戏货币数量
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCurrency"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCurrencyInfoDTO>> UpdateCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, GameCurrencyInfoDTO gameCurrency)
        {
            return this.TrySendAsync<GameCurrencyModifyDTO, GameCurrencyInfoDTO>("game/UpdateCurrencyInfo", new GameCurrencyModifyDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrency.ObjectId, NewValue = gameCurrency.DisplayValue });
        }
        #endregion

        #region Inventory
        /// <summary>
        /// Api.获取游戏道具列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameInventoryDisplayDTO[]>> GetListInventoryDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameInventoryDisplayDTO[]>("game/GetListInventoryDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        /// <summary>
        /// Api.获取指定道具信息
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameInventoryId"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameInventoryInfoDTO>> GetInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameInventoryId, string? category)
        {
            return this.TrySendAsync<GameInventoryObjectDTO, GameInventoryInfoDTO>("game/GetInventoryInfo", new GameInventoryObjectDTO() { Session = gameSessionInfo.ObjectId, InventoryCategory = category, InventoryObject = gameInventoryId });
        }
        /// <summary>
        /// Api.修改指定的道具数量
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="category"></param>
        /// <param name="gameInventory"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameInventoryInfoDTO>> UpdateInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string? category, GameInventoryInfoDTO gameInventory)
        {
            return this.TrySendAsync<GameInventoryModifyDTO, GameInventoryInfoDTO>("game/UpdateInventoryInfo", new GameInventoryModifyDTO { Session = gameSessionInfo.ObjectId, InventoryCategory = category, InventoryObject = gameInventory.ObjectId, NewValue = gameInventory.DisplayValue });
        }
        #endregion

        #region Character
        /// <summary>
        /// Api.获取游戏角色列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterDisplayDTO[]>> GetListCharacterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameCharacterDisplayDTO[]>("game/GetListCharacterDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        //[Obsolete("remove...")]
        //public Task<MonoResultDTO<GameCharacterInfoDTO>> GetCharacterInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameCharacterId)
        //{
        //    return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterInfoDTO>("game/GetCharacterInfo", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterId });
        //}
        /// <summary>
        /// Api.获取角色状态信息
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterStatusDTO>> GetCharacterStatusAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterStatusDTO>("game/GetCharacterStatus", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory });
        }
        /// <summary>
        /// Api.更新角色状态值
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <param name="gameValueInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterStatusDTO>> UpdateCharacterStatusAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, GameSwitchDisplayDTO gameValueInfo)
        {
            return this.TrySendAsync<GameCharacterModifyDTO, GameCharacterStatusDTO>("game/UpdateCharacterStatus", new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = gameValueInfo.DisplayCategory, ModifyObject = gameValueInfo.ObjectId, NewValue = gameValueInfo.ContentValue });
        }
        /// <summary>
        /// Api.获取角色技能列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterSkillDTO>> GetCharacterSkillAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterSkillDTO>("game/GetCharacterSkill", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory });
        }
        /// <summary>
        /// Api.更新角色技能
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <param name="modifyCategory"></param>
        /// <param name="oldSkill"></param>
        /// <param name="newSkill">为空表示移除技能</param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterSkillDTO>> UpdateCharacterSkillAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, string? modifyCategory, string oldSkill, string newSkill)
        {
            return this.TrySendAsync<GameCharacterModifyDTO, GameCharacterSkillDTO>("game/UpdateCharacterSkill", new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = modifyCategory, ModifyObject = oldSkill, NewValue = newSkill });
        }
        /// <summary>
        /// Api.获取角色装备列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterEquipmentDTO>> GetCharacterEquipmentAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterEquipmentDTO>("game/GetCharacterEquipment", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory });
        }
        /// <summary>
        /// Api.修改角色装备
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameCharacterDisplay"></param>
        /// <param name="modifyCategory"></param>
        /// <param name="oldEquip"></param>
        /// <param name="newEquip">为空则移除装备</param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterEquipmentDTO>> UpdateCharacterEquipmentAsync(GameSessionInfoDTO gameSessionInfo, GameCharacterDisplayDTO gameCharacterDisplay, string? modifyCategory, string oldEquip, string newEquip)
        {
            return this.TrySendAsync<GameCharacterModifyDTO, GameCharacterEquipmentDTO>("game/UpdateCharacterEquipment", new GameCharacterModifyDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterDisplay.ObjectId, CharacterCategory = gameCharacterDisplay.DisplayCategory, ModifyCategory = modifyCategory, ModifyObject = oldEquip, NewValue = newEquip });
        }
        #endregion

        #region Monster
        /// <summary>
        /// Api.获取怪兽列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameMonsterDisplayDTO[]>> GetListMonsterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameMonsterDisplayDTO[]>("game/GetListMonsterDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        /// <summary>
        /// Api.添加指定怪兽
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="monsterObject"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameCharacterSkillDTO>> AddMonsterMemberAsync(GameSessionInfoDTO gameSessionInfo, string monsterObject)
        {
            return this.TrySendAsync<GameMonsterObjectDTO, GameCharacterSkillDTO>("game/AddMonsterMember", new GameMonsterObjectDTO() { Session = gameSessionInfo.ObjectId, MonsterObject = monsterObject });
        }
        #endregion

        #region Skill
        /// <summary>
        /// Api.获取游戏技能列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSkillDisplayDTO[]>> GetListSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSkillDisplayDTO[]>("game/GetListSkillDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        /// <summary>
        /// Api.添加技能列表
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameSkillDisplay"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSkillDisplayDTO>> AddSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo, GameSkillDisplayDTO gameSkillDisplay)
        {
            return this.TrySendAsync<GameSkillObjectDTO, GameSkillDisplayDTO>("game/AddSkillDisplay", new GameSkillObjectDTO() { Session = gameSessionInfo.ObjectId, SkillObject = gameSkillDisplay.ObjectId, SkillCategory = gameSkillDisplay.DisplayCategory });
        }

        #endregion

        //public Task<MonoResultDTO<GameMonsterInfoDTO[]>> GetListMonsterInfoAsync(GameSessionInfoDTO gameSessionInfo)
        //{
        //    return this.TrySendAsync<GameSessionObjectDTO, GameMonsterInfoDTO[]>("game/GetListMonsterInfo", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        //}


        //public Task<MonoResultDTO<GameQuestDisplayDTO[]>> GetListQuestDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        //{
        //    return this.TrySendAsync<GameSessionObjectDTO, GameQuestDisplayDTO[]>("game/GetListQuestDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        //}
        //public Task<MonoResultDTO<GameQuestInfoDTO[]>> GetListQuestInfoAsync(GameSessionInfoDTO gameSessionInfo)
        //{
        //    return this.TrySendAsync<GameSessionObjectDTO, GameQuestInfoDTO[]>("game/GetListQuestInfo", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        //}
        //public Task<MonoResultDTO<bool>> UpdateQuestAsync(GameQuestRequestDTO requestDTO)
        //{
        //    return this.TrySendAsync<GameQuestRequestDTO, bool>("game/UpdateQuestAsync", requestDTO);
        //}

        //public Task<MonoResultDTO<GameSkillDisplayDTO[]>> GetListSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        //{
        //    return this.TrySendAsync<GameSessionObjectDTO, GameSkillDisplayDTO[]>("game/GetListSkillDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        //}
        //public Task<MonoResultDTO<GameSkillInfoDTO[]>> GetListSkillInfoAsync(GameSessionInfoDTO gameSessionInfo)
        //{
        //    return this.TrySendAsync<GameSessionObjectDTO, GameSkillInfoDTO[]>("game/GetListSkillInfo", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        //}

        #region Switch
        /// <summary>
        /// Api.获取可操作游戏功能列表
        /// 具体返回不同的Button 显示对应的操作UI
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSwitchDisplayDTO[]>> GetListSwitchDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSwitchDisplayDTO[]>("game/GetListSwitchDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        /// <summary>
        /// Api.执行指定游戏功能
        /// </summary>
        /// <param name="gameSessionInfo"></param>
        /// <param name="gameSwitchInfo"></param>
        /// <returns></returns>
        public Task<MonoResultDTO<GameSwitchDisplayDTO>> UpdateSwitchDisplayAsync(GameSessionInfoDTO gameSessionInfo, GameSwitchDisplayDTO gameSwitchInfo)
        {
            return this.TrySendAsync<GameSwitchModifyDTO, GameSwitchDisplayDTO>("game/UpdateSwitchDisplay", new GameSwitchModifyDTO() { Session = gameSessionInfo.ObjectId, SwitchObjectId = gameSwitchInfo.ObjectId, ContentValue = gameSwitchInfo.ContentValue, });
        }
        #endregion

    }
}
