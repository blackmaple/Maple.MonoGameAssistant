using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    [Generator]
    class MonoCollectorGeneratorV2 : ISourceGenerator
    {

        public void Initialize(GeneratorInitializationContext context)
        {
     //       System.Diagnostics.Debugger.Launch();
            context.RegisterForSyntaxNotifications(() => new MonoCollectorSyntaxReceiver());

        }

        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                if (!(context.SyntaxContextReceiver is MonoCollectorSyntaxReceiver receiver))
                {
                    return;
                }

                foreach (var optionsData in receiver.CollectorOptionsDatas)
                {
                    foreach (var verData in optionsData.VersionDatas)
                    {
                        foreach (var typeData in verData.TypeDatas)
                        {
                            context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, $"正在生成:{verData.CustomClassFullName}.{typeData.ClassFullName}..."));

                            var fileContent = typeData.OutputCurrTypeClassContent(optionsData);
                            context.AddSource($"{typeData.ClassName}.g.cs", fileContent);
                            //className.g.cs
                        }

                        context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, $"正在生成:{verData.CustomClassFullName}..."));
                        var contextFile = optionsData.OutputTypeClassesContext_Ver(verData);
                        context.AddSource($"{verData.CustomClassName}.g.cs", contextFile);
                        //optionsData.g.cs

                    }


                }
                context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Info, Location.None, "MonoCollectorGeneratorV2源生成器执行完毕了..."));

            }
            catch (MonoCollectorGeneratorV2Exception msg)
            {
                context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Error, Location.None, msg));
            }
            catch (Exception ex)
            {
                context.ReportDiagnostic(Diagnostic.Create(MonoCollectorGeneratorV2Exception.V2Exception, Location.None, ex));
            }
        }

    }


}
