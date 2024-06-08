using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoMethodInfoDTO : MonoObjectInfoDTO
    {
        public uint Flags { set; get; }
        public required MonoParameterTypeDTO[] ParameterTypes { get; set; }
        public required MonoReturnTypeDTO ReturnType { get; set; }

        public bool IsStatic { set; get; }
        public bool IsAbstract { set; get; }
        public bool IsPublic { set; get; }

        //   public bool IsGeneric { set; get; }
        //[Obsolete("暂时区分不了泛型方法 这个默认作废")]
        //[JsonIgnore]
        //public nint MethodAddress { set; get; }

        public bool FromParent { set; get; }
        public nint SourceClass { set; get; }
    }

}
