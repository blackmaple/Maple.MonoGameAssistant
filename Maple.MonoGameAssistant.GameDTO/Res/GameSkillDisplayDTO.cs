using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSkillDisplayDTO : GameObjectDisplayDTO
    {
        public bool CanUse { set; get; }
        public GameValueInfoDTO[]? SkillAttributes { set; get; }


        [JsonIgnore]
        public bool Loading { set; get; }
    }
}
