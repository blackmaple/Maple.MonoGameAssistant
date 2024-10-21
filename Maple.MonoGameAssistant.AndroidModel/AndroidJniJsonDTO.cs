using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidModel
{
    public class AndroidJniJsonDTO<T> where T : class
    {
        public static AndroidJniJsonDTO<T> Empty { get; } = new AndroidJniJsonDTO<T>() { OK = false };

        public bool OK { set; get; }
        public string? ActionName { set; get; }
        public T? Data { get; set; }

        public bool TryGet([MaybeNullWhen(false)] out string? action, [MaybeNullWhen(false)] out T? data)
        {
            action = this.ActionName;
            data = this.Data;
            return OK;
        }
    }



}
