using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    /// <summary>
    /// 源生成器对象配置器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorOptionsAttribute : Attribute
    {

        public Type MonoCollectorContext { get; }
        public Type MonoCollectorMember { get; }
        public Type MonoRuntimeContext { get; }
        //public Type MonoCollectorImageInfo { get; }
        public Type MonoCollectorClassInfo { get; }
        //public Type MonoImageInfoDTO {  get; }
        //public Type MonoClassInfoDTO { get; }
        //public Type MonoFieldInfoDTO { get; }
        //public Type MonoMethodInfoDTO { get; }

        public MonoCollectorOptionsAttribute(
            Type monoCollectorContext,
            Type monoCollectorMember,
            Type monoRuntimeContext,
            Type monoCollectorClassInfo)
        {
            MonoCollectorContext = monoCollectorContext;
            MonoCollectorMember = monoCollectorMember;
            MonoRuntimeContext = monoRuntimeContext;
            //MonoCollectorImageInfo = monoCollectorImageInfo;
            MonoCollectorClassInfo = monoCollectorClassInfo;
            //MonoImageInfoDTO = monoImageInfoDTO;
            //MonoClassInfoDTO = monoClassInfoDTO;
            //MonoFieldInfoDTO = monoFieldInfoDTO;
            //MonoMethodInfoDTO = monoMethodInfoDTO;
        }
    }
}
