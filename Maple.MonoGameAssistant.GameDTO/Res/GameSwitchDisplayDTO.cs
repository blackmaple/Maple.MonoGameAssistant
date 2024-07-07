using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;
namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchDisplayDTO : GameObjectDisplayDTO
    {
        public string? NewValue { set; get; }



        [JsonIgnore]
        public bool SwitchValue
        {
            get
            {
                if (bool.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.NewValue = value.ToString();
            }
        }

        [JsonIgnore]
        public bool ButtonType
        {
            get
            {
                if (bool.TryParse(DisplayCategory, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.DisplayCategory = value.ToString();
            }
        }

        [JsonIgnore]
        public bool Loading { set; get; }
    }
}
