using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]

#if SOURCE_GEN
    internal
#else 
    public
#endif
        partial class MonoCollectorSearchFieldAttribute : Attribute
    {
        public Type FieldType { get; }
        public string EntryPoint { get; }
        public string PropertyName { get; }
        public bool IsStatic { get; }
        public bool IsReadOnly { set; get; } = true;
        public MonoCollectorSearchFieldAttribute(Type fieldType, string entryPoint, string propertyName, bool isStatic = false)
        {
            this.FieldType = fieldType;
            this.EntryPoint = entryPoint;
            this.PropertyName = propertyName;
            this.IsStatic = isStatic;
        }
    }
}
