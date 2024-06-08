using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MonoCollector
{
    public class MonoCollectorObjectException : MonoCommonException
    {

        public MonoCollectorObjectException(string? msg) : base(msg)
        {
        }

        public MonoCollectorObjectException(int code, string? msg) : base(code, msg)
        {
        }

        public MonoCollectorObjectException(int code, string? msg, Exception exception) : base(code, msg, exception)
        {
        }

        [DoesNotReturn]
        public static void Throw(string msg)
           => throw new MonoCollectorObjectException(msg);

        [DoesNotReturn]
        public static T Throw<T>(string msg)
            => throw new MonoCollectorObjectException(msg);

        //[DoesNotReturn]
        //public static ref T Throw_RefValue<T>(string msg) where T : unmanaged
        //    => throw new MonoCollectorObjectException(msg);

    }

}
