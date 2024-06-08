using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoClassInfoDTO : MonoObjectInfoDTO
    {

        public string? Namespace { set; get; }
        public byte[]? Utf8Namespace { set; get; }

        public uint Flags { set; get; }
        public bool IsEnum { set; get; }
        public bool IsValueType { set; get; }
        public bool IsGeneric { set; get; }
        public bool IsInterface { set; get; }

        public bool IsStatic { set; get; }
        public bool IsAbstract { set; get; }
        //public bool IsSystem { set; get; }
        //public bool IsUnity { set; get; }

        public int Size { set; get; }
        public uint TypeToken { set; get; }
        public string? ImageName { set; get; }
        public byte[]? Utf8ImageName { set; get; }

       // public string? ImageFile { set; get; }

        public uint TypeEnum { set; get; }
        public string? TypeName { set; get; }

        //public string? ToDisplayName()
        //{
        //    if (string.IsNullOrEmpty(this.Namespace))
        //    {
        //        return $@"{this.Name}";
        //    }
        //    return $@"{this.Namespace}.{this.Name}";

        //}
        [JsonIgnore]
        public string? FullName => TypeName;

        [JsonIgnore]
        public bool IsRefType => !IsValueType && !IsInterface;
    }
}
