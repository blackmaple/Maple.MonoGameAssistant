using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class MonoCollectorTypeAttribute : Attribute
    {
        public Type ClassType { set; get; }

        public EnumMonoCollectorTypeVersion Ver { set; get; } = EnumMonoCollectorTypeVersion.Game;

        public MonoCollectorTypeAttribute(Type classType)
        {
            this.ClassType = classType;
        }


    }
}
