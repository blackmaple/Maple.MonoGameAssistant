using System;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 静态属性生成器
    /// </summary>
    [Description("内部使用...")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]

#if SOURCE_GEN
    internal
#else 
    public
#endif
        class MonoCollectorStaticPropertyAttribute : Attribute
    {
        public string EntryPoint { get; set; }
        public string PropertyName { get; set; }
    }
}
