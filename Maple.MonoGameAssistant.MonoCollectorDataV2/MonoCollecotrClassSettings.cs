using System;
using System.Runtime;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    public class MonoCollecotrClassSettings
    {
        public byte[] Utf8ImageName { set; get; }
        public string ImageName { set; get; }

        public byte[] Utf8Namespace { set; get; }
        public string Namespace { set; get; }

        public byte[] Utf8ClassName { set; get; }
        public string ClassName { set; get; }

        public uint TypeToken { set; get; }

        //[Obsolete("remove...")]
        //public int EnumParentCount { set; get; }


      
    }

}
