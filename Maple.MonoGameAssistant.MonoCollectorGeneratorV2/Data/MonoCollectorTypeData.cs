﻿using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Collections.Generic;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    public class MonoCollectorTypeData
    {

        public EnumMonoCollectorTypeVersion Ver { get; set; }

        public string NameSpace { set; get; }
        public string ClassName { set; get; }
        public string PtrClassName { set; get; }
        public string RefClassName { set; get; }
        public string VTableClassName { set; get; }

        public string ClassFullName { set; get; }

        public string Utf8_ImageName { set; get; }
        public string Const_ImageName { set; get; }

        public string Utf8_Namespace { set; get; }
        public string Const_Namespace { set; get; }

        public string Utf8_ClassName { set; get; }
        public string Const_ClassName { set; get; }

        public uint Const_TypeToken { set; get; }
        public IReadOnlyList<MonoCollectorStaticPropertyData> StaticFieldDatas { set; get; }
        public IReadOnlyList<MonoCollectorPropertyData> PropertyDatas { set; get; }
        public IReadOnlyList<MonoCollectorMethodData> MethodDatas { set; get; }

        public IReadOnlyList<MonoCollectorInheritViewData> InheritViewDatas { set; get; }


        public IReadOnlyList<MonoCollectorPtrVTableData> VTableDatas { set; get; }


    }
}
