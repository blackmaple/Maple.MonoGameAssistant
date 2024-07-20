using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCharacterObjectDTO : GameSessionObjectDTO
    {
        public required string CharacterId { set; get; }

        /// <summary>
        /// 对象的类型
        /// </summary>
        public string? CharacterCategory { set; get; }


        [JsonIgnore]
        public ulong UCharacterId
        {
            get
            {
                if (ulong.TryParse(CharacterId, out var result))
                {
                    return result;
                }
                return 0;
            }
            set => CharacterId = value.ToString();
        }

    }



}
