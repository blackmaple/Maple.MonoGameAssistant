using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Core
{
    public class MonoRuntimeException : MonoCommonException
    {
        public MonoRuntimeException(string? msg) : base(msg)
        {
        }

        public MonoRuntimeException(int code, string? msg) : base(code, msg)
        {
        }

        public MonoRuntimeException(int code, string? msg, Exception exception) : base(code, msg, exception)
        {
        }


        [DoesNotReturn]
        public static void Throw(string msg)
           => throw new MonoRuntimeException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg)
            => throw new MonoRuntimeException(msg);
    }
}
