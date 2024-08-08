using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.RawDotNet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct REF_MONO_VECTOR3(float x, float y, float z)
    {
        [MarshalAs(UnmanagedType.R4)]
        //  [FieldOffset(0)]
        public float x = x;

        [MarshalAs(UnmanagedType.R4)]
        //   [FieldOffset(4)]
        public float y = y;

        [MarshalAs(UnmanagedType.R4)]
        //      [FieldOffset(8)]
        public float z = z;


        public REF_MONO_VECTOR3() : this(0f, 0f, 0f) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static REF_MONO_VECTOR3 Cross(in REF_MONO_VECTOR3 lhs, in REF_MONO_VECTOR3 rhs)
        {
            return new REF_MONO_VECTOR3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(in REF_MONO_VECTOR3 lhs, in REF_MONO_VECTOR3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(in REF_MONO_VECTOR3 a, in REF_MONO_VECTOR3 b)
        {
            double num = a.x - b.x;
            double num2 = a.y - b.y;
            double num3 = a.z - b.z;
            return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
        }
    }
}
