using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Collections.Generic;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    internal class MonoCollectorVersionData
    {
        public string CustomClassNamespace { set; get; }
        public string CustomClassName { set; get; }
        public string CustomClassFullName { set; get; }
        public EnumMonoCollectorTypeVersion Ver { get; set; }
        public List<MonoCollectorTypeData> TypeDatas { set; get; } = new List<MonoCollectorTypeData>(256);

       
    }
}
