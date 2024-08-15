using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.StaticFiles;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;

namespace Maple.MonoGameAssistant.WebApi
{
    public class WebApiBaseService
    {

        WebApplicationBuilder SlimBuilder { get; }
        IServiceCollection ServiceDescriptors => SlimBuilder.Services;
        MonoGameSettings Settings { get; }



        //   [RequiresUnreferencedCode("This functionality is not compatible with trimming. Use 'MethodFriendlyToTrimming' instead")]
        public WebApiBaseService(string gameName = "Test", string? qq = default)
        {
            this.SlimBuilder = WebApplication.CreateSlimBuilder();
            this.Settings = this.ConfigureMonoGameSettings(gameName, qq);
        }

        //    [RequiresUnreferencedCode("This functionality is not compatible with trimming. Use 'MethodFriendlyToTrimming' instead")]
        private MonoGameSettings ConfigureMonoGameSettings(string gameName, string? qq = default)
        {
            var settings = SlimBuilder.Configuration.GetSection(nameof(MonoGameSettings)).Get<MonoGameSettings>();
            settings ??= new MonoGameSettings()
            {
                MonoDataCollector = true,
                NamedPipe = true,
                Http = false,
                IndexPage = "/index.html"

            };
            settings.GameName = gameName;
            settings.QQ = qq;
            settings.GamePath = this.SlimBuilder.Environment.ContentRootPath;
            settings.WebRootPath = this.SlimBuilder.Environment.WebRootPath;
            this.ServiceDescriptors.AddSingleton(settings);
            return settings;
        }


        private void ConfigureListenIP()
        {
            if (this.Settings.Http && this.Settings.TryGetRandomPort(out var port))
            {
                this.Settings.BaseAddress = $"http://localhost:{port}";
                SlimBuilder.WebHost.UseKestrel(p => p.ListenAnyIP(port));
            }
        }


        private void ConfigureListenNamedPipe()
        {
            if (this.Settings.NamedPipe)
            {
                this.SlimBuilder.WebHost.UseKestrel(p =>
                {
                    p.ListenNamedPipe(MonoJsonExtensions.GetPipeName(Process.GetCurrentProcess()));
                });
            }
        }

        private void ConfigureMonoGameService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GameService>()
              where T_GameService : class, IMapleGameService, IGameWebApiControllers
        {
            this.ServiceDescriptors.AddMonoRT();
            this.ServiceDescriptors.AddLogging(p => p.AddOnlyMonoLogger());
            this.ServiceDescriptors.AddGameHostedService<T_GameService>();
            this.ServiceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<T_GameService>());

        }


        private void ConfigureHttpService()
        {
            ServiceDescriptors.ConfigureHttpJsonOptions(jsonOptions =>
            {
                jsonOptions.SerializerOptions.AddMonoJsonContext();
                jsonOptions.SerializerOptions.TypeInfoResolverChain.Insert(0, GameJsonContext.Default);
            });
            ServiceDescriptors.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
            });
            ServiceDescriptors.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });
            ServiceDescriptors.AddCors();

            ServiceDescriptors.AddTryCatchService(this.Settings.IndexPage ?? "/index.html", ["/mono", "/game"]);
        }
        private WebApplication ConfigureWebApplication()
        {
            var app = SlimBuilder.Build();
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

            //app.Use(async (ctx, next) =>
            //{
            //    if (ctx.Request.Method.Equals("options", StringComparison.InvariantCultureIgnoreCase) && ctx.Request.Headers.ContainsKey("Access-Control-Request-Private-Network"))
            //    {
            //        ctx.Response.Headers.TryAdd("Access-Control-Allow-Private-Network", "true");
            //    }

            //    await next();
            //});
            app.UseCors();

            UseWebApi(app);

            return app;
        }

        internal Task RunAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GameService>()
            where T_GameService : class, IMapleGameService, IGameWebApiControllers
        {
            this.ConfigureListenNamedPipe();
            this.ConfigureListenIP();
            this.ConfigureMonoGameService<T_GameService>();
            this.ConfigureHttpService();
            var app = this.ConfigureWebApplication();
            return app.RunAsync();

        }

        public async Task LazyRunAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GameService>(int millisecondsDelay = 2500)
            where T_GameService : class, IMapleGameService, IGameWebApiControllers
        {
            var logger = MonoLoggerExtensions.DefaultProvider.CreateLogger(typeof(T_GameService).FullName ?? typeof(T_GameService).Name);
            using (logger.Running())
            {
                try
                {
                    //     logger.LogInformation("port=>{p}", this.Settings.Port.ToString());
                    await Task.Delay(millisecondsDelay).ConfigureAwait(false);
                    await this.RunAsync<T_GameService>().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
            }
        }

        private void UseWebApi(IEndpointRouteBuilder app)
        {
            this.UseGameWebApi(app);
            this.UseEnumMonoWebApi(app);
        }
        private void UseEnumMonoWebApi(IEndpointRouteBuilder app)
        {
            if (!this.Settings.MonoDataCollector)
            {
                return;
            }
            var monoGroup = app.MapGroup("/mono");

            monoGroup.MapGet("/EnumImages", ([FromServices] MonoRuntimeContext runtimeContext) =>
            {
                using var webApiService = runtimeContext.CreateWebApiService();
                return webApiService.Api_EnumMonoImages().GetOk();

            });
            monoGroup.MapPost("/EnumClasses", ([FromBody] MonoPointerRequestDTO postDTO, [FromServices] MonoRuntimeContext runtimeContext) =>
            {
                using var webApiService = runtimeContext.CreateWebApiService();
                return webApiService.Api_EnumMonoClasses(postDTO.Pointer).GetOk();

            });
            monoGroup.MapPost("/EnumObjects", ([FromBody] MonoPointerRequestDTO postDTO, [FromServices] MonoRuntimeContext runtimeContext) =>
            {
                using var webApiService = runtimeContext.CreateWebApiService();
                return webApiService.Api_EnumMonoObjects(postDTO.Pointer).GetOk();

            });
            monoGroup.MapPost("/EnumClassDetail", ([FromBody] MonoClassDetailRequestDTO postDTO, [FromServices] MonoRuntimeContext runtimeContext) =>
            {
                using var webApiService = runtimeContext.CreateWebApiService();
                return webApiService.Api_EnumMonoClassDetail(postDTO.Pointer, postDTO.FieldOptions).GetOk();
            });

        }
        private void UseGameWebApi(IEndpointRouteBuilder app)
        {
            var gameGroup = app.MapGroup("/game").RequireCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            gameGroup.MapGet("/info", async ([FromServices] IGameWebApiControllers gameService) =>
            {
                var data = await gameService.GetSessionInfoAsync().ConfigureAwait(false);
                return data.GetOk();
            });

            if (!this.Settings.Http)
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
