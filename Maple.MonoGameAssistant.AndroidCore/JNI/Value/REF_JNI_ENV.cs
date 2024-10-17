using Maple.MonoGameAssistant.AndroidCore.Extension;
using Maple.MonoGameAssistant.AndroidCore.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using Maple.MonoGameAssistant.AndroidNdk.Helper;
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
{

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_JNI_ENV
    {
        readonly PTR_JNI_NATIVE_INTERFACE functions;

        public ref REF_JNI_NATIVE_INTERFACE Functions => ref functions.AsRef();

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct PTR_JNI_ENV(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PTR_JNI_ENV(nint val) => new(val);
        public static implicit operator nint(PTR_JNI_ENV val) => val._ptr;
        public static implicit operator bool(PTR_JNI_ENV val) => val.IsNullPtr();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;
        public ref REF_JNI_ENV Env => ref _ptr.RefStruct<REF_JNI_ENV>();
        public ref REF_JNI_NATIVE_INTERFACE Functions => ref Env.Functions;

        public bool TryGetEnv(out PTR_JAVA_VM javaVM)
            => Functions.Func_GetJavaVM.Invoke(this, out javaVM) == JRESULT.Ok;

        public JGLOBAL NewGlobal(JOBJECT obj)
        {
            return Functions.Func_NewGlobalRef.Invoke(this, obj);
        }
        public void DeleteGlobal(JGLOBAL obj)
        {
            Functions.Func_DeleteGlobalRef.Invoke(this, obj);
        }
        public void DeleteLocal(JOBJECT obj)
        {
            Functions.Func_DeleteLocalRef.Invoke(this, obj);
        }


        public JMETHODID GetStaticMethodId(JCLASS classObj, string methodName, string methodDesc)
        {

            using var ref_name = methodName.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            using var ref_desc = methodDesc.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));

            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    return Functions.Func_GetStaticMethodID.Invoke(this, classObj, pName, pDesc);
                }
            }

        }
        public JMETHODID GetMethodId(JCLASS classObj, string methodName, string methodDesc)
        {

            using var ref_name = methodName.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            using var ref_desc = methodDesc.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));

            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    return Functions.Func_GetMethodID.Invoke(this, classObj, pName, pDesc);
                }
            }

        }

        public void CallStaticVoidMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
        {
            ref var ref_args = ref MemoryMarshal.GetArrayDataReference(args);
            fixed (void* pArgs = &ref_args)
            {
                Functions.Func_CallStaticVoidMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public void CallStaticObjectMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
        {
            ref var ref_args = ref MemoryMarshal.GetArrayDataReference(args);
            fixed (void* pArgs = &ref_args)
            {
                Functions.Func_CallStaticObjectMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }

        public bool TryFindClass(string className, out JCLASS classObj)
        {
            Unsafe.SkipInit(out classObj);
            using var ref_Content = className.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                classObj = Functions.Func_FindClass.Invoke(this, pContent);
                return classObj.IsNullPtr();
            }
        }
        public bool RegisterNative(JCLASS classObj, in REF_JNI_NATIVE_METHOD method)
        {
            ref var ref_method = ref Unsafe.AsRef(in method);
            fixed (void* pMethods = &ref_method)
            {
                return Functions.Func_RegisterNatives.Invoke(this, classObj, pMethods, 1)
                    == JRESULT.Ok;
            }
        }
        public bool RegisterNative(JCLASS classObj, JniNativeMethodDTO method)
        {
            using var ref_Name = method.Name.AsUnmanaged(Encoding.UTF8, default);
            using var ref_Signature = method.Signature.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_Name.GetPinnableReference())
            {
                fixed (void* pSignature = &ref_Signature.GetPinnableReference())
                {
                    return RegisterNative(classObj, new REF_JNI_NATIVE_METHOD() { Name = pName, Signature = pSignature, Pointer = method.Pointer });
                }
            }
        }
        public bool RegisterNatives(JCLASS classObj, params ReadOnlySpan<JniNativeMethodDTO> methods)
        {
            var ok = true;
            foreach (var method in methods)
            {
                ok &= RegisterNative(classObj, method);
            }
            return ok;
        }















        public JTHROWABLE ExceptionOccurred()
            => Functions.Func_ExceptionOccurred.Invoke(this);
        public void ExceptionDescribe()
            => Functions.Func_ExceptionDescribe.Invoke(this);
        public void ExceptionClear()
            => Functions.Func_ExceptionClear.Invoke(this);
        public bool ExceptionCheck()
            => Functions.Func_ExceptionCheck.Invoke(this);

    }



}
