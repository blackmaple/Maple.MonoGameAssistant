using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.GameContext
{
    public class GameWebApi<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMEWEBAPI,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMESERVICE,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXT>(string gameName, string? qq = default)
        : WebApiBaseService(gameName, qq)
        where T_GAMEWEBAPI : WebApiBaseService, new()
        where T_GAMESERVICE : GameService<T_GAMECONTEXT>
        where T_GAMECONTEXT : MonoCollectorContext
    {



        public static void Initializer(int millisecondsDelay)
        {
            _ = (new T_GAMEWEBAPI()).LazyRunAsync<T_GAMESERVICE>(millisecondsDelay);
        }

    }


}
