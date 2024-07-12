using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCharacterDisplayDTO : GameObjectDisplayDTO
    {

        public GameValueInfoDTO[]? CharacterAttributes { set; get; }

        [JsonIgnore]
        public bool Loading { set; get; }
    }


}
