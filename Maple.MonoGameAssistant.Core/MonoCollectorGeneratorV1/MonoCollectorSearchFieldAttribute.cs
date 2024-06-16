using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.MonoGameAssistant.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public partial class MonoCollectorSearchFieldAttribute<T_STRUCT>(string entryPoint, string propertyName, bool isStatic = false) 
        : MonoCollectorSearchFieldAttribute(typeof(T_STRUCT), entryPoint, propertyName, isStatic)
        where T_STRUCT : unmanaged
    {
    }
}
