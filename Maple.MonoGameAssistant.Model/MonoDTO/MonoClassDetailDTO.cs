namespace Maple.MonoGameAssistant.Model
{
    public class MonoClassDetailDTO
    { 
        public required MonoClassInfoDTO ClassInfoDTO { get; set; }

        public MonoClassInfoDTO[]? ParentClassInfos { set; get; }

        public MonoMethodInfoDTO[]? MethodInfos { set; get; }

        public MonoInterfaceInfoDTO[]? InterfaceInfos { set; get; }

        public MonoFieldInfoDTO[]? FieldInfos { set; get; }
    }
}
