using Maple.MonoGameAssistant.DllHijackData;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.DllHijackGenerator
{
    public static class DllHijackSyntaxReceiverHelper
    {
        static T GetAttributeValue_NamedArgs<T>(this AttributeData attributeData, string name, T def)
        {
            var nVal = attributeData.NamedArguments.FirstOrDefault(p => p.Key == name).Value;
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.Values is T arr)
                {
                    return arr;
                }
            }
            else if (nVal.Value is T val2)
            {
                return val2;
            }
            return def;
        }

        static bool TryGetAttributeValue_CtorArgs<T>(this AttributeData attributeData, int index, out T val)
        {
            Unsafe.SkipInit(out val);
            var nVal = attributeData.ConstructorArguments.ElementAtOrDefault(index);
            if (nVal.Kind == TypedConstantKind.Array)
            {
                if (nVal.Values is T arr)
                {
                    val = arr;
                    return true;
                }
            }
            else if (nVal.Value is T val2)
            {
                val = val2;
                return true;
            }

            return false;
        }


        public static DllHijackData GetDllHijackData(this AttributeData attributeData, ISymbol classSymbol)
        {
            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out string fileName))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackAttribute)}.{nameof(DllHijackAttribute.FileName)}");
            }
            if (false == attributeData.TryGetAttributeValue_CtorArgs(1, out bool system))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackAttribute)}.{nameof(DllHijackAttribute.System)}");
            }
            if (false == attributeData.TryGetAttributeValue_CtorArgs(2, out string dllName))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackAttribute)}.{nameof(DllHijackAttribute.DllName)}");
            }
            if (false == (classSymbol is INamedTypeSymbol namedTypeSymbol) || namedTypeSymbol.IsStatic == false)
            {
                throw new DllHijackException($"ERROR {classSymbol.ToDisplayString()}");
            }

            string nameGetModuleHandle = string.Empty;
            string nameGetProcAddress = string.Empty;
            string nameJump = string.Empty;
            foreach (var member in namedTypeSymbol.GetMembers())
            {
                if (member is IMethodSymbol methodSymbol && methodSymbol.IsStatic)
                {
                    //GetModuleHandle
                    if (methodSymbol.ReturnType.SpecialType == SpecialType.System_IntPtr
                        && methodSymbol.Parameters.Length == 2
                        && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_Boolean
                        && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_String)
                    {
                        nameGetModuleHandle = methodSymbol.Name;
                    }

                    //GetProcAddress
                    else if (methodSymbol.ReturnType.SpecialType == SpecialType.System_IntPtr
                        && methodSymbol.Parameters.Length == 2
                        && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_IntPtr
                        && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_String)
                    {
                        nameGetProcAddress = methodSymbol.Name;
                    }
                    //Jump
                    else if (methodSymbol.ReturnsVoid
                         && methodSymbol.Parameters.Length == 2
                         && methodSymbol.Parameters[0].Type.TypeKind == TypeKind.FunctionPointer
                         && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_IntPtr)
                    {
                        nameJump = methodSymbol.Name;
                    }

                }
            }

            if (string.IsNullOrEmpty(nameGetModuleHandle))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackData)}.{nameof(DllHijackData.GetModuleHandle)}");
            }
            if (string.IsNullOrEmpty(nameGetProcAddress))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackData)}.{nameof(DllHijackData.GetProcAddress)}");
            }
            if (string.IsNullOrEmpty(nameJump))
            {
                throw new DllHijackException($"NOT FOUND {nameof(DllHijackData)}.{nameof(DllHijackData.Jump)}");
            }
            return new DllHijackData()
            {
                ClassName = classSymbol.Name,
                ClassFullName = classSymbol.ToDisplayString(),
                ClassNamespace = classSymbol.ContainingNamespace.ToDisplayString(),
                DeclaredAccessibility = classSymbol.DeclaredAccessibility == Accessibility.Public ? "public" : "internal",

                GetModuleHandle = nameGetModuleHandle,
                GetProcAddress = nameGetProcAddress,
                Jump = nameJump,


                FileName = fileName,
                System = system,
                DllName = dllName
            };
        }
    }
}
