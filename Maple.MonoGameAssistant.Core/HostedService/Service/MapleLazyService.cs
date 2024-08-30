using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.Core
{
    public sealed class MapleLazyService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T_GameService>
        (IServiceProvider serviceProvider) : MapleLazy<T_GameService>(serviceProvider.GetRequiredService<T_GameService>)
        where T_GameService : class
    {
    }
}
