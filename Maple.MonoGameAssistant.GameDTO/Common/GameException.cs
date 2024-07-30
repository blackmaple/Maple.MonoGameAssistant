using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameException(string msg) : MonoCommonException(msg)
    {

        [DoesNotReturn]
        public static void Throw(string msg)=> throw new GameException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new GameException(msg);


        [DoesNotReturn]
        public static T ThrowIfNotLoaded<T>() => throw new GameException("Please load the game save first");

        [DoesNotReturn]
        public static void ThrowIfNotLoaded(string msg) => throw new GameException("Please load the game save first");

    }
}
