namespace Maple.MonoGameAssistant.GameDTO
{

    public class GameSessionObjectDTO
    {

        public required string Session { set; get; }


        public void ThrowIfGameSessionDiff()
        {
            if (Environment.ProcessId.ToString() != this.Session)
            {
                throw new GameException("Game session has expired, please refresh!");
            }
        }

       
        
    }
}
