namespace Maple.MonoGameAssistant.Model
{
    public class GameDisplayDTO: GameUniqueIndexDTO
    {
        /// <summary>
        /// 图片的Uri
        /// </summary>
        public string? DisplayImage { set; get; }
        /// <summary>
        /// 对象名称
        /// </summary>
        public string? DisplayName { set; get; }
        /// <summary>
        /// 对象的描述
        /// </summary>
        public string? DisplayDesc { set; get; }

    }
}