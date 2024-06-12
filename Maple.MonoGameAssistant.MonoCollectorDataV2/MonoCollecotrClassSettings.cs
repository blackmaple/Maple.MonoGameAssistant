using System;
using System.ComponentModel;
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

        [Obsolete("游戏更新token变动, 兼容性较差不推荐使用")]
        public uint TypeToken { set; get; }


        //[Obsolete("remove...")]
        //public int EnumParentCount { set; get; }



    }

}
