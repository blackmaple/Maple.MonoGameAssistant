using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidModel.ExceptionData
{
    public sealed class AndroidTaskStateException([CallerMemberName] string msg = nameof(AndroidTaskStateException))
    : AndroidCommonException(msg)
    {
        [DoesNotReturn]
        public static void Throw([CallerMemberName] string msg = nameof(AndroidTaskStateException))
        => throw new AndroidTaskStateException(msg);

        [DoesNotReturn]
        public static T Throw<T>([CallerMemberName] string msg = nameof(AndroidTaskStateException))
            => throw new AndroidTaskStateException(msg);

    }
}
