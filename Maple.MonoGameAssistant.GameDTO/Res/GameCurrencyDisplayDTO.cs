using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCurrencyDisplayDTO : GameObjectDisplayDTO
    {

        [JsonIgnore]
        public bool Loading { set; get; }
    }
}
