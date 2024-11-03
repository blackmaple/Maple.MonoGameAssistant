using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;

namespace Maple.MonoGameAssistant.AndroidJNI.Classes
{
    public sealed partial class AndroidToastMetadata : JavaClassMetadata<AndroidToastMetadata>
    {

        public JMETHODID METHOD_MAKETEXT;
        public JMETHODID METHOD_SHOW;

        protected override void FindMethods(in JniEnvironmentContext context)
        {
            METHOD_MAKETEXT = context.JNI_ENV.GetStaticMethodId(GlobalClass, "makeText\0"u8, "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;\0"u8);
            METHOD_SHOW = context.JNI_ENV.GetMethodId(GlobalClass, "show\0"u8, "()V\0"u8);
        }

        //protected override void FindFields(in JniEnvironmentContext context)
        //{
        //    throw new NotImplementedException();
        //}

        public static AndroidToastMetadata CreateMetadata(in JniEnvironmentContext context)
        {
            return CreateMetadata(context, "android/widget/Toast\0"u8);
        }
    }

}
