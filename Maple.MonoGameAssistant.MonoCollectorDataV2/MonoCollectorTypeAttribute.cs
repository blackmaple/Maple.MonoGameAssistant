using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class MonoCollectorTypeAttribute : Attribute
    {
        public Type ClassType { set; get; }

        [Obsolete("remove...")]
        public EnumMonoCollectorTypeVersion Ver { set; get; } = EnumMonoCollectorTypeVersion.Game;

        public MonoCollectorTypeAttribute(Type classType)
        {
            this.ClassType = classType;
        }


    }

    //[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    //public class MonoCollectorTypeAttribute<T>() : MonoCollectorTypeAttribute(typeof(T)) where T : class
    //{ 
    
    //}
}
