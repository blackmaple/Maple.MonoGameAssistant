namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public enum EnumApiActionIndex
    {
        None = 0,
        //MONO
        EnumImages,
        EnumClasses,
        EnumObjects,
        EnumClassDetail,

        //GAME
        INFO,
        LoadResource,

        GetListCurrencyDisplay,
        GetCurrencyInfo,
        UpdateCurrencyInfo,

        GetListInventoryDisplay,
        GetInventoryInfo,
        UpdateInventoryInfo,

        GetListCharacterDisplay,

        GetCharacterStatus,
        UpdateCharacterStatus,

        GetCharacterEquipment,
        UpdateCharacterEquipment,

        GetCharacterSkill,
        UpdateCharacterSkill,

        GetListMonsterDisplay,
        AddMonsterMember,

        GetListSkillDisplay,
        AddSkillDisplay,


        GetListSwitchDisplay,
        UpdateSwitchDisplay,
    }
}
