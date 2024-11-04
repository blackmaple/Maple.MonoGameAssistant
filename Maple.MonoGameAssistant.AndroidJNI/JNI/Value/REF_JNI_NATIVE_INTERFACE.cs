using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.Array;
using Maple.MonoGameAssistant.AndroidModel;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Value
{
    //void* reserved0;
    //void* reserved1;
    //void* reserved2;
    //void* reserved3;

    //jint(*GetVersion)(JNIEnv*);

    //jclass(*DefineClass)(JNIEnv*, const char*, jobject, const jbyte*,
    //                    jsize);


    [StructLayout(LayoutKind.Sequential)]
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

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_AllocObject(nint ptr)
    {
        /// <summary>
        ///         //jobject(*AllocObject)(JNIEnv*, jclass);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JOBJECT> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JOBJECT>)ptr;
        public JOBJECT Invoke(PTR_JNI_ENV @this, JCLASS obj)
            => _ptr(@this, obj);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewObjectA(nint ptr)
    {
        /// <summary>
        ///             //jobject(*NewObject)(JNIEnv*, jclass, jmethodID, ...);
        /// //jobject(*NewObjectV)(JNIEnv*, jclass, jmethodID, va_list);
        /// //jobject(*NewObjectA)(JNIEnv*, jclass, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT>)ptr;
        public JOBJECT Invoke(PTR_JNI_ENV @this, JCLASS obj, JMETHODID methodId, JVALUE_ARRAY args)
            => _ptr(@this, obj, methodId, args);
    }


    
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetObjectClass(nint ptr)
    {
        /// <summary>
        /// //jclass(*GetObjectClass)(JNIEnv*, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT,JCLASS>
            _ptr = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS>)ptr;
        public JCLASS Invoke(PTR_JNI_ENV @this,JOBJECT instance)
            => _ptr(@this, instance);
    }

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
    [StructLayout(LayoutKind.Sequential)]
    readonly unsafe struct Ptr_Func_CallObjectMethodA(nint ptr)
    {
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JOBJECT instance, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, method, args);


    }

    //jboolean(*CallBooleanMethod)(JNIEnv*, jobject, jmethodID, ...);
    //jboolean(*CallBooleanMethodV)(JNIEnv*, jobject, jmethodID, va_list);
    //jboolean(*CallBooleanMethodA)(JNIEnv*, jobject, jmethodID, const jvalue*);
    [StructLayout(LayoutKind.Sequential)]
    readonly unsafe struct Ptr_Func_CallUnmanagedMethodA<T>(nint ptr) where T : unmanaged
    {

        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, T> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, T>)ptr;

        public T Invoke(PTR_JNI_ENV @this, JOBJECT instance, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, method, args);


    }

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
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_CallVoidMethodA(nint ptr)
    {
        /// <summary>
        ///         //void (* CallVoidMethodA) (JNIEnv*, jobject, jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JMETHODID, JVALUE_ARRAY, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JOBJECT instance, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, method, args);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_CallNonvirtualObjectMethodA(nint ptr)
    {
        /// <summary>
        ///             //jobject(*CallNonvirtualObjectMethod)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, ...);
        /// //jobject(*CallNonvirtualObjectMethodV)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, va_list);
        /// //jobject(*CallNonvirtualObjectMethodA)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JOBJECT instance, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, classObj, method, args);
    }

    //jboolean(*CallNonvirtualBooleanMethod)(JNIEnv*, jobject, jclass,
    //                    jmethodID, ...);
    //jboolean(*CallNonvirtualBooleanMethodV)(JNIEnv*, jobject, jclass,
    //                     jmethodID, va_list);
    //jboolean(*CallNonvirtualBooleanMethodA)(JNIEnv*, jobject, jclass,
    //                     jmethodID, const jvalue*);
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_CallNonvirtualUnmanagedMethodA<T>(nint ptr) where T : unmanaged
    {
        /// <summary>
        ///             //jobject(*CallNonvirtualObjectMethod)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, ...);
        /// //jobject(*CallNonvirtualObjectMethodV)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, va_list);
        /// //jobject(*CallNonvirtualObjectMethodA)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, T> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, T>)ptr;

        public T Invoke(PTR_JNI_ENV @this, JOBJECT instance, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, classObj, method, args);
    }

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
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_CallNonvirtualVoidMethodA(nint ptr)
    {
        /// <summary>
        ///             //jobject(*CallNonvirtualObjectMethod)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, ...);
        /// //jobject(*CallNonvirtualObjectMethodV)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, va_list);
        /// //jobject(*CallNonvirtualObjectMethodA)(JNIEnv*, jobject, jclass,
        /// //                    jmethodID, const jvalue*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JCLASS, JMETHODID, JVALUE_ARRAY, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JOBJECT instance, JCLASS classObj, JMETHODID method, JVALUE_ARRAY args)
            => _ptr(@this, instance, classObj, method, args);
    }




    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetFieldID(nint ptr)
    {
        /// <summary>
        /// //jfieldID(*GetFieldID)(JNIEnv*, jclass, const char*, const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JFIELDID> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JFIELDID>)ptr;

        public JFIELDID Invoke(PTR_JNI_ENV @this, JCLASS classObj, PStringUTF8 fieldName, PStringUTF8 fieldDesc)
            => _ptr(@this, classObj, fieldName, fieldDesc);
    }



    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetObjectField(nint ptr)
    {
        /// <summary>
        /// //jobject(*GetObjectField)(JNIEnv*, jobject, jfieldID);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JOBJECT instance, JFIELDID fieldID)
            => _ptr(@this, instance, fieldID);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetUnmanagedField<T>(nint ptr) where T : unmanaged
    {
        /// <summary>
        ///      //jboolean(*GetBooleanField)(JNIEnv*, jobject, jfieldID);
        /// //jbyte(*GetByteField)(JNIEnv*, jobject, jfieldID);
        /// //jchar(*GetCharField)(JNIEnv*, jobject, jfieldID);
        /// //jshort(*GetShortField)(JNIEnv*, jobject, jfieldID);
        /// //jint(*GetIntField)(JNIEnv*, jobject, jfieldID);
        /// //jlong(*GetLongField)(JNIEnv*, jobject, jfieldID);
        /// //jfloat(*GetFloatField)(JNIEnv*, jobject, jfieldID);
        /// //jdouble(*GetDoubleField)(JNIEnv*, jobject, jfieldID);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, T> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, T>)ptr;

        public T Invoke(PTR_JNI_ENV @this, JOBJECT instance, JFIELDID fieldID)
            => _ptr(@this, instance, fieldID);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_SetObjectField(nint ptr)
    {
        /// <summary>
        ///     //void (* SetObjectField) (JNIEnv*, jobject, jfieldID, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, JOBJECT, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, JOBJECT, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JOBJECT instance, JFIELDID fieldID, JOBJECT arg)
            => _ptr(@this, instance, fieldID, arg);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_SetUnmanagedField<T>(nint ptr) where T : unmanaged
    {
        /// <summary>
        ///          //void (* SetBooleanField) (JNIEnv*, jobject, jfieldID, jboolean);
        /// //void (* SetByteField) (JNIEnv*, jobject, jfieldID, jbyte);
        /// //void (* SetCharField) (JNIEnv*, jobject, jfieldID, jchar);
        /// //void (* SetShortField) (JNIEnv*, jobject, jfieldID, jshort);
        /// //void (* SetIntField) (JNIEnv*, jobject, jfieldID, jint);
        /// //void (* SetLongField) (JNIEnv*, jobject, jfieldID, jlong);
        /// //void (* SetFloatField) (JNIEnv*, jobject, jfieldID, jfloat);
        /// //void (* SetDoubleField) (JNIEnv*, jobject, jfieldID, jdouble);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, T, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JFIELDID, T, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JOBJECT instance, JFIELDID fieldID, T arg)
            => _ptr(@this, instance, fieldID, arg);
    }


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
    [StructLayout(LayoutKind.Sequential)]
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

    [StructLayout(LayoutKind.Sequential)]
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
    [StructLayout(LayoutKind.Sequential)]
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


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetStaticFieldID(nint ptr)
    {
        /// <summary>
        ///     //jfieldID(*GetStaticFieldID)(JNIEnv*, jclass, const char*,//                    const char*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JFIELDID> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, PStringUTF8, PStringUTF8, JFIELDID>)ptr;

        public JFIELDID Invoke(PTR_JNI_ENV @this, JCLASS classObj, PStringUTF8 fieldName, PStringUTF8 fieldDesc)
            => _ptr(@this, classObj, fieldName, fieldDesc);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetStaticObjectField(nint ptr)
    {
        /// <summary>
        ///     //jobject(*GetStaticObjectField)(JNIEnv*, jclass, jfieldID);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, JOBJECT> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, JOBJECT>)ptr;

        public JOBJECT Invoke(PTR_JNI_ENV @this, JCLASS classObj, JFIELDID fieldID)
            => _ptr(@this, classObj, fieldID);
    }



    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_GetStaticUnmanagedField<T>(nint ptr) where T : unmanaged
    {
        /// <summary>
        ///          //jboolean(*GetStaticBooleanField)(JNIEnv*, jclass, jfieldID);
        /// //jbyte(*GetStaticByteField)(JNIEnv*, jclass, jfieldID);
        /// //jchar(*GetStaticCharField)(JNIEnv*, jclass, jfieldID);
        /// //jshort(*GetStaticShortField)(JNIEnv*, jclass, jfieldID);
        /// //jint(*GetStaticIntField)(JNIEnv*, jclass, jfieldID);
        /// //jlong(*GetStaticLongField)(JNIEnv*, jclass, jfieldID);
        /// //jfloat(*GetStaticFloatField)(JNIEnv*, jclass, jfieldID);
        /// //jdouble(*GetStaticDoubleField)(JNIEnv*, jclass, jfieldID);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, T> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, T>)ptr;

        public T Invoke(PTR_JNI_ENV @this, JCLASS classObj, JFIELDID fieldID)
            => _ptr(@this, classObj, fieldID);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_SetStaticObjectField(nint ptr)
    {
        /// <summary>
        ///        //void (* SetStaticObjectField) (JNIEnv*, jclass, jfieldID, jobject);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, JOBJECT, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, JOBJECT, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JCLASS classObj, JFIELDID fieldID, JOBJECT arg)
            => _ptr(@this, classObj, fieldID, arg);
    }


    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe struct Ptr_Func_SetStaticUnmanagedField<T>(nint ptr) where T : unmanaged
    {
        /// <summary>
        ///      //void (* SetStaticBooleanField) (JNIEnv*, jclass, jfieldID, jboolean);
        ///      //void (* SetStaticByteField) (JNIEnv*, jclass, jfieldID, jbyte);
        ///      //void (* SetStaticCharField) (JNIEnv*, jclass, jfieldID, jchar);
        ///      //void (* SetStaticShortField) (JNIEnv*, jclass, jfieldID, jshort);
        ///      //void (* SetStaticIntField) (JNIEnv*, jclass, jfieldID, jint);
        ///      //void (* SetStaticLongField) (JNIEnv*, jclass, jfieldID, jlong);
        ///      //void (* SetStaticFloatField) (JNIEnv*, jclass, jfieldID, jfloat);
        ///      //void (* SetStaticDoubleField) (JNIEnv*, jclass, jfieldID, jdouble);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, T, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCLASS, JFIELDID, T, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JCLASS classObj, JFIELDID fieldID, T arg)
            => _ptr(@this, classObj, fieldID, arg);
    }



    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_NewString(nint ptr)
    {
        /// <summary>
        /// //jstring(*NewString)(JNIEnv*, const jchar*, jsize);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCHAR_ARRAY, JSIZE, JSTRING> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JCHAR_ARRAY, JSIZE, JSTRING>)ptr;

        public JSTRING Invoke(PTR_JNI_ENV @this, JCHAR_ARRAY txt, JSIZE length)
            => _ptr(@this, txt, length);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_GetStringLength(nint ptr)
    {
        /// <summary>
        ///     //jsize(*GetStringLength)(JNIEnv*, jstring);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JSIZE> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JSIZE>)ptr;

        public JSIZE Invoke(PTR_JNI_ENV @this, JSTRING str)
            => _ptr(@this, str);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_GetStringChars(nint ptr)
    {
        /// <summary>
        ///        //const jchar* (*GetStringChars)(JNIEnv*, jstring, jboolean*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JREF<JOBJECT>, JCHAR_ARRAY> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JREF<JOBJECT>, JCHAR_ARRAY>)ptr;

        public JCHAR_ARRAY Invoke(PTR_JNI_ENV @this, JSTRING str )
            => _ptr(@this, str, JREF<JOBJECT>.NullRef());
    }


    [StructLayout(LayoutKind.Sequential)]
    internal unsafe readonly struct Ptr_Func_ReleaseStringChars(nint ptr)
    {
        /// <summary>
        ///            //void (* ReleaseStringChars) (JNIEnv*, jstring, const jchar*);
        /// </summary>
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JCHAR_ARRAY, void> _ptr
            = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JSTRING, JCHAR_ARRAY, void>)ptr;

        public void Invoke(PTR_JNI_ENV @this, JSTRING str, JCHAR_ARRAY pString)
            => _ptr(@this, str, pString);
    }

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



    [StructLayout(LayoutKind.Sequential)]
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
        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JWEAK> _ptr =
            (delegate* unmanaged[Cdecl, SuppressGCTransition]<PTR_JNI_ENV, JOBJECT, JWEAK>)ptr;
        public JWEAK Invoke(PTR_JNI_ENV @this, JOBJECT obj)
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
        internal readonly Ptr_Func_AllocObject Func_AllocObject;
        internal readonly Ptr_Func_NewObjectA Func_NewObject;
        internal readonly Ptr_Func_NewObjectA Func_NewObjectV;
        internal readonly Ptr_Func_NewObjectA Func_NewObjectA;
        internal readonly Ptr_Func_GetObjectClass Func_GetObjectClass;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint IsInstanceOfPointer;

        internal readonly Ptr_Func_GetMethodID Func_GetMethodID;

        internal readonly Ptr_Func_CallObjectMethodA Func_CallObjectMethod;
        internal readonly Ptr_Func_CallObjectMethodA Func_CallObjectMethodV;
        internal readonly Ptr_Func_CallObjectMethodA Func_CallObjectMethodA;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JBOOLEAN> Func_CallBooleanMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JBOOLEAN> Func_CallBooleanMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JBOOLEAN> Func_CallBooleanMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JBYTE> Func_CallByteMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JBYTE> Func_CallByteMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JBYTE> Func_CallByteMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JCHAR> Func_CallCharMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JCHAR> Func_CallCharMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JCHAR> Func_CallCharMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JSHORT> Func_CallShortMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JSHORT> Func_CallShortMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JSHORT> Func_CallShortMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JINT> Func_CallIntMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JINT> Func_CallIntMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JINT> Func_CallIntMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JLONG> Func_CallLongMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JLONG> Func_CallLongMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JLONG> Func_CallLongMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JFLOAT> Func_CallFloatMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JFLOAT> Func_CallFloatMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JFLOAT> Func_CallFloatMethodA;

        internal readonly Ptr_Func_CallUnmanagedMethodA<JDOUBLE> Func_CallDoubleMethod;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JDOUBLE> Func_CallDoubleMethodV;
        internal readonly Ptr_Func_CallUnmanagedMethodA<JDOUBLE> Func_CallDoubleMethodA;

        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethod;
        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethodV;
        internal readonly Ptr_Func_CallVoidMethodA Func_CallVoidMethodA;



        internal readonly Ptr_Func_CallNonvirtualObjectMethodA Func_CallNonVirtualObjectMethod;
        internal readonly Ptr_Func_CallNonvirtualObjectMethodA Func_CallNonVirtualObjectMethodV;
        internal readonly Ptr_Func_CallNonvirtualObjectMethodA Func_CallNonVirtualObjectMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBOOLEAN> Func_CallNonVirtualBooleanMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBOOLEAN> Func_CallNonVirtualBooleanMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBOOLEAN> Func_CallNonVirtualBooleanMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBYTE> Func_CallNonVirtualByteMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBYTE> Func_CallNonVirtualByteMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JBYTE> Func_CallNonVirtualByteMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JCHAR> Func_CallNonVirtualCharMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JCHAR> Func_CallNonVirtualCharMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JCHAR> Func_CallNonVirtualCharMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JSHORT> Func_CallNonVirtualShortMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JSHORT> Func_CallNonVirtualShortMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JSHORT> Func_CallNonVirtualShortMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JINT> Func_CallNonVirtualIntMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JINT> Func_CallNonVirtualIntMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JINT> Func_CallNonVirtualIntMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JLONG> Func_CallNonVirtualLongMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JLONG> Func_CallNonVirtualLongMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JLONG> Func_CallNonVirtualLongMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JFLOAT> Func_CallNonVirtualFloatMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JFLOAT> Func_CallNonVirtualFloatMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JFLOAT> Func_CallNonVirtualFloatMethodA;

        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JDOUBLE> Func_CallNonVirtualDoubleMethod;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JDOUBLE> Func_CallNonVirtualDoubleMethodV;
        internal readonly Ptr_Func_CallNonvirtualUnmanagedMethodA<JDOUBLE> Func_CallNonVirtualDoubleMethodA;

        internal readonly Ptr_Func_CallNonvirtualVoidMethodA Func_CallNonVirtualVoidMethod;
        internal readonly Ptr_Func_CallNonvirtualVoidMethodA Func_CallNonVirtualVoidMethodV;
        internal readonly Ptr_Func_CallNonvirtualVoidMethodA Func_CallNonVirtualVoidMethodA;

        internal readonly Ptr_Func_GetFieldID Func_GetFieldID;

        internal readonly Ptr_Func_GetObjectField Func_GetObjectField;
        internal readonly Ptr_Func_GetUnmanagedField<JBOOLEAN> Func_GetBooleanField;
        internal readonly Ptr_Func_GetUnmanagedField<JBYTE> Func_GetByteField;
        internal readonly Ptr_Func_GetUnmanagedField<JCHAR> Func_GetCharField;
        internal readonly Ptr_Func_GetUnmanagedField<JSHORT> Func_GetShortField;
        internal readonly Ptr_Func_GetUnmanagedField<JINT> Func_GetIntField;
        internal readonly Ptr_Func_GetUnmanagedField<JLONG> Func_GetLongField;
        internal readonly Ptr_Func_GetUnmanagedField<JFLOAT> Func_GetFloatField;
        internal readonly Ptr_Func_GetUnmanagedField<JDOUBLE> Func_GetDoubleField;

        internal readonly Ptr_Func_SetObjectField Func_SetObjectField;
        internal readonly Ptr_Func_SetUnmanagedField<JBOOLEAN> Func_SetBooleanField;
        internal readonly Ptr_Func_SetUnmanagedField<JBYTE> Func_SetByteField;
        internal readonly Ptr_Func_SetUnmanagedField<JCHAR> Func_SetCharField;
        internal readonly Ptr_Func_SetUnmanagedField<JSHORT> Func_SetShortField;
        internal readonly Ptr_Func_SetUnmanagedField<JINT> Func_SetIntField;
        internal readonly Ptr_Func_SetUnmanagedField<JLONG> Func_SetLongField;
        internal readonly Ptr_Func_SetUnmanagedField<JFLOAT> Func_SetFloatField;
        internal readonly Ptr_Func_SetUnmanagedField<JDOUBLE> Func_SetDoubleField;
        internal readonly Ptr_Func_GetStaticMethodID Func_GetStaticMethodID;

        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethod;
        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethodV;
        internal readonly Ptr_Func_CallStaticObjectMethodA Func_CallStaticObjectMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> Func_CallStaticBooleanMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> Func_CallStaticBooleanMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBOOLEAN> Func_CallStaticBooleanMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> Func_CallStaticByteMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> Func_CallStaticByteMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JBYTE> Func_CallStaticByteMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> Func_CallStaticCharMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> Func_CallStaticCharMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JCHAR> Func_CallStaticCharMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> Func_CallStaticShortMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> Func_CallStaticShortMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JSHORT> Func_CallStaticShortMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> Func_CallStaticIntMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> Func_CallStaticIntMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JINT> Func_CallStaticIntMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> Func_CallStaticLongMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> Func_CallStaticLongMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JLONG> Func_CallStaticLongMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> Func_CallStaticFloatMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> Func_CallStaticFloatMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JFLOAT> Func_CallStaticFloatMethodA;

        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> Func_CallStaticDoubleMethod;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> Func_CallStaticDoubleMethodV;
        internal readonly Ptr_Func_CallStaticUnmanagedMethodA<JDOUBLE> Func_CallStaticDoubleMethodA;

        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethod;
        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethodV;
        internal readonly Ptr_Func_CallStaticVoidMethodA Func_CallStaticVoidMethodA;

        internal readonly Ptr_Func_GetStaticFieldID Func_GetStaticFieldID;
        internal readonly Ptr_Func_GetStaticObjectField Func_GetStaticObjectField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JBOOLEAN> Func_GetStaticBooleanField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JBYTE> Func_GetStaticByteField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JCHAR> Func_GetStaticCharField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JSHORT> Func_GetStaticShortField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JINT> Func_GetStaticIntField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JLONG> Func_GetStaticLongField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JFLOAT> Func_GetStaticFloatField;
        internal readonly Ptr_Func_GetStaticUnmanagedField<JDOUBLE> Func_GetStaticDoubleField;

        internal readonly Ptr_Func_SetStaticObjectField Func_SetStaticObjectField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JBOOLEAN> Func_SetStaticBooleanField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JBYTE> Func_SetStaticByteField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JCHAR> Func_SetStaticCharField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JSHORT> Func_SetStaticShortField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JINT> Func_SetStaticIntField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JLONG> Func_SetStaticLongField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JFLOAT> Func_SetStaticFloatField;
        internal readonly Ptr_Func_SetStaticUnmanagedField<JDOUBLE> Func_SetStaticDoubleField;

        internal readonly Ptr_Func_NewString Func_NewString;
        internal readonly Ptr_Func_GetStringLength Func_GetStringLength;
        internal readonly Ptr_Func_GetStringChars Func_GetStringChars;
        internal readonly Ptr_Func_ReleaseStringChars Func_ReleaseStringChars;
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
        internal readonly Ptr_Func_NewWeakGlobalRef Func_NewWeakGlobalRef;
        internal readonly Ptr_Func_DeleteWeakGlobalRef Func_DeleteWeakGlobalRef;

        internal readonly Ptr_Func_ExceptionCheck Func_ExceptionCheck;

        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint NewDirectByteBufferPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDirectBufferAddressPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetDirectBufferCapacityPointer;
        [MarshalAs(UnmanagedType.SysInt)] internal readonly nint GetObjectRefTypePointer;
    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PTR_JNI_NATIVE_INTERFACE(nint ptr): IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;

        public nint Ptr => _ptr;

        public static implicit operator PTR_JNI_NATIVE_INTERFACE(nint val) => new(val);
        public static implicit operator nint(PTR_JNI_NATIVE_INTERFACE val) => val._ptr;
        public static implicit operator bool(PTR_JNI_NATIVE_INTERFACE val) => val.IsNotNullPtr();
 

        public ref REF_JNI_NATIVE_INTERFACE AsRef() => ref _ptr.RefStruct<REF_JNI_NATIVE_INTERFACE>();

    }
}
