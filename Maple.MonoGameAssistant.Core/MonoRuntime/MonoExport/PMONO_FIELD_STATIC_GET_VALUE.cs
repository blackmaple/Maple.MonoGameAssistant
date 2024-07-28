
using Maple.MonoGameAssistant.Common;
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    #region PMONO_FIELD_STATIC_GET_VALUE


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_FIELD_STATIC_GET_VALUE(nint ptr)
    {
        public const string mono = "mono_field_static_get_value";

        //nint MONO_FIELD_STATIC_GET_VALUE (void *vtable, void* field, void* output)
        //typedef void* (__cdecl *MONO_FIELD_STATIC_GET_VALUE)(void *vtable, void* field, void* output);
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoVirtualTable, PMonoField, PMonoAddress, PMonoAddress> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoVirtualTable, PMonoField, PMonoAddress, PMonoAddress>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Invoke(PMonoVirtualTable pMonoVirtualTable, PMonoField pMonoField, PMonoAddress pMonoAddress) => _func(pMonoVirtualTable, pMonoField, pMonoAddress);

        //public readonly ref T_STRUCT Invoke_Ref<T_STRUCT>(PMonoVirtualTable pMonoVirtualTable, PMonoField pMonoField)
        //    where T_STRUCT : struct
        //{
        //    var size = Unsafe.SizeOf<T_STRUCT>();
        //    var buffer = new byte[size];
        //    ref var ref_buffer = ref MemoryMarshal.GetArrayDataReference(buffer);
        //    //fixed:托管内存需要pin
        //    fixed (void* pBuffer = &ref_buffer)
        //    {
        //        Invoke(pMonoVirtualTable, pMonoField, pBuffer);
        //    }
        //    return ref Unsafe.As<byte, T_STRUCT>(ref ref_buffer);
        //}

        /// <summary>
        /// x86 error?
        /// </summary>
        /// <typeparam name="T_STRUCT"></typeparam>
        /// <param name="pMonoVirtualTable"></param>
        /// <param name="pMonoField"></param>
        /// <returns></returns>
        [SkipLocalsInit]
        public readonly T_STRUCT Invoke<T_STRUCT>(PMonoVirtualTable pMonoVirtualTable, PMonoField pMonoField)
            where T_STRUCT : struct
        {
            //fixed:栈对象不需要Pin
            var size = Unsafe.SizeOf<T_STRUCT>();
            System.Diagnostics.Trace.Assert(size <= sizeof(long));
            Span<byte> buffer = (stackalloc byte[size]);
            ref var ref_buffer = ref MemoryMarshal.GetReference(buffer);
            var pBuffer = Unsafe.AsPointer(ref ref_buffer);
            Invoke(pMonoVirtualTable, pMonoField, pBuffer);
            return Unsafe.As<byte, T_STRUCT>(ref ref_buffer);
        }

        [SkipLocalsInit]
        public readonly T_STRUCT Invoke2<T_STRUCT>(PMonoVirtualTable pMonoVirtualTable, PMonoField pMonoField)
            where T_STRUCT : struct
        {
            var size = Unsafe.SizeOf<T_STRUCT>();
            using var memoryOwner = MemoryPool<byte>.Shared.Rent(size);
            var buffer = memoryOwner.Memory.Span;
            ref var ref_buffer = ref MemoryMarshal.GetReference(buffer);
            fixed (void* pBuffer = &ref_buffer)
            {
                Invoke(pMonoVirtualTable, pMonoField, pBuffer);
            }
            return Unsafe.As<byte, T_STRUCT>(ref ref_buffer);

        }


        public readonly void Invoke_Buffer(PMonoVirtualTable pMonoVirtualTable, PMonoField pMonoField, Span<byte> buffer)
        {
            ref var ref_buffer = ref MemoryMarshal.GetReference(buffer);
            //fixed:不知道来源是非托管还是托管 fixed
            fixed (void* pBuffer = &ref_buffer)
            {
                Invoke(pMonoVirtualTable, pMonoField, pBuffer);
            }

        }
    }


    #endregion



}