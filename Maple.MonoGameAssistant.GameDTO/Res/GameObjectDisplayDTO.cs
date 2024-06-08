using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{


    /// <summary>
    /// 基础类型
    /// </summary>
    public class GameObjectDisplayDTO: GameDisplayDTO
    {
        /// <summary>
        /// 对象的类型
        /// </summary>
        public string? DisplayCategory { set; get; }
    }

}
