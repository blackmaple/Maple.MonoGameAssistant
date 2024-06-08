using Maple.MonoGameAssistant.Model;

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

    }
}
