using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCharacterModifyDTO : GameCharacterObjectDTO
    {
        public string? ModifyCategory { set; get; }
        public string? ModifyObject { set; get; }
        public string? NewValue { set; get; }


        [JsonIgnore]
        public int IntValue
        {
            get
            {
                if (int.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return 0;
            }
            set => NewValue = value.ToString();
        }

        [JsonIgnore]
        public ulong ULongValue
        {
            get
            {
                if (ulong.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return 0;
            }
            set => NewValue = value.ToString();
        }

        [JsonIgnore]
        public float FloatValue
        {
            get
            {
                if (float.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return 0;
            }
            set => NewValue = value.ToString();
        }

        [JsonIgnore]
        public double DoubleValue
        {
            get
            {
                if (float.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return 0;
            }
            set => NewValue = value.ToString();
        }


        [JsonIgnore]
        public bool? BoolValue
        {
            get
            {
                if (bool.TryParse(NewValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => NewValue = value.HasValue ? value.ToString() : string.Empty;
        }
    }
}
