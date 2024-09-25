using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    /// <summary>
    /// 人物技能
    /// </summary>
    public class GameCharacterSkillDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 技能集合
        /// </summary>
        public GameSkillInfoDTO[]? SkillInfos { set; get; }

    }

 
}
