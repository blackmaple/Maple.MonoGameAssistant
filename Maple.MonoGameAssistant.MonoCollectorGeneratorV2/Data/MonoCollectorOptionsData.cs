using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Collections.Generic;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{


    internal class MonoCollectorOptionsData
    {
        //public MonoCollectorVersionData VersionData { set; get; }

        public string CustomClassNamespace { set; get; }
        public string CustomClassName { set; get; }
        public string CustomClassFullName { set; get; }

        public string MonoCollectorContext { set; get; }
        public MonoCollectorMethodData MonoCollectorContext_Ctor { set; get; }
        public MonoCollectorMethodData MonoCollectorContext_GetClassInfo { set; get; }
        public MonoCollectorMethodData MonoCollectorContext_ThrowException { set; get; }

        //public MonoCollectorPropertyData[] MonoCollectorContext_PropertyDatas { set; get; }
        //   public MonoCollectorMethodData MonoCollectorContext_CallbackCollectorImp { set; get; }


        public string MonoCollectorMember { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_Ctor { set; get; }
        public MonoCollectorMethodData[] MonoCollectorMember_GetMethodPointers { set; get; }
        public MonoCollectorMethodData[] MonoCollectorMember_GetStaticMethodInvokers { set; get; }

        public MonoCollectorPropertyData[] MonoCollectorMember_PropertyDatas { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_InitMember { set; get; }
        public MonoCollectorMethodData[] MonoCollectorMember_New { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_GetMonoStaticFieldValue { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_GetModuleBaseAddress { set; get; }

        public MonoCollectorMethodData MonoCollectorMember_GetMemberFieldOffset { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_GetMemberFieldValue { set; get; }
        public MonoCollectorMethodData MonoCollectorMember_SetMemberFieldValue { set; get; }

        

        public string MonoRuntimeContext { set; get; }

        //[Obsolete("Remove...")]
        //public string MonoCollectorImageInfo { set; get; }
        //[Obsolete("Remove...")]
        //public string MonoCollectorClassInfo { set; get; }
        //[Obsolete("Remove...")]
        //public string MonoImageInfoDTO { set; get; }
        //[Obsolete("Remove...")]
        //public string MonoClassInfoDTO { set; get; }
        //[Obsolete("Remove...")]
        //public string MonoFieldInfoDTO { set; get; }
        //[Obsolete("Remove...")]
        //public string MonoMethodInfoDTO { set; get; }


        //public List<MonoCollectorTypeData> CollectorTypeDatas { get; } = new List<MonoCollectorTypeData>();

        public List<MonoCollectorVersionData> VersionDatas { get; } = new List<MonoCollectorVersionData>();
    }
}
