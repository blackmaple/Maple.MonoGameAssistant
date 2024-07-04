using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSkillInfoDTO : GameValueInfoDTO
    {
        /// <summary>
        /// 技能类型
        /// </summary>
        public string? DisplayCategory { set; get; }
        public GameValueInfoDTO[]? SkillAttributes { set; get; }

    }
}
