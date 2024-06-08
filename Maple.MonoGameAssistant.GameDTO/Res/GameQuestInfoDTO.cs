using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameQuestInfoDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 任务奖励
        /// </summary>
        public GameValueInfoDTO[]? LootAttributes { set; get; }
    }
}
