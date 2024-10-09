namespace Maple.MonoGameAssistant.Core
{
    public class MonoRuntimeModuleView
    {
        public HashSet<string> ModuleViews { get; } = ["mono-2.0-bdwgc.dll", "GameAssembly.dll", "libil2cpp.so"];

        public bool AddModule(string lib) => ModuleViews.Add(lib);

    }
}
