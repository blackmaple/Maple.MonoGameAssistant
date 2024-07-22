using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class MonoCollectorTypeVersionAttribute : Attribute
    {
        public Type ClassType { get; }
        public EnumMonoCollectorTypeVersion Ver { get; } = EnumMonoCollectorTypeVersion.Game;

        public MonoCollectorTypeVersionAttribute(Type classType, EnumMonoCollectorTypeVersion ver)
        {
            ClassType = classType;
            Ver = ver;
        }
    }
}
