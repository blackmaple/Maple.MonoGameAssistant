using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

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

        [DoesNotReturn]
        public static void ThrowNotFound(string? name) => GameException.Throw($"NOT FOUND {name}");
        [DoesNotReturn]
        public static T ThrowNotFound<T>(string? name) => GameException.Throw<T>($"NOT FOUND {name}");

 


    }
}
