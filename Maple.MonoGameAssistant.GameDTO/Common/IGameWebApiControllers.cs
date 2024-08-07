﻿using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    public interface IGameWebApiControllers
    {



        #region Game Res
        ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
            => GameException.Throw<ValueTask<GameSessionInfoDTO>>("NotImplemented");
        ValueTask<GameSessionInfoDTO> LoadResourceAsync()
            => GameException.Throw<ValueTask<GameSessionInfoDTO>>("NotImplemented");
        #endregion

        #region Character

        ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
            => GameException.Throw<ValueTask<GameCharacterDisplayDTO[]>>("NotImplemented");
        ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");
        ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterStatusDTO>>("NotImplemented");
        ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");
        ValueTask<GameCharacterEquipmentDTO> AddCharacterMemberAsync(GameCharacterObjectDTO characterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterEquipmentDTO>>("NotImplemented");
        #endregion

        #region Monster

        ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
            => GameException.Throw<ValueTask<GameMonsterDisplayDTO[]>>("NotImplemented");
        ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
            => GameException.Throw<ValueTask<GameCharacterSkillDTO>>("NotImplemented");
        #endregion

        #region Skill

        ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
            => GameException.Throw<ValueTask<GameSkillDisplayDTO[]>>("NotImplemented");
        ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
            => GameException.Throw<ValueTask<GameSkillDisplayDTO>>("NotImplemented");
        #endregion

        #region Currency

        ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
            => GameException.Throw<ValueTask<GameCurrencyDisplayDTO[]>>("NotImplemented");

        ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");

        ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
            => GameException.Throw<ValueTask<GameCurrencyInfoDTO>>("NotImplemented");
        #endregion

        #region Inventory

        ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
            => GameException.Throw<ValueTask<GameInventoryDisplayDTO[]>>("NotImplemented");

        ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");

        ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
            => GameException.Throw<ValueTask<GameInventoryInfoDTO>>("NotImplemented");
        #endregion

        #region Switch

        ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO[]>>("NotImplemented");
        ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
                => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");
        #endregion

    }
}
