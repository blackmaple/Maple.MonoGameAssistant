using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 标记[extern] 
    /// 仅支持virtual
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
#if SOURCE_GEN
    internal
#else 
    public
#endif   
        class MonoCollectorVTableMethodAttribute : Attribute
    {
        public int MethodOffset { get; }

        //[Obsolete("remove...")]
        //public int VTableOffset { get; set; }
        public string VTableField { get; set; }
        public Type[] CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;
        public MonoCollectorVTableMethodAttribute(int methodOffset)
        {
            this.MethodOffset = methodOffset;
        }
    }
}
