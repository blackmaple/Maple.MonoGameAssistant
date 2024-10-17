using Maple.MonoGameAssistant.AndroidCore.JNI.Reference;

namespace Maple.MonoGameAssistant.AndroidCore
{
    public sealed class JniGlobalObjectColltion
    {
        public const string LooperClassName = "android/os/Looper";
        public JGLOBAL LooperObject { set; get; }

        public const string ToastClassName = "android/widget/Toast";
        public JGLOBAL ToastObject { set; get; }
    }

}
