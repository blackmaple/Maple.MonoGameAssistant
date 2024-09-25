using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.StaticFiles;
using System.Diagnostics;
using System.IO.Compression;

namespace Maple.MonoGameAssistant.WebApi
{
    public static class WebApiServiceExtensions
    {

        public static WebApplication AsRunWebApiService(
            Action<MonoGameSettings> actionGameSettings,
            Action<IServiceCollection> actionAddServices)
        {
            var slimBuilder = WebApplication.CreateSlimBuilder();
            var settings = new MonoGameSettings()
            {
                MonoDataCollector = true,
                NamedPipe = true,
                Http = false,
                IndexPage = "/index.html",
                GamePath = slimBuilder.Environment.ContentRootPath,
                WebRootPath = slimBuilder.Environment.WebRootPath
            };
            actionGameSettings(settings);
            slimBuilder.Services.AddSingleton(settings);

            slimBuilder.ConfigureListenIP(settings);
            slimBuilder.ConfigureListenNamedPipe(settings);
            slimBuilder.ConfigureHttpService(settings);

            actionAddServices(slimBuilder.Services);

            var app = slimBuilder.BuildWebApplication();
            app.UseEnumMonoWebApi(settings);
            app.UseGameWebApi(settings);

            return app;
        }

        private static void ConfigureListenIP(this WebApplicationBuilder slimBuilder, MonoGameSettings settings)
        {
            if (settings.Http && settings.TryGetRandomPort(out var port))
            {

                settings.BaseAddress = $"http://localhost:{port}";
                slimBuilder.WebHost.UseKestrel(p => p.ListenAnyIP(port));
            }
        }
        private static void ConfigureListenNamedPipe(this WebApplicationBuilder slimBuilder, MonoGameSettings settings)
        {
            if (settings.NamedPipe)
            {
                slimBuilder.WebHost.UseKestrel(p =>
                {
                    p.ListenNamedPipe(MonoJsonExtensions.GetPipeName(Process.GetCurrentProcess()));
                });
            }
        }
        private static void ConfigureHttpService(this WebApplicationBuilder slimBuilder, MonoGameSettings settings)
        {
            var serviceDescriptors = slimBuilder.Services;
            serviceDescriptors.ConfigureHttpJsonOptions(jsonOptions =>
            {
                jsonOptions.SerializerOptions.AddMonoJsonContext();
                jsonOptions.SerializerOptions.TypeInfoResolverChain.Insert(0, GameJsonContext.Default);
            });
            serviceDescriptors.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
            });
            serviceDescriptors.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });
            serviceDescriptors.AddCors();

            serviceDescriptors.AddTryCatchService(settings.IndexPage ?? "/index.html", ["/mono", "/game"]);
        }



        private static WebApplication BuildWebApplication(this WebApplicationBuilder slimBuilder)
        {
            var app = slimBuilder.Build();
            app.UseResponseCompression();
            app.UseTryCatchService();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                ContentTypeProvider = new FileExtensionContentTypeProvider(new Dictionary<string, string>
                {
                    [".blat"] = "application/octet-stream",
                    [".dll"] = "application/octet-stream",
                    [".webcil"] = "application/octet-stream",
                    [".dat"] = "application/octet-stream",

                    [".wasm"] = "application/wasm",

                    [".json"] = "application/json",

                    [".woff"] = "application/font-woff",
                    [".woff2"] = "application/font-woff",

                }),
                HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
            });
            app.UseCors();
            return app;
        }
        private static void UseEnumMonoWebApi(this IEndpointRouteBuilder app, MonoGameSettings settings)
        {
            if (!settings.MonoDataCollector)
            {
                return;
            }
            var monoGroup = app.MapGroup("/mono");

            monoGroup.MapGet("/EnumImages", async ([FromServices] MonoCollectorApiService webApiService) =>
            {
                var dto = await webApiService.EnumMonoImagesAsync().ConfigureAwait(false);
                return dto.GetOk();

            });
            monoGroup.MapPost("/EnumClasses", async ([FromBody] MonoPointerRequestDTO postDTO, [FromServices] MonoCollectorApiService webApiService) =>
            {
                var dto = await webApiService.EnumMonoClassesAsync(postDTO.Pointer).ConfigureAwait(false);
                return dto.GetOk();

            });
            monoGroup.MapPost("/EnumObjects", async ([FromBody] MonoPointerRequestDTO postDTO, [FromServices] MonoCollectorApiService webApiService) =>
            {
                var dto = await webApiService.EnumMonoObjectsAsync(postDTO.Pointer).ConfigureAwait(false);
                return dto.GetOk();

            });
            monoGroup.MapPost("/EnumClassDetail", async ([FromBody] MonoClassDetailRequestDTO postDTO, [FromServices] MonoCollectorApiService webApiService) =>
            {
                var dto = await webApiService.EnumMonoClassDetailAsync(postDTO.Pointer, postDTO.FieldOptions).ConfigureAwait(false);
                return dto.GetOk();
            });

        }
        private static void UseGameWebApi(this IEndpointRouteBuilder app, MonoGameSettings settings)
        {
            var gameGroup = app.MapGroup("/game").RequireCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            gameGroup.MapGet("/info", async ([FromServices] IGameWebApiControllers gameService) =>
            {
                var data = await gameService.GetSessionInfoAsync().ConfigureAwait(false);
                return data.GetOk();
            });

            if (!settings.Http)
            {
                return;
            }
            gameGroup.MapPost("/LoadResource", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.LoadResourceAsync().ConfigureAwait(false);
                return datas.GetOk();

            });


            gameGroup.MapPost("/GetListCurrencyDisplay", async (/*HttpContext context,*/ [FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListCurrencyDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/GetCurrencyInfo", async ([FromBody] GameCurrencyObjectDTO currencyObjectDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                currencyObjectDTO.ThrowIfGameSessionDiff();
                var data = await gameService.GetCurrencyInfoAsync(currencyObjectDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/UpdateCurrencyInfo", async ([FromBody] GameCurrencyModifyDTO gameCurrency, [FromServices] IGameWebApiControllers gameService) =>
            {
                gameCurrency.ThrowIfGameSessionDiff();
                var data = await gameService.UpdateCurrencyInfoAsync(gameCurrency).ConfigureAwait(false);
                return data.GetOk();
            });

            gameGroup.MapPost("/GetListInventoryDisplay", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListInventoryDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/GetInventoryInfo", async ([FromBody] GameInventoryObjectDTO inventoryObjectDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                inventoryObjectDTO.ThrowIfGameSessionDiff();
                var data = await gameService.GetInventoryInfoAsync(inventoryObjectDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/UpdateInventoryInfo", async ([FromBody] GameInventoryModifyDTO gameInventory, [FromServices] IGameWebApiControllers gameService) =>
            {
                gameInventory.ThrowIfGameSessionDiff();
                var data = await gameService.UpdateInventoryInfoAsync(gameInventory).ConfigureAwait(false);
                return data.GetOk();
            });

            gameGroup.MapPost("/GetListCharacterDisplay", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListCharacterDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/GetCharacterStatus", async ([FromBody] GameCharacterObjectDTO characterObjectDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterObjectDTO.ThrowIfGameSessionDiff();

                var data = await gameService.GetCharacterStatusAsync(characterObjectDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/UpdateCharacterStatus", async ([FromBody] GameCharacterModifyDTO characterModifyDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterModifyDTO.ThrowIfGameSessionDiff();
                var data = await gameService.UpdateCharacterStatusAsync(characterModifyDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/GetCharacterEquipment", async ([FromBody] GameCharacterObjectDTO characterObjectDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterObjectDTO.ThrowIfGameSessionDiff();

                var data = await gameService.GetCharacterEquipmentAsync(characterObjectDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/GetCharacterSkill", async ([FromBody] GameCharacterObjectDTO characterObjectDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterObjectDTO.ThrowIfGameSessionDiff();

                var data = await gameService.GetCharacterSkillAsync(characterObjectDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/UpdateCharacterSkill", async ([FromBody] GameCharacterModifyDTO characterModifyDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterModifyDTO.ThrowIfGameSessionDiff();
                var data = await gameService.UpdateCharacterSkillAsync(characterModifyDTO).ConfigureAwait(false);
                return data.GetOk();
            });
            gameGroup.MapPost("/UpdateCharacterEquipment", async ([FromBody] GameCharacterModifyDTO characterModifyDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                characterModifyDTO.ThrowIfGameSessionDiff();
                var data = await gameService.UpdateCharacterEquipmentAsync(characterModifyDTO).ConfigureAwait(false);
                return data.GetOk();
            });

            gameGroup.MapPost("/GetListMonsterDisplay", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListMonsterDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/AddMonsterMember", async ([FromBody] GameMonsterObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.AddMonsterMemberAsync(requestDTO).ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/GetListSkillDisplay", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListSkillDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/AddSkillDisplay", async ([FromBody] GameSkillObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.AddSkillDisplayAsync(requestDTO).ConfigureAwait(false);
                return datas.GetOk();
            });



            gameGroup.MapPost("/GetListSwitchDisplay", async ([FromBody] GameSessionObjectDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.GetListSwitchDisplayAsync().ConfigureAwait(false);
                return datas.GetOk();
            });
            gameGroup.MapPost("/UpdateSwitchDisplay", async ([FromBody] GameSwitchModifyDTO requestDTO, [FromServices] IGameWebApiControllers gameService) =>
            {
                requestDTO.ThrowIfGameSessionDiff();
                var datas = await gameService.UpdateSwitchDisplayAsync(requestDTO).ConfigureAwait(false);
                return datas.GetOk();
            });

        }

    }
}
