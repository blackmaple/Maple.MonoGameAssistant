using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    [Generator]
    class MonoCollectorGeneratorV2 : IIncrementalGenerator
    {

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
  //        System.Diagnostics.Debugger.Launch();
            //  context.RegisterForSyntaxNotifications(() => new MonoCollectorSyntaxReceiver());
            try
            {
                var genOptions = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(MonoCollectorOptionsAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return ctx.Attributes[0].GetMonoCollectorOptionsData_NET9(ctx.TargetSymbol);
                });
                var settingsClasses = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(MonoCollectorTypeAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    var verDatas = ctx.TargetSymbol.CreateMonoCollectorVersionData_NET9();
                    var typeDatas = ctx.Attributes.Select(p => p.CreateMonoCollectorTypeSettings_NET9()).ToArray();
                    verDatas.TypeDatas.AddRange(typeDatas);
                    return verDatas;
                }).Collect();
                var genContenxt = genOptions.Combine(settingsClasses);
                //output genContext
                context.RegisterSourceOutput(genContenxt, (ctx, p) =>
                {
                    var l_genOptions = p.Left;
                    var genSourceContent = l_genOptions.OutputTypeClassesContext_Master_NET9();
                    ctx.AddSource($"{l_genOptions.CustomClassName}.master.cs", genSourceContent);


                    var r_settingsClasses = p.Right;

                    //兼容下
                    if (r_settingsClasses.Length >0)
                    {
                        l_genOptions.VersionDatas.AddRange(r_settingsClasses);
                        foreach (var settings in r_settingsClasses)
                        {
                            foreach (var type in settings.TypeDatas)
                            {
                                var typeSourceContent = type.OutputCurrTypeClassContent_Master_NET9(l_genOptions);
                                ctx.AddSource($"{type.ClassName}.master.cs", typeSourceContent);
                            }
                            var verSourceContent = l_genOptions.OutputTypeClassesContext_Detail_NET9(settings);
                            ctx.AddSource($"{settings.CustomClassName}.detail.cs", verSourceContent);
                        }
                    }

                });


                var typeClasses = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(MonoCollectorSettingsAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                {
                    return ctx.TargetSymbol.CreateMonoCollectorTypeData_NET9();
                }).Collect();

                var typeCollectDatas = genOptions.Combine(typeClasses);
                //output typeClass
                context.RegisterSourceOutput(typeCollectDatas, (ctx, p) =>
                {
                    var l_genOptions = p.Left;
                    var r_typeClasses = p.Right;
                    foreach (var type in r_typeClasses)
                    {
                        var typeSourceContent = type.OutputCurrTypeClassContent_Detail_NET9(l_genOptions);
                        ctx.AddSource($"{type.ClassName}.detail.cs", typeSourceContent);
                    }
                });

                //var typeClasses_1 = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(MonoCollectorSettingsAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                //{
                //    return ctx.TargetSymbol;
                //});
                //var typeClasses_2 = context.SyntaxProvider.ForAttributeWithMetadataName(typeof(MonoCollectorSearchFieldAttribute).FullName, (node, _) => node is ClassDeclarationSyntax, (ctx, _) =>
                //{
                //    return ctx.TargetSymbol;
                //});
                ////MonoCollectorVTableMethodAttribute
                ////MonoCollectorMethodAttribute
                ////MonoCollectorBaseAddressAttribute
                //context.RegisterSourceOutput(genContenxt, (ctx, p) =>
                //{
                //    var l_genOptions = p.Left;
                //    var r_settingsClasses = p.Right;

                //    foreach (var settings in r_settingsClasses)
                //    {
                //        foreach (var type in settings.TypeDatas)
                //        {
                //            var typeSourceContent = type.OutputCurrTypeClassContent_Master_NET9(l_genOptions);
                //            ctx.AddSource($"{type.ClassName}.master.cs", typeSourceContent);
                //        }
                //        var verSourceContent = l_genOptions.OutputTypeClassesContext_NET9(settings);
                //        ctx.AddSource($"{settings.CustomClassName}.g.cs", verSourceContent);
                //    }
                //});
            }
            catch (MonoCollectorGeneratorV2Exception)
            {

            }
            catch (Exception)
            {

            }
        }

        //public void Execute(GeneratorExecutionContext context)
        //{
        //    try
        //    {
        //        if (!(context.SyntaxContextReceiver is MonoCollectorSyntaxReceiver receiver))
        //        {
        //            return;
        //        }

        //        foreach (var optionsData in receiver.CollectorOptionsDatas)
        //        {
        //            foreach (var verData in optionsData.VersionDatas)
        //            {
        //                foreach (var typeData in verData.TypeDatas)
        //                {
        //                    context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, $"正在生成:{verData.CustomClassFullName}.{typeData.ClassFullName}..."));

        //                    var fileContent = typeData.OutputCurrTypeClassContent(optionsData);
        //                    context.AddSource($"{typeData.ClassName}.g.cs", fileContent);
        //                    //className.g.cs
        //                }

        //                context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, $"正在生成:{verData.CustomClassFullName}..."));
        //                var contextFile = optionsData.OutputTypeClassesContext_Ver(verData);
        //                context.AddSource($"{verData.CustomClassName}.g.cs", contextFile);
        //                //optionsData.g.cs

        //            }


        //        }
        //        context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, "MonoCollectorGeneratorV2源生成器执行完毕了..."));

        //    }
        //    catch (MonoCollectorGeneratorV2Exception msg)
        //    {
        //        context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Error, Location.None, msg));
        //    }
        //    catch (Exception ex)
        //    {
        //        context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Exception, Location.None, ex));
        //    }
        //}

    }


}
