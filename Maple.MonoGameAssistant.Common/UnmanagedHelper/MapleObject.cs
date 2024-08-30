using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Common
{
    public struct MapleObject<TObject, TValue>(TObject obj)
        where TObject : class
        where TValue : unmanaged
    {
        public readonly TObject Obj { get; } = obj;
        public TValue Val;


        public static unsafe nint ToIntPtr(scoped ref MapleObject<TObject, TValue> obj)
        {
            return (nint)Unsafe.AsPointer(ref obj);
        }

        public static unsafe ref MapleObject<TObject, TValue> ToObject(nint ptr)
        {
            return ref Unsafe.AsRef<MapleObject<TObject, TValue>>(ptr.ToPointer());
        }
    }
}
