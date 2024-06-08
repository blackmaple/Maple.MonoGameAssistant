namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameInventoryObjectDTO : GameSessionObjectDTO
    {
        public string? InventoryCategory { set; get; }
        public required string InventoryObject { set; get; }
    }
}
