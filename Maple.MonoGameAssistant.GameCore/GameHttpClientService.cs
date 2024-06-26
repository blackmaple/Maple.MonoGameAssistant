﻿using Maple.MonoGameAssistant.GameDTO;
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

        public Task<MonoResultDTO<GameSessionInfoDTO>> GetGameSessionInfoAsync()
        {
            return this.TrySendAsync<GameUniqueIndexDTO, GameSessionInfoDTO>("game/info");
        }

        public Task<MonoResultDTO<GameCurrencyDisplayDTO[]>> GetListCurrencyDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameCurrencyDisplayDTO[]>("game/GetListCurrencyDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        public Task<MonoResultDTO<GameCurrencyInfoDTO>> GetCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameCurrencyId)
        {
            return this.TrySendAsync<GameCurrencyObjectDTO, GameCurrencyInfoDTO>("game/GetCurrencyInfo", new GameCurrencyObjectDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrencyId });
        }
        public Task<MonoResultDTO<GameCurrencyInfoDTO>> UpdateCurrencyInfoAsync(GameSessionInfoDTO gameSessionInfo, GameCurrencyInfoDTO gameCurrency)
        {
            return this.TrySendAsync<GameCurrencyModifyDTO, GameCurrencyInfoDTO>("game/UpdateCurrencyInfo", new GameCurrencyModifyDTO() { Session = gameSessionInfo.ObjectId, CurrencyObject = gameCurrency.ObjectId, NewValue = gameCurrency.DisplayValue });
        }

        public Task<MonoResultDTO<GameInventoryDisplayDTO[]>> GetListInventoryDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameInventoryDisplayDTO[]>("game/GetListInventoryDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        public Task<MonoResultDTO<GameInventoryInfoDTO>> GetInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameInventoryId, string? category)
        {
            return this.TrySendAsync<GameInventoryObjectDTO, GameInventoryInfoDTO>("game/GetInventoryInfo", new GameInventoryObjectDTO() { Session = gameSessionInfo.ObjectId, InventoryCategory = category, InventoryObject = gameInventoryId });
        }
        public Task<MonoResultDTO<GameInventoryInfoDTO>> UpdateInventoryInfoAsync(GameSessionInfoDTO gameSessionInfo, string? category, GameInventoryInfoDTO gameInventory)
        {
            return this.TrySendAsync<GameInventoryModifyDTO, GameInventoryInfoDTO>("game/UpdateInventoryInfo", new GameInventoryModifyDTO { Session = gameSessionInfo.ObjectId, InventoryCategory = category, InventoryObject = gameInventory.ObjectId, NewValue = gameInventory.DisplayValue });
        }


        public Task<MonoResultDTO<GameCharacterDisplayDTO[]>> GetListCharacterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameCharacterDisplayDTO[]>("game/GetListCharacterDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        [Obsolete("remove...")]
        public Task<MonoResultDTO<GameCharacterInfoDTO>> GetCharacterInfoAsync(GameSessionInfoDTO gameSessionInfo, string gameCharacterId)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterInfoDTO>("game/GetCharacterInfo", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterId });
        }
        public Task<MonoResultDTO<GameCharacterStatusDTO>> GetCharacterStatusAsync(GameSessionInfoDTO gameSessionInfo, string gameCharacterId)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterStatusDTO>("game/GetCharacterStatus", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterId });
        }
        public Task<MonoResultDTO<GameCharacterSkillDTO>> GetCharacterSkillAsync(GameSessionInfoDTO gameSessionInfo, string gameCharacterId)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterSkillDTO>("game/GetCharacterSkill", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterId });
        }
        public Task<MonoResultDTO<GameCharacterEquipmentDTO>> GetCharacterEquipmentAsync(GameSessionInfoDTO gameSessionInfo, string gameCharacterId)
        {
            return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterEquipmentDTO>("game/GetCharacterEquipment", new GameCharacterObjectDTO() { Session = gameSessionInfo.ObjectId, CharacterId = gameCharacterId });
        }

        //public Task<MonoResultDTO<GameCharacterInfoDTO>> UpdateCharacterAsync(GameCharacterObjectDTO requestDTO)
        //{
        //    return this.TrySendAsync<GameCharacterObjectDTO, GameCharacterInfoDTO>("game/UpdateCharacter", requestDTO);
        //}

        public Task<MonoResultDTO<GameMonsterDisplayDTO[]>> GetListMonsterDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameMonsterDisplayDTO[]>("game/GetListMonsterDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        public Task<MonoResultDTO<GameSkillDisplayDTO[]>> GetListSkillDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSkillDisplayDTO[]>("game/GetListSkillDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
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


        public Task<MonoResultDTO<GameSwitchDisplayDTO[]>> GetListSwitchDisplayAsync(GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSwitchDisplayDTO[]>("game/GetListSwitchDisplay", new GameSessionObjectDTO() { Session = gameSessionInfo.ObjectId });
        }
        public Task<MonoResultDTO<GameSwitchDisplayDTO[]>> UpdateSwitchDisplayAsync(GameSwitchDisplayDTO gameSwitchInfo, GameSessionInfoDTO gameSessionInfo)
        {
            return this.TrySendAsync<GameSessionObjectDTO, GameSwitchDisplayDTO[]>("game/UpdateSwitchDisplay", new GameSwitchModifyDTO() { SwitchObjectId = gameSwitchInfo.ObjectId, SwitchValue = gameSwitchInfo.SwitchValue, Session = gameSessionInfo.ObjectId });
        }
    }
}
