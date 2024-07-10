using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchModifyDTO : GameSessionObjectDTO
    {

        public required string SwitchObjectId { set; get; }

        public string? ContentValue { set; get; }

        [JsonIgnore]
        public bool SwitchValue
        {
            get
            {
                if (bool.TryParse(ContentValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => ContentValue = value.ToString();
        }

        [JsonIgnore]
        public uint UIntValue
        {
            get
            {
                if (uint.TryParse(ContentValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => ContentValue = value.ToString();
        }

    }
}
