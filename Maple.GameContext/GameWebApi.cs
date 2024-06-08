using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
namespace Maple.GameContext
{
    public class GameWebApi<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMEWEBAPI,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMESERVICE,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXT>(string gameName)
        : WebApiBaseService(gameName)
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
