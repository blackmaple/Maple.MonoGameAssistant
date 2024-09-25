using System;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 指定Class的基类,并继承基类的方法(Mono将递归基类查询方法)
    /// 按次数递归;所以基类需要连续指定
    /// </summary>
    [Description("内部使用")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
#if SOURCE_GEN
    internal
#else 
    public
#endif     
        class MonoCollectorInheritViewAttribute : Attribute
    {

        public Type BaseClass { get; }

        //public bool OnlyAsRef { set; get; } = false;

        public MonoCollectorInheritViewAttribute(Type baseClasses)
        {
            this.BaseClass = baseClasses;
        }
    }
}
