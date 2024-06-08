using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// Class标记/Const_TypeToken暂只支持Mono编译
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorSettingsAttribute : Attribute
    {
        public byte[] Const_ImageName { set; get; }
        public byte[] Const_Namespace { set; get; }
        public byte[] Const_ClassName { set; get; }
        public uint Const_TypeToken { set; get; }
        public MonoCollectorSettingsAttribute(byte[] const_imageName, uint const_TypeToken)
        {

            this.Const_ImageName = const_imageName;
            this.Const_TypeToken = const_TypeToken;
        }

        public MonoCollectorSettingsAttribute(byte[] const_imageName, byte[] const_nameSpace, byte[] const_className)
        {

            this.Const_ImageName = const_imageName;
            this.Const_Namespace = const_nameSpace;
            this.Const_ClassName = const_className;
        }
    }

}
