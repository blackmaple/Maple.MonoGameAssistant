using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorPtrVTableAttribute : Attribute
    {
        //    public string PropertyName { get; set; }

        public int VTableSort { get; set; } = 0;

   
    }
}
