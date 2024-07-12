using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameInventoryDisplayDTO : GameObjectDisplayDTO
    {


        /// <summary>
        /// 道具属性集合
        /// </summary>
        public GameValueInfoDTO[]? ItemAttributes { set; get; }

        /// <summary>
        /// 装备适应角色
        /// </summary>
        public GameValueInfoDTO[]? ValidCharacters { set; get; }

        [JsonIgnore]
        public bool Loading { set; get; }
    }
}
