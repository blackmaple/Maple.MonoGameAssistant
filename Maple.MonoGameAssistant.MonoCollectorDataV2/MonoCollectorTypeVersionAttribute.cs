using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [Obsolete("remove...")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]

#if SOURCE_GEN
    internal
#else 
    public
#endif
        sealed class MonoCollectorTypeVersionAttribute : Attribute
    {
        public Type ClassType { get; }
        public EnumMonoCollectorTypeVersion Ver { get; } = EnumMonoCollectorTypeVersion.APP;

        public MonoCollectorTypeVersionAttribute(Type classType, EnumMonoCollectorTypeVersion ver)
        {
            ClassType = classType;
            Ver = ver;
        }
    }
}
