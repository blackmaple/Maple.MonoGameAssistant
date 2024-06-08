using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{
    public class MonoFieldInfoDTO : MonoObjectInfoDTO
    {
        public required MonoFieldTypeDTO FieldType { get; set; }
        public uint Flags { set; get; }
        public int Offset { set; get; }
        public int RawOffset { set; get; }

        public bool IsStatic { set; get; }
        public bool IsConst { set; get; }

        public string? Value { set; get; }

        /// <summary>
        /// 获取FileValue所用的PMonoClass
        /// </summary>
        public nint SourceClass { set; get; }
    }




}
