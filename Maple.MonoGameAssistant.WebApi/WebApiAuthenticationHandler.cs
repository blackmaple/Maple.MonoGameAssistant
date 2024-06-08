//using Maple.MonoGameAssistant.Common;
//using Microsoft.AspNetCore.Authorization;


//namespace Maple.MonoGameAssistant.WebApi
//{

//    [Obsolete("remove...")]
//    public class WebApiAuthenticationHandler(ILogger<WebApiAuthenticationHandler> logger) : AuthorizationHandler<WebApiAuthorizationRequirement>
//    {
//        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, WebApiAuthorizationRequirement requirement)
//        {

//            if (context.User.Identity?.IsAuthenticated != true)
//            {
//                logger.LogError("ERROR {MSG}", "IsAuthenticated");
//                context.Fail();
//            }
//            var claim = context.User.Claims.Where(p => p.Type == WebApiAuthorizationRequirement.MonoWebApiServiceProcessId).FirstOrDefault();
//            if (claim is null)
//            {
//                logger.LogError("ERROR {MSG}", "Claims");
//                context.Fail();
//            }
//            else if (claim.Value != requirement.Pid.ToString())
//            {
//                logger.LogError("ERROR {MSG}", "Value");
//                context.Fail();
//            }
//            else
//            {
//                context.Succeed(requirement);
//            }

//            return Task.CompletedTask;

//        }
//    }
//}
