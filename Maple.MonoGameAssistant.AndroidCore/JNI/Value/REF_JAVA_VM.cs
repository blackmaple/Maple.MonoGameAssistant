using Maple.MonoGameAssistant.AndroidCore.Extension;
using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_JAVA_VM
    {
        readonly PTR_JNI_INVOKE_INTERFACE functions;

        public ref REF_JNI_INVOKE_INTERFACE Functions => ref functions.AsRef();
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PTR_JAVA_VM(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PTR_JAVA_VM(nint val) => new(val);
        public static implicit operator nint(PTR_JAVA_VM val) => val._ptr;
        public static implicit operator bool(PTR_JAVA_VM val) => val.IsNullPtr();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;

        public ref REF_JAVA_VM VirtualMachine => ref _ptr.RefStruct<REF_JAVA_VM>();

        public bool DestroyJavaVM()
            => VirtualMachine.Functions.Func_DestroyJavaVM.Invoke(this) == JRESULT.Ok;
        public bool AttachCurrentThread(out PTR_JNI_ENV jniEnv, in REF_JAVA_VM_ATTACH_ARGS args)
            => VirtualMachine.Functions.Func_AttachCurrentThread.Invoke(this, out jniEnv, in args) == JRESULT.Ok;
        public unsafe bool AttachCurrentThread(out PTR_JNI_ENV jniEnv, int ver, [CallerMemberName] string threadName = nameof(AttachCurrentThread))
        {
            using var ref_Content = threadName.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                return AttachCurrentThread(out jniEnv, new REF_JAVA_VM_ATTACH_ARGS()
                {
                    Version = ver,
                    Name = pContent,
                    Group = nint.Zero
                });
            }
        }


        public bool DetachCurrentThread()
            => VirtualMachine.Functions.Func_DetachCurrentThread.Invoke(this) == JRESULT.Ok;
        public bool GetEnv(out PTR_JNI_ENV jniEnv, JINT ver)
            => VirtualMachine.Functions.Func_GetEnv.Invoke(this, out jniEnv, ver) == JRESULT.Ok;

        public bool AttachCurrentThreadAsDaemon(out PTR_JNI_ENV jniEnv, in REF_JAVA_VM_ATTACH_ARGS args)
            => VirtualMachine.Functions.Func_AttachCurrentThreadAsDaemon.Invoke(this, out jniEnv, in args) == JRESULT.Ok;
        public unsafe bool AttachCurrentThreadAsDaemon(out PTR_JNI_ENV jniEnv, int ver, [CallerMemberName] string daemonName = nameof(AttachCurrentThreadAsDaemon))
        {
            using var ref_Content = daemonName.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                return AttachCurrentThreadAsDaemon(out jniEnv, new REF_JAVA_VM_ATTACH_ARGS()
                {
                    Version = ver,
                    Name = pContent,
                    Group = nint.Zero
                });
            }
        }

    }
}
