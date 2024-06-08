using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;
namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchDisplayDTO : GameUniqueIndexDTO
    {

        /// <summary>
        /// 对象名称
        /// </summary>
        public string? DisplayName { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        public string? DisplayDesc { set; get; }

        /// <summary>
        /// 值
        /// </summary>
        public bool SwitchValue { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public bool ButtonType { set; get; }

        [JsonIgnore]
        public bool Loading { set; get; }
    }
}
