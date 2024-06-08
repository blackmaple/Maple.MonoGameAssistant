using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCurrencyInfoDTO : GameUniqueIndexDTO
    {
        public string? DisplayValue { get; set; }



        [JsonIgnore]
        public decimal Currency
        {
            get
            {
                if (decimal.TryParse(DisplayValue, out var result))
                {
                    return result;
                }
                return decimal.Zero;
            }
            set => DisplayValue = value.ToString();
        }
    }
}
