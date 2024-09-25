using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{

    public class GameInventoryModifyDTO : GameInventoryObjectDTO
    {
        /// <summary>
        /// Value>0 Add Value;
        /// Value=0 remove All
        /// Value<0 remove Value;
        /// </summary>
        public string? NewValue { set; get; }

        [JsonIgnore]
        public int InventoryCount
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

        public int ThrowIfRemove(int old)
        {
            var add = InventoryCount - old;
            return add > 0 ? add : GameException.Throw<int>("REMOVE ERROR");
        }
    }
}
