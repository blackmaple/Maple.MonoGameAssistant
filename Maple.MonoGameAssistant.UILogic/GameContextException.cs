using System.Diagnostics.CodeAnalysis;
using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameContextException : MonoCommonException
{
    public GameContextException(string? msg) : base(msg)
    {
    }

    public GameContextException(int code, string? msg) : base(code, msg)
    {
    }

    [DoesNotReturn]
    public static void Throw(string msg) => throw new GameContextException(msg);

    [DoesNotReturn]
    public static T Throw<T>(string msg) => throw new GameContextException(msg);


}