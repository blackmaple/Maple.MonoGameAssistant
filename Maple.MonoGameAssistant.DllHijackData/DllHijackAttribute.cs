using System;

namespace Maple.MonoGameAssistant.DllHijackData
{

    [AttributeUsage(AttributeTargets.Class)]
    public class DllHijackAttribute : Attribute
    {
        public string FileName { set; get; }
        public bool System { set; get; }
        public string DllName { set; get; }

        public DllHijackAttribute(string fileName, bool system, string dllName)
        {
            this.FileName = fileName;
            this.System = system;
            this.DllName = dllName;
        }
    }
}
