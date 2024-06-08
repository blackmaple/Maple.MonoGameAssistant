using Maple.MonoGameAssistant.DllHijackData;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{
    public class DllHijackSyntaxReceiver : ISyntaxContextReceiver
    {
        public List<DllHijackData> DllHijackDatas { get; } = new List<DllHijackData>();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax classDeclaration)
            {
                if (false == classDeclaration.AttributeLists.Any())
                {
                    return;
                }

                var classSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);
                var genOptions = classSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(DllHijackAttribute).FullName);
                if (genOptions is null)
                {
                    return;
                }

                var data = genOptions.GetDllHijackData(classSymbol);
                DllHijackDatas.Add(data);
            }

        }
    }
}
