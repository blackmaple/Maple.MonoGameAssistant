using System;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [Description("内部使用...")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]

#if SOURCE_GEN
    internal
#else 
    public
#endif
        class MonoCollectorPtrVTableAttribute : Attribute
    {
        //    public string PropertyName { get; set; }

        public int VTableSort { get; set; } = 0;


    }
}
