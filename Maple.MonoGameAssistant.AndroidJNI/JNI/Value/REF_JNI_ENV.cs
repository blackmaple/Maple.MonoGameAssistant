using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidModel;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.Common;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Value
{

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_JNI_ENV
    {
        readonly PTR_JNI_NATIVE_INTERFACE functions;

        public ref REF_JNI_NATIVE_INTERFACE Functions => ref functions.AsRef();

    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe readonly struct PTR_JNI_ENV(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public nint Ptr => _ptr;


        public static implicit operator PTR_JNI_ENV(nint val) => new(val);
        public static implicit operator nint(PTR_JNI_ENV val) => val._ptr;
        public static implicit operator bool(PTR_JNI_ENV val) => val.IsNotNullPtr();


        public ref REF_JNI_ENV Env => ref _ptr.RefStruct<REF_JNI_ENV>();
        public ref REF_JNI_NATIVE_INTERFACE Functions => ref Env.Functions;


        public bool TryGetEnv(out PTR_JAVA_VM javaVM)
            => Functions.Func_GetJavaVM.Invoke(this, out javaVM) == JRESULT.Ok;


        public JWEAK NewWeakGlobalRef(JOBJECT obj)
        {
            var jRef = Env.Functions.Func_NewWeakGlobalRef.Invoke(this, obj);
            return ExceptionCheck() ? AndroidJNIException.Throw<JWEAK>() : jRef;
        }
        public void DeleteWeakGlobalRef(JWEAK obj)
            => Env.Functions.Func_DeleteWeakGlobalRef.Invoke(this, obj);

        public JGLOBAL NewGlobalRef(JOBJECT obj)
        {
            var jRef = Env.Functions.Func_NewGlobalRef.Invoke(this, obj);
            return ExceptionCheck() ? AndroidJNIException.Throw<JGLOBAL>() : jRef;
        }
        public void DeleteGlobalRef(JGLOBAL obj)
            => Functions.Func_DeleteGlobalRef.Invoke(this, obj);

        public JOBJECT NewLocalRef(JOBJECT obj)
        {
            var jRef = Env.Functions.Func_NewLocalRef.Invoke(this, obj);
            return ExceptionCheck() ? AndroidJNIException.Throw<JOBJECT>() : jRef;
        }
        public void DeleteLocalRef(JOBJECT obj)
            => Functions.Func_DeleteLocalRef.Invoke(this, obj);

        public JSTRING CreateStringUnicode(ReadOnlySpan<char> content)
        {

            ref var ref_content = ref MemoryMarshal.GetReference(content);
            fixed (char* pContent = &ref_content)
            {
                var jStr = Functions.Func_NewString.Invoke(this, pContent, content.Length);
                return ExceptionCheck() ? AndroidJNIException.Throw<JSTRING>() : jStr;

            }
        }

        public string? ConvertStringUnicode(JSTRING str)
        {
            var len = Functions.Func_GetStringLength.Invoke(this, str);
            var pstring = Functions.Func_GetStringChars.Invoke(this, str);
            var content = pstring.ToString(len);
            Functions.Func_ReleaseStringChars.Invoke(this, str, pstring);
            return content;
        }
        public PStringUnicode GetStringChars(JSTRING str)
        {
            return Functions.Func_GetStringChars.Invoke(this, str);
        }
        public void ReleaseStringChars(JSTRING str, PStringUnicode pString)
        {
            Functions.Func_ReleaseStringChars.Invoke(this, str, pString);
        }


        public JCLASS GetObjectClass(JOBJECT instance)
        {
            return this.Functions.Func_GetObjectClass.Invoke(this, instance);
        }

        public bool TryFindClass(ReadOnlySpan<char> className, out JCLASS classObj)
        {
            Unsafe.SkipInit(out classObj);
            using var ref_Content = className.AsUnmanaged(Encoding.UTF8, (stackalloc byte[MapleStringUnmanaged_Ref.MaxSize]));
            fixed (void* pContent = &ref_Content.GetPinnableReference())
            {
                classObj = Functions.Func_FindClass.Invoke(this, pContent);
                return classObj.IsNotNullPtr();
            }
        }
        public bool TryFindClass(ReadOnlySpan<byte> className, out JCLASS classObj)
        {
            Unsafe.SkipInit(out classObj);
            ref var ref_Content = ref MemoryMarshal.GetReference(className);
            fixed (void* pContent = &ref_Content)
            {
                classObj = Functions.Func_FindClass.Invoke(this, pContent);
                return classObj.IsNotNullPtr();
            }
        }
        public JCLASS FindClass(ReadOnlySpan<char> className)
        {
            if (this.TryFindClass(className, out var classObj))
            {
                return classObj;
            }
            return AndroidJNIException.Throw<JCLASS>();
        }
        public JCLASS FindClass(ReadOnlySpan<byte> className)
        {
            if (this.TryFindClass(className, out var classObj))
            {
                return classObj;
            }
            return AndroidJNIException.Throw<JCLASS>();
        }

        public bool TryGetStaticMethodId(JCLASS classObj, ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc, out JMETHODID methodId)
        {
            ref var ref_name = ref MemoryMarshal.GetReference(methodName);
            ref var ref_desc = ref MemoryMarshal.GetReference(methodDesc);
            fixed (void* pName = &ref_name)
            {
                fixed (void* pDesc = &ref_desc)
                {
                    methodId = Functions.Func_GetStaticMethodID.Invoke(this, classObj, pName, pDesc);
                    return methodId;
                }
            }
        }
        public bool TryGetStaticMethodId(JCLASS classObj, ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc, out JMETHODID methodId)
        {
            using var ref_name = methodName.AsUnmanaged(Encoding.UTF8, default);
            using var ref_desc = methodDesc.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    methodId = Functions.Func_GetStaticMethodID.Invoke(this, classObj, pName, pDesc);
                    return methodId;
                }
            }

        }
        public JMETHODID GetStaticMethodId(JCLASS classObj, ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc)
        {
            if (TryGetStaticMethodId(classObj, methodName, methodDesc, out var methodId))
            {
                return methodId;
            }
            return AndroidJNIException.Throw<JMETHODID>();

        }
        public JMETHODID GetStaticMethodId(JCLASS classObj, ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc)
        {
            if (TryGetStaticMethodId(classObj, methodName, methodDesc, out var methodId))
            {
                return methodId;
            }
            return AndroidJNIException.Throw<JMETHODID>();

        }

        public bool TryGetMethodId(JCLASS classObj, ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc, out JMETHODID methodId)
        {
            ref var ref_name = ref MemoryMarshal.GetReference(methodName);
            ref var ref_desc = ref MemoryMarshal.GetReference(methodDesc);
            fixed (void* pName = &ref_name)
            {
                fixed (void* pDesc = &ref_desc)
                {
                    methodId = Functions.Func_GetMethodID.Invoke(this, classObj, pName, pDesc);
                    return methodId;
                }
            }
        }
        public bool TryGetMethodId(JCLASS classObj, ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc, out JMETHODID methodId)
        {
            using var ref_name = methodName.AsUnmanaged(Encoding.UTF8, default);
            using var ref_desc = methodDesc.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    methodId = Functions.Func_GetMethodID.Invoke(this, classObj, pName, pDesc);
                    return methodId;
                }
            }

        }
        public JMETHODID GetMethodId(JCLASS classObj, ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc)
        {
            if (TryGetMethodId(classObj, methodName, methodDesc, out var methodId))
            {
                return methodId;
            }
            return AndroidJNIException.Throw<JMETHODID>();
        }
        public JMETHODID GetMethodId(JCLASS classObj, ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc)
        {
            if (TryGetMethodId(classObj, methodName, methodDesc, out var methodId))
            {
                return methodId;
            }
            return AndroidJNIException.Throw<JMETHODID>();
        }

        public void CallStaticVoidMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                Functions.Func_CallStaticVoidMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JOBJECT CallStaticObjectMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticObjectMethodA.Invoke(this, classObj, methodId, pArgs);

            }
        }
        public JBOOLEAN CallStaticBooleanMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticBooleanMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JBYTE CallStaticByteMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticByteMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JCHAR CallStaticCharMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticCharMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JSHORT CallStaticShortMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticShortMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JINT CallStaticIntMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticIntMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JFLOAT CallStaticFloatMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticFloatMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }
        public JDOUBLE CallStaticDoubleMethod(JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallStaticDoubleMethodA.Invoke(this, classObj, methodId, pArgs);
            }
        }


        public void CallVoidMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                Functions.Func_CallVoidMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JOBJECT CallObjectMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallObjectMethodA.Invoke(this, instance, methodId, pArgs);

            }
        }
        public JBOOLEAN CallBooleanMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallBooleanMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JBYTE CallByteMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallByteMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JCHAR CallCharMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallCharMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JSHORT CallShortMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallShortMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JINT CallIntMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallIntMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JFLOAT CallFloatMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallFloatMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }
        public JDOUBLE CallDoubleMethod(JOBJECT instance, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallDoubleMethodA.Invoke(this, instance, methodId, pArgs);
            }
        }


        public void CallNonVirtualVoidMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                Functions.Func_CallNonVirtualVoidMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JOBJECT CallNonVirtualObjectMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualObjectMethodA.Invoke(this, instance, classObj, methodId, pArgs);

            }
        }
        public JBOOLEAN CallNonVirtualBooleanMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualBooleanMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JBYTE CallNonVirtualByteMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualByteMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JCHAR CallNonVirtualCharMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualCharMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JSHORT CallNonVirtualShortMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualShortMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JINT CallNonVirtualIntMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualIntMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JFLOAT CallNonVirtualFloatMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualFloatMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }
        public JDOUBLE CallNonVirtualDoubleMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params ReadOnlySpan<JVALUE> args)
        {
            ref var ref_args = ref MemoryMarshal.GetReference(args);
            fixed (void* pArgs = &ref_args)
            {
                return Functions.Func_CallNonVirtualDoubleMethodA.Invoke(this, instance, classObj, methodId, pArgs);
            }
        }


        public void CallStaticVoidMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticVoidMethod(classObj, methodId, args.AsSpan());
        public JOBJECT CallStaticObjectMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticObjectMethod(classObj, methodId, args.AsSpan());
        public JBOOLEAN CallStaticBooleanMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticBooleanMethod(classObj, methodId, args.AsSpan());
        public JBYTE CallStaticByteMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticByteMethod(classObj, methodId, args.AsSpan());
        public JCHAR CallStaticCharMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticCharMethod(classObj, methodId, args.AsSpan());
        public JSHORT CallStaticShortMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticShortMethod(classObj, methodId, args.AsSpan());
        public JINT CallStaticIntMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticIntMethod(classObj, methodId, args.AsSpan());
        public JFLOAT CallStaticFloatMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticFloatMethod(classObj, methodId, args.AsSpan());
        public JDOUBLE CallStaticDoubleMethod(JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallStaticDoubleMethod(classObj, methodId, args.AsSpan());




        public void CallVoidMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallVoidMethod(instance, methodId, args.AsSpan());
        public JOBJECT CallObjectMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallObjectMethod(instance, methodId, args.AsSpan());
        public JBOOLEAN CallBooleanMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallBooleanMethod(instance, methodId, args.AsSpan());
        public JBYTE CallByteMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallByteMethod(instance, methodId, args.AsSpan());
        public JCHAR CallCharMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallCharMethod(instance, methodId, args.AsSpan());
        public JSHORT CallShortMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallShortMethod(instance, methodId, args.AsSpan());
        public JINT CallIntMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallIntMethod(instance, methodId, args.AsSpan());
        public JFLOAT CallFloatMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallFloatMethod(instance, methodId, args.AsSpan());
        public JDOUBLE CallDoubleMethod(JOBJECT instance, JMETHODID methodId, params JVALUE[] args)
            => CallDoubleMethod(instance, methodId, args.AsSpan());




        public void CallNonVirtualVoidMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualVoidMethod(instance, classObj, methodId, args.AsSpan());
        public JOBJECT CallNonVirtualObjectMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualObjectMethod(instance, classObj, methodId, args.AsSpan());
        public JBOOLEAN CallNonVirtualBooleanMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualBooleanMethod(instance, classObj, methodId, args.AsSpan());
        public JBYTE CallNonVirtualByteMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualByteMethod(instance, classObj, methodId, args.AsSpan());
        public JCHAR CallNonVirtualCharMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualCharMethod(instance, classObj, methodId, args.AsSpan());
        public JSHORT CallNonVirtualShortMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualShortMethod(instance, classObj, methodId, args.AsSpan());
        public JINT CallNonVirtualIntMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualIntMethod(instance, classObj, methodId, args.AsSpan());
        public JFLOAT CallNonVirtualFloatMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualFloatMethod(instance, classObj, methodId, args.AsSpan());
        public JDOUBLE CallNonVirtualDoubleMethod(JOBJECT instance, JCLASS classObj, JMETHODID methodId, params JVALUE[] args)
            => CallNonVirtualDoubleMethod(instance, classObj, methodId, args.AsSpan());






        public bool TryGetFieldId(JCLASS classObj, ReadOnlySpan<byte> fieldName, ReadOnlySpan<byte> fieldDesc, out JFIELDID fieldId)
        {
            ref var ref_name = ref MemoryMarshal.GetReference(fieldName);
            ref var ref_desc = ref MemoryMarshal.GetReference(fieldDesc);
            fixed (void* pName = &ref_name)
            {
                fixed (void* pDesc = &ref_desc)
                {
                    fieldId = Functions.Func_GetFieldID.Invoke(this, classObj, pName, pDesc);
                    return fieldId;
                }
            }
        }
        public bool TryGetFieldId(JCLASS classObj, ReadOnlySpan<char> fieldName, ReadOnlySpan<char> fieldDesc, out JFIELDID fieldId)
        {
            using var ref_name = fieldName.AsUnmanaged(Encoding.UTF8, default);
            using var ref_desc = fieldDesc.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    fieldId = Functions.Func_GetFieldID.Invoke(this, classObj, pName, pDesc);
                    return fieldId;
                }
            }

        }
        public JFIELDID GetFieldId(JCLASS classObj, ReadOnlySpan<byte> fieldName, ReadOnlySpan<byte> fieldDesc)
        {
            if (TryGetFieldId(classObj, fieldName, fieldDesc, out var fieldId))
            {
                return fieldId;
            }
            return AndroidJNIException.Throw<JFIELDID>();

        }
        public JFIELDID GetFieldId(JCLASS classObj, ReadOnlySpan<char> fieldName, ReadOnlySpan<char> fieldDesc)
        {
            if (TryGetFieldId(classObj, fieldName, fieldDesc, out var fieldId))
            {
                return fieldId;
            }
            return AndroidJNIException.Throw<JFIELDID>();

        }


        public bool TryGetStaticFieldId(JCLASS classObj, ReadOnlySpan<byte> fieldName, ReadOnlySpan<byte> fieldDesc, out JFIELDID fieldId)
        {
            ref var ref_name = ref MemoryMarshal.GetReference(fieldName);
            ref var ref_desc = ref MemoryMarshal.GetReference(fieldDesc);
            fixed (void* pName = &ref_name)
            {
                fixed (void* pDesc = &ref_desc)
                {
                    fieldId = Functions.Func_GetStaticFieldID.Invoke(this, classObj, pName, pDesc);
                    return fieldId;
                }
            }
        }
        public bool TryGetStaticFieldId(JCLASS classObj, ReadOnlySpan<char> fieldName, ReadOnlySpan<char> fieldDesc, out JFIELDID fieldId)
        {
            using var ref_name = fieldName.AsUnmanaged(Encoding.UTF8, default);
            using var ref_desc = fieldDesc.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_desc.GetPinnableReference())
                {
                    fieldId = Functions.Func_GetStaticFieldID.Invoke(this, classObj, pName, pDesc);
                    return fieldId;
                }
            }

        }
        public JFIELDID GetStaticFieldId(JCLASS classObj, ReadOnlySpan<byte> fieldName, ReadOnlySpan<byte> fieldDesc)
        {
            if (TryGetStaticFieldId(classObj, fieldName, fieldDesc, out var fieldId))
            {
                return fieldId;
            }
            return AndroidJNIException.Throw<JFIELDID>();

        }
        public JFIELDID GetStaticFieldId(JCLASS classObj, ReadOnlySpan<char> fieldName, ReadOnlySpan<char> fieldDesc)
        {
            if (TryGetStaticFieldId(classObj, fieldName, fieldDesc, out var fieldId))
            {
                return fieldId;
            }
            return AndroidJNIException.Throw<JFIELDID>();

        }

        public JOBJECT GetObjectField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetObjectField.Invoke(this, instance, fieldId);
        }
        public JBOOLEAN GetBooleanField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetBooleanField.Invoke(this, instance, fieldId);
        }
        public JBYTE GetByteField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetByteField.Invoke(this, instance, fieldId);
        }
        public JCHAR GetCharField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetCharField.Invoke(this, instance, fieldId);
        }
        public JSHORT GetShortField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetShortField.Invoke(this, instance, fieldId);
        }
        public JINT GetIntField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetIntField.Invoke(this, instance, fieldId);
        }
        public JLONG GetLongField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetLongField.Invoke(this, instance, fieldId);
        }
        public JFLOAT GetFloatField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetFloatField.Invoke(this, instance, fieldId);
        }
        public JDOUBLE GetDoubleField(JOBJECT instance, JFIELDID fieldId)
        {
            return Functions.Func_GetDoubleField.Invoke(this, instance, fieldId);
        }

        public void SetObjectField(JOBJECT instance, JFIELDID fieldId, JOBJECT obj)
        {
            Functions.Func_SetObjectField.Invoke(this, instance, fieldId, obj);
        }
        public void SetBooleanField(JOBJECT instance, JFIELDID fieldId, JBOOLEAN obj)
        {
            Functions.Func_SetBooleanField.Invoke(this, instance, fieldId, obj);
        }
        public void SetByteField(JOBJECT instance, JFIELDID fieldId, JBYTE obj)
        {
            Functions.Func_SetByteField.Invoke(this, instance, fieldId, obj);
        }
        public void SetCharField(JOBJECT instance, JFIELDID fieldId, JCHAR obj)
        {
            Functions.Func_SetCharField.Invoke(this, instance, fieldId, obj);
        }
        public void SetShortField(JOBJECT instance, JFIELDID fieldId, JSHORT obj)
        {
            Functions.Func_SetShortField.Invoke(this, instance, fieldId, obj);
        }
        public void SetIntField(JOBJECT instance, JFIELDID fieldId, JINT obj)
        {
            Functions.Func_SetIntField.Invoke(this, instance, fieldId, obj);
        }
        public void SetLongField(JOBJECT instance, JFIELDID fieldId, JLONG obj)
        {
            Functions.Func_SetLongField.Invoke(this, instance, fieldId, obj);
        }
        public void SetFloatField(JOBJECT instance, JFIELDID fieldId, JFLOAT obj)
        {
            Functions.Func_SetFloatField.Invoke(this, instance, fieldId, obj);
        }
        public void SetDoubleField(JOBJECT instance, JFIELDID fieldId, JDOUBLE obj)
        {
            Functions.Func_SetDoubleField.Invoke(this, instance, fieldId, obj);
        }


        public JOBJECT GetStaticObjectField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticObjectField.Invoke(this, classObj, fieldId);
        }
        public JBOOLEAN GetStaticBooleanField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticBooleanField.Invoke(this, classObj, fieldId);
        }
        public JBYTE GetStaticByteField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticByteField.Invoke(this, classObj, fieldId);
        }
        public JCHAR GetStaticCharField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticCharField.Invoke(this, classObj, fieldId);
        }
        public JSHORT GetStaticShortField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticShortField.Invoke(this, classObj, fieldId);
        }
        public JINT GetStaticIntField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticIntField.Invoke(this, classObj, fieldId);
        }
        public JLONG GetStaticLongField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticLongField.Invoke(this, classObj, fieldId);
        }
        public JFLOAT GetStaticFloatField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticFloatField.Invoke(this, classObj, fieldId);
        }
        public JDOUBLE GetStaticDoubleField(JCLASS classObj, JFIELDID fieldId)
        {
            return Functions.Func_GetStaticDoubleField.Invoke(this, classObj, fieldId);
        }


        public void SetStaticObjectField(JCLASS classObj, JFIELDID fieldId, JOBJECT obj)
        {
            Functions.Func_SetStaticObjectField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticBooleanField(JCLASS classObj, JFIELDID fieldId, JBOOLEAN obj)
        {
            Functions.Func_SetStaticBooleanField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticByteField(JCLASS classObj, JFIELDID fieldId, JBYTE obj)
        {
            Functions.Func_SetStaticByteField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticCharField(JCLASS classObj, JFIELDID fieldId, JCHAR obj)
        {
            Functions.Func_SetStaticCharField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticShortField(JCLASS classObj, JFIELDID fieldId, JSHORT obj)
        {
            Functions.Func_SetStaticShortField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticIntField(JCLASS classObj, JFIELDID fieldId, JINT obj)
        {
            Functions.Func_SetStaticIntField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticLongField(JCLASS classObj, JFIELDID fieldId, JLONG obj)
        {
            Functions.Func_SetStaticLongField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticFloatField(JCLASS classObj, JFIELDID fieldId, JFLOAT obj)
        {
            Functions.Func_SetStaticFloatField.Invoke(this, classObj, fieldId, obj);
        }
        public void SetStaticDoubleField(JCLASS classObj, JFIELDID fieldId, JDOUBLE obj)
        {
            Functions.Func_SetStaticDoubleField.Invoke(this, classObj, fieldId, obj);
        }

        public JOBJECT AllocObject(JCLASS classObj)
        {
            var jObject = this.Functions.Func_AllocObject.Invoke(this, classObj);
            return jObject.IsNotNullPtr() ? jObject : AndroidJNIException.Throw<JOBJECT>();
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
        public bool RegisterNative(JCLASS classObj, ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc, nint methodPointer)
        {
            using var ref_Name = methodName.AsUnmanaged(Encoding.UTF8, default);
            using var ref_Desc = methodDesc.AsUnmanaged(Encoding.UTF8, default);
            fixed (void* pName = &ref_Name.GetPinnableReference())
            {
                fixed (void* pDesc = &ref_Desc.GetPinnableReference())
                {
                    return RegisterNative(classObj, new REF_JNI_NATIVE_METHOD() { Name = pName, Signature = pDesc, Pointer = methodPointer });
                }
            }
        }
        public bool RegisterNative(JCLASS classObj, ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc, nint methodPointer)
        {
            ref var ref_Name = ref MemoryMarshal.GetReference(methodName);
            ref var ref_Desc = ref MemoryMarshal.GetReference(methodDesc);
            fixed (void* pName = &ref_Name)
            {
                fixed (void* pDesc = &ref_Desc)
                {
                    return RegisterNative(classObj, new REF_JNI_NATIVE_METHOD() { Name = pName, Signature = pDesc, Pointer = methodPointer });
                }
            }
        }

        public bool ExceptionCheck()
        {
            if (Functions.Func_ExceptionCheck.Invoke(this))
            {
                Functions.Func_ExceptionDescribe.Invoke(this);
                Functions.Func_ExceptionClear.Invoke(this);
                return true;
            }
            return false;
        }



    }



}
