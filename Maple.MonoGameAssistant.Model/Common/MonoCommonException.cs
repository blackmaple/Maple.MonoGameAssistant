using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoCommonException : Exception
    {
        public int Code { set; get; }
        public MonoCommonException(string? msg) : this(0, msg) { }
        public MonoCommonException(int code, string? msg) : base(msg) { Code = code; }
        public MonoCommonException(int code, string? msg, Exception exception) : base(msg, exception) { Code = code; }


    }
}