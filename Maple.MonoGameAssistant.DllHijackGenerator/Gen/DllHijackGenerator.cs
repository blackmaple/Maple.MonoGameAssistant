using Maple.MonoGameAssistant.DllHijackData;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{

    [Generator(LanguageNames.CSharp)]
    public class DllHijackGenerator : IIncrementalGenerator
    {



        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
        //    Debugger.Launch();

            try
            {

                var provider = context.SyntaxProvider.ForAttributeWithMetadataName(
             fullyQualifiedMetadataName: typeof(DllHijackAttribute).FullName,
             predicate: (node, cancellationToken_) => node is ClassDeclarationSyntax,
             transform: (ctx, cancellationToken) =>
             {
                 ISymbol classSymbol = ctx.TargetSymbol;
                 return classSymbol.GetAttributes().Select(p => p.GetDllHijackData(classSymbol)).ToArray();
             });



                var apiFiles = context.AdditionalTextsProvider.Where(file => file.Path.EndsWith(".api", StringComparison.OrdinalIgnoreCase)).Collect();
                var datas = provider.Combine(apiFiles);

                context.RegisterSourceOutput(datas, (p, t) =>
                {
                    foreach (var dllHijackData in t.Left)
                    {
                        dllHijackData.AddApis(t.Right);

                        if (dllHijackData.Apis.Count != 0)
                        {
                            var fileContent = dllHijackData.OutputApis();
                            p.AddSource($"{dllHijackData.ClassName}.g.cs", fileContent);
                        }
                    }
                });

            }
            catch (DllHijackException)
            {

                // context.ReportDiagnostic(Diagnostic.Create(DllHijackException.V1Error, Location.None, msg));
            }
            catch (Exception)
            {
                // context.ReportDiagnostic(Diagnostic.Create(DllHijackException.V1Exception, Location.None, ex));
            }

        }
    }
}
