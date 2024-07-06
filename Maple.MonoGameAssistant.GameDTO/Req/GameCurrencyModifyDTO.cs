using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCurrencyModifyDTO : GameCurrencyObjectDTO
    {
        /// <summary>
        /// 修改值
        /// </summary>
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
    }
}
