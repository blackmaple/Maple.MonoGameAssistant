using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidModel.ExceptionData
{
    public sealed class AndroidServiceException([CallerMemberName] string msg = nameof(AndroidJNIException)) : AndroidCommonException(msg)
    {
        [DoesNotReturn]
        public static void Throw([CallerMemberName] string msg = nameof(AndroidJNIException))
        => throw new AndroidServiceException(msg);

        [DoesNotReturn]
        public static T Throw<T>([CallerMemberName] string msg = nameof(AndroidJNIException))
            => throw new AndroidServiceException(msg);
    }
}
