using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoList_x86<T_DATA>(nint ptr) : IPtrMonoList<Ref_MonoList_x86, T_DATA>
        where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList_x86<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList_x86<T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoList(PMonoList_x86<T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoList_x86<T_DATA>(PMonoList obj) => new(obj);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoList_x86 AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoList_x86>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMonoList_x86<T_DATA>, Ref_MonoList_x86, T_DATA>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoList_x86<T_DATA>, Ref_MonoList_x86, T_DATA>(index);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public int Size => AsRef().Size;

        public IEnumerable<T_DATA> AsEnumerable()
        {
            var size = this.Size;
            for (int i = 0; i < size; ++i)
            {
                yield return this[i % size];
            }
        }

        public Enumerator GetEnumerator() => new(this);

        public struct Enumerator(PMonoList_x86<T_DATA> list)
        {
            private int _index = 0;
            private readonly int _size = list.Size;
            private T_DATA _current = default;

            public readonly void Dispose() { }

            public readonly T_DATA Current => _current;

            public bool MoveNext()
            {
                if (((uint)_index < (uint)_size))
                {
                    _current = list[_index];
                    _index++;
                    return true;
                }
                return false;
            }
        }
    }

}
