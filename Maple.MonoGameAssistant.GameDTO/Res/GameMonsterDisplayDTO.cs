namespace Maple.MonoGameAssistant.GameDTO
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class GameMonsterDisplayDTO : GameObjectDisplayDTO
    {
        /// <summary>
        /// 属性
        /// </summary>
        public GameValueInfoDTO[]? MonsterAttributes { set; get; }

        /// <summary>
        /// 技能
        /// </summary>
        public GameSkillInfoDTO[]? SkillInfos { set; get;}

        /// <summary>
        /// 奖励
        /// </summary>
        public GameValueInfoDTO[]? LootAttributes { set; get; }

    }

}
