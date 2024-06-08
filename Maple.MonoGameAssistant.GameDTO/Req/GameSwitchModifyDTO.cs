using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchModifyDTO : GameSessionObjectDTO
    {

        public required string SwitchObjectId { set; get; }
        public bool SwitchValue { set; get; }
    }
}
