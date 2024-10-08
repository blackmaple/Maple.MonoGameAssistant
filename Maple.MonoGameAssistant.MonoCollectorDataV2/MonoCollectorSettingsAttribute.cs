﻿using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// Class标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]

#if SOURCE_GEN
    internal
#else 
    public
#endif
        class MonoCollectorSettingsAttribute : Attribute
    {
        public byte[] Const_ImageName { set; get; }
        public byte[] Const_Namespace { set; get; }
        public byte[] Const_ClassName { set; get; }

        [Obsolete("remove...", true)]
        public uint Const_TypeToken { set; get; }

        [Obsolete("游戏更新导致token变动;不推荐使用", true)]
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
