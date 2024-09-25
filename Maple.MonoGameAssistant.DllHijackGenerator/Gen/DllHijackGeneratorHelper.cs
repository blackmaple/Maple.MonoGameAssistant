using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{
    public static class DllHijackGeneratorHelper
    {
        //public static void LogInfo(this GeneratorExecutionContext context, string info)
        //{
        //    context.ReportDiagnostic(Diagnostic.Create(DllHijackException.V1Info, Location.None, $"DllHijackGenerator=>{info}"));

        //}
        static IEnumerable<string> ReadAllApi(this AdditionalText additionalText)
        {
            var file = new FileInfo(additionalText.Path);
            if (file.Exists == false)
            {
                throw new DllHijackException($"NOT FOUND {additionalText.Path}");
            }
            using (var fileStream = file.OpenRead())
            {
                using (var reader = new StreamReader(fileStream))
                {
                    while (reader.EndOfStream == false)
                    {
                        yield return reader.ReadLine();
                    }
                }
            }
        }
        public static void AddApis(this DllHijackData dllHijackData, ImmutableArray<AdditionalText> additionalTexts)
        {
            foreach (var additionalText in additionalTexts)
            {
                if (Path.GetFileName(additionalText.Path).Equals(dllHijackData.FileName, System.StringComparison.OrdinalIgnoreCase))
                {
                    dllHijackData.Apis.AddRange(additionalText.ReadAllApi());
                }
            }
        }


        const string DisplayName_PtrHeader = "ptr_";
        const string DisplayName_PartialClass = "partial class";



        static string BuildFuncStruct(this string apiName)
        {
            
            return $@"
        /// <summary>
        /// {apiName}
        /// </summary>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = ""{apiName}"")]
        public static nint {apiName}() => nint.Zero;";
        }
        static string BuildFuncStructContent(this DllHijackData dllHijackData)
        {
            return string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), dllHijackData.Apis.Select(p => p.BuildFuncStruct()));
        }

        static string BuildLoadApi(this string apiName, DllHijackData dllHijackData)
        {
            return $@"
            var {DisplayName_PtrHeader}{apiName} = {dllHijackData.GetProcAddress}({dllHijackData.ModuleHandle}, ""{apiName}"");
            {dllHijackData.Jump}(&{apiName}, {DisplayName_PtrHeader}{apiName});
        ";
        }
        static string BuildLoadApiContent(this DllHijackData dllHijackData)
        {
            var loadContent = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), dllHijackData.Apis.Select(p => p.BuildLoadApi(dllHijackData)));
            return $@"
        public static unsafe void LoadApis()
        {{
            var {dllHijackData.ModuleHandle} = {dllHijackData.GetModuleHandle}({dllHijackData.System.ToString().ToLower()}, ""{dllHijackData.DllName}"");
            
            {loadContent}
        }}
        ";
        }

        //static string BuildJumpApi(this DllHijackData dllHijackData, string apiName)
        //{

        //}

        public static string OutputApis(this DllHijackData dllHijackData)
        {
            var funcContent = dllHijackData.BuildFuncStructContent();
            var loadContent = dllHijackData.BuildLoadApiContent();

            return $@"
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace {dllHijackData.ClassNamespace}
{{
    {dllHijackData.DeclaredAccessibility} static {DisplayName_PartialClass} {dllHijackData.ClassName} 
    {{
        {funcContent}

        {loadContent}

    }}
}}";
        }

    }

}
