using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    /// <summary>
    /// 人物信息
    /// </summary>
    public class GameCharacterInfoDTO : GameObjectDisplayDTO
    {
        /// <summary>
        /// 属性集合
        /// </summary>
        public GameValueInfoDTO[]? CharacterAttributes { set; get; }
        /// <summary>
        /// 装备集合
        /// </summary>
        public GameValueInfoDTO[]? EquipmentAttributes { set; get; }
        /// <summary>
        /// 技能集合
        /// </summary>
        public GameSkillDisplayDTO[]? SkillInfos { set; get; }

    }

    /// <summary>
    /// 人物属性
    /// </summary>
    public class GameCharacterStatusDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 属性集合
        /// </summary>
        public GameValueInfoDTO[]? CharacterAttributes { set; get; }

    }


    /// <summary>
    /// 人物装逼
    /// </summary>
    public class GameCharacterEquipmentDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 装备集合
        /// </summary>
        public GameValueInfoDTO[]? EquipmentAttributes { set; get; }

    }


    /// <summary>
    /// 人物技能
    /// </summary>
    public class GameCharacterSkillDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 技能集合
        /// </summary>
        public GameValueInfoDTO[]? SkillInfos { set; get; }

    }

}
