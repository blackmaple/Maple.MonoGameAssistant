using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace Maple.MonoGameAssistant.MonoCollector
{

    public static class MonoCollectorGeneratorV0
    {
        #region 帮助类
        static string ToTitle(this string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            return JsonNamingPolicy.SnakeCaseUpper.ConvertName(name);
            // return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(field);
        }
        static string? GetTypeDisplayName(this MonoClassInfoDTO typeInfoDTO)
        {
            if (typeInfoDTO.IsValueType)
            {
                if (typeInfoDTO.TypeName == typeof(void).FullName)
                {
                    return "void";
                }
                return typeInfoDTO.TypeName;
            }
            return MonoCollecotrConvString.DisplayName_IntPtr;
        }
        static string? GetFieldTypeDisplayName(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return fieldInfoDTO.FieldType.GetTypeDisplayName();
        }
        static string? GetFixFieldName(this MonoFieldInfoDTO fieldInfoDTO, bool title = false)
        {
            var field = GetFixFieldNameImp(fieldInfoDTO);
            return title ? field.ToTitle() : field;
            static string? GetFixFieldNameImp(MonoFieldInfoDTO fieldInfoDTO)
            {
                var fieldName = fieldInfoDTO.Name;
                if (string.IsNullOrEmpty(fieldName))
                {
                    return fieldName;
                }
                var index0 = fieldName.IndexOf('<');
                if (index0 == -1)
                {
                    return fieldName;
                }
                var index1 = fieldName.IndexOf(">k__BackingField");
                if (index1 == -1)
                {
                    return fieldName;
                }
                return fieldName.Substring(index0 + 1, index1 - 1);
            }
        }
        static string? GetFixClassName(this MonoClassInfoDTO classInfoDTO)
        {
            var className = classInfoDTO.Name;
            if (string.IsNullOrEmpty(className))
            {
                return className;
            }
            var index = className.IndexOf('`');
            if (index != -1)
            {
                return $"{className[..index]}{nameof(System.Collections.Generic)}";
            }
            if (className.StartsWith('.') && className.Length > 1)
            {
                return $"{className[1..]}";
            }
            return className;
        }

        static string? GetReturnTypeDisplayName(this MonoReturnTypeDTO returnTypeDTO)
        {
            return returnTypeDTO.GetTypeDisplayName();
        }
        static string? GetParamTypeDisplayName(this MonoParameterTypeDTO parameterTypeDTO)
        {
            return parameterTypeDTO.GetTypeDisplayName();
        }

        static string? GetByteArrayDisplayName(this byte[]? bytes)
        {

            return $@"[{string.Join(", ", bytes ?? [])}]";
        }

        static string GetObjectTypeInfo(this MonoClassInfoDTO classInfoDTO)
        {
            if (classInfoDTO.IsEnum)
            {
                return "enum";
            }
            else if (classInfoDTO.IsValueType)
            {
                return "struct";
            }
            else if (classInfoDTO.IsInterface)
            {
                return "interface";
            }
            else
            {

                if (classInfoDTO.IsStatic)
                {
                    return "static class";
                }
                else if (classInfoDTO.IsAbstract)
                {
                    return "abstract class";
                }
                else
                {
                    return "class";
                }
            }

        }

        #endregion

        #region 创建成员字段 & 输出
        static string BuildMemberField(this MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO fieldInfoDTO)
        {
            if (classInfoDTO.IsValueType)
            {
                return fieldInfoDTO.BuildMemberField_ValueType();
            }
            return fieldInfoDTO.BuildMemberField_RefType();
        }
        static string BuildMemberField_ValueType(this MonoFieldInfoDTO fieldInfoDTO)
        {
            var displayMethodName = fieldInfoDTO.GetFixFieldName();
            return $@"            
            /// {MonoCollecotrConvString.DisplayName_ConstString} {MonoCollecotrConvString.DisplayName_NameHeader}{MonoCollecotrConvString.DisplayName_FieldHeader}{displayMethodName} = ""{fieldInfoDTO.Name}"";
            /// <summary>
            /// {fieldInfoDTO.FieldType.GetObjectTypeInfo()} 0x{fieldInfoDTO.RawOffset:X} {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name}
            /// </summary>
            [{typeof(FieldOffsetAttribute).FullName}(0x{fieldInfoDTO.Offset:X})]
            {MonoCollecotrConvString.DisplayName_public} readonly {fieldInfoDTO.GetFieldTypeDisplayName()} {displayMethodName};";

        }
        static string BuildMemberField_RefType(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return BuildMemberField_ValueType(fieldInfoDTO);
            //return $@"            
            ///// <summary>
            ///// {fieldInfoDTO.FieldType.GetObjectTypeInfo()} 0x{fieldInfoDTO.RawOffset:X} {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name}
            ///// </summary>
            //[{typeof(FieldOffsetAttribute).FullName}(0x{fieldInfoDTO.Offset:X})]
            //{MonoCollecotrConvString.DisplayName_public} readonly {fieldInfoDTO.GetFieldTypeDisplayName()} {fieldInfoDTO.GetFixFieldName()};";

        }
        static string BuildMemberField_Search(this MonoFieldInfoDTO fieldInfoDTO)
        {
            var displayMethodName = fieldInfoDTO.GetFixFieldName().ToTitle();
            return $@"            
    // {fieldInfoDTO.FieldType.GetObjectTypeInfo()} 0x{fieldInfoDTO.RawOffset:X} {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name}
    [{nameof(MonoCollectorSearchFieldAttribute)}(typeof({fieldInfoDTO.GetFieldTypeDisplayName()}),""{fieldInfoDTO.Name}"", ""{displayMethodName}"")]";

        }


        static string OutputMemberFieldContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            string RefTypeMemberFields = @$"
            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [{typeof(MarshalAsAttribute).FullName}({typeof(UnmanagedType).FullName}.{nameof(UnmanagedType.SysInt)})]
            [{typeof(FieldOffsetAttribute).FullName}(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [{typeof(MarshalAsAttribute).FullName}({typeof(UnmanagedType).FullName}.{nameof(UnmanagedType.SysInt)})]
            [{typeof(FieldOffsetAttribute).FullName}(8)]
            public readonly nint _synchronisation;";


            //Ref_ClassName
            var ref_className = $"{MonoCollecotrConvString.DisplayName_RefHeader}{classInfoDTO.GetFixClassName()}";

            //Ptr_ClassName
            var ptr_className = $"{MonoCollecotrConvString.DisplayName_PtrHeader}{classInfoDTO.GetFixClassName()}";
            var content = string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return $@"
            {classInfoDTO.BuildMemberField(p)}";
            }));
            return $@"
        [{typeof(StructLayoutAttribute).FullName}({typeof(LayoutKind).FullName}.{nameof(LayoutKind.Explicit)})]
        {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialStruct} {ref_className}
        {{

            {(classInfoDTO.IsValueType ? string.Empty : RefTypeMemberFields)}
            
            {content}

        }}
        [{typeof(StructLayoutAttribute).FullName}({typeof(LayoutKind).FullName}.{nameof(LayoutKind.Sequential)})]
        {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialStruct} {ptr_className}(nint ptr)
        {{

            [{typeof(MarshalAsAttribute).FullName}({typeof(UnmanagedType).FullName}.{nameof(UnmanagedType.SysInt)})]
            readonly nint {MonoCollecotrConvString.DisplayName_PtrClassMember} = ptr;
            public static implicit operator {ptr_className}(nint ptr) => new(ptr);
            public static implicit operator nint({ptr_className} obj) => obj.{MonoCollecotrConvString.DisplayName_PtrClassMember};
            
            public override string ToString()
            {{
                return {MonoCollecotrConvString.DisplayName_PtrClassMember}.ToString(""X8"");
            }}

            {MonoCollecotrConvString.DisplayName_MethodInline}
            public bool Valid() => {MonoCollecotrConvString.DisplayName_PtrClassMember} != nint.Zero;
            
            {MonoCollecotrConvString.DisplayName_MethodInline}
            public ref {ref_className} {MonoCollecotrConvString.DisplayName_FuncAsRef}
            {{
                return ref {typeof(Unsafe).FullName}.{nameof(Unsafe.AsRef)}<{ref_className}>({MonoCollecotrConvString.DisplayName_PtrClassMember}.ToPointer());
            }}
        }}";
        }

        static string OutputMemberFieldContent_Search(this IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            return string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return $@"{p.BuildMemberField_Search()}";
            }));
        }

        #endregion

        #region 创建静态字段 & 输出
        static string BuildStaticField(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return fieldInfoDTO.BuildMemberField_RefType();
        }
        static string BuildStaticFieldName(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return $@"//{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_ConstString} {MonoCollecotrConvString.DisplayName_NameHeader}{MonoCollecotrConvString.DisplayName_StaticHeader}{fieldInfoDTO.GetFixFieldName(true)} = ""{fieldInfoDTO.Name}"";";

        }
        static string BuildStaticField_Search(this MonoFieldInfoDTO fieldInfoDTO)
        {
            var displayMethodName = fieldInfoDTO.GetFixFieldName().ToTitle();
            return $@"            
    //  {fieldInfoDTO.FieldType.GetObjectTypeInfo()} static {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name}
    //  [{nameof(MonoCollectorSearchFieldAttribute)}(typeof({fieldInfoDTO.GetFieldTypeDisplayName()}),""{fieldInfoDTO.Name}"", ""{displayMethodName}""), true]";

        }

        static string OutputStaticFieldContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            //Static_ClassName
            var static_className = $"{MonoCollecotrConvString.DisplayName_StaticHeader}{classInfoDTO.GetFixClassName()}";
            var fieldcontent = string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return $@"
            {p.BuildStaticField()}";
            }));
            //    var fieldnames = string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            //    {
            //        return $@"
            //{p.OutputStaticFieldName()}";
            //    }));

            return $@"
        [{typeof(StructLayoutAttribute).FullName}({typeof(LayoutKind).FullName}.{nameof(LayoutKind.Explicit)})]
        {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialStruct} {static_className}
        {{

            {fieldcontent}

        }}";


        }

        static string OutputStaticFieldContent_Search(this IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            return string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return $@"{p.BuildStaticField_Search()}";
            }));
        }
        #endregion

        #region 创建常量字段 & 输出

        static string? BuildConstField(this MonoFieldInfoDTO fieldInfoDTO)
        {
            return $@"            
        /// <summary>
        /// {fieldInfoDTO.FieldType.GetObjectTypeInfo()} {fieldInfoDTO.FieldType.TypeName} {fieldInfoDTO.Name} ""{fieldInfoDTO.Value}""
        /// </summary>
        /// {MonoCollecotrConvString.DisplayName_public} const {fieldInfoDTO.GetFieldTypeDisplayName()} {fieldInfoDTO.GetFixFieldName(true)}=>""{fieldInfoDTO.Value}"";";

        }
        static string OutputConstFieldContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            var const_className = $"{MonoCollecotrConvString.DisplayName_ConstHeader}{classInfoDTO.GetFixClassName()}";
            return string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return $@"{p.BuildConstField()}";
            }));
            //    return $@"
            //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialStruct} {const_className}
            //{{

            //    {content}

            //}}";

        }
        #endregion

        #region 创建枚举字段 & 输出
        static string OutputEnumFieldContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs, string? typeName)
        {
            var content = string.Join(Environment.NewLine, fieldInfoDTOs.Select(p =>
            {
                return @$"
        {p.Name} = {p.Value},";
            }));

            return $@"
    /// <summary>
    /// [""{classInfoDTO.ImageName}"".""{classInfoDTO.Namespace}"".""{classInfoDTO.Name}""]
    /// </summary>
    {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_Enum} {classInfoDTO.Name} : {typeName}
    {{ 

        {content}

    }}";

        }
        #endregion

        #region 创建方法 & 输出
        static string? BuildMethodSearch(this MonoMethodInfoDTO methodInfoDTO, string methodIndex)
        {
            var displayRetTypeName = methodInfoDTO.ReturnType.GetReturnTypeDisplayName();
            var displayMethodName = methodInfoDTO.Name.ToTitle();
            var displayParamNames = string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.GetParamTypeDisplayName()} {p.ParameterName}"));
            var staticName = methodInfoDTO.IsStatic ? "static" : string.Empty;
            var abstractName = methodInfoDTO.IsAbstract ? "abstract" : string.Empty;
            var argName = "monoMethodInfoDTO";
            string?[] searchArgs = [methodInfoDTO.Name, .. methodInfoDTO.ParameterTypes.Select(p => p.TypeName)];
            string searchContent = string.Join(", ", searchArgs.Select(p => $@"""{p}"""));
            return $@"
                    /// <summary>
                    /// {staticName} {abstractName} {methodInfoDTO.ReturnType.TypeName} {methodInfoDTO.Name}({string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.TypeName} {p.ParameterName}"))})
                    /// </summary>
                    /// {MonoCollecotrConvString.DisplayName_public} static bool {displayMethodName}{methodIndex} ({typeof(MonoMethodInfoDTO).FullName} {argName})
                    ///     =>  {typeof(MonoCollectorExtensions).FullName}.{nameof(MonoCollectorExtensions.SearchMonoMethodInfo)}({argName}, {searchContent});
                    ///     
                    ///  
                    /// ";
        }

        static string? OutputMethodSearchContent(this IReadOnlyList<(int index, MonoMethodInfoDTO method)> overrideMethods, string? className)
        {
            var overrideMethodContent = string.Join(Environment.NewLine, overrideMethods.Select(p =>
            {
                return @$"
                    {p.method.BuildMethodSearch($"_{p.index:X2}")}";
            }));
            return $@"
            /// {MonoCollecotrConvString.DisplayName_public} static {MonoCollecotrConvString.DisplayName_PartialClass} {MonoCollecotrConvString.DisplayName_SearchHeader}{className}
            /// {{
            /// 
            ///     {overrideMethodContent}
            /// 
            /// }}";
        }

        static string? GetParamTypeDesc(this MonoParameterTypeDTO parameterTypeDTO)
        {
            return $@"            /// <param name=""{parameterTypeDTO.ParameterName}"">{parameterTypeDTO.GetObjectTypeInfo()} {parameterTypeDTO.TypeName}</param>";
        }

        static string? BuildMethod(this MonoMethodInfoDTO methodInfoDTO, string methodIndex, string? className)
        {
            var displayRetTypeName = methodInfoDTO.ReturnType.GetReturnTypeDisplayName();
            var displayMethodName = methodInfoDTO.Name.ToTitle();
            var displayParamNames = string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.GetParamTypeDisplayName()} {p.ParameterName}"));
            var descParamTypes = string.Join(Environment.NewLine, methodInfoDTO.ParameterTypes.Select(p => p.GetParamTypeDesc()));
            var staticName = methodInfoDTO.IsStatic ? "static" : string.Empty;
            var abstractName = methodInfoDTO.IsAbstract ? "abstract" : string.Empty;
            var searchType = string.IsNullOrEmpty(methodIndex) ? string.Empty : $", Search = typeof({MonoCollecotrConvString.DisplayName_SearchHeader}{className})";
            if (string.IsNullOrEmpty(descParamTypes))
            {
                return $@"
            /// <summary>
            /// {staticName} {abstractName} {methodInfoDTO.ReturnType.TypeName} {methodInfoDTO.Name}({string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.TypeName} {p.ParameterName}"))})
            /// </summary>
            /// <returns>{methodInfoDTO.ReturnType.GetObjectTypeInfo()} {methodInfoDTO.ReturnType.TypeName}</returns>
            /// [{typeof(MonoCollectorMethodAttribute).FullName}(""{methodInfoDTO.Name}""{searchType})]
            /// {staticName} extern {displayRetTypeName} {displayMethodName}{methodIndex} ({displayParamNames});";

            }
            return $@"
            /// <summary>
            /// {staticName} {abstractName} {methodInfoDTO.ReturnType.TypeName} {methodInfoDTO.Name}({string.Join(", ", methodInfoDTO.ParameterTypes.Select(p => $"{p.TypeName} {p.ParameterName}"))})
            /// </summary>
{descParamTypes}
            /// <returns>{methodInfoDTO.ReturnType.GetObjectTypeInfo()} {methodInfoDTO.ReturnType.TypeName}</returns>
            /// [{typeof(MonoCollectorMethodAttribute).FullName}(""{methodInfoDTO.Name}""{searchType})]
            /// {staticName} extern {displayRetTypeName} {displayMethodName}{methodIndex} ({displayParamNames});";
        }
        static (IReadOnlyList<MonoMethodInfoDTO> normalMethods, IReadOnlyList<(int index, MonoMethodInfoDTO method)> overrideMethods) GroupMethod(IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs)
        {
            var normalMethods = new List<MonoMethodInfoDTO>(32);
            var overrideMethods = new List<(int index, MonoMethodInfoDTO method)>(32);

            foreach (var group in methodInfoDTOs.GroupBy(p => p.Name))
            {
                if (group.Count() == 1)
                {
                    normalMethods.AddRange(group);
                }
                else
                {
                    foreach (var method in group.Select((p, i) => (i, p)))
                    {
                        overrideMethods.Add(method);
                    }
                }

            }
            return (normalMethods, overrideMethods);
        }

        static string OutputMethodContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs)
        {
            var fixClassName = classInfoDTO.GetFixClassName();
            var (normalMethods, overrideMethods) = GroupMethod(methodInfoDTOs);
            var normalMethodContent = string.Join(Environment.NewLine, normalMethods.Select(p =>
            {
                return @$"
            {p.BuildMethod(string.Empty, fixClassName)}";
            }));
            var overrideMethodContent = string.Join(Environment.NewLine, overrideMethods.Select(p =>
            {
                return @$"
            {p.method.BuildMethod($"_{p.index:X2}", fixClassName)}";
            }));

            var overrideMethodSearchContent = OutputMethodSearchContent(overrideMethods, fixClassName);

            return $@"
        /// <summary>
        /// [""{classInfoDTO.ImageName}"".""{classInfoDTO.Namespace}"".""{classInfoDTO.Name}""]
        /// </summary>
        {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialClass} {classInfoDTO.GetFixClassName()}
        {{ 

            {normalMethodContent}
            
            {overrideMethodContent}

            {overrideMethodSearchContent}

        }}";
        }
        #endregion

        #region 创建继承对象 & 输出
        static string BuildInheritViewContent(this IReadOnlyList<MonoClassInfoDTO> classInfoDTOs)
        {
            return string.Join("=>", classInfoDTOs.Select(p => $"[{p.TypeName}]"));
        }


        #endregion

        #region 输出整个Class信息


        static string OutputImageClassFieldContent(this MonoClassInfoDTO classInfoDTO, IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs, IReadOnlyList<MonoClassInfoDTO> parentClasses, IReadOnlyList<MonoInterfaceInfoDTO> interfaceInfoDTOs)
        {

            var constfields = classInfoDTO.GetConstFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset).ToArray();

            var staticfields = classInfoDTO.GetStaticFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset).ToArray();



            var memberfields = classInfoDTO.GetMemberFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset).ToArray();



            //const没有则不显示
            var constContent = constfields.Length > 0 ? classInfoDTO.OutputConstFieldContent(constfields) : string.Empty;
            //static没有则不显示
            var staticContent = /*staticfields.Length > 0 ? classInfoDTO.OutputStaticFieldContent(staticfields) :*/ string.Empty;
            var staticAtt = staticfields.Length > 0 ? staticfields.OutputStaticFieldContent_Search() : string.Empty;

            //没有也显示空的ref & ptr
            var memberContent = /*classInfoDTO.OutputMemberFieldContent(memberfields)*/ string.Empty;
            var memberAtt = memberfields.OutputMemberFieldContent_Search();
            //类继承图
            var inheritViewContent = parentClasses.BuildInheritViewContent();

            //接口继承图
            var interfaceContent = interfaceInfoDTOs.BuildInheritViewContent();

            return $@"
    /// <summary>
    /// {classInfoDTO.GetObjectTypeInfo()} [""{classInfoDTO.ImageName}"".""{classInfoDTO.Namespace}"".""{classInfoDTO.Name}""]
    /// {inheritViewContent}
    /// {interfaceContent}
    /// </summary>
    {(classInfoDTO.IsInterface ? "" : "//")}[{typeof(MonoCollectorSettingsAttribute).FullName}({GetByteArrayDisplayName(classInfoDTO.Utf8ImageName)}, 0x{classInfoDTO.TypeToken:X8}U)]
    {(classInfoDTO.IsInterface ? "//" : "")}[{typeof(MonoCollectorSettingsAttribute).FullName}({GetByteArrayDisplayName(classInfoDTO.Utf8ImageName)}, {GetByteArrayDisplayName(classInfoDTO.Utf8Namespace)}, {GetByteArrayDisplayName(classInfoDTO.Utf8Name)})]
    {staticAtt}
    {memberAtt}
    {MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_PartialClass} {classInfoDTO.GetFixClassName()}
    {{ 
        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_ConstString} {MonoCollecotrConvString.DisplayName_ConstImageName} = ""{classInfoDTO.ImageName}"";
        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_StaticByteArray} {MonoCollecotrConvString.DisplayName_StaticImageName} {{ get; }} = {GetByteArrayDisplayName(classInfoDTO.Utf8ImageName)};

        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_ConstString} {MonoCollecotrConvString.DisplayName_ConstNamespaceName} = ""{classInfoDTO.Namespace}"";
        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_StaticByteArray} {MonoCollecotrConvString.DisplayName_StaticNamespaceName} {{ get; }} = {GetByteArrayDisplayName(classInfoDTO.Utf8Namespace)};

        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_ConstString} {MonoCollecotrConvString.DisplayName_ConstClassName} = ""{classInfoDTO.Name}"";
        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_StaticByteArray} {MonoCollecotrConvString.DisplayName_StaticClassName} {{ get; }} = {GetByteArrayDisplayName(classInfoDTO.Utf8Name)};

        //{MonoCollecotrConvString.DisplayName_public} {MonoCollecotrConvString.DisplayName_ConstUInt32} {MonoCollecotrConvString.DisplayName_ConstTypeToken} = 0x{classInfoDTO.TypeToken:X8}U;



        {constContent}
            
        {staticContent}

        {memberContent}

    }}";
        }
        #endregion

        public static IEnumerable<string> OutputFiles(
            this MonoClassInfoDTO classInfoDTO,
            IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs,
            IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs,
            IReadOnlyList<MonoClassInfoDTO> parentClasses,
            IReadOnlyList<MonoInterfaceInfoDTO> interfaceInfoDTOs,
            int chuck = 256)
        {
            if (classInfoDTO.IsEnum)
            {
                var enumInfos = classInfoDTO.GetEnumFieldInfos(fieldInfoDTOs).OrderBy(p => p.Offset).ToArray();
                var enumTypeName = MonoCollectorExtensions.GetEnumTypeName(fieldInfoDTOs);
                yield return classInfoDTO.OutputEnumFieldContent(enumInfos, enumTypeName);
            }
            else
            {
                yield return classInfoDTO.OutputImageClassFieldContent(fieldInfoDTOs, parentClasses, interfaceInfoDTOs);

                var chuck_methodInfos = methodInfoDTOs.OrderBy(p => p.Name).Chunk(chuck);
                foreach (var methodInfos in chuck_methodInfos)
                {
                    yield return classInfoDTO.OutputMethodContent(methodInfos);
                }
            }
        }


        public static StringBuilder OutputStringBuilder(
            this MonoClassInfoDTO classInfoDTO,
            IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs,
            IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs,
            IReadOnlyList<MonoClassInfoDTO> parentClasses,
            IReadOnlyList<MonoInterfaceInfoDTO> interfaceInfoDTOs,
            int chuck = 256)
        {
            var sb = new StringBuilder();
            foreach (var line in OutputFiles(classInfoDTO, fieldInfoDTOs, methodInfoDTOs, parentClasses, interfaceInfoDTOs, chuck))
            {
                sb.AppendLine(line);
            }
            return sb;
        }

    }
}
