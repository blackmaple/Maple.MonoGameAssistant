namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSkillObjectDTO : GameSessionObjectDTO
    {
        public required string SkillObject { set; get; }
        public string? SkillCategory { set; get; }
    }
}
