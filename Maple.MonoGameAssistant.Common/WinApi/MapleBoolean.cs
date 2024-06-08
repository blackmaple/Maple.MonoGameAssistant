using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Common
{

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MapleBoolean
    {
        [MarshalAs(UnmanagedType.I4)]
        readonly int _value;

        public MapleBoolean(bool b)
        {
            _value = b ? 1 : 0;
        }
        public MapleBoolean(int n)
        {
            _value = n;
        }

        public static implicit operator int(MapleBoolean b) => b._value;
        public static implicit operator bool(MapleBoolean b) => b._value != 0;
        public static implicit operator MapleBoolean(int n) => new(n);
        public static implicit operator MapleBoolean(bool b) => new(b);

        public override string ToString()
        {
            return (_value != 0).ToString();
        }
    }
}
