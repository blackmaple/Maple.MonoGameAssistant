using Maple.MonoGameAssistant.AndroidJNI.Extension;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Maple.MonoGameAssistant.AndroidCore
{
    public sealed class JniGlobalObjectColltion
    {
        public const string LooperClassName = "android/os/Looper";
        public JGLOBAL LooperObject { set; get; }

        public const string ToastClassName = "android/widget/Toast";
        public JGLOBAL ToastObject { set; get; }
    }


    [JavaClassAttribute("android/os/Looper")]
    public partial class JavaClassWrapper
    {

        [JavaMethodAttribute("ctor", "()V")]
        public extern void Ctor();


        public extern string? Name
        {
            [JavaFieldAttribute("name", "Ljava/lang/String;")]
            get;
            [JavaFieldAttribute("name", "Ljava/lang/String;")]
            set;
        }
    }

    public partial class JavaClassWrapper : IDisposable
    {
        public JniEnvironmentContext Jni { get; }
        public JGLOBAL GlobalClass { get; protected set; }

        JMETHODID MethodId_Ctor_xxx;
        JFIELDID FieldId_Name_xxx;

        public JavaClassWrapper(in JniEnvironmentContext jniEnvironmentContext)
        {
            this.Jni = jniEnvironmentContext;
            this.GlobalClass = this.FindClass();
            this.FindMethod();
            this.FindField();
        }

        protected virtual JGLOBAL FindClass()
        {
            return default!;
        }

        protected virtual void FindMethod()
        {

        }

        protected virtual void FindField()
        {

        }

        public string? Static_Name
            => Jni.JNI_ENV.GetHashCode().ToString();

        public void Dispose()
        {
            var obj = this.GlobalClass;
            this.GlobalClass = nint.Zero;
            if (obj)
            {
                //delete Global ref
               
            }
        }

    }

    public partial class JavaClassInstance(JavaClassWrapper classWrapper) : IDisposable
    {

        public JOBJECT Instance { get; protected set; }
        EnumJavaClassReferenceType ReferenceType { get; }
        JavaClassWrapper ClassWrapper { get; } = classWrapper;
        JniEnvironmentContext Jni => ClassWrapper.Jni;
        JGLOBAL GlobalClass => ClassWrapper.GlobalClass;

        public string? Name
            => Jni.JNI_ENV.ToString();

        public void Dispose()
        {
            var obj = this.Instance;
            this.Instance = nint.Zero;
            if (obj)
            {
                if (EnumJavaClassReferenceType.NewRef == this.ReferenceType)
                {
                    //jvm
                }
                else if (this.ReferenceType == EnumJavaClassReferenceType.LocalRef)
                {
                    //delete LocalRef
                }
                else if (this.ReferenceType == EnumJavaClassReferenceType.GlobalRef)
                {
                    //delete GlobalRef
                }
                else if (this.ReferenceType == EnumJavaClassReferenceType.WeakRef)
                {
                    //delete WeakRef
                }
            }
        }
    }

    public enum EnumJavaClassReferenceType
    {
        NewRef = 0,
        LocalRef,
        GlobalRef,
        WeakRef,
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class JavaClassAttribute(string classDesc) : Attribute
    {
        public string ClassDesc { get; } = classDesc;
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class JavaMethodAttribute(string methodName, string methodDesc) : Attribute
    {
        public string MethodName { get; } = methodName;
        public string MethodDesc { get; } = methodDesc;
    }


    [AttributeUsage(AttributeTargets.Method)]
    public class JavaFieldAttribute(string fieldName, string fieldDesc) : Attribute
    {
        public string FieldName { get; } = fieldName;
        public string FieldDesc { get; } = fieldDesc;

    }
}
