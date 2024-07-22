using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{

    static class MonoCollectorGeneratorV2Helper
    {



        #region 声明函数指针&定义函数指针&输出
        static string BuildMethodData(this MonoCollectorMethodData methodData, MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            if (methodData.IsVirtual)
            {
                return BuildMethodData_Virtual(methodData, typeData);
            }
            if (methodData.IsStatic && !methodData.BaseAddress)
            {
                if (methodData.FromRuntimeMethod)
                {
                    return BuildMethodData_StaticInvoker(methodData, typeData.PtrClassName);
                }
                return BuildMethodData_Static(methodData, typeData.PtrClassName);
            }
            if (methodData.BaseAddress)
            {
                if (methodData.RealTime)
                {
                    return BuildMethodData_BaseAddress_RealTime(methodData, typeData.PtrClassName, optionsData);
                }
                else
                {
                    return BuildMethodData_BaseAddress_NonRealTime(methodData, typeData.PtrClassName, optionsData);
                }
            }
            return BuildMethodData_Other(methodData, typeData.PtrClassName);

        }
        static string BuildMethodData_Virtual(this MonoCollectorMethodData methodData, MonoCollectorTypeData typeData)
        {
            if (methodData.IsStatic)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR Virtual {methodData.FuncStructName} IS Static");
            }

            var vtableData = typeData.VTableDatas.Where(p => p.VTableField == methodData.VTableField).OrderBy(p => p.Sort).FirstOrDefault()
                ?? typeData.VTableDatas.Where(p => p.Sort == 0).FirstOrDefault()
                ?? throw new MonoCollectorGeneratorV2Exception($"NOT FOUND {methodData.VTableField} In {nameof(MonoCollectorTypeData.VTableDatas)}");

            var funcStructName = methodData.FuncStructName;
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {funcStructName}(nint {MonoCollecotrConvString.DisplayName_DelegatePtrArg})
        {{
            {methodData.OutputDelegate()}

            {MonoCollecotrConvString.DisplayName_public} static implicit operator {funcStructName}(nint ptr) => new(ptr);

            {MonoCollecotrConvString.DisplayName_public} override string ToString()
            {{
                return ((nint)((void*){MonoCollecotrConvString.DisplayName_DelegateMember})).ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputInvoke()}
        }}


        [{typeof(StructLayoutAttribute).FullName}({typeof(LayoutKind).FullName}.{nameof(LayoutKind.Explicit)})]
        {MonoCollecotrConvString.DisplayName_PartialStruct} {typeData.VTableClassName}
        {{

            [{typeof(FieldOffsetAttribute).FullName}(0x{methodData.MethodOffset:X8})]
            {MonoCollecotrConvString.DisplayName_public} readonly {funcStructName} {methodData.FuncName};

        }}

        {MonoCollecotrConvString.DisplayName_PartialStruct} {typeData.PtrClassName}
        {{
            readonly {MonoCollecotrConvString.DisplayName_IntPtr} {methodData.FuncName}_{vtableData.VTableField} 
                => {MonoCollecotrConvString.DisplayName_FuncAsRef}.{vtableData.VTableField};

            readonly ref {typeData.VTableClassName} {methodData.FuncName}_{typeData.VTableClassName} 
                => ref {typeof(Unsafe).FullName}.{nameof(Unsafe.AsRef)}<{typeData.VTableClassName}>({methodData.FuncName}_{vtableData.VTableField}.{nameof(UIntPtr.ToPointer)}());
            
            readonly {funcStructName} {methodData.FuncName} 
                =>  {methodData.FuncName}_{typeData.VTableClassName}.{methodData.FuncName};


            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputCall()}
        }}";

        }

        static string BuildMethodData_Static(this MonoCollectorMethodData methodData, string ptrClassName)
            => BuildMethodData_Other(methodData, ptrClassName);
        static string BuildMethodData_StaticInvoker(this MonoCollectorMethodData methodData, string ptrClassName)
        {
            var funcStructName = methodData.FuncStructName;
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {funcStructName}(nint {MonoCollecotrConvString.DisplayName_DelegatePtrArg})
        {{
            {methodData.OutputDelegate()}

            {MonoCollecotrConvString.DisplayName_public} static implicit operator {funcStructName}(nint ptr) => new(ptr);

            {MonoCollecotrConvString.DisplayName_public} override string ToString()
            {{
                return ((nint)((void*){MonoCollecotrConvString.DisplayName_DelegateMember})).ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputInvoke()}
        }}

        static {typeof(MonoStaticMethodInvoker).FullName} {methodData.FuncName};
  

        {MonoCollecotrConvString.DisplayName_PartialStruct} {ptrClassName}
        {{
            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputCall()}
        }}";

        }


        static string BuildMethodData_BaseAddress_NonRealTime(this MonoCollectorMethodData methodData, string ptrClassName, MonoCollectorOptionsData optionsData)
        {
            if (false == methodData.BaseAddress)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodData.FuncStructName} is not BaseAddress");
            }
            var funcStructName = methodData.FuncStructName;
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {funcStructName}(nint {MonoCollecotrConvString.DisplayName_DelegatePtrArg})
        {{
            {methodData.OutputDelegate()}

            {MonoCollecotrConvString.DisplayName_public} static implicit operator {funcStructName}(nint ptr) => new(ptr);

            {MonoCollecotrConvString.DisplayName_public} override string ToString()
            {{
                return ((nint)((void*){MonoCollecotrConvString.DisplayName_DelegateMember})).ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            public {methodData.OutputInvoke()}
        }}

        static {funcStructName} {methodData.FuncName};

        {MonoCollecotrConvString.DisplayName_MethodInline}
        static unsafe {funcStructName} {MonoCollecotrConvString.DisplayName_BaseAddressHeader}{methodData.FuncName}()
        {{
            {methodData.OutputBaseAddress(optionsData.MonoCollectorMember_GetModuleBaseAddress.MethodName)}
        }}      

        {MonoCollecotrConvString.DisplayName_PartialStruct} {ptrClassName}
        {{
            {MonoCollecotrConvString.DisplayName_MethodInline}
            public {methodData.OutputCall()}
        }}";

        }

        static string BuildMethodData_BaseAddress_RealTime(this MonoCollectorMethodData methodData, string ptrClassName, MonoCollectorOptionsData optionsData)
        {
            if (false == methodData.BaseAddress)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {methodData.FuncStructName} is not BaseAddress");
            }
            var funcStructName = methodData.FuncStructName;
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {funcStructName}(nint {MonoCollecotrConvString.DisplayName_DelegatePtrArg})
        {{
            {methodData.OutputDelegate()}

            {MonoCollecotrConvString.DisplayName_public} static implicit operator {funcStructName}(nint ptr) => new(ptr);

            {MonoCollecotrConvString.DisplayName_public} override string ToString()
            {{
                return ((nint)((void*){MonoCollecotrConvString.DisplayName_DelegateMember})).ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputInvoke()}
        }}

        static unsafe {funcStructName} {methodData.FuncName}
        {{
            get
            {{
                {methodData.OutputBaseAddress(optionsData.MonoCollectorMember_GetModuleBaseAddress.MethodName)}
            }}
        }}

        {MonoCollecotrConvString.DisplayName_PartialStruct} {ptrClassName}
        {{
            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputCall()}
        }}";

        }

        static string BuildMethodData_Other(this MonoCollectorMethodData methodData, string ptrClassName)
        {
            var funcStructName = methodData.FuncStructName;
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {funcStructName}(nint {MonoCollecotrConvString.DisplayName_DelegatePtrArg})
        {{
            {methodData.OutputDelegate()}

            {MonoCollecotrConvString.DisplayName_public} static implicit operator {funcStructName}(nint ptr) => new(ptr);

            {MonoCollecotrConvString.DisplayName_public} override string ToString()
            {{
                return ((nint)((void*){MonoCollecotrConvString.DisplayName_DelegateMember})).ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputInvoke()}
        }}

        static {funcStructName} {methodData.FuncName};

        {MonoCollecotrConvString.DisplayName_PartialStruct} {ptrClassName}
        {{
            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {methodData.OutputCall()}
        }}";

        }
        static string OutputMethodDataContent(this IReadOnlyList<MonoCollectorMethodData> methodDatas, MonoCollectorTypeData collectorTypeData, MonoCollectorOptionsData optionsData)
        {
            if (methodDatas.Count == 0)
            {
                return string.Empty;
            }
            return string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), methodDatas.Select(p => p.BuildMethodData(collectorTypeData, optionsData)));
        }
        #endregion

        #region 声明成员属性&定义成员属性&输出
        static string BuildPropertyData(this MonoCollectorPropertyData propertyData, MonoCollectorOptionsData optionsData)
        {
            return propertyData.IsSearch ? propertyData.BuildPropertyData_Offset(optionsData) : propertyData.BuildPropertyData_Default();
        }
        static string BuildPropertyData_Default(this MonoCollectorPropertyData propertyData)
        {
            var setContent = propertyData.IsReadOnly ? string.Empty : $"set =>  {MonoCollecotrConvString.DisplayName_FuncAsRef}.{propertyData.FieldName} = value;";
            return $@"
            {MonoCollecotrConvString.DisplayName_public} {propertyData.ReturnType} {propertyData.PropertyName}
            {{
                get =>  {MonoCollecotrConvString.DisplayName_FuncAsRef}.{propertyData.FieldName};
                {setContent}
            }}";
        }
        static string BuildPropertyData_Offset(this MonoCollectorPropertyData propertyData, MonoCollectorOptionsData optionsData)
        {
            var offsetValue = $"{MonoCollecotrConvString.DisplayName_FieldOffsetHeader}{propertyData.PropertyName}";
            var getContent = $"get => {optionsData.MonoCollectorMember_GetMemberFieldValue.GenericOutputCall(new string[] { propertyData.ReturnType }, "this", offsetValue)};";
            var setContent = propertyData.IsReadOnly ? string.Empty :
                $"set => {optionsData.MonoCollectorMember_SetMemberFieldValue.GenericOutputCall(new string[] { propertyData.ReturnType }, "this", offsetValue, "value")};";
            return $@"
            {MonoCollecotrConvString.DisplayName_public} {propertyData.ReturnType} {propertyData.PropertyName}
            {{
                {getContent}

                {setContent}
            }}";
        }


        static string BuildPropertyOffset(this MonoCollectorPropertyData propertyData)
        {
            return $@"
        {MonoCollecotrConvString.DisplayName_StaticInt32} {MonoCollecotrConvString.DisplayName_FieldOffsetHeader}{propertyData.PropertyName};";

        }

        static string OutputPropertyDataContent(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            var propertyDatas = typeData.PropertyDatas;
            if (propertyDatas.Count == 0)
            {
                return string.Empty;
            }
            var contentPropertyOffset = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), propertyDatas.Select(p => p.BuildPropertyOffset()));
            var contentPropertyData = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), propertyDatas.Select(p => p.BuildPropertyData(optionsData)));

            return $@"

        {contentPropertyOffset}

        {MonoCollecotrConvString.DisplayName_PartialStruct} {typeData.PtrClassName}
        {{
            {contentPropertyData}
        }}";
        }
        #endregion

        #region 继承对象转换&输出
        static string BuildInheritViewData(this MonoCollectorInheritViewData inheritViewData)
        {
            return $@"
            {MonoCollecotrConvString.DisplayName_MethodInline}
            {MonoCollecotrConvString.DisplayName_public} {inheritViewData.BasePtrClassFullName} As{inheritViewData.BaseClassName}()
                => new {inheritViewData.BasePtrClassFullName}({MonoCollecotrConvString.DisplayName_PtrClassMember});";
        }
        static string OutputInheritViewContent(this IReadOnlyList<MonoCollectorInheritViewData> inheritViewDatas, string ptrClassName)
        {
            if (inheritViewDatas.Count == 0)
            {
                return string.Empty;
            }

            var contentProperty = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), inheritViewDatas.Select(p => p.BuildInheritViewData()));
            return $@"
        {MonoCollecotrConvString.DisplayName_PartialStruct} {ptrClassName}
        {{
            {contentProperty}
        }}";
        }
        #endregion

        #region 声明静态属性&定义静态属性&输出

        static string BuildStaticField(this MonoCollectorStaticPropertyData staticFieldData, MonoCollectorOptionsData optionsData)
        {
            return $@"
        {MonoCollecotrConvString.DisplayName_public} {staticFieldData.ReturnType} {staticFieldData.PropertyName}
            =>  {optionsData.MonoCollectorMember_GetMonoStaticFieldValue.MethodName}<{staticFieldData.ReturnType}>(""{staticFieldData.EntryPoint}"");";
        }
        static string OutputStaticFieldContent(this IReadOnlyList<MonoCollectorStaticPropertyData> staticFieldDatas, MonoCollectorOptionsData optionsData)
        {
            if (staticFieldDatas.Count == 0)
            {
                return string.Empty;
            }
            return string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), staticFieldDatas.Select(p => p.BuildStaticField(optionsData)));
        }
        #endregion

        #region 初始化函数指针变量&输出
        static string BuildMethodData(this MonoCollectorMethodData methodData, MonoCollectorOptionsData optionsData)
        {
            if (methodData.BaseAddress)
            {
                return BuildMethodData_BaseAddress(methodData);
            }
            if (methodData.IsStatic && methodData.FromRuntimeMethod)
            {
                return BuildMethodData_StaticMethodInvoker(methodData, optionsData);
            }
            return BuildMethodData_Other(methodData, optionsData);
        }
        static string BuildMethodData_Other(this MonoCollectorMethodData methodData, MonoCollectorOptionsData optionsData)
        {
            var getMethodPointers = string.Empty;
            var args = methodData.Search;
            if (string.IsNullOrEmpty(args))
            {
                var methodname = optionsData.MonoCollectorMember_GetMethodPointers.Where(p => p.ParamDatas.Count == 1 && string.Equals(p.ParamDatas[0].TypeName, typeof(string).Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault()
                    ?? throw new MonoCollectorGeneratorV2Exception("NOT FOUDN MonoCollectorMember_GetMethodPointers");
                getMethodPointers = $@"{methodname.MethodName}(""{methodData.EntryPoint}"")";
            }
            else
            {
                var methodname = optionsData.MonoCollectorMember_GetMethodPointers.Where(p => p.ParamDatas.Count == 2 && string.Equals(p.ParamDatas[0].TypeName, typeof(string).Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault()
                     ?? throw new MonoCollectorGeneratorV2Exception("NOT FOUDN MonoCollectorMember_GetMethodPointers");
                getMethodPointers = $@"{methodname.MethodName}(""{methodData.EntryPoint}"", {args})";
            }


            return $@"
            {methodData.FuncName} = {getMethodPointers};";
        }
        static string BuildMethodData_BaseAddress(this MonoCollectorMethodData methodData)
        {
            return $@"
            {methodData.FuncName} = {MonoCollecotrConvString.DisplayName_BaseAddressHeader}{methodData.FuncName}();";
        }
        static string BuildMethodData_StaticMethodInvoker(this MonoCollectorMethodData methodData, MonoCollectorOptionsData optionsData)
        {
            var getMethodPointers = string.Empty;
            var methodname = optionsData.MonoCollectorMember_GetStaticMethodInvokers.Where(p => p.ParamDatas.Count == 1 && string.Equals(p.ParamDatas[0].TypeName, typeof(string).Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault()
                    ?? throw new MonoCollectorGeneratorV2Exception("NOT FOUDN MonoCollectorMember_GetStaticMethodInvokers");
            getMethodPointers = $@"{methodname.MethodName}(""{methodData.EntryPoint}"")";



            return $@"
            {methodData.FuncName} = {getMethodPointers};";
        }

        static string BuildFieldData(this MonoCollectorPropertyData propertyData, MonoCollectorOptionsData optionsData)
        {
            var invokeContent = $@"{optionsData.MonoCollectorMember_GetMemberFieldOffset.MethodName}(""{propertyData.EntryPoint}"")";
            return $@"
            {MonoCollecotrConvString.DisplayName_FieldOffsetHeader}{propertyData.PropertyName} = {invokeContent};";
        }

        static string OutputInitMemeberContent(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            //此处排除虚函数/非托管实时函数
            var methods = typeData.MethodDatas.Where(p => p.NotInitMethod == false).Select(p => p.BuildMethodData(optionsData)).ToArray();
            var contentMethod = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), methods);
            var fields = typeData.PropertyDatas.Where(p => p.IsSearch).Select(p => p.BuildFieldData(optionsData)).ToArray();
            var contentField = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), fields);
            if (methods.Length == 0 && fields.Length == 0)
            {
                return default;
            }
            return $@"
        protected sealed override {optionsData.MonoCollectorMember_InitMember.ReturnData.ReturnTypeName} {optionsData.MonoCollectorMember_InitMember.MethodName}()
        {{
            {contentMethod}
            
            {contentField}
        }}";
        }

        #endregion

        #region 调用Mono创建对象
        static string GetObjectNewContent(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData, MonoCollectorMethodData methodData)
        {
            var ptr_classFullName = $"{typeData.ClassFullName}.{typeData.PtrClassName}";

            return $@"
        {MonoCollecotrConvString.DisplayName_public} {ptr_classFullName} {methodData.MethodName}({methodData.OutputArgs()})
            =>  {methodData.GenericOutputCall(new string[] { ptr_classFullName }, methodData.ParamDatas.Select(p => p.ParamName).ToArray())};";

        }
        static string OutputObjectNewContent(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            // optionsData.MonoCollectorMember_New.Select(p=>)
            return string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), optionsData.MonoCollectorMember_New.Select(p => typeData.GetObjectNewContent(optionsData, p)));
            //    return $@"
            //{MonoCollecotrConvString.DisplayName_public} {ptr_classFullName} {optionsData.MonoCollectorMember_New.MethodName}()
            //    =>  {optionsData.MonoCollectorMember_New.MethodName}<{ptr_classFullName}>();";

        }
        #endregion

        #region 获取Class基本信息&输出
        static (string classMainCtor, string baseMainCtor) GetCurrClassMainCtor(this MonoCollectorOptionsData optionsData)
        {
            var classMainCtor = string.Join(", ", optionsData.MonoCollectorMember_Ctor.ParamDatas.Select(p => p.OutputInvoke()));
            var baseMainCtor = string.Join(", ", optionsData.MonoCollectorMember_Ctor.ParamDatas.Select(p => p.OutputCall()));
            return (classMainCtor, baseMainCtor);
        }
        public static string OutputCurrTypeClassContent(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            var (classMainCtor, baseMainCtor) = optionsData.GetCurrClassMainCtor();
            var methodContent = typeData.MethodDatas.OutputMethodDataContent(typeData, optionsData);
            var propertyDataContent = typeData.OutputPropertyDataContent(optionsData);
            var inheritViewDatas = typeData.InheritViewDatas.OutputInheritViewContent(typeData.PtrClassName);
            var staticFieldContent = typeData.StaticFieldDatas.OutputStaticFieldContent(optionsData);
            var initMemeberContent = typeData.OutputInitMemeberContent(optionsData);
            var objectNewContent = typeData.OutputObjectNewContent(optionsData);
            return $@"
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace {typeData.NameSpace}
{{
    {MonoCollecotrConvString.DisplayName_PartialClass} {typeData.ClassName}({classMainCtor}) : {optionsData.MonoCollectorMember}({baseMainCtor})
    {{
        {staticFieldContent}

        {methodContent}
        
        {propertyDataContent}
        
        {inheritViewDatas}

        {initMemeberContent}

        {objectNewContent}
    }}
}}";


        }

        #endregion


        #region 声明Class&创建查找Class条件属性&输出
        static string BuildTypeClassesField(this MonoCollectorTypeData typeData)
        {
            //            {nameof(MonoCollecotrClassSettings.EnumParentCount)} = {typeData.InheritViewDatas.Count},

            var settingsFullName = typeof(MonoCollecotrClassSettings).FullName;
            var args = $@"
        {{
            {nameof(MonoCollecotrClassSettings.Utf8ImageName)} = {typeData.Utf8_ImageName},
            {nameof(MonoCollecotrClassSettings.ImageName)} = ""{typeData.Const_ImageName}"",

            {nameof(MonoCollecotrClassSettings.Utf8Namespace)} = {typeData.Utf8_Namespace},
            {nameof(MonoCollecotrClassSettings.Namespace)} = ""{typeData.Const_Namespace}"",

            {nameof(MonoCollecotrClassSettings.Utf8ClassName)} = {typeData.Utf8_ClassName},
            {nameof(MonoCollecotrClassSettings.ClassName)} = ""{typeData.Const_ClassName}"",


        }}";
            //       //     {nameof(MonoCollecotrClassSettings.TypeToken)} = 0x{typeData.Const_TypeToken:X8}U,

            return $@"
        {settingsFullName} {MonoCollecotrConvString.DisplayName_SettingsHeader}{typeData.ClassName} {{ get; }} = new {settingsFullName} {args};
        {MonoCollecotrConvString.DisplayName_public} {typeData.ClassFullName} {typeData.ClassName} {{ get; }}";
        }
        static string OutputTypeClassesFieldContent(this MonoCollectorVersionData versionData)
        {
            return string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), versionData.TypeDatas.Select(p => p.BuildTypeClassesField()));

        }
        #endregion

        #region 根据条件属性查询Class信息&输出
        static string BuildTypeClassesInit(this MonoCollectorTypeData typeData, MonoCollectorOptionsData optionsData)
        {
            //var firstParam = optionsData.MonoCollectorMember_Ctor.ParamDatas.FirstOrDefault()
            //    ?? throw new MonoCollectorGeneratorV2Exception("NOT FOUDN MonoCollectorMember_Ctor.ParamDatas");
            //var monoContext = optionsData.MonoCollectorContext_PropertyDatas.Where(p => p.ReturnType == firstParam.TypeName).FirstOrDefault()
            //    ?? throw new MonoCollectorGeneratorV2Exception($"NOT FOUDN MonoCollectorContext_PropertyDatas.{firstParam.TypeName} {firstParam.ParamName}");
            //var contextName = optionsData.MonoCollectorContext;
            return $@"
            {typeData.ClassName} = new {typeData.ClassFullName}(this, {optionsData.MonoCollectorContext_GetClassInfo.MethodName}({MonoCollecotrConvString.DisplayName_SettingsHeader}{typeData.ClassName}));";
        }
        static string OutputTypeClassesInitContent_MainCtor(this MonoCollectorVersionData versionData, MonoCollectorOptionsData optionsData)
        {
            var classMainCtor = string.Join(", ", optionsData.MonoCollectorContext_Ctor.ParamDatas.Select(p => p.OutputInvoke()));
            var baseMainCtor = string.Join(", ", optionsData.MonoCollectorContext_Ctor.ParamDatas.Select(p => p.OutputCall()));
            var initContent = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), versionData.TypeDatas.Select(p => p.BuildTypeClassesInit(optionsData)));
            return $@"
        {MonoCollecotrConvString.DisplayName_public} {versionData.CustomClassName}({classMainCtor}) : base({baseMainCtor})
        {{
            {initContent}
        }}";
        }
        #endregion

        #region 创建一个根据版本号实例化的静态方法 仅在ver_commmon
        public static string CreateNewClassStaticMethod(this MonoCollectorVersionData versionData, string baseMainCtor)
        {
            return $@"
                {versionData.Ver.GetType().FullName}.{versionData.Ver} => new {versionData.CustomClassFullName}({baseMainCtor}),";
        }
        public static string OutputNewClassStaticMethod(this MonoCollectorOptionsData optionsData, MonoCollectorVersionData versionData)
        {
            if (versionData.Ver != EnumMonoCollectorTypeVersion.Game)
            {
                return string.Empty;
            }

            if (optionsData.MonoCollectorContext_ThrowException.ParamDatas.All(p => p.TypeName != typeof(EnumMonoCollectorTypeVersion).FullName))
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {nameof(optionsData.MonoCollectorContext_ThrowException)} {nameof(optionsData.MonoCollectorContext_ThrowException.ParamDatas)}.0");
            }


            if (optionsData.MonoCollectorContext_Ctor.ParamDatas.Count < 3)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {nameof(optionsData.MonoCollectorContext_Ctor)} {nameof(optionsData.MonoCollectorContext_Ctor.ParamDatas)}.1");
            }
            var arg1 = optionsData.MonoCollectorContext_Ctor.ParamDatas[1];
            if (arg1.TypeName != typeof(EnumMonoCollectorTypeVersion).FullName)
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {nameof(optionsData.MonoCollectorContext_Ctor)} {nameof(optionsData.MonoCollectorContext_Ctor.ParamDatas)}.2");
            }
            var arg3 = optionsData.MonoCollectorContext_Ctor.ParamDatas[3];
            if (arg3.TypeName != "string")
            {
                throw new MonoCollectorGeneratorV2Exception($"ERROR {nameof(optionsData.MonoCollectorContext_Ctor)} {nameof(optionsData.MonoCollectorContext_Ctor.ParamDatas)}.3");
            }
            var count = optionsData.MonoCollectorContext_Ctor.ParamDatas.Count;
            var arrParamData = optionsData.MonoCollectorContext_Ctor.ParamDatas.Take(count - 1) ;
            var classMainCtor = string.Join(", ", arrParamData.Select(p => p.OutputInvoke()));

            var baseMainCtor = string.Join(", ", arrParamData.Concat(new MonoCollectorMethodParamData[] { new MonoCollectorMethodParamData() { ParamName= $@"""{DateTime.Now:yyyyMMddHHmmss}""" } }).Select(p => p.OutputCall()));
            var code = string.Join(SyntaxFactory.ElasticCarriageReturnLineFeed.ToString(), optionsData.VersionDatas.Select(p => p.CreateNewClassStaticMethod(baseMainCtor)));
            return $@"
        {MonoCollecotrConvString.DisplayName_public} static {versionData.CustomClassName} LoadGameContext({classMainCtor}) 
        {{
            return {arg1.ParamName} switch
            {{

                {code}

                _ => {optionsData.MonoCollectorContext_ThrowException.GenericOutputCall(new string[] { versionData.CustomClassFullName }, arg1.ParamName)},

            }};

        }}";


        }
        #endregion

        #region 输出以上Classes
        public static string OutputTypeClassesContext_Ver(
            this MonoCollectorOptionsData optionsData,
            MonoCollectorVersionData versionData)
        {
            var customClassFieldContent = versionData.OutputTypeClassesFieldContent();
            var mainCtorContent = versionData.OutputTypeClassesInitContent_MainCtor(optionsData);
            var newClassStaticMethod = optionsData.OutputNewClassStaticMethod(versionData);
            return $@"
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace {versionData.CustomClassNamespace}
{{

    {MonoCollecotrConvString.DisplayName_PartialClass} {versionData.CustomClassName} 
        : {(versionData.Ver == EnumMonoCollectorTypeVersion.Game ? optionsData.MonoCollectorContext : optionsData.CustomClassFullName)} 
    {{

        {customClassFieldContent}

        {mainCtorContent}

        {newClassStaticMethod}

    }}
}}";

        }
        #endregion


    }




}
