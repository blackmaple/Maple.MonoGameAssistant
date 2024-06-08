
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PIL2CPP_FIELD_STATIC_GET_VALUE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PIL2CPP_FIELD_STATIC_GET_VALUE(nint ptr)
    {
        public const string il2cpp = "il2cpp_field_static_get_value";

        //nint IL2CPP_FIELD_STATIC_GET_VALUE (void* field, void* output)
        //typedef void* (__cdecl *IL2CPP_FIELD_STATIC_GET_VALUE)(void* field, void* output);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoAddress, void> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoField, PMonoAddress, void>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoField pMonoField, PMonoAddress pMonoAddress) => _func(pMonoField, pMonoAddress);

        public readonly ref T_STRUCT Invoke_Ref<T_STRUCT>(PMonoField pMonoField)
            where T_STRUCT : struct
        {
            //托管对象Pin
            var size = Unsafe.SizeOf<T_STRUCT>();
            var buffer = new byte[size];
            ref var ref_buffer = ref MemoryMarshal.GetArrayDataReference(buffer);
            fixed (void* pBuffer = &ref_buffer)
            {
                Invoke(pMonoField, pBuffer);
            }
            return ref Unsafe.As<byte, T_STRUCT>(ref ref_buffer);
        }

        [SkipLocalsInit]
        public readonly T_STRUCT Invoke<T_STRUCT>(PMonoField pMonoField)
            where T_STRUCT : struct
        {
            //栈对象不需要Pin
            var size = Unsafe.SizeOf<T_STRUCT>();
            Span<byte> buffer = (stackalloc byte[size]);
            ref var ref_buffer = ref MemoryMarshal.GetReference(buffer);
            var pBuffer = Unsafe.AsPointer(ref ref_buffer);
            Invoke(pMonoField, pBuffer);
            return Unsafe.As<byte, T_STRUCT>(ref ref_buffer);
        }


        public readonly void Invoke_Buffer(PMonoField pMonoField, Span<byte> buffer)
        {
            ref var ref_buffer = ref MemoryMarshal.GetReference(buffer);
            fixed (void* pBuffer = &ref_buffer)
            {
                Invoke(pMonoField, pBuffer);
            }
        }

    }



    #endregion



}