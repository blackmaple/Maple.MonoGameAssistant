using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.AndroidModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore
{
    public sealed class JniGlobalObjectColltion
    {
        public const string LooperClassName = "android/os/Looper";
        public JGLOBAL LooperObject { set; get; }

        public const string ToastClassName = "android/widget/Toast";
        public JGLOBAL ToastObject { set; get; }
    }

    public partial class JavaClassWrapper : IDisposable
    {
        public JniEnvironmentContext Jni { get; init; }
        public JGLOBAL<JCLASS> GlobalClass { get; protected set; }

        protected JavaClassWrapper()
        {

        }

        protected virtual void FindMethods()
        {

        }
        protected JMETHODID GetMethodId(ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc)
        {
            return this.Jni.JNI_ENV.GetMethodId(this.GlobalClass, methodName, methodDesc);
        }
        protected JMETHODID GetMethodId(ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc)
        {
            return this.Jni.JNI_ENV.GetMethodId(this.GlobalClass, methodName, methodDesc);
        }
        protected JMETHODID GetStaticMethodId(ReadOnlySpan<char> methodName, ReadOnlySpan<char> methodDesc)
        {
            return this.Jni.JNI_ENV.GetStaticMethodId(this.GlobalClass, methodName, methodDesc);
        }
        protected JMETHODID GetStaticMethodId(ReadOnlySpan<byte> methodName, ReadOnlySpan<byte> methodDesc)
        {
            return this.Jni.JNI_ENV.GetStaticMethodId(this.GlobalClass, methodName, methodDesc);
        }

        protected virtual void FindFields()
        {

        }



        public void Dispose()
        {
            var obj = this.GlobalClass;
            this.GlobalClass = default;
            if (obj)
            {
                Jni.JNI_ENV.DeleteGlobalRef(obj);
            }
        }

        public static T Create<T>(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<char> className)
            where T : JavaClassWrapper, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.FindClass(className);
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            var javaClass = new T() { Jni = jniEnvironmentContext, GlobalClass = globalClass };
            javaClass.FindMethods();
            javaClass.FindMethods();
            return javaClass;
        }
        public static T Create<T>(in JniEnvironmentContext jniEnvironmentContext, ReadOnlySpan<byte> className)
            where T : JavaClassWrapper, new()
        {
            var classObj = jniEnvironmentContext.JNI_ENV.FindClass(className);
            var globalClass = jniEnvironmentContext.JNI_ENV.NewGlobalRef(classObj);
            jniEnvironmentContext.JNI_ENV.DeleteLocalRef(classObj);
            var javaClass = new T() { Jni = jniEnvironmentContext, GlobalClass = globalClass };
            javaClass.FindMethods();
            javaClass.FindFields();
            return javaClass;
        }

    }

    public partial class JavaClassInstance : IDisposable
    {

        public JOBJECT Instance { get; protected set; }
        public EnumJavaClassReferenceType RefType { get; protected set; }
        public required JavaClassWrapper ClassWrapper { get; init; }
        JniEnvironmentContext Jni => ClassWrapper.Jni;
        JGLOBAL<JCLASS> GlobalClass => ClassWrapper.GlobalClass;

        public void Dispose()
        {
            var obj = this.Instance;
            this.Instance = nint.Zero;
            if (obj)
            {
                switch (this.RefType)
                {
                    case EnumJavaClassReferenceType.WeakRef: { this.Jni.JNI_ENV.DeleteWeakGlobalRef(new JWEAK(obj)); break; }
                    case EnumJavaClassReferenceType.GlobalRef: { this.Jni.JNI_ENV.DeleteGlobalRef(new JGLOBAL(obj)); break; }
                    case EnumJavaClassReferenceType.LocalRef:
                    case EnumJavaClassReferenceType.NewRef:
                    default:
                        {
                            this.Jni.JNI_ENV.DeleteLocalRef(obj);
                            break;
                        }

                }
            }
        }

        public static T Create<T>(JavaClassWrapper javaClassWrapper, EnumJavaClassReferenceType refType) where T : JavaClassInstance, new()
        {
            JOBJECT jObj;

            if (refType == EnumJavaClassReferenceType.GlobalRef)
            {
                jObj = javaClassWrapper.Jni.JNI_ENV.NewGlobalRef(javaClassWrapper.Jni.JNI_ENV.AllocObject(javaClassWrapper.GlobalClass));
            }
            else if (refType == EnumJavaClassReferenceType.WeakRef)
            {
                jObj = javaClassWrapper.Jni.JNI_ENV.NewWeakGlobalRef(javaClassWrapper.Jni.JNI_ENV.AllocObject(javaClassWrapper.GlobalClass));
            }
            else if (refType == EnumJavaClassReferenceType.NewRef)
            {
                jObj = javaClassWrapper.Jni.JNI_ENV.AllocObject(javaClassWrapper.GlobalClass);
            }
            else
            {
                return AndroidJNIException.Throw<T>();
            }
            return new T()
            {
                Instance = jObj,
                RefType = refType,
                ClassWrapper = javaClassWrapper
            };
        }
        public static T Create<T>(JavaClassWrapper javaClassWrapper, JOBJECT jObj, EnumJavaClassReferenceType refType) where T : JavaClassInstance, new()
        {
            if (refType == EnumJavaClassReferenceType.GlobalRef)
            {
                jObj = javaClassWrapper.Jni.JNI_ENV.NewGlobalRef(jObj);
            }
            else if (refType == EnumJavaClassReferenceType.WeakRef)
            {
                jObj = javaClassWrapper.Jni.JNI_ENV.NewWeakGlobalRef(jObj);
            }
            else if (refType != EnumJavaClassReferenceType.LocalRef)
            {
                return AndroidJNIException.Throw<T>();
            }
            return new T()
            {
                Instance = jObj,
                RefType = refType,
                ClassWrapper = javaClassWrapper
            };
        }

    }

    public enum EnumJavaClassReferenceType
    {
        NewRef = 0,
        LocalRef,
        GlobalRef,
        WeakRef,
    }



    public sealed partial class AndroidToast : JavaClassWrapper
    {
        public static AndroidToast Create(in JniEnvironmentContext jniEnvironmentContext)
        {
            return Create<AndroidToast>(jniEnvironmentContext, "android/widget/Toast\0"u8);
        }

        public JMETHODID ID_MAKETEXT;
        public JMETHODID ID_SHOW;
        protected override void FindMethods()
        {
            ID_MAKETEXT = this.GetStaticMethodId("makeText\0"u8, "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;\0"u8);
            ID_SHOW = this.GetMethodId("show\0"u8, "()V\0"u8);
        }



        public unsafe void Show(JOBJECT context, ReadOnlySpan<char> content, bool showLong = true)
        {
            const int LENGTH_LONG = 1;
            const int LENGTH_SHORT = 0;
            var jTime = new JINT(showLong ? LENGTH_LONG : LENGTH_SHORT);
            var jString = this.Jni.JNI_ENV.CreateStringUnicode(content);
            var jObject = this.Jni.JNI_ENV.CallStaticObjectMethod(this.GlobalClass, ID_MAKETEXT, context, jString, jTime);
            this.Jni.JNI_ENV.CallVoidMethod(jObject, ID_SHOW);
            this.Jni.JNI_ENV.DeleteLocalRef(jString);
            this.Jni.JNI_ENV.DeleteLocalRef(jObject);
        }

    }




}
