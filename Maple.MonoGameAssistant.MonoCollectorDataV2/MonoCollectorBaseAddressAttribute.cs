using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 标记[extern] 
    /// 仅支持unsafe
    /// 通过基址+偏移获取方法地址或属性值
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorBaseAddressAttribute : MonoCollectorCallConvsAttribute
    {
        public string Module { get; }
        public int BaseOffset { get; }
        public int[] Offsets { get; set; }
        /// <summary>
        /// 对于方法可以false提前获取地址
        /// 对于属性可以true每次调用获取值
        /// </summary>
        public bool RealTime { set; get; } = false;

        public MonoCollectorBaseAddressAttribute(string name, int baseOffset)
        {
            this.Module = name;
            this.BaseOffset = baseOffset;

        }



    }

    [AttributeUsage(AttributeTargets.All)]
    public class MonoCollectorCallConvsAttribute : Attribute
    {
        public Type[] CallConvs { set; get; }
        public bool SuppressGCTransition { set; get; } = true;

    }
}
