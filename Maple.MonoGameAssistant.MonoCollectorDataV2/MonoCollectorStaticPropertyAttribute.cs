using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 静态属性生成器
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorStaticPropertyAttribute : Attribute
    {
        public string EntryPoint { get; set; }
        public string PropertyName { get; set; }
    }
}
