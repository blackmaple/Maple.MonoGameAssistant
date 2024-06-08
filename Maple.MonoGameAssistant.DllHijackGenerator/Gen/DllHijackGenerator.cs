using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;
using System.Linq;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{

    [Generator]
    public class DllHijackGenerator : ISourceGenerator
    {

        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                if (!(context.SyntaxContextReceiver is DllHijackSyntaxReceiver receiver))
                {
                    return;
                }
                foreach (var dllHijackData in receiver.DllHijackDatas)
                {
                    dllHijackData.AddApis(context.AdditionalFiles);
                    context.LogInfo($"{dllHijackData.ClassFullName}::{dllHijackData.Apis.Count}");
                    if (dllHijackData.Apis.Count != 0)
                    {
                        var fileContent = dllHijackData.OutputApis();
                        context.AddSource($"{dllHijackData.ClassName}.g.cs", fileContent);
                    }
                }
                context.LogInfo("DllHijackGenerator源生成器执行完毕了...");

            }
            catch (DllHijackException msg)
            {
                context.ReportDiagnostic(Diagnostic.Create(DllHijackException.V1Error, Location.None, msg));
            }
            catch (Exception ex)
            {
                context.ReportDiagnostic(Diagnostic.Create(DllHijackException.V1Exception, Location.None, ex));
            }

        }

        public void Initialize(GeneratorInitializationContext context)
        {
            //Debugger.Launch();
            context.RegisterForSyntaxNotifications(() => new DllHijackSyntaxReceiver());

        }
    }
}
