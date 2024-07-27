using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class MonoCollectorTypeAttribute : Attribute
    {
        public Type ClassType { set; get; }

        public EnumMonoCollectorTypeVersion Ver { set; get; } = EnumMonoCollectorTypeVersion.APP;

        public MonoCollectorTypeAttribute(Type classType)
        {
            this.ClassType = classType;
        }


    }


}
