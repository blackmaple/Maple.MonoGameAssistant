using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    /// <summary>
    /// 道具
    /// </summary>
    public class GameInventoryInfoDTO : GameUniqueIndexDTO
    {
        public string? DisplayValue { get; set; }


        [JsonIgnore]
        public int InventoryCount
        {
            get
            {
                if (int.TryParse(DisplayValue, out var result))
                {
                    return result;
                }
                return 0;
            }
            set =>  DisplayValue = value.ToString();
        }

    }
}
