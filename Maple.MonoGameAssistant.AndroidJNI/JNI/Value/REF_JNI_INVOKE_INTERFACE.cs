using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_DestroyJavaVM(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, JRESULT>)ptr;
        public JRESULT Invoke(PTR_JAVA_VM javaVM) => _ptr(javaVM);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_AttachCurrentThread(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, in REF_JAVA_VM_ATTACH_ARGS, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, in REF_JAVA_VM_ATTACH_ARGS, JRESULT>)ptr;

        public JRESULT Invoke(PTR_JAVA_VM javaVM, out PTR_JNI_ENV pJniEnv, in REF_JAVA_VM_ATTACH_ARGS args)
            => _ptr(javaVM, out pJniEnv, in args);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_DetachCurrentThread(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, JRESULT>)ptr;

        public JRESULT Invoke(PTR_JAVA_VM javaVM) => _ptr(javaVM);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_GetEnv(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, JINT, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, JINT, JRESULT>)ptr;
        public JRESULT Invoke(PTR_JAVA_VM javaVM, out PTR_JNI_ENV jniEnv, JINT ver) => _ptr(javaVM, out jniEnv, ver);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_AttachCurrentThreadAsDaemon(nint ptr)
    {
        [MarshalAs(UnmanagedType.FunctionPtr)]
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, in REF_JAVA_VM_ATTACH_ARGS, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JAVA_VM, out PTR_JNI_ENV, in REF_JAVA_VM_ATTACH_ARGS, JRESULT>)ptr;
        public JRESULT Invoke(PTR_JAVA_VM javaVM, out PTR_JNI_ENV jniEnv, in REF_JAVA_VM_ATTACH_ARGS args) => _ptr(javaVM, out jniEnv, in args);
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_JNI_INVOKE_INTERFACE
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint reserved0;

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint reserved1;

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint reserved2;


        /// <summary>
        ///         //    jint(*DestroyJavaVM)(JavaVM*);
        /// </summary>
        internal readonly Ptr_Func_DestroyJavaVM Func_DestroyJavaVM;

        /// <summary>
        ///         //jint(*AttachCurrentThread)(JavaVM*, JNIEnv**, void*);
        /// </summary>
        internal readonly Ptr_Func_AttachCurrentThread Func_AttachCurrentThread;

        /// <summary>
        ///         //jint(*DetachCurrentThread)(JavaVM*);
        /// </summary>
        internal readonly Ptr_Func_DetachCurrentThread Func_DetachCurrentThread;


        /// <summary>
        ///         //jint(*GetEnv)(JavaVM*, void**, jint);
        /// </summary>
        internal readonly Ptr_Func_GetEnv Func_GetEnv;


        /// <summary>
        ///         //jint(*AttachCurrentThreadAsDaemon)(JavaVM*, JNIEnv**, void*);
        /// </summary>
        internal readonly Ptr_Func_AttachCurrentThreadAsDaemon Func_AttachCurrentThreadAsDaemon;

    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PTR_JNI_INVOKE_INTERFACE(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public nint Ptr => _ptr;

        public static implicit operator PTR_JNI_INVOKE_INTERFACE(nint val) => new(val);
        public static implicit operator nint(PTR_JNI_INVOKE_INTERFACE val) => val._ptr;
        public static implicit operator bool(PTR_JNI_INVOKE_INTERFACE val) => val.IsNotNullPtr();


        public ref REF_JNI_INVOKE_INTERFACE AsRef() => ref _ptr.RefStruct<REF_JNI_INVOKE_INTERFACE>();
    }
}
