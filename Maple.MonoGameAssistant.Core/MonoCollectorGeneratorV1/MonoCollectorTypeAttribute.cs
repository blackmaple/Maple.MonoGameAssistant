using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.MonoGameAssistant.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class MonoCollectorTypeAttribute<T>() : MonoCollectorTypeAttribute(typeof(T)) where T : class
    {

    }
}
