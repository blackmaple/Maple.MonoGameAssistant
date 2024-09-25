using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Common
{
    public class MapleLazy<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T_LazyObject> : Lazy<T_LazyObject>
        where T_LazyObject : class
    {
        public MapleLazy() : base(LazyThreadSafetyMode.ExecutionAndPublication)
        { }

        public MapleLazy(Func<T_LazyObject> valueFactory) : base(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
        { }


    }
}
