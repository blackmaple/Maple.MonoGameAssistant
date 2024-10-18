using Maple.MonoGameAssistant.AndroidCore.Context;
using Maple.MonoGameAssistant.AndroidCore.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidCore.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;
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

        protected virtual void Dispose(bool disposing)
        {
           if(!this.GlobalClass.IsNullPtr())
            {
                //delete Global ref

                this.GlobalClass = nint.Zero;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~JavaClassWrapper()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public   partial class JavaClassInstance(JavaClassWrapper classWrapper) : IDisposable
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
                else if(this.ReferenceType == EnumJavaClassReferenceType.LocalRef)
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
