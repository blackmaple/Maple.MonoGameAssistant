using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 属性生成器
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorPropertyAttribute : Attribute
    {
        public string EntryPoint { set; get; }

        public string PropertyName { set; get; }

        public bool Search { set; get; } = true;



    }


}
