using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSkillObjectDTO : GameSessionObjectDTO
    {
        public required string SkillObject { set; get; }
        public string? SkillCategory { set; get; }

        [JsonIgnore]
        public ulong ULongSkill
        {
            get
            {
                if (ulong.TryParse(SkillObject, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.SkillObject = value.ToString();
            }
        }
    }
}
