using Maple.MonoGameAssistant.AndroidCore.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference.Array;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Value
{
    //void* reserved0;
    //void* reserved1;
    //void* reserved2;
    //void* reserved3;

    //jint(*GetVersion)(JNIEnv*);

    //jclass(*DefineClass)(JNIEnv*, const char*, jobject, const jbyte*,
    //                    jsize);


    internal readonly unsafe struct Ptr_Func_FindClass(nint ptr)
    {
        /// <summary>
        ///     //jclass(*FindClass)(JNIEnv*, const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JCLASS> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JCLASS>)ptr;

        public JCLASS Invoke(PTR_JNI_ENV @this, PStringUTF8 className)
            => _ptr(@this, className);
    }



    //jmethodID(*FromReflectedMethod)(JNIEnv*, jobject);
    //jfieldID(*FromReflectedField)(JNIEnv*, jobject);
    ///* spec doesn't show jboolean parameter */
    //jobject(*ToReflectedMethod)(JNIEnv*, jclass, jmethodID, jboolean);

    //jclass(*GetSuperclass)(JNIEnv*, jclass);
    //jboolean(*IsAssignableFrom)(JNIEnv*, jclass, jclass);

    ///* spec doesn't show jboolean parameter */
    //jobject(*ToReflectedField)(JNIEnv*, jclass, jfieldID, jboolean);

    //jint(*Throw)(JNIEnv*, jthrowable);
    //jint(*ThrowNew)(JNIEnv*, jclass, const char*);

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_ExceptionOccurred(nint ptr)
    {
        /// <summary>
        ///               //jthrowable(*ExceptionOccurred)(JNIEnv*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JTHROWABLE> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JTHROWABLE>)ptr;

        public JTHROWABLE Invoke(PTR_JNI_ENV jniEnv)
            => _ptr(jniEnv);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_ExceptionDescribe(nint ptr)
    {
        /// <summary>
        ///           //void (* ExceptionDescribe) (JNIEnv*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, void>)ptr;

        public void Invoke(PTR_JNI_ENV jniEnv)
            => _ptr(jniEnv);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_ExceptionClear(nint ptr)
    {
        /// <summary>
        ///              //void (* ExceptionClear) (JNIEnv*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, void>)ptr;

        public void Invoke(PTR_JNI_ENV jniEnv)
            => _ptr(jniEnv);
    }


    //void (* FatalError) (JNIEnv*, const char*);

    //jint(*PushLocalFrame)(JNIEnv*, jint);
    //jobject(*PopLocalFrame)(JNIEnv*, jobject);

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewGlobalRef(nint ptr)
    {
        /// <summary>
        ///     //jobject(*NewGlobalRef)(JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JGLOBAL> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JGLOBAL>)ptr;
        public JGLOBAL Invoke(PTR_JNI_ENV @this, JOBJECT obj)
            => _ptr(@this, obj);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_DeleteGlobalRef(nint ptr)
    {
        /// <summary>
        ///     //void (* DeleteGlobalRef) (JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JGLOBAL, void> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JGLOBAL, void>)ptr;
        public void Invoke(PTR_JNI_ENV @this, JGLOBAL obj)
            => _ptr(@this, obj);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_DeleteLocalRef(nint ptr)
    {
        /// <summary>
        ///     //void (* DeleteLocalRef) (JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, void> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, void>)ptr;
        public void Invoke(PTR_JNI_ENV @this, JOBJECT obj)
            => _ptr(@this, obj);
    }



    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_IsSameObject(nint ptr)
    {
        /// <summary>
        ///        //jboolean(*IsSameObject)(JNIEnv*, jobject, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JOBJECT, JBOOLEAN> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JOBJECT, JBOOLEAN>)ptr;
        public JBOOLEAN Invoke(PTR_JNI_ENV @this, JOBJECT obj1, JOBJECT obj2)
            => _ptr(@this, obj1, obj2);
    }



    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewLocalRef(nint ptr)
    {
        /// <summary>
        ///     //jobject(*NewLocalRef)(JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JOBJECT> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JOBJECT>)ptr;
        public JOBJECT Invoke(PTR_JNI_ENV @this, JOBJECT obj)
            => _ptr(@this, obj);
    }


    //jint(*EnsureLocalCapacity)(JNIEnv*, jint);

    //jobject(*AllocObject)(JNIEnv*, jclass);
    //jobject(*NewObject)(JNIEnv*, jclass, jmethodID, ...);
    //jobject(*NewObjectV)(JNIEnv*, jclass, jmethodID, va_list);
    //jobject(*NewObjectA)(JNIEnv*, jclass, jmethodID, const jvalue*);

    //jclass(*GetObjectClass)(JNIEnv*, jobject);
    //jboolean(*IsInstanceOf)(JNIEnv*, jobject, jclass);

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetMethodID(nint ptr)
    {
        /// <summary>
        ///     //jmethodID(*GetMethodID)(JNIEnv*, jclass, const char*, const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JMETHODID> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JMETHODID>)ptr;

        public JMETHODID Invoke(PTR_JNI_ENV @this, JCLASS classObj, PStringUTF8 methodName, PStringUTF8 methodDesc)
            => _ptr(@this, classObj, methodName, methodDesc);
    }


    //jobject(*CallObjectMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jobject(*CallObjectMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jobject(*CallObjectMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    readonly unsafe struct Ptr_Func_CallObjectMethodA(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, classObj, method, args);


    }

    //jboolean(*CallBooleanMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jboolean(*CallBooleanMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jboolean(*CallBooleanMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jbyte(*CallByteMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jbyte(*CallByteMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jbyte(*CallByteMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jchar(*CallCharMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jchar(*CallCharMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jchar(*CallCharMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jshort(*CallShortMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jshort(*CallShortMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jshort(*CallShortMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jint(*CallIntMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jint(*CallIntMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jint(*CallIntMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jlong(*CallLongMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jlong(*CallLongMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jlong(*CallLongMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jfloat(*CallFloatMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jfloat(*CallFloatMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jfloat(*CallFloatMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    //jdouble(*CallDoubleMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jdouble(*CallDoubleMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jdouble(*CallDoubleMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);

    //void (* CallVoidMethod) (JNIEnv*, jobject, jmethodID, ...);
    //void (* CallVoidMethodV) (JNIEnv*, jobject, jmethodID, va_list);
    internal readonly unsafe struct Ptr_Func_CallVoidMethodA(nint ptr)
    {
        /// <summary>
        ///         //void (* CallVoidMethodA) (JNIEnv*, jobject, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, classObj, method, args);
    }

    //jobject(*CallNonvirtualObjectMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jobject(*CallNonvirtualObjectMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jobject(*CallNonvirtualObjectMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jboolean(*CallNonvirtualBooleanMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jboolean(*CallNonvirtualBooleanMethodV)(JNIEnv*, jobject, jclass,
    //                     jmethodID, va_list);
    //jboolean(*CallNonvirtualBooleanMethodA)(JNIEnv*, jobject, jclass,
    //                     jmethodID, const jvalue*);
    //jbyte(*CallNonvirtualByteMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jbyte(*CallNonvirtualByteMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jbyte(*CallNonvirtualByteMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jchar(*CallNonvirtualCharMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jchar(*CallNonvirtualCharMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jchar(*CallNonvirtualCharMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jshort(*CallNonvirtualShortMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jshort(*CallNonvirtualShortMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jshort(*CallNonvirtualShortMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jint(*CallNonvirtualIntMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jint(*CallNonvirtualIntMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jint(*CallNonvirtualIntMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jlong(*CallNonvirtualLongMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jlong(*CallNonvirtualLongMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jlong(*CallNonvirtualLongMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jfloat(*CallNonvirtualFloatMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jfloat(*CallNonvirtualFloatMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jfloat(*CallNonvirtualFloatMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //jdouble(*CallNonvirtualDoubleMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jdouble(*CallNonvirtualDoubleMethodV)(JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //jdouble(*CallNonvirtualDoubleMethodA)(JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);
    //void (* CallNonvirtualVoidMethod) (JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //void (* CallNonvirtualVoidMethodV) (JNIEnv*, jobject, jclass,
    //                    jmethodID, va_list);
    //void (* CallNonvirtualVoidMethodA) (JNIEnv*, jobject, jclass,
    //                    jmethodID, const jvalue*);

    //jfieldID(*GetFieldID)(JNIEnv*, jclass, const char*, const char*);

    //jobject(*GetObjectField)(JNIEnv*, jobject, jfieldID);
    //jboolean(*GetBooleanField)(JNIEnv*, jobject, jfieldID);
    //jbyte(*GetByteField)(JNIEnv*, jobject, jfieldID);
    //jchar(*GetCharField)(JNIEnv*, jobject, jfieldID);
    //jshort(*GetShortField)(JNIEnv*, jobject, jfieldID);
    //jint(*GetIntField)(JNIEnv*, jobject, jfieldID);
    //jlong(*GetLongField)(JNIEnv*, jobject, jfieldID);
    //jfloat(*GetFloatField)(JNIEnv*, jobject, jfieldID);
    //jdouble(*GetDoubleField)(JNIEnv*, jobject, jfieldID);

    //void (* SetObjectField) (JNIEnv*, jobject, jfieldID, jobject);
    //void (* SetBooleanField) (JNIEnv*, jobject, jfieldID, jboolean);
    //void (* SetByteField) (JNIEnv*, jobject, jfieldID, jbyte);
    //void (* SetCharField) (JNIEnv*, jobject, jfieldID, jchar);
    //void (* SetShortField) (JNIEnv*, jobject, jfieldID, jshort);
    //void (* SetIntField) (JNIEnv*, jobject, jfieldID, jint);
    //void (* SetLongField) (JNIEnv*, jobject, jfieldID, jlong);
    //void (* SetFloatField) (JNIEnv*, jobject, jfieldID, jfloat);
    //void (* SetDoubleField) (JNIEnv*, jobject, jfieldID, jdouble);


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetStaticMethodID(nint ptr)
    {
        /// <summary>
        ///  //jmethodID(*GetStaticMethodID)(JNIEnv*, jclass, const char*, const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JMETHODID> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JMETHODID>)ptr;

        public JMETHODID Invoke(PTR_JNI_ENV @this, JCLASS classObj, PStringUTF8 methodName, PStringUTF8 methodDesc)
            => _ptr(@this, classObj, methodName, methodDesc);
    }

    //jobject(*CallStaticObjectMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jobject(*CallStaticObjectMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    internal readonly unsafe struct Ptr_Func_CallStaticObjectMethodA(nint ptr)
    {
        /// <summary>
        ///     //jobject(*CallStaticObjectMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, classObj, method, args);
    }

    internal readonly unsafe struct Ptr_Func_CallStaticUnmanagedMethodA<T>(nint ptr)
        where T : unmanaged
    {

        /// <summary>
        ///     //jobject(*CallStaticObjectMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, T> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, T>)ptr;

        public T Invoke(PTR_JNI_ENV @this, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, classObj, method, args);
    }
    //jboolean(*CallStaticBooleanMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jboolean(*CallStaticBooleanMethodV)(JNIEnv*, jclass, jmethodID,
    //                    va_list);
    //jboolean(*CallStaticBooleanMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jbyte(*CallStaticByteMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jbyte(*CallStaticByteMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jbyte(*CallStaticByteMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jchar(*CallStaticCharMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jchar(*CallStaticCharMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jchar(*CallStaticCharMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jshort(*CallStaticShortMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jshort(*CallStaticShortMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jshort(*CallStaticShortMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jint(*CallStaticIntMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jint(*CallStaticIntMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jint(*CallStaticIntMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jlong(*CallStaticLongMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jlong(*CallStaticLongMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jlong(*CallStaticLongMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jfloat(*CallStaticFloatMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jfloat(*CallStaticFloatMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jfloat(*CallStaticFloatMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);
    //jdouble(*CallStaticDoubleMethod)(JNIEnv*, jclass, jmethodID, ...);
    //jdouble(*CallStaticDoubleMethodV)(JNIEnv*, jclass, jmethodID, va_list);
    //jdouble(*CallStaticDoubleMethodA)(JNIEnv*, jclass, jmethodID, const jvalue*);


    //void (* CallStaticVoidMethod) (JNIEnv*, jclass, jmethodID, ...);
    //void (* CallStaticVoidMethodV) (JNIEnv*, jclass, jmethodID, va_list);
    internal readonly unsafe struct Ptr_Func_CallStaticVoidMethodA(nint ptr)
    {
        /// <summary>
        ///     //void (* CallStaticVoidMethodA) (JNIEnv*, jclass, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, classObj, method, args);
    }


    //jfieldID(*GetStaticFieldID)(JNIEnv*, jclass, const char*,
    //                    const char*);

    //jobject(*GetStaticObjectField)(JNIEnv*, jclass, jfieldID);
    //jboolean(*GetStaticBooleanField)(JNIEnv*, jclass, jfieldID);
    //jbyte(*GetStaticByteField)(JNIEnv*, jclass, jfieldID);
    //jchar(*GetStaticCharField)(JNIEnv*, jclass, jfieldID);
    //jshort(*GetStaticShortField)(JNIEnv*, jclass, jfieldID);
    //jint(*GetStaticIntField)(JNIEnv*, jclass, jfieldID);
    //jlong(*GetStaticLongField)(JNIEnv*, jclass, jfieldID);
    //jfloat(*GetStaticFloatField)(JNIEnv*, jclass, jfieldID);
    //jdouble(*GetStaticDoubleField)(JNIEnv*, jclass, jfieldID);

    //void (* SetStaticObjectField) (JNIEnv*, jclass, jfieldID, jobject);
    //void (* SetStaticBooleanField) (JNIEnv*, jclass, jfieldID, jboolean);
    //void (* SetStaticByteField) (JNIEnv*, jclass, jfieldID, jbyte);
    //void (* SetStaticCharField) (JNIEnv*, jclass, jfieldID, jchar);
    //void (* SetStaticShortField) (JNIEnv*, jclass, jfieldID, jshort);
    //void (* SetStaticIntField) (JNIEnv*, jclass, jfieldID, jint);
    //void (* SetStaticLongField) (JNIEnv*, jclass, jfieldID, jlong);
    //void (* SetStaticFloatField) (JNIEnv*, jclass, jfieldID, jfloat);
    //void (* SetStaticDoubleField) (JNIEnv*, jclass, jfieldID, jdouble);


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewString(nint ptr)
    {
        /// <summary>
        /// //jstring(*NewString)(JNIEnv*, const jchar*, jsize);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JSIZE, JSTRING> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JSIZE, JSTRING>)ptr;

        public JSTRING Invoke(PTR_JNI_ENV @this, PStringUTF8 txt, JSIZE length)
            => _ptr(@this, txt, length);
    }

    //jsize(*GetStringLength)(JNIEnv*, jstring);
    //const jchar* (*GetStringChars)(JNIEnv*, jstring, jboolean*);
    //void (* ReleaseStringChars) (JNIEnv*, jstring, const jchar*);

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewStringUTF(nint ptr)
    {
        /// <summary>
        ///     //jstring(*NewStringUTF)(JNIEnv*, const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JSTRING> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, PStringUTF8, JSTRING>)ptr;

        public JSTRING Invoke(PTR_JNI_ENV @this, PStringUTF8 txt)
            => _ptr(@this, txt);
    }


    //jsize(*GetStringUTFLength)(JNIEnv*, jstring);
    ///* JNI spec says this returns const jbyte*, but that's inconsistent */
    //const char* (*GetStringUTFChars)(JNIEnv*, jstring, jboolean*);
    //void (* ReleaseStringUTFChars) (JNIEnv*, jstring, const char*);
    //jsize(*GetArrayLength)(JNIEnv*, jarray);
    //jobjectArray(*NewObjectArray)(JNIEnv*, jsize, jclass, jobject);
    //jobject(*GetObjectArrayElement)(JNIEnv*, jobjectArray, jsize);
    //void (* SetObjectArrayElement) (JNIEnv*, jobjectArray, jsize, jobject);

    //jbooleanArray(*NewBooleanArray)(JNIEnv*, jsize);
    //jbyteArray(*NewByteArray)(JNIEnv*, jsize);
    //jcharArray(*NewCharArray)(JNIEnv*, jsize);
    //jshortArray(*NewShortArray)(JNIEnv*, jsize);
    //jintArray(*NewIntArray)(JNIEnv*, jsize);
    //jlongArray(*NewLongArray)(JNIEnv*, jsize);
    //jfloatArray(*NewFloatArray)(JNIEnv*, jsize);
    //jdoubleArray(*NewDoubleArray)(JNIEnv*, jsize);

    //jboolean* (* GetBooleanArrayElements) (JNIEnv*, jbooleanArray, jboolean*);
    //jbyte* (* GetByteArrayElements) (JNIEnv*, jbyteArray, jboolean*);
    //jchar* (* GetCharArrayElements) (JNIEnv*, jcharArray, jboolean*);
    //jshort* (* GetShortArrayElements) (JNIEnv*, jshortArray, jboolean*);
    //jint* (* GetIntArrayElements) (JNIEnv*, jintArray, jboolean*);
    //jlong* (* GetLongArrayElements) (JNIEnv*, jlongArray, jboolean*);
    //jfloat* (* GetFloatArrayElements) (JNIEnv*, jfloatArray, jboolean*);
    //jdouble* (* GetDoubleArrayElements) (JNIEnv*, jdoubleArray, jboolean*);

    //void (* ReleaseBooleanArrayElements) (JNIEnv*, jbooleanArray,
    //                    jboolean*, jint);
    //void (* ReleaseByteArrayElements) (JNIEnv*, jbyteArray,
    //                    jbyte*, jint);
    //void (* ReleaseCharArrayElements) (JNIEnv*, jcharArray,
    //                    jchar*, jint);
    //void (* ReleaseShortArrayElements) (JNIEnv*, jshortArray,
    //                    jshort*, jint);
    //void (* ReleaseIntArrayElements) (JNIEnv*, jintArray,
    //                    jint*, jint);
    //void (* ReleaseLongArrayElements) (JNIEnv*, jlongArray,
    //                    jlong*, jint);
    //void (* ReleaseFloatArrayElements) (JNIEnv*, jfloatArray,
    //                    jfloat*, jint);
    //void (* ReleaseDoubleArrayElements) (JNIEnv*, jdoubleArray,
    //                    jdouble*, jint);

    //void (* GetBooleanArrayRegion) (JNIEnv*, jbooleanArray,
    //                    jsize, jsize, jboolean*);
    //void (* GetByteArrayRegion) (JNIEnv*, jbyteArray,
    //                    jsize, jsize, jbyte*);
    //void (* GetCharArrayRegion) (JNIEnv*, jcharArray,
    //                    jsize, jsize, jchar*);
    //void (* GetShortArrayRegion) (JNIEnv*, jshortArray,
    //                    jsize, jsize, jshort*);
    //void (* GetIntArrayRegion) (JNIEnv*, jintArray,
    //                    jsize, jsize, jint*);
    //void (* GetLongArrayRegion) (JNIEnv*, jlongArray,
    //                    jsize, jsize, jlong*);
    //void (* GetFloatArrayRegion) (JNIEnv*, jfloatArray,
    //                    jsize, jsize, jfloat*);
    //void (* GetDoubleArrayRegion) (JNIEnv*, jdoubleArray,
    //                    jsize, jsize, jdouble*);

    ///* spec shows these without const; some jni.h do, some don't */
    //void (* SetBooleanArrayRegion) (JNIEnv*, jbooleanArray,
    //                    jsize, jsize, const jboolean*);
    //void (* SetByteArrayRegion) (JNIEnv*, jbyteArray,
    //                    jsize, jsize, const jbyte*);
    //void (* SetCharArrayRegion) (JNIEnv*, jcharArray,
    //                    jsize, jsize, const jchar*);
    //void (* SetShortArrayRegion) (JNIEnv*, jshortArray,
    //                    jsize, jsize, const jshort*);
    //void (* SetIntArrayRegion) (JNIEnv*, jintArray,
    //                    jsize, jsize, const jint*);
    //void (* SetLongArrayRegion) (JNIEnv*, jlongArray,
    //                    jsize, jsize, const jlong*);
    //void (* SetFloatArrayRegion) (JNIEnv*, jfloatArray,
    //                    jsize, jsize, const jfloat*);
    //void (* SetDoubleArrayRegion) (JNIEnv*, jdoubleArray,
    //                    jsize, jsize, const jdouble*);



    internal readonly unsafe struct Ptr_Func_RegisterNatives(nint ptr)
    {
        /// <summary>
        ///     //jint(*RegisterNatives)(JNIEnv*, jclass, const JNINativeMethod*,jint);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JOBJECT, JINT, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JOBJECT, JINT, JRESULT>)ptr;

        public JRESULT Invoke(PTR_JNI_ENV @this, JCLASS classObj, JOBJECT arrayMethod, JINT methodSize)
            => _ptr(@this, classObj, arrayMethod, methodSize);
    }


    //jint(*UnregisterNatives)(JNIEnv*, jclass);
    //jint(*MonitorEnter)(JNIEnv*, jobject);
    //jint(*MonitorExit)(JNIEnv*, jobject);




    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_GetJavaVM(nint ptr)
    {
        /// <summary>
        ///     //jint(*GetJavaVM)(JNIEnv*, JavaVM**);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, out PTR_JAVA_VM, JRESULT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, out PTR_JAVA_VM, JRESULT>)ptr;

        public JRESULT Invoke(PTR_JNI_ENV jniEnv, out PTR_JAVA_VM javaVM)
            => _ptr(jniEnv, out javaVM);
    }

    //void (* GetStringRegion) (JNIEnv*, jstring, jsize, jsize, jchar*);
    //void (* GetStringUTFRegion) (JNIEnv*, jstring, jsize, jsize, char*);

    //void* (* GetPrimitiveArrayCritical) (JNIEnv*, jarray, jboolean*);
    //void (* ReleasePrimitiveArrayCritical) (JNIEnv*, jarray, void*, jint);

    //const jchar* (*GetStringCritical)(JNIEnv*, jstring, jboolean*);
    //void (* ReleaseStringCritical) (JNIEnv*, jstring, const jchar*);


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewWeakGlobalRef(nint ptr)
    {
        /// <summary>
        ///       //jweak(*NewWeakGlobalRef)(JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JWEAK, JWEAK> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JWEAK, JWEAK>)ptr;
        public JWEAK Invoke(PTR_JNI_ENV @this, JWEAK obj)
            => _ptr(@this, obj);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_DeleteWeakGlobalRef(nint ptr)
    {
        /// <summary>
        ///      //void (* DeleteWeakGlobalRef) (JNIEnv*, jweak);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JWEAK, void> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JWEAK, void>)ptr;
        public void Invoke(PTR_JNI_ENV @this, JWEAK obj)
            => _ptr(@this, obj);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_ExceptionCheck(nint ptr)
    {
        /// <summary>
        ///        //jboolean(*ExceptionCheck)(JNIEnv*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JBOOLEAN> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JBOOLEAN>)ptr;

        public JBOOLEAN Invoke(PTR_JNI_ENV jniEnv)
            => _ptr(jniEnv);
    }



    //jobject(*NewDirectByteBuffer)(JNIEnv*, void*, jlong);
    //void* (* GetDirectBufferAddress) (JNIEnv*, jobject);
    //jlong(*GetDirectBufferCapacity)(JNIEnv*, jobject);

    ///* added in JNI 1.6 */
    //jobjectRefType(*GetObjectRefType)(JNIEnv*, jobject);




    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_JNI_NATIVE_INTERFACE
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _reserved0;

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _reserved1;

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _reserved2;

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _reserved3;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetVersionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint DefineClassPointer;

        internal readonly Ptr_Func_FindClass Func_FindClass;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint FromReflectedMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint FromReflectedFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ToReflectedMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetSuperclassPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint IsAssignableFromPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ToReflectedFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ThrowPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ThrowNewPointer;

        internal readonly Ptr_Func_ExceptionOccurred Func_ExceptionOccurred;
        internal readonly Ptr_Func_ExceptionDescribe Func_ExceptionDescribe;
        internal readonly Ptr_Func_ExceptionClear Func_ExceptionClear;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint FatalErrorPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint PushLocalFramePointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint PopLocalFramePointer;

        internal readonly Ptr_Func_NewGlobalRef Func_NewGlobalRef;

        internal readonly Ptr_Func_DeleteGlobalRef Func_DeleteGlobalRef;
        internal readonly Ptr_Func_DeleteLocalRef Func_DeleteLocalRef;
        internal readonly Ptr_Func_IsSameObject Func_IsSameObject;
        internal readonly Ptr_Func_NewLocalRef Func_NewLocalRef;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint EnsureLocalCapacityPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint AllocObjectPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewObjectPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewObjectVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewObjectAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetObjectClassPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint IsInstanceOfPointer;

        internal readonly Ptr_Func_GetMethodID Func_GetMethodID;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallObjectMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallObjectMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallObjectMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallBooleanMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallBooleanMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallBooleanMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallByteMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallByteMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallByteMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallCharMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallCharMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallCharMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallShortMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallShortMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallShortMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallIntMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallIntMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallIntMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallLongMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallLongMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallLongMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallFloatMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallFloatMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallFloatMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallDoubleMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallDoubleMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallDoubleMethodAPointer;

        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethod;
        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethodV;
        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethodA;



        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualObjectMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualObjectMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualObjectMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualBooleanMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualBooleanMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualBooleanMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualByteMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualByteMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualByteMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualCharMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualCharMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualCharMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualShortMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualShortMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualShortMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualIntMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualIntMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualIntMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualLongMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualLongMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualLongMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualFloatMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualFloatMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualFloatMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualDoubleMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualDoubleMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualDoubleMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualVoidMethodPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualVoidMethodVPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint CallNonVirtualVoidMethodAPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetFieldIdPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetObjectFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetBooleanFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetByteFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetCharFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetShortFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetIntFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetLongFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetFloatFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDoubleFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetObjectFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetBooleanFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetByteFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetCharFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetShortFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetIntFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetLongFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetFloatFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetDoubleFieldPointer;
        internal readonly Ptr_Func_GetStaticMethodID Func_GetStaticMethodID;

        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethod;
        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethodV;
        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> CallStaticBooleanMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> CallStaticBooleanMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> CallStaticBooleanMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> CallStaticByteMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> CallStaticByteMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> CallStaticByteMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> CallStaticCharMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> CallStaticCharMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> CallStaticCharMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> CallStaticShortMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> CallStaticShortMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> CallStaticShortMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> CallStaticIntMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> CallStaticIntMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> CallStaticIntMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> CallStaticLongMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> CallStaticLongMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> CallStaticLongMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> CallStaticFloatMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> CallStaticFloatMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> CallStaticFloatMethodAPointer;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> CallStaticDoubleMethodPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> CallStaticDoubleMethodVPointer;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> CallStaticDoubleMethodAPointer;

        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethod;
        /// <summary>
        /// ???
        /// </summary>
        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethodV;
        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethodA;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticFieldIdPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticObjectFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticBooleanFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticByteFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticCharFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticShortFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticIntFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticLongFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticFloatFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStaticDoubleFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticObjectFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticBooleanFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticByteFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticCharFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticShortFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticIntFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticLongFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticFloatFieldPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetStaticDoubleFieldPointer;
        internal readonly Ptr_Func_NewString Func_NewString;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringLengthPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringCharsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseStringCharsPointer;
        internal readonly Ptr_Func_NewStringUTF Func_NewStringUTF;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringUtfLengthPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringUtfCharsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseStringUtfCharsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetArrayLengthPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewObjectArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetObjectArrayElementPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetObjectArrayElementPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewBooleanArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewByteArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewCharArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewShortArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewIntArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewLongArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewFloatArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewDoubleArrayPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetBooleanArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetByteArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetCharArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetShortArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetIntArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetLongArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetFloatArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDoubleArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseBooleanArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseByteArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseCharArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseShortArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseIntArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseLongArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseFloatArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseDoubleArrayElementsPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetBooleanArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetByteArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetCharArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetShortArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetIntArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetLongArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetFloatArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDoubleArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetBooleanArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetByteArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetCharArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetShortArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetIntArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetLongArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetFloatArrayRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint SetDoubleArrayRegionPointer;

        internal readonly Ptr_Func_RegisterNatives Func_RegisterNatives;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint UnregisterNativesPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint MonitorEnterPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint MonitorExitPointer;

        internal readonly Ptr_Func_GetJavaVM Func_GetJavaVM;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringUtfRegionPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetPrimitiveArrayCriticalPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleasePrimitiveArrayCriticalPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetStringCriticalPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint ReleaseStringCriticalPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewWeakGlobalRefPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint DeleteWeakGlobalRefPointer;

        internal readonly Ptr_Func_ExceptionCheck Func_ExceptionCheck;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewDirectByteBufferPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDirectBufferAddressPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDirectBufferCapacityPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetObjectRefTypePointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PTR_JNI_NATIVE_INTERFACE(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PTR_JNI_NATIVE_INTERFACE(nint val) => new(val);
        public static implicit operator nint(PTR_JNI_NATIVE_INTERFACE val) => val._ptr;
        public static implicit operator bool(PTR_JNI_NATIVE_INTERFACE val) => val.IsNullPtr();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNullPtr() => _ptr != nint.Zero;

        public ref REF_JNI_NATIVE_INTERFACE AsRef() => ref _ptr.RefStruct<REF_JNI_NATIVE_INTERFACE>();

    }
}
