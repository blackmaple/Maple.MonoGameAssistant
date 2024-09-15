using System;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 属性生成器
    /// </summary>
    [Description("内部使用...")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal
#else 
    public
#endif    
        class MonoCollectorPropertyAttribute : Attribute
    {
        public string EntryPoint { set; get; }

        public string PropertyName { set; get; }

        public bool Search { set; get; } = true;



    }


}
