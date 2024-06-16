using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    static class MonoCollectorSyntaxReceiverHelper
    {
        #region 帮助类->从指定特性的构造函数 & 成员获取需要的参数
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
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                return (T)nVal.Value;
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
            else if (nVal.Kind == TypedConstantKind.Enum)
            {
                val = (T)nVal.Value;
                return true;
            }
            else if (nVal.Value is T val2)
            {
                val = val2;
                return true;
            }

            return false;
        }

        static IEnumerable<T> ReadImmutableArray<T>(this ImmutableArray<TypedConstant> offsetSymbols)
            where T : struct
        {
            if (offsetSymbols.IsDefaultOrEmpty)
            {
                yield break;
            }
            foreach (var subMember in offsetSymbols)
            {
                if (subMember.Value is T val)
                {
                    yield return val;
                }
            }

        }

        static string ArrayDisplay<T>(this IEnumerable<T> arr)
            where T : struct
        {
            return $@"[{string.Join(", ", arr)}]";
        }
        #endregion

        #region MonoCollectorOptionsAttribute获取源生成器需要的对象
        public static MonoCollectorOptionsData GetMonoCollectorOptionsData(this AttributeData genOptions, ISymbol classSymbol)
        {
            var collectorOptionsData = genOptions.CreateMonoCollectorOptionsData();
            collectorOptionsData.CustomClassName = classSymbol.Name;
            collectorOptionsData.CustomClassNamespace = classSymbol.ContainingNamespace.ToDisplayString();
            collectorOptionsData.CustomClassFullName = classSymbol.ToDisplayString();

            collectorOptionsData.VersionDatas.AddRange(GetMonoCollectorVersionData(classSymbol));

            return collectorOptionsData;
        }

        static IEnumerable<MonoCollectorVersionData> GetMonoCollectorVersionData(ISymbol classSymbol)
        {

            List<MonoCollectorTypeData> listTypeData = new List<MonoCollectorTypeData>(256);
            List<MonoCollectorVersionData> versionDatas = new List<MonoCollectorVersionData>(256)
            {
                classSymbol.CreateMonoCollectorVersionData(EnumMonoCollectorTypeVersion.Ver_Common)
            };

            foreach (var att in classSymbol.GetAttributes())
            {
                if (att.AttributeClass.ToDisplayString() == typeof(MonoCollectorTypeAttribute).FullName)
                {
                    listTypeData.Add(att.CreateMonoCollectorTypeData());
                }
                else if (att.AttributeClass.ToDisplayString() == typeof(MonoCollectorTypeVersionAttribute).FullName)
                {
                    var verData = att.CreateMonoCollectorVersionData();
                    versionDatas.Add(verData);
                }
            }


            foreach (var verData in versionDatas)
            {
                var typeData = listTypeData.Where(p => p.Ver == verData.Ver).ToArray();

                verData.TypeDatas.AddRange(typeData);
                //???过滤???
                yield return verData;
            }


        }


        static MonoCollectorOptionsData CreateMonoCollectorOptionsData(this AttributeData attributeData)
        {
            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out INamedTypeSymbol MonoCollectorContext))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorOptionsAttribute)}.{nameof(MonoCollectorOptionsAttribute.MonoCollectorContext)}");
            }
            if (MonoCollectorContext.Name != nameof(MonoCollectorOptionsData.MonoCollectorContext))
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorContext.Name}!={nameof(MonoCollectorOptionsAttribute.MonoCollectorContext)}");
            }

            if (false == attributeData.TryGetAttributeValue_CtorArgs(1, out INamedTypeSymbol MonoCollectorMember))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorOptionsAttribute)}.{nameof(MonoCollectorOptionsAttribute.MonoCollectorMember)}");
            }
            if (MonoCollectorMember.Name != nameof(MonoCollectorOptionsData.MonoCollectorMember))
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorMember.Name}!={nameof(MonoCollectorOptionsAttribute.MonoCollectorMember)}");
            }

            if (false == attributeData.TryGetAttributeValue_CtorArgs(2, out INamedTypeSymbol MonoRuntimeContext))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorOptionsAttribute)}.{nameof(MonoCollectorOptionsAttribute.MonoRuntimeContext)}");
            }
            if (MonoRuntimeContext.Name != nameof(MonoCollectorOptionsData.MonoRuntimeContext))
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoRuntimeContext.Name}!={nameof(MonoCollectorOptionsAttribute.MonoRuntimeContext)}");
            }

            //if (false == attributeData.TryGetAttributeValue_CtorArgs(3, out INamedTypeSymbol MonoCollectorImageInfo))
            //{
            //    throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorOptionsAttribute)}.{nameof(MonoCollectorOptionsAttribute.MonoCollectorImageInfo)}");
            //}
            //if (MonoCollectorImageInfo.Name != nameof(MonoCollectorOptionsData.MonoCollectorImageInfo))
            //{
            //    throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorImageInfo.Name}!={nameof(MonoCollectorOptionsAttribute.MonoCollectorImageInfo)}");
            //}

            if (false == attributeData.TryGetAttributeValue_CtorArgs(3, out INamedTypeSymbol MonoCollectorClassInfo))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorOptionsAttribute)}.{nameof(MonoCollectorOptionsAttribute.MonoCollectorClassInfo)}");
            }
            //if (MonoCollectorClassInfo.Name != nameof(MonoCollectorOptionsData.MonoCollectorClassInfo))
            //{

            //    throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorClassInfo.Name}!={nameof(MonoCollectorOptionsAttribute.MonoCollectorClassInfo)}");
            //}


            var MonoCollectorContext_Ctor = GetMonoCollectorContext_Ctor()
                ?? throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorContext.Name}.Ctor");

            var MonoCollectorContext_GetClassInfo = GetMonoCollectorContext_GetClassInfo()
                ?? throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(GetMonoCollectorContext_GetClassInfo)}");

            var MonoCollectorContext_ThrowException = GetMonoCollectorContext_ThrowException()
                ?? throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(GetMonoCollectorContext_ThrowException)}");


            var MonoCollectorMember_Ctor = GetMonoCollectorMember_Ctor()
                ?? throw new MonoCollectorGeneratorV2Exception($"ERROR {MonoCollectorMember.Name}.Ctor");

            GetMonoCollectorMember_Methods(
                out var MonoCollectorMember_GetStaticMethodInvokers,
                out var MonoCollectorMember_GetMethodPointers,
                out var MonoCollectorMember_PropertyDatas,
                out var MonoCollectorMember_InitMember,
                out var MonoCollectorMember_New,
                out var MonoCollectorMember_GetMonoStaticFieldValue,
                out var MonoCollectorMember_GetModuleBaseAddress,
                out var MonoCollectorMember_GetMemberFieldOffset,
                out var MonoCollectorMember_GetMemberFieldValue,
                out var MonoCollectorMember_SetMemberFieldValue);



            if (MonoCollectorMember_GetStaticMethodInvokers.Count == 0)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_GetStaticMethodInvokers)}");
            }
            if (MonoCollectorMember_GetMethodPointers.Count == 0)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_GetMethodPointers)}");
            }
            if (MonoCollectorMember_PropertyDatas.Count == 0)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_PropertyDatas)}");
            }
            if (MonoCollectorMember_InitMember == null)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_InitMember)}");
            }
            if (MonoCollectorMember_New.Count == 0)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_New)}");
            }
            if (MonoCollectorMember_GetMonoStaticFieldValue == null)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_GetMonoStaticFieldValue)}");
            }
            if (MonoCollectorMember_GetModuleBaseAddress == null)
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {MonoCollectorContext.Name}=>{nameof(MonoCollectorOptionsData.MonoCollectorMember_GetModuleBaseAddress)}");
            }

            return new MonoCollectorOptionsData()
            {

                MonoCollectorContext = MonoCollectorContext.ToDisplayString(),
                MonoCollectorContext_Ctor = MonoCollectorContext_Ctor,
                MonoCollectorContext_GetClassInfo = MonoCollectorContext_GetClassInfo,
                MonoCollectorContext_ThrowException = MonoCollectorContext_ThrowException,
                //MonoCollectorContext_PropertyDatas = MonoCollectorContext_PropertyDatas,
                //      MonoCollectorContext_CallbackCollectorImp = MonoCollectorContext_CallbackCollectorImp,

                MonoCollectorMember = MonoCollectorMember.ToDisplayString(),
                MonoCollectorMember_Ctor = MonoCollectorMember_Ctor,
                MonoCollectorMember_GetMethodPointers = MonoCollectorMember_GetMethodPointers.ToArray(),
                MonoCollectorMember_GetStaticMethodInvokers = MonoCollectorMember_GetStaticMethodInvokers.ToArray(),
                MonoCollectorMember_PropertyDatas = MonoCollectorMember_PropertyDatas.ToArray(),
                MonoCollectorMember_InitMember = MonoCollectorMember_InitMember,
                MonoCollectorMember_New = MonoCollectorMember_New.ToArray(),
                MonoCollectorMember_GetMonoStaticFieldValue = MonoCollectorMember_GetMonoStaticFieldValue,
                MonoCollectorMember_GetModuleBaseAddress = MonoCollectorMember_GetModuleBaseAddress,

                MonoCollectorMember_GetMemberFieldOffset = MonoCollectorMember_GetMemberFieldOffset,
                MonoCollectorMember_GetMemberFieldValue = MonoCollectorMember_GetMemberFieldValue,
                MonoCollectorMember_SetMemberFieldValue = MonoCollectorMember_SetMemberFieldValue,

                MonoRuntimeContext = MonoRuntimeContext.ToDisplayString(),
                //MonoCollectorImageInfo = MonoCollectorImageInfo.ToDisplayString(),
                //MonoCollectorClassInfo = MonoCollectorClassInfo.ToDisplayString(),

                //MonoImageInfoDTO = MonoImageInfoDTO.ToDisplayString(),
                //MonoClassInfoDTO = MonoClassInfoDTO.ToDisplayString(),
                //MonoFieldInfoDTO = MonoFieldInfoDTO.ToDisplayString(),
                //MonoMethodInfoDTO = MonoMethodInfoDTO.ToDisplayString(),
            };

            MonoCollectorMethodData GetMonoCollectorMethodData(IMethodSymbol methodSymbol)
            {
                var methodData = new MonoCollectorMethodData()
                {
                    MethodName = methodSymbol.Name,
                    ReturnData = new MonoCollectorMethodReturnData()
                    {
                        RefReturn = methodSymbol.RefKind.ToString(),
                        ReturnTypeName = methodSymbol.ReturnType.ToDisplayString()
                    }
                };
                foreach (var param in methodSymbol.Parameters)
                {
                    methodData.ParamDatas.Add(new MonoCollectorMethodParamData()
                    {
                        RefParam = param.RefKind.ToString(),
                        TypeName = param.Type.ToDisplayString(),
                        ParamName = param.Name
                    });
                }
                return methodData;

            }

            bool ExistsMonoCollectorFlagFlag(IMethodSymbol methodSymbol, EnumMonoCollectorFlag flag)
            {
                var att = methodSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorFlagAttribute).FullName);
                if (att is null)
                {
                    return false;
                }
                if (att.TryGetAttributeValue_CtorArgs<EnumMonoCollectorFlag>(0, out var collectorFlag))
                {
                    return collectorFlag == flag;
                }
                return false;
            }

            MonoCollectorMethodData GetMonoCollectorContext_Ctor()
            {
                foreach (var ctor in MonoCollectorContext.Constructors)
                {
                    if (ExistsMonoCollectorFlagFlag(ctor, EnumMonoCollectorFlag.ContextCtor))
                    {
                        return GetMonoCollectorMethodData(ctor);
                    }
                    //if (ctor.Parameters.Length == 3
                    //    && SymbolEqualityComparer.Default.Equals(ctor.Parameters[0].Type, MonoRuntimeContext)
                    //    && ctor.Parameters[1].Type.TypeKind == TypeKind.Enum
                    //     && ctor.Parameters[2].Type.TypeKind == TypeKind.Interface)
                    //{
                    //    return GetMonoCollectorMethodData(ctor);
                    //}
                }
                return default;
            }
            MonoCollectorMethodData GetMonoCollectorContext_GetClassInfo()
            {
                foreach (var member in MonoCollectorContext.GetMembers())
                {
                    if (member is IMethodSymbol methodSymbol)
                    {
                        if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetClassInfo))
                        {
                            return GetMonoCollectorMethodData(methodSymbol);
                        }
                        //if (SymbolEqualityComparer.Default.Equals(methodSymbol.ReturnType, MonoCollectorClassInfo))
                        //{
                        //    return GetMonoCollectorMethodData(methodSymbol);
                        //}
                    }

                }
                return default;
            }
            MonoCollectorMethodData GetMonoCollectorContext_ThrowException()
            {
                foreach (var member in MonoCollectorContext.GetMembers())
                {
                    if (member is IMethodSymbol methodSymbol)
                    {
                        if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.Throw))
                        {
                            return GetMonoCollectorMethodData(methodSymbol);
                        }
                        //if (methodSymbol.IsGenericMethod
                        // && methodSymbol.ReturnType.TypeKind == TypeKind.TypeParameter
                        // && methodSymbol.Parameters.Length > 0
                        // && methodSymbol.Parameters[0].Type.TypeKind == TypeKind.Enum)
                        //{
                        //    return GetMonoCollectorMethodData(methodSymbol);

                        //}
                    }

                }
                return default;
            }

            MonoCollectorMethodData GetMonoCollectorMember_Ctor()
            {
                foreach (var ctor in MonoCollectorMember.Constructors)
                {
                    if (ExistsMonoCollectorFlagFlag(ctor, EnumMonoCollectorFlag.MemberCtor))
                    {
                        return GetMonoCollectorMethodData(ctor);
                    }
                    //if (ctor.Parameters.Length == 2
                    //    && SymbolEqualityComparer.Default.Equals(ctor.Parameters[0].Type, MonoCollectorContext)
                    //    && SymbolEqualityComparer.Default.Equals(ctor.Parameters[1].Type, MonoCollectorClassInfo)
                    //    )
                    //{
                    //    return GetMonoCollectorMethodData(ctor);
                    //}
                }
                return default;

            }
            void GetMonoCollectorMember_Methods(
                out IList<MonoCollectorMethodData> _MonoCollectorMember_GetStaticMethodInvokers,
                out IList<MonoCollectorMethodData> _MonoCollectorMember_GetMethodPointers,
                out IList<MonoCollectorPropertyData> _MonoCollectorMember_PropertyDatas,
                out MonoCollectorMethodData _MonoCollectorMember_InitMember,
                out IList<MonoCollectorMethodData> _MonoCollectorMember_New,
                out MonoCollectorMethodData _MonoCollectorMember_GetMonoStaticFieldValue,
                out MonoCollectorMethodData _MonoCollectorMember_GetModuleBaseAddress,
                out MonoCollectorMethodData _MonoCollectorMember_GetMemberFieldOffset,
                out MonoCollectorMethodData _MonoCollectorMember_GetMemberFieldValue,
                out MonoCollectorMethodData _MonoCollectorMember_SetMemberFieldValue)
            {
                _MonoCollectorMember_GetStaticMethodInvokers = new List<MonoCollectorMethodData>();
                _MonoCollectorMember_InitMember = default;
                _MonoCollectorMember_New = new List<MonoCollectorMethodData>();
                _MonoCollectorMember_GetMonoStaticFieldValue = default;
                _MonoCollectorMember_GetModuleBaseAddress = default;
                _MonoCollectorMember_GetMethodPointers = new List<MonoCollectorMethodData>();
                _MonoCollectorMember_PropertyDatas = new List<MonoCollectorPropertyData>();

                _MonoCollectorMember_GetMemberFieldOffset = default;
                _MonoCollectorMember_GetMemberFieldValue = default;
                _MonoCollectorMember_SetMemberFieldValue = default;

                foreach (var member in MonoCollectorMember.GetMembers())
                {
                    var _GetStaticMethodInvoker = GetMonoCollectorMember_GetStaticMethodInvoker(member);
                    if (_GetStaticMethodInvoker != null)
                    {
                        _MonoCollectorMember_GetStaticMethodInvokers.Add(_GetStaticMethodInvoker);
                    }

                    var _GetMethodPointer = GetMonoCollectorMember_GetMethodPointer(member);
                    if (_GetMethodPointer != null)
                    {
                        _MonoCollectorMember_GetMethodPointers.Add(_GetMethodPointer);
                    }

                    var _PropertyData = GetMonoCollectorMember_PropertyData(member);
                    if (_PropertyData != null)
                    {
                        _MonoCollectorMember_PropertyDatas.Add(_PropertyData);
                    }

                    if (_MonoCollectorMember_InitMember == null)
                    {
                        _MonoCollectorMember_InitMember = GetMonoCollectorMember_InitMember(member);
                    }

                    var newMethod = GetMonoCollectorMember_New(member);
                    if (newMethod != null)
                    {
                        _MonoCollectorMember_New.Add(newMethod);
                    }

                    if (_MonoCollectorMember_GetMonoStaticFieldValue == null)
                    {
                        _MonoCollectorMember_GetMonoStaticFieldValue = GetMonoCollectorMember_GetMonoStaticFieldValue(member);

                    }

                    if (_MonoCollectorMember_GetModuleBaseAddress == null)
                    {
                        _MonoCollectorMember_GetModuleBaseAddress = GetMonoCollectorMember_GetModuleBaseAddress(member);
                    }

                    if (_MonoCollectorMember_GetMemberFieldOffset == null)
                    {
                        _MonoCollectorMember_GetMemberFieldOffset = GetMonoCollectorMember_GetMemberFieldOffset(member);
                    }

                    if (_MonoCollectorMember_GetMemberFieldValue == null)
                    {
                        _MonoCollectorMember_GetMemberFieldValue = GetMonoCollectorMember_GetMemberFieldValue(member);
                    }

                    if (_MonoCollectorMember_SetMemberFieldValue == null)
                    {
                        _MonoCollectorMember_SetMemberFieldValue = GetMonoCollectorMember_SetMemberFieldValue(member);
                    }
                }
            }

            MonoCollectorMethodData GetMonoCollectorMember_GetStaticMethodInvoker(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetStaticMethodInvoker))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (member.DeclaredAccessibility == Accessibility.Protected
                    //    && methodSymbol.ReturnType.IsValueType
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters.Length > 0
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String)
                    //{
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }
                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_GetMethodPointer(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetMethodPointer))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (member.DeclaredAccessibility == Accessibility.Protected
                    //    && methodSymbol.ReturnType.IsValueType
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters.Length > 0
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String)
                    //{
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }
                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_InitMember(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.InitMember))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (member.DeclaredAccessibility == Accessibility.Protected
                    //    && methodSymbol.ReturnsVoid
                    //    && methodSymbol.IsVirtual
                    //    && methodSymbol.Parameters.Length == 0)
                    //{
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_New(ISymbol member)
            {

                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.Ctor))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.DeclaredAccessibility == Accessibility.Public
                    //    && methodSymbol.IsGenericMethod
                    //    && methodSymbol.ReturnType.TypeKind == TypeKind.TypeParameter
                    //    && methodSymbol.ReturnType.IsUnmanagedType
                    //    && methodSymbol.Parameters.Length == 0)
                    //{
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }


                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_GetMonoStaticFieldValue(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetMonoStaticFieldValue))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.DeclaredAccessibility == Accessibility.Protected
                    //    && methodSymbol.IsGenericMethod
                    //    && methodSymbol.ReturnType.TypeKind == TypeKind.TypeParameter
                    //    && methodSymbol.ReturnType.IsUnmanagedType
                    //    && methodSymbol.Parameters.Length == 1
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String)
                    //{
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_GetModuleBaseAddress(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetModuleBaseAddress))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.IsStatic
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_Boolean
                    //    && methodSymbol.Parameters.Length == 2
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String
                    //    && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters[1].RefKind == RefKind.Out)
                    //{
                    //    //  MethodName = $@"{methodSymbol.ContainingSymbol.ToDisplayString()}.{methodSymbol.Name}",
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_GetMemberFieldOffset(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetMemberFieldOffset))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.IsStatic
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_Boolean
                    //    && methodSymbol.Parameters.Length == 2
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String
                    //    && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters[1].RefKind == RefKind.Out)
                    //{
                    //    //  MethodName = $@"{methodSymbol.ContainingSymbol.ToDisplayString()}.{methodSymbol.Name}",
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_GetMemberFieldValue(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.GetMemberFieldValue))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.IsStatic
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_Boolean
                    //    && methodSymbol.Parameters.Length == 2
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String
                    //    && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters[1].RefKind == RefKind.Out)
                    //{
                    //    //  MethodName = $@"{methodSymbol.ContainingSymbol.ToDisplayString()}.{methodSymbol.Name}",
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }
            MonoCollectorMethodData GetMonoCollectorMember_SetMemberFieldValue(ISymbol member)
            {
                if (member is IMethodSymbol methodSymbol)
                {
                    if (ExistsMonoCollectorFlagFlag(methodSymbol, EnumMonoCollectorFlag.SetMemberFieldValue))
                    {
                        return GetMonoCollectorMethodData(methodSymbol);
                    }
                    //if (methodSymbol.IsStatic
                    //    && methodSymbol.ReturnType.SpecialType == SpecialType.System_Boolean
                    //    && methodSymbol.Parameters.Length == 2
                    //    && methodSymbol.Parameters[0].Type.SpecialType == SpecialType.System_String
                    //    && methodSymbol.Parameters[1].Type.SpecialType == SpecialType.System_IntPtr
                    //    && methodSymbol.Parameters[1].RefKind == RefKind.Out)
                    //{
                    //    //  MethodName = $@"{methodSymbol.ContainingSymbol.ToDisplayString()}.{methodSymbol.Name}",
                    //    return GetMonoCollectorMethodData(methodSymbol);
                    //}
                }

                return default;
            }

            MonoCollectorPropertyData GetMonoCollectorMember_PropertyData(ISymbol member)
            {
                if (member is IPropertySymbol propertySymbol)
                {
                    if (SymbolEqualityComparer.Default.Equals(propertySymbol.Type, MonoRuntimeContext)
                        || SymbolEqualityComparer.Default.Equals(propertySymbol.Type, MonoCollectorClassInfo))
                    {
                        return new MonoCollectorPropertyData()
                        {
                            ReturnType = propertySymbol.Type.ToDisplayString(),
                            PropertyName = propertySymbol.Name,
                        };
                    }
                }

                return default;

            }

        }
        #endregion

        #region MonoCollectorTypeVersionAttribute获取需要处理的Class 
        static MonoCollectorVersionData CreateMonoCollectorVersionData(this AttributeData attributeData)
        {
            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out INamedTypeSymbol classSymbol))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorTypeVersionAttribute)}.{nameof(MonoCollectorTypeVersionAttribute.ClassType)}");
            }
            if (false == attributeData.TryGetAttributeValue_CtorArgs(1, out EnumMonoCollectorTypeVersion typeVersion))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorTypeVersionAttribute)}.{nameof(MonoCollectorTypeVersionAttribute.Ver)}");
            }
            return classSymbol.CreateMonoCollectorVersionData(typeVersion);
        }
        static MonoCollectorVersionData CreateMonoCollectorVersionData(this ISymbol classSymbol, EnumMonoCollectorTypeVersion typeVersion = EnumMonoCollectorTypeVersion.Ver_Common)
        {

            var className = classSymbol.Name;
            var classNamespace = classSymbol.ContainingNamespace.ToDisplayString();
            var classFullName = classSymbol.ToDisplayString();

            return new MonoCollectorVersionData()
            {
                CustomClassName = className,
                CustomClassNamespace = classNamespace,
                CustomClassFullName = classFullName,
                Ver = typeVersion,
            };
        }

        #endregion

        #region MonoCollectorTypeAttribute获取需要处理的Class->MonoCollectorSettingsAttribute获取Class信息
        static MonoCollectorTypeData CreateMonoCollectorTypeData(this AttributeData genType)
        {
            if (false == genType.TryGetAttributeValue_CtorArgs(0, out INamedTypeSymbol namedTypeSymbol))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorTypeAttribute)}.{nameof(MonoCollectorTypeAttribute.ClassType)}");
            }
            //排除泛型
            if (namedTypeSymbol.IsGenericType)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {namedTypeSymbol.ToDisplayString()}=>{nameof(namedTypeSymbol.IsGenericType)}");
            }
            var ver = genType.GetAttributeValue_NamedArgs(nameof(MonoCollectorTypeAttribute.Ver), EnumMonoCollectorTypeVersion.Ver_Common);
            return namedTypeSymbol.GetTypeClassSettings(ver);
        }
        static IEnumerable<MonoCollectorTypeData> EnumCurrContextTypeClasses(this AttributeData[] genTypes)
        {
            foreach (var genType in genTypes)
            {
                yield return genType.CreateMonoCollectorTypeData();
            }

        }
        static MonoCollectorTypeData GetTypeClassSettings(this INamedTypeSymbol namedTypeSymbol, EnumMonoCollectorTypeVersion ver = EnumMonoCollectorTypeVersion.Ver_Common)
        {
            var classAtts = namedTypeSymbol.GetAttributes();
            var classGenType = classAtts.Where(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorSettingsAttribute).FullName).FirstOrDefault()
            ?? throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute)}");


            string const_ImageName = default;
            string utf8_ImageName = default;

            if (false == classGenType.TryGetAttributeValue_CtorArgs<ImmutableArray<TypedConstant>>(0, out var arr_ImageName))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute.Const_ImageName)}");

            }
            var buffer_ImageName = arr_ImageName.ReadImmutableArray<byte>().ToArray();
            utf8_ImageName = buffer_ImageName.ArrayDisplay();
            const_ImageName = Encoding.UTF8.GetString(buffer_ImageName);


            string const_Namespace = default;
            string utf8_Namespace = default;

            string const_ClassName = default;
            string utf8_ClassName = default;

            var const_TypeToken = 0U;
            if (classGenType.ConstructorArguments.Length == 2)
            {
                if (false == classGenType.TryGetAttributeValue_CtorArgs(1, out const_TypeToken))
                {
                    const_TypeToken = classGenType.GetAttributeValue_NamedArgs(nameof(MonoCollectorSettingsAttribute.Const_TypeToken), const_TypeToken);
                }
                if (const_TypeToken == default)
                {
                    throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute.Const_TypeToken)}");
                }

                utf8_ClassName = utf8_Namespace = Array.Empty<byte>().ArrayDisplay();


            }
            else if (classGenType.ConstructorArguments.Length == 3)
            {
                if (false == classGenType.TryGetAttributeValue_CtorArgs<ImmutableArray<TypedConstant>>(1, out var arr_Namespace))
                {
                    throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute.Const_Namespace)}");

                }
                var buffer_Namespace = arr_Namespace.ReadImmutableArray<byte>().ToArray();
                utf8_Namespace = buffer_Namespace.ArrayDisplay();
                const_Namespace = Encoding.UTF8.GetString(buffer_Namespace);

                if (false == classGenType.TryGetAttributeValue_CtorArgs<ImmutableArray<TypedConstant>>(2, out var arr_ClassName))
                {
                    throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute.Const_ClassName)}");
                }
                var buffer_ClassName = arr_ClassName.ReadImmutableArray<byte>().ToArray();
                utf8_ClassName = buffer_ClassName.ArrayDisplay();
                const_ClassName = Encoding.UTF8.GetString(buffer_ClassName);

            }
            else
            {
                throw new MonoCollectorGeneratorV2Exception($"Error {namedTypeSymbol.ToDisplayString()}=>{nameof(MonoCollectorSettingsAttribute)}.{nameof(MonoCollectorSettingsAttribute)}");
            }


            var nameSpace = namedTypeSymbol.ContainingNamespace.ToDisplayString();
            var className = namedTypeSymbol.Name;
            var classFullName = namedTypeSymbol.ToDisplayString();
            //  var declaredAccessibility = namedTypeSymbol.DeclaredAccessibility == Accessibility.Public ? MonoCollecotrConvString.DisplayName_public : MonoCollecotrConvString.DisplayName_internal;

            var staticClassName = $"{MonoCollecotrConvString.DisplayName_StaticHeader}{className}";
            var refClassName = $"{MonoCollecotrConvString.DisplayName_RefHeader}{className}";
            var ptrClassName = $"{MonoCollecotrConvString.DisplayName_PtrHeader}{className}";
            var vtableClassName = $"{MonoCollecotrConvString.DisplayName_VTableHeader}{className}";
            //Debug.WriteLine($"{nameSpace}.{className}");



            //var staticFieldDatas = namedTypeSymbol.EnumCurrClassStaticFieldDatas(staticClassName).ToArray();
            //var propertyDatas = namedTypeSymbol.EnumCurrClassPropertyDatas(refClassName).ToArray();
            //var ptrClass = namedTypeSymbol.FindCurrClassNestedPtrClass(ptrClassName);
            //var ptrClassFullName = ptrClass is null ? $"{classFullName}.{ptrClassName}" : ptrClass.ToDisplayString();


            var staticFieldDatas = new List<MonoCollectorStaticPropertyData>();
            var propertyDatas = new List<MonoCollectorPropertyData>();
            var ptrVTableDatas = new List<MonoCollectorPtrVTableData>();
            INamedTypeSymbol ptrClass = default;

            foreach (var member in namedTypeSymbol.GetMembers())
            {
                if (member is INamedTypeSymbol typeSymbol && typeSymbol.IsValueType)
                {
                    staticFieldDatas.AddRange(EnumCurrClassStaticFieldDatas(typeSymbol, staticClassName));
                    EnumCurrClassRefClassDatas(typeSymbol, refClassName, (prop) =>
                    {
                        propertyDatas.Add(prop);
                    }, (vtable) =>
                    {
                        ptrVTableDatas.Add(vtable);
                    });
                    if (ptrClass is null)
                    {
                        ptrClass = FindCurrClassNestedPtrClass(typeSymbol, ptrClassName);
                    }
                }
            }

            EnumMonoCollectorFieldDatas(classAtts, s =>
            {
                staticFieldDatas.Add(s);
            }, p => propertyDatas.Add(p));


            var ptrClassFullName = ptrClass is null ? $"{classFullName}.{ptrClassName}" : ptrClass.ToDisplayString();
            var methodDatas = namedTypeSymbol.EnumCurrClassMethodDatas(ptrClassFullName).ToArray();
            //var baseClassesInfo = .ToArray();
            //var baseMethodDatas = baseClassesInfo.Where(p => p.onlyAsRef == false).Select(p => p.baseClassSymbol).EnumBaseClassMethodDatas(ptrClassName);
            //var allMethodDatas = SortMonoCollectorMethodDatas(methodDatas, baseMethodDatas);


            var inheritViewDatas = namedTypeSymbol.EnumCurrClassInheritViewDatas(namedTypeSymbol.GetBaseClasses()).ToArray();

            //add search files

            return new MonoCollectorTypeData()
            {
                Ver = ver,

                NameSpace = nameSpace,
                ClassName = className,
                ClassFullName = classFullName,
                PtrClassName = ptrClassName,
                RefClassName = refClassName,
                VTableClassName = vtableClassName,

                Const_ImageName = const_ImageName,
                Utf8_ImageName = utf8_ImageName,

                Const_Namespace = const_Namespace,
                Utf8_Namespace = utf8_Namespace,

                Const_ClassName = const_ClassName,
                Utf8_ClassName = utf8_ClassName,

                Const_TypeToken = const_TypeToken,

                StaticFieldDatas = staticFieldDatas,
                PropertyDatas = propertyDatas,
                MethodDatas = methodDatas,

                InheritViewDatas = inheritViewDatas,

                VTableDatas = ptrVTableDatas,
            };

        }


        static void EnumMonoCollectorFieldDatas(ImmutableArray<AttributeData> classAtts,
            Action<MonoCollectorStaticPropertyData> staticFunc,
            Action<MonoCollectorPropertyData> propFunc)
        {
            var searchFieldDatas = classAtts.Where(p =>
                p.AttributeClass.ToDisplayString() == typeof(MonoCollectorSearchFieldAttribute).FullName
                || p.AttributeClass.BaseType.ToDisplayString() == typeof(MonoCollectorSearchFieldAttribute).FullName);
            foreach (var search in searchFieldDatas)
            {
                var retType = string.Empty;
                var index = 0;
                if (search.AttributeClass.IsGenericType && search.AttributeClass.TypeArguments.Length == 1)
                {
                    retType = search.AttributeClass.TypeArguments[0].ToDisplayString();
                    index = 0;
                }
                else if (search.ConstructorArguments.Length == 4 && search.TryGetAttributeValue_CtorArgs(index, out INamedTypeSymbol namedTypeSymbol))
                {
                    retType = namedTypeSymbol.ToDisplayString();

                    ++index;
                }
                else
                {
                    // err;
                }
                if (search.TryGetAttributeValue_CtorArgs(index++, out string entryPoint)
                  && search.TryGetAttributeValue_CtorArgs(index++, out string propName)
                  && search.TryGetAttributeValue_CtorArgs(index++, out bool isStatic))
                {
                    if (isStatic)
                    {
                        staticFunc(new MonoCollectorStaticPropertyData() 
                        {
                            ReturnType = retType,
                            PropertyName = propName,
                            EntryPoint = entryPoint,
                        });
                    }
                    else
                    {
                        var readOnly = search.GetAttributeValue_NamedArgs(nameof(MonoCollectorSearchFieldAttribute.IsReadOnly), true);

                        propFunc(new MonoCollectorPropertyData()
                        {
                            ReturnType = retType,
                            PropertyName = propName,
                            IsReadOnly = readOnly,
                            EntryPoint = entryPoint,
                            FieldName = propName,
                            IsSearch = true
                        });
                    }

                }
            }
        }


        static MonoCollectorMethodData[] SortMonoCollectorMethodDatas(IEnumerable<MonoCollectorMethodData> methodDatas, IEnumerable<MonoCollectorMethodData> baseMethodDatas)
        {
            var allMethodDatas = methodDatas.Concat(baseMethodDatas).OrderBy(p => p.BaseClassMethod).ThenBy(p => p.MethodName).ToArray();
            //fixed 防重载 methodname = old_methodName_{index}
            for (int i = 0; i < allMethodDatas.Length; ++i)
            {
                var methodData = allMethodDatas[i];
                methodData.FuncStructName = $"{methodData.FuncStructName}_{i:X2}";
                methodData.FuncName = $"{methodData.FuncName}_{i:X2}";
            }
            return allMethodDatas;
        }

        static INamedTypeSymbol FindCurrClassNestedPtrClass(this INamedTypeSymbol typeSymbol, string mathPtrClass)
        {
            if (typeSymbol.ToDisplayString().EndsWith(mathPtrClass))
            {
                return typeSymbol;
            }
            return default;
        }


        #endregion

        #region MonoCollectorStaticPropertyAttribute获取Class的静态字段
        static MonoCollectorStaticPropertyData GetStaticFieldData(this AttributeData attributeData, IFieldSymbol fieldSymbol)
        {
            var entryPoint = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorStaticPropertyAttribute.EntryPoint), fieldSymbol.Name);


            var methodName = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorStaticPropertyAttribute.PropertyName), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(fieldSymbol.Name));
            return new MonoCollectorStaticPropertyData()
            {
                ReturnType = fieldSymbol.Type.ToDisplayString(),
                EntryPoint = entryPoint,
                PropertyName = methodName,
            };
        }
        static IEnumerable<MonoCollectorStaticPropertyData> EnumCurrClassStaticFieldDatas(this INamedTypeSymbol typeSymbol, string mathStaticClass)
        {
            if (typeSymbol.ToDisplayString().EndsWith(mathStaticClass))
            {
                foreach (var subMember in typeSymbol.GetMembers())
                {
                    if (subMember is IFieldSymbol fieldSymbol)
                    {
                        var staticFieldAtt = fieldSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorStaticPropertyAttribute).FullName);
                        if (staticFieldAtt != null)
                        {
                            yield return staticFieldAtt.GetStaticFieldData(fieldSymbol);
                        }
                    }
                }
            }



        }
        #endregion

        #region MonoCollectorPropertyAttribute & MonoCollectorPtrVTableAttribute获取RefClass的属性 
        static MonoCollectorPropertyData GetPropertyData(this AttributeData attributeData, IFieldSymbol fieldSymbol)
        {
            var fieldName = fieldSymbol.Name;
            var entryPointName = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorPropertyAttribute.EntryPoint), fieldName);
            var propertyName = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorPropertyAttribute.PropertyName), fieldName);
            var search = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorPropertyAttribute.Search), true);

            return new MonoCollectorPropertyData()
            {
                ReturnType = fieldSymbol.Type.ToDisplayString(),
                PropertyName = propertyName,
                IsReadOnly = fieldSymbol.IsReadOnly,
                EntryPoint = entryPointName,
                FieldName = fieldName,
                IsSearch = search
            };
        }
        static MonoCollectorPtrVTableData GetVTableData(this AttributeData attributeData, IFieldSymbol fieldSymbol)
        {
            if (fieldSymbol.Type.SpecialType != SpecialType.System_IntPtr)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {fieldSymbol.ToDisplayString()}=>Type Is Not {typeof(IntPtr).FullName}");
            }
            var sort = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorPtrVTableAttribute.VTableSort), 0);

            return new MonoCollectorPtrVTableData()
            {
                VTableField = fieldSymbol.Name,
                Sort = sort,

            };
        }
        static void EnumCurrClassRefClassDatas(
            this ISymbol member, string mathRefClass,
            Action<MonoCollectorPropertyData> propertyCallback,
             Action<MonoCollectorPtrVTableData> vtableCallback)
        {
            if (member is INamedTypeSymbol typeSymbol && typeSymbol.IsValueType)
            {
                if (member.ToDisplayString().EndsWith(mathRefClass))
                {
                    foreach (var subMember in typeSymbol.GetMembers())
                    {
                        if (subMember is IFieldSymbol fieldSymbol)
                        {
                            var propertyAtt = fieldSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorPropertyAttribute).FullName);
                            if (propertyAtt != null)
                            {
                                propertyCallback(propertyAtt.GetPropertyData(fieldSymbol));
                            }
                            var vtableAtt = fieldSymbol.GetAttributes().FirstOrDefault(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorPtrVTableAttribute).FullName);
                            if (vtableAtt != null)
                            {
                                vtableCallback(vtableAtt.GetVTableData(fieldSymbol));
                            }
                        }
                    }
                }

            }

        }

        #endregion

        #region MonoCollectorMethodAttribute获取Class的函数 & MonoCollectorVTableAttribute获取Class的虚函数
        static MonoCollectorMethodData GetClassMethodData_Common(this IMethodSymbol methodSymbol, string ptrClassFullName, bool baseClassMethod = false, bool fromRuntimeMethod = false)
        {
            var methodName = methodSymbol.Name;
            var methodData = new MonoCollectorMethodData()
            {
                MethodName = methodName,
                FuncStructName = $"{MonoCollecotrConvString.DisplayName_FuncStructHeader}{methodName}",
                FuncName = $"{MonoCollecotrConvString.DisplayName_FuncHeader}{methodName}",

                IsStatic = methodSymbol.IsStatic,
                IsVirtual = methodSymbol.IsVirtual,
                FromRuntimeMethod = fromRuntimeMethod,
                ReturnData = new MonoCollectorMethodReturnData()
                {
                    RefReturn = methodSymbol.RefKind.ToString(),
                    ReturnTypeName = methodSymbol.ReturnType.ToDisplayString(),
                },

                BaseClassMethod = baseClassMethod,
            };


            if (methodData.IsStatic == false)
            {
                methodData.ParamDatas.Add(new MonoCollectorMethodParamData()
                {
                    IsThis = true,
                    RefParam = RefKind.None.ToString(),
                    TypeName = ptrClassFullName,
                    ParamName = "__this__"
                });
            }
            if (methodData.FromRuntimeMethod)
            {
                methodData.ParamDatas.Insert(0, new MonoCollectorMethodParamData()
                {
                    IsThis = true,
                    RefParam = RefKind.None.ToString(),
                    TypeName = typeof(IntPtr).FullName,
                    ParamName = "__runtimeMethod__"
                });
            }

            foreach (var param in methodSymbol.Parameters)
            {
                methodData.ParamDatas.Add(new MonoCollectorMethodParamData()
                {
                    RefParam = param.RefKind.ToString(),
                    TypeName = param.Type.ToDisplayString(),
                    ParamName = param.Name
                });
            }
            return methodData;

        }
        static IEnumerable<string> GetCallConvs(this ImmutableArray<TypedConstant> callConvsSymbols, bool suppressGCTransition = true)
        {
            if (false == callConvsSymbols.IsDefaultOrEmpty)
            {
                foreach (var subMember in callConvsSymbols)
                {
                    if (subMember.Value is INamedTypeSymbol callSymbol)
                    {
                        var name = callSymbol.Name;
                        if (name.StartsWith(MonoCollecotrConvString.DisplayName_CallConv))
                        {
                            yield return name.Substring(MonoCollecotrConvString.DisplayName_CallConv.Length);
                        }
                    }
                }
            }

            if (suppressGCTransition)
            {
                yield return nameof(Maple.MonoGameAssistant.MonoCollectorDataV2.CallConvSuppressGCTransition).Substring(MonoCollecotrConvString.DisplayName_CallConv.Length);
            }
        }
        static string GetCallConvs(this AttributeData attributeData)
        {
            var suppressGCTransition = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorCallConvsAttribute.SuppressGCTransition), true);
            var callConvsSymbols = attributeData.GetAttributeValue_NamedArgs<ImmutableArray<TypedConstant>>(nameof(MonoCollectorCallConvsAttribute.CallConvs), default);
            var callConvs = string.Join(", ", callConvsSymbols.GetCallConvs(suppressGCTransition));
            return callConvs;
        }


        static MonoCollectorMethodData GetClassMethodData_Other(this AttributeData attributeData, IMethodSymbol methodSymbol, string ptrClassFullName, bool baseClassMethod = false)
        {
            if (methodSymbol.IsVirtual)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodSymbol.ToDisplayString()} is Virtual");
            }
            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out string entryPoint) || string.IsNullOrEmpty(entryPoint))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {methodSymbol.ToDisplayString()}.{nameof(MonoCollectorMethodAttribute.EntryPoint)}");
            }
            var fromRuntimeMethod = attributeData.GetAttributeValue_NamedArgs<bool>(nameof(MonoCollectorMethodAttribute.FromRuntimeMethod), default);


            var searchSymbol = attributeData.GetAttributeValue_NamedArgs<INamedTypeSymbol>(nameof(MonoCollectorMethodAttribute.Search), default);
            var searchName = searchSymbol is null ? string.Empty : GetSearchName();

            var callConvs = attributeData.GetCallConvs();

            var methodData = methodSymbol.GetClassMethodData_Common(ptrClassFullName, baseClassMethod, fromRuntimeMethod: fromRuntimeMethod);

            methodData.CallConvs = callConvs;
            methodData.Search = searchName;
            methodData.EntryPoint = entryPoint;
            methodData.FromRuntimeMethod = fromRuntimeMethod;

            if (methodData.FromRuntimeMethod && methodData.IsStatic == false)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodSymbol.ToDisplayString()}.{nameof(MonoCollectorMethodData.IsStatic)}!={nameof(MonoCollectorMethodAttribute.FromRuntimeMethod)}");
            }

            return methodData;

            string GetSearchName()
            {
                var methodname = methodSymbol.Name;
                foreach (var memeber in searchSymbol.GetMembers())
                {
                    if (memeber is IMethodSymbol searchmethod)
                    {
                        var searchMethodName = searchmethod.Name;
                        if (searchmethod.IsStatic
                            && searchmethod.Parameters.Length == 1
                            && searchmethod.ReturnType.SpecialType == SpecialType.System_Boolean
                            && searchMethodName.EndsWith(methodname))
                        {
                            return $"{searchSymbol.ToDisplayString()}.{searchMethodName}";
                        }
                    }
                }
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {searchSymbol.ToDisplayString()}.{methodname}");

            }

        }
        static MonoCollectorMethodData GetClassMethodData_Virtual(this AttributeData attributeData, IMethodSymbol methodSymbol, string ptrClassFullName, bool baseClassMethod = false)
        {
            if (methodSymbol.IsStatic)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodSymbol.ToDisplayString()} is Static");
            }
            if (methodSymbol.IsVirtual == false)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodSymbol.ToDisplayString()} is not Virtual");
            }

            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out int methodOffset))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {methodSymbol.ToDisplayString()}.{nameof(MonoCollectorVTableMethodAttribute.MethodOffset)}");
            }
            //var vtableOffset = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorVTableAttribute.VTableOffset), 0);
            var vtableName = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorVTableMethodAttribute.VTableField), string.Empty);

            var callConvs = attributeData.GetCallConvs();


            var methodData = methodSymbol.GetClassMethodData_Common(ptrClassFullName, baseClassMethod);
            methodData.CallConvs = callConvs;


            //methodData.VirtualOffset = vtableOffset;
            methodData.MethodOffset = methodOffset;
            methodData.VTableField = vtableName;







            return methodData;



        }
        static MonoCollectorMethodData GetClassMethodData_BaseAddress(this AttributeData attributeData, IMethodSymbol methodSymbol, string ptrClassFullName, bool baseClassMethod = false)
        {


            if (false == attributeData.TryGetAttributeValue_CtorArgs(0, out string module))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {methodSymbol.ToDisplayString()}.{nameof(MonoCollectorBaseAddressAttribute.Module)}");
            }
            if (false == attributeData.TryGetAttributeValue_CtorArgs(1, out int baseOffset))
            {
                throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {methodSymbol.ToDisplayString()}.{nameof(MonoCollectorBaseAddressAttribute.BaseOffset)}");
            }
            var realTime = attributeData.GetAttributeValue_NamedArgs(nameof(MonoCollectorBaseAddressAttribute.RealTime), false);

            var offsetSymbols = attributeData.GetAttributeValue_NamedArgs<ImmutableArray<TypedConstant>>(nameof(MonoCollectorBaseAddressAttribute.Offsets), default);
            var offsets = offsetSymbols.ReadImmutableArray<int>().ToArray();

            var callConvs = attributeData.GetCallConvs();

            var methodData = methodSymbol.GetClassMethodData_Common(ptrClassFullName, baseClassMethod);
            methodData.CallConvs = callConvs;

            methodData.BaseAddress = true;
            methodData.RealTime = realTime;
            methodData.ModuleName = module;
            methodData.BaseOffset = baseOffset;
            methodData.Offsets = offsets;
            return methodData;
        }
        static IEnumerable<MonoCollectorMethodData> EnumCurrClassMethodDatas(this INamedTypeSymbol namedTypeSymbol, string ptrClassFullName, bool baseClassMethod = false)
        {
            foreach (var member in namedTypeSymbol.GetMembers())
            {
                if (member is IMethodSymbol methodSymbol && methodSymbol.IsExtern)
                {
                    foreach (var methodAtt in methodSymbol.GetAttributes())
                    {
                        var attName = methodAtt.AttributeClass.ToDisplayString();
                        if (attName == typeof(MonoCollectorMethodAttribute).FullName)
                        {
                            yield return methodAtt.GetClassMethodData_Other(methodSymbol, ptrClassFullName, baseClassMethod);
                        }
                        else if (attName == typeof(MonoCollectorVTableMethodAttribute).FullName)
                        {
                            yield return methodAtt.GetClassMethodData_Virtual(methodSymbol, ptrClassFullName, baseClassMethod);
                        }
                        else if (attName == typeof(MonoCollectorBaseAddressAttribute).FullName)
                        {
                            yield return methodAtt.GetClassMethodData_BaseAddress(methodSymbol, ptrClassFullName, baseClassMethod);
                        }
                    }

                }
            }

        }
        #endregion

        #region MonoCollectorInheritViewAttribute获取Class的继承 & 获取基类的方法
        static IEnumerable<INamedTypeSymbol> GetBaseClasses(this INamedTypeSymbol namedTypeSymbol)
        {
            var inheritViewTypes = namedTypeSymbol.GetAttributes().Where(p => p.AttributeClass.ToDisplayString() == typeof(MonoCollectorInheritViewAttribute).FullName);
            foreach (var inheritViewType in inheritViewTypes)
            {
                if (false == inheritViewType.TryGetAttributeValue_CtorArgs(0, out INamedTypeSymbol baseClassSymbol))
                {
                    throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {nameof(MonoCollectorInheritViewAttribute.BaseClass)}");
                }
                //var onlyAsRef = inheritViewType.GetAttributeValue_NamedArgs(nameof(MonoCollectorInheritViewAttribute.OnlyAsRef), false);
                if (baseClassSymbol.IsGenericType)
                {
                    if (baseClassSymbol.TypeArguments.Any(p => p.TypeKind == TypeKind.Error))
                    {
                        throw new MonoCollectorGeneratorV2Exception($"Error {baseClassSymbol.ToDisplayString()}");
                    }
                }
                yield return baseClassSymbol;
            }
        }
        static IEnumerable<MonoCollectorMethodData> EnumBaseClassMethodDatas(this IEnumerable<INamedTypeSymbol> baseClasses, string ptrClassFullName)
        {
            foreach (var baseClassSymbol in baseClasses)
            {
                var baseMethods = EnumCurrClassMethodDatas(baseClassSymbol, ptrClassFullName, true);
                foreach (var method in baseMethods)
                {
                    yield return method;
                }
            }
        }
        static IEnumerable<MonoCollectorInheritViewData> EnumCurrClassInheritViewDatas(this INamedTypeSymbol derivedClass, IEnumerable<INamedTypeSymbol> baseClasses)
        {

            var derivedClassName = derivedClass.Name;
            var derivedClassFullName = derivedClass.ToDisplayString();
            var derivedPtrClassFullName = $"{derivedClassFullName}.{MonoCollecotrConvString.DisplayName_PtrHeader}{derivedClassName}";
            foreach (var (className, ptrClassFullName) in GetBaseClassSymbols(baseClasses))
            {
                yield return new MonoCollectorInheritViewData()
                {
                    DerivedClassName = derivedClassName,
                    DerivedPtrClassFullName = derivedPtrClassFullName,

                    BaseClassName = className,
                    BasePtrClassFullName = ptrClassFullName,
                };
            }

            IEnumerable<(string className, string ptrClassFullName)> GetBaseClassSymbols(IEnumerable<INamedTypeSymbol> namedTypeSymbols)
            {
                foreach (var baseClassSymbol in namedTypeSymbols)
                {
                    var className = baseClassSymbol.Name;
                    var fullName = baseClassSymbol.ToDisplayString();
                    var ptrClassName = $"{fullName}.{MonoCollecotrConvString.DisplayName_PtrHeader}{className}";
                    yield return (className, ptrClassName);

                }
            }

        }
        #endregion


    }
}
