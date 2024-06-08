using System.Collections.Generic;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{
    public class DllHijackData
    {
        public string ClassName { set; get; }
        public string ClassFullName { set; get; }
        public string ClassNamespace { set; get; }
        public string DeclaredAccessibility { set; get; }

        public string FileName { set; get; }
        public bool System { set; get; }
        public string DllName { set; get; }

        public List<string> Apis { get; } = new List<string>();

        public string GetModuleHandle { set; get; } = "GetModuleHandle";
        public string ModuleHandle { set; get; } = "hModule";
        public string GetProcAddress { set; get; } = "GetProcAddress";

        public string Jump { set; get; } = "Jump";
    }

}
