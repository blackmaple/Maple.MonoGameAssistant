using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class GameMonsterInfoDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 属性集合
        /// </summary>
        public GameValueInfoDTO[]? MonsterAttributes { set; get; }

        ///// <summary>
        ///// 技能集合
        ///// </summary>
        //public GameSkillDisplayDTO[]? SkillInfos { set; get; }


    }

}
