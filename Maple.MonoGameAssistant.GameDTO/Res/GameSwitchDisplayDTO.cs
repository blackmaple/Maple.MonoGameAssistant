using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;
namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchDisplayDTO : GameObjectDisplayDTO
    {
        public bool SwitchValue { set; get; }

        [JsonIgnore]
        public string? CacheValue { set; get; }

        [JsonIgnore]
        public int IntCache
        {
            get
            {
                if (int.TryParse(CacheValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.CacheValue = value.ToString();
            }
        }

        [JsonIgnore]
        public float FloatCache
        {
            get
            {
                if (float.TryParse(CacheValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.CacheValue = value.ToString();
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
