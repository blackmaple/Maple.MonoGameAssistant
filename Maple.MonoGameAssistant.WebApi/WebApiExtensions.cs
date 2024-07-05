using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net.Mime;

namespace Maple.MonoGameAssistant.WebApi
{
    public static class WebApiExtensions
    {
        internal static IServiceCollection AddTryCatchService(this IServiceCollection services, string errorPage, string[] webApiPaths)
        {
            return services.Configure<WebApiPathSettings>(p =>
            {
                p.ErrorPage = errorPage;
                p.ApiPaths = webApiPaths;
            });
        }

        internal static IApplicationBuilder UseTryCatchService(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(p => p.Run(ExceptionHandler));
            app.UseStatusCodePages(p => p.Run(StatusCodePages));
            return app;

            static async Task ExceptionHandler(HttpContext context)
            {
                var error = context.Features.Get<IExceptionHandlerFeature>();
                if (error is not null)
                {
                    var logger = context.RequestServices.GetRequiredService<ILogger<WebApiBaseService>>();
                    logger.LogError("{error}", error.Error);
                    await context.Response.WriteResponseException(error.Error);
                }

            }
            static async Task StatusCodePages(HttpContext context)
            {
                var statusCode = context.Response.StatusCode;

                if (statusCode >= StatusCodes.Status200OK && statusCode < StatusCodes.Status300MultipleChoices)
                {
                    return;
                }
                context.Response.StatusCode = StatusCodes.Status200OK;

                //var error = context.Features.Get<IExceptionHandlerFeature>();
                //if (error is not null)
                //{
                //    var logger = context.RequestServices.GetRequiredService<ILogger<MonoCommonException>>();
                //    logger.LogError("{error}", error.Error);
                //}

                switch (statusCode)
                {
                    case StatusCodes.Status401Unauthorized:
                        {
                            await context.Response.WriteResponseUnauthorizedErorr($"{nameof(StatusCodes.Status401Unauthorized)}:{DateTime.Now:yyyyMMddHHmmss}").ConfigureAwait(false);
                            break;
                        }
                    case StatusCodes.Status404NotFound:
                        {
                            var settings = context.RequestServices.GetService<IOptions<WebApiPathSettings>>()?.Value;
                            if (settings is not null && false == settings.ExistsWebApiPath(context.Request.Path))
                            {
                                context.Response.Redirect(settings.ErrorPage);
                            }
                            else
                            {
                                await context.Response.WriteResponseStatusErorr($"{nameof(StatusCodes.Status404NotFound)}:{DateTime.Now:yyyyMMddHHmmss}").ConfigureAwait(false);
                            }

                            break;
                        }
                    case StatusCodes.Status400BadRequest:
                        {
                            await context.Response.WriteResponseStatusErorr($"{nameof(StatusCodes.Status400BadRequest)}:{DateTime.Now:yyyyMMddHHmmss}").ConfigureAwait(false);
                            break;
                        }
                    default:
                        {
                            await context.Response.WriteResponseStatusErorr($"SystemStatusError({statusCode}):{DateTime.Now:yyyyMMddHHmmss}").ConfigureAwait(false);
                            break;
                        }


                };
            }



        }
        internal static ValueTask WriteResponseException(this HttpResponse response, Exception exception)
        {
            MonoResultDTO jsonDTO;
            if (exception is MonoCommonException ex)
            {
                jsonDTO = MonoResultDTO.GetBizError(ex);
            }
            else
            {
                var errorMsg = $"SystemException:{DateTime.Now:yyyyMMddHHmmss}";
                jsonDTO = MonoResultDTO.GetSystemError(errorMsg);
            }
            return response.WriteResponse(jsonDTO);
        }
        internal static ValueTask WriteResponseStatusErorr(this HttpResponse response, string error)
        {
            var jsonDTO = MonoResultDTO.GetSystemError(error);
            return response.WriteResponse(jsonDTO);
        }
        internal static ValueTask WriteResponseUnauthorizedErorr(this HttpResponse response, string error)
        {
            var jsonDTO = MonoResultDTO.GetSystemUnauthorized(error);
            return response.WriteResponse(jsonDTO);
        }
        internal static ValueTask WriteResponse(this HttpResponse response, MonoResultDTO error)
        {
            //response.StatusCode = StatusCodes.Status200OK;
            //response.ContentType = "application/json";
            response.StatusCode = StatusCodes.Status200OK;
            response.ContentType = MediaTypeNames.Application.Json;
            return response.Body.WriteAsync(error.ToBufferJson());

        }

        public static MonoResultDTO<T_DTO> GetOk<T_DTO>(this T_DTO dto)
            where T_DTO : notnull
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = (int)EnumMonoCommonCode.OK,
                DATA = dto
            };
        }
    }

    public class WebApiPathSettings
    {
        public required string ErrorPage { set; get; }
        public required string[] ApiPaths { get; set; }

        public bool ExistsWebApiPath(PathString pathString)
        {
            return this.ApiPaths.Any(p => pathString.StartsWithSegments(p));
        }
    }
}
