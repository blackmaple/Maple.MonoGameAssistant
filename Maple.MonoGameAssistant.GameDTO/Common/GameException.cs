using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameException(int code, string msg) : MonoCommonException(code, msg)
    {
        public GameException(string msg) : this(0, msg)
        {

        }

        [DoesNotReturn]
        public static void Throw(string msg) => throw new GameException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg) => throw new GameException(msg);


        [DoesNotReturn]
        public static T ThrowIfNotLoaded<T>() => throw new GameException("Please load the game save first");

        [DoesNotReturn]
        public static void ThrowIfNotLoaded(string msg) => throw new GameException("Please load the game save first");



        [DoesNotReturn]
        public static T ThrowUIHide<T>(string msg) => throw new GameException((int)EnumMonoCommonCode.BIZ_UIHIDE, msg);

    }
}
