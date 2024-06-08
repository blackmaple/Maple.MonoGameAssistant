using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Maple.MonoGameAssistant.Core
{
    public sealed partial class MonoRuntimeContext
    {
        #region Helper  
        public static bool HasFlag(uint flags, uint flag)
        {
            return (flags & flag) != 0;
        }
        public static bool HasFlag(uint flags, uint flag, uint result)
        {
            return (flags & flag) == result;
        }

        public static bool IsStaticField(uint fieldFlags)
        {
            var flag = (uint)(EnumMonoFieldAttribute.FIELD_ATTRIBUTE_STATIC | EnumMonoFieldAttribute.FIELD_ATTRIBUTE_HAS_FIELD_RVA);
            return HasFlag(fieldFlags, flag);
        }
        public static bool IsConstField(uint fieldFlags)
        {
            var flag = (uint)(EnumMonoFieldAttribute.FIELD_ATTRIBUTE_LITERAL | EnumMonoFieldAttribute.FIELD_ATTRIBUTE_HAS_DEFAULT);
            return HasFlag(fieldFlags, flag);
        }

        public static bool IsStaticMethod(uint methodFlags)
        {
            var flag = (uint)EnumMonoMethodAttribute.METHOD_ATTRIBUTE_STATIC;
            return HasFlag(methodFlags, flag);
        }
        public static bool IsAbstractMethod(uint methodFlags)
        {
            var flag = (uint)EnumMonoMethodAttribute.METHOD_ATTRIBUTE_ABSTRACT;
            return HasFlag(methodFlags, flag);
        }
        public static bool IsPublicMethod(uint methodFlags)
        {
            var flag = (uint)EnumMonoMethodAttribute.METHOD_ATTRIBUTE_MEMBER_ACCESS_MASK;
            var result = (uint)EnumMonoMethodAttribute.METHOD_ATTRIBUTE_PUBLIC;
            return HasFlag(methodFlags, flag, result);
        }


        public static bool IsStaticClass(uint classFlags)
        {
            return HasFlag(classFlags, (uint)EnumMonoClassAttribute.TYPE_ATTRIBUTE_ABSTRACT)
                && HasFlag(classFlags, (uint)EnumMonoClassAttribute.TYPE_ATTRIBUTE_SEALED);
        }
        public static bool IsAbstractClass(uint classFlags)
        {
            return HasFlag(classFlags, (uint)EnumMonoClassAttribute.TYPE_ATTRIBUTE_ABSTRACT)
                && false == HasFlag(classFlags, (uint)EnumMonoClassAttribute.TYPE_ATTRIBUTE_INTERFACE);
        }
        public static bool IsInterfaceClass(uint classFlags)
        {
            return HasFlag(classFlags, (uint)EnumMonoClassAttribute.TYPE_ATTRIBUTE_INTERFACE);
        }
        #endregion

        #region Prop
        public ILogger Logger => RuntiemProvider.Logger;
        public EnumMonoRuntimeType RuntimeType => RuntiemProvider.RuntimeType;
        public IMonoRuntiemProvider RuntiemProvider { get; }
        public PMonoDomain RootDomain { get; }
        #endregion

        public MonoRuntimeContext(IMonoRuntiemProvider monoRuntiemProvider)
        {
            this.RuntiemProvider = monoRuntiemProvider;
            this.RootDomain = this.RuntiemProvider.GetMonoRootDomain();
        }

        #region IMonoRuntiemProvider->MonoDomains
        public MonoRuntimeAttachContext CreateAttachContext() => new(this);
        public PMonoThread AttachThread() => this.RuntiemProvider.MonoAttachThread(this.RootDomain);
        public void DetachThread(PMonoThread pMonoThread) => this.RuntiemProvider.MonoDetachThread(pMonoThread);

        #endregion

        #region IMonoRuntiemProvider->MonoImages
        private MonoImageInfoDTO GetMonoImageInfoDTO(PMonoImage pMonoImage)
        {
            var pUtf8ImageName = this.RuntiemProvider.GetMonoImageName(pMonoImage);
            var imageName = pUtf8ImageName.GetRawString();
            var utf8ImageName = pUtf8ImageName.ToArray();
            var fileName = this.RuntiemProvider.GetMonoImageFileName(pMonoImage);
            return new MonoImageInfoDTO() { Pointer = pMonoImage, Name = imageName, Utf8Name = utf8ImageName, FileName = fileName };
        }

        #endregion

        #region IMonoRuntiemProvider->Common

        public T_Struct CreateMonoClass<T_Struct>(PMonoClass pMonoClass, bool execDefCtor)
           where T_Struct : unmanaged
        {
            return this.RuntiemProvider.CreateMonoClass<T_Struct>(this.RootDomain, pMonoClass, execDefCtor);
        }

        public PMonoString GetMonoString(string str)
        {
            return this.RuntiemProvider.GetMonoString(this.RootDomain, str);
        }

        public Span<T_Struct> CreateMonoArray<T_Struct>(PMonoClass pMonoClass, int count, out PMonoArray pMonoArray)
             where T_Struct : unmanaged
        {
            pMonoArray = this.CreateMonoArray(pMonoClass, count);
            return pMonoArray.AsSpan<T_Struct>();
        }
        public PMonoArray CreateMonoArray(PMonoClass pMonoClass, int count)
            => this.RuntiemProvider.CreateMonoArray(this.RootDomain, pMonoClass, count);

        public unsafe T_METHOD GetInternalCall<T_METHOD>(string signature) where T_METHOD : unmanaged
        {
            var pMethod = this.RuntiemProvider.GetInternalCall(signature);
            return Unsafe.As<PDelegatePointer, T_METHOD>(ref pMethod);
        }

        #endregion

        #region IMonoRuntiemProvider->MonoField->Enum&Const&Static

        public nint GetMonoStaticFieldAddress(PMonoClass pMonoClass, int offset)
        {
            return this.RuntiemProvider.GetMonoStaticFieldAddress(this.RootDomain, pMonoClass, offset);
        }
        public T_Value GetMonoEnumFieldValue<T_Value>(PMonoField pMonoField)
            where T_Value : unmanaged
        {
            return this.RuntiemProvider.GetMonoEnumFieldValue<T_Value>(this.RootDomain, pMonoField);
        }

        public string GetMonoEnumFieldValue_String(PMonoField pMonoField, int size)
        {
            //考虑缓存区溢出的情况
            var buffer = (stackalloc byte[size]);
            if (this.RuntiemProvider.GetMonoEnumFieldValue_Buffer(this.RootDomain, pMonoField, buffer))
            {
                ulong val;
                //if size == 0x14   enum:uint
                if (size == Unsafe.SizeOf<REF_MONO_OBJECT>() + sizeof(uint))
                {
                    val = MemoryMarshal.Read<uint>(buffer);
                }

                //if size == 0x18   enum:ulong
                else if (size == Unsafe.SizeOf<REF_MONO_OBJECT>() + sizeof(ulong))
                {
                    val = MemoryMarshal.Read<ulong>(buffer);
                }

                //if size == 0x11   enum:byte
                else if (size == Unsafe.SizeOf<REF_MONO_OBJECT>() + sizeof(byte))
                {
                    val = MemoryMarshal.Read<byte>(buffer);
                }

                //if size == 0x12   enum:ushort
                else if (size == Unsafe.SizeOf<REF_MONO_OBJECT>() + sizeof(ushort))
                {
                    val = MemoryMarshal.Read<ushort>(buffer);
                }
                else
                {
                    return Convert.ToHexString(buffer);
                }
                return $"0x{val:X8}";

            }
            return string.Empty;

        }

        public T_Struct GetMonoStaticFieldValue_Unmanaged<T_Struct>(PMonoClass pMonoClass, PMonoField pMonoField)
            where T_Struct : unmanaged
        {
            return this.RuntiemProvider.GetMonoStaticFieldValue<T_Struct>(this.RootDomain, pMonoClass, pMonoField);
        }
        public bool GetMonoStaticFieldValue_Buffer(PMonoClass pMonoClass, PMonoField pMonoField, Span<byte> buffer)
        {
            return this.RuntiemProvider.GetMonoStaticFieldValue_Buffer(this.RootDomain, pMonoClass, pMonoField, buffer);
        }
        public string? GetMonoStaticFieldValue_String(PMonoClass pMonoClass, PMonoField pMonoField, int readSize = -1)
        {
            return this.RuntiemProvider.GetMonoStaticFieldValue_String(this.RootDomain, pMonoClass, pMonoField, readSize);
        }

        private MonoFieldInfoDTO GetMonoFieldInfoDTO(PMonoClass pMonoClass, PMonoField pMonoField, EnumMonoFieldOptions fieldOptions)
        {
            //      using (this.Logger.Running())
            //       {
            var fieldFlags = this.RuntiemProvider.GetMonoFieldFlags(pMonoField);

            var isStatic = IsStaticField(fieldFlags);

            var isConst = IsConstField(fieldFlags);

            var fieldName = this.RuntiemProvider.GetMonoFieldName(pMonoField);


            var fieldType = this.RuntiemProvider.GetMonoFieldType(pMonoField);

            var fieldTypeClass = this.GetMonoClassInfoDTO(fieldType, new MonoFieldTypeDTO());

            var rawOffset = this.RuntiemProvider.GetMonoFieldOffset(pMonoField);

            int fieldOffset;
            if (false == isStatic
                && this.RuntiemProvider.IsValueTypeClass(pMonoClass)
                && false == this.RuntiemProvider.IsEnumClass(pMonoClass))
            {
                //typevalue(struct) field offset 需要减去基类大小sizeof(REF_MONO_OBJECT)
                fieldOffset = (rawOffset - Unsafe.SizeOf<REF_MONO_OBJECT>());
            }
            else
            {
                fieldOffset = rawOffset;
            }

            var fieldValue = GetMonoStaticFieldValue(isStatic, isConst, pMonoClass, pMonoField, rawOffset, fieldTypeClass, fieldOptions);


            return new MonoFieldInfoDTO()
            {
                Pointer = pMonoField,
                Name = fieldName,
                FieldType = fieldTypeClass,
                Flags = fieldFlags,

                Offset = fieldOffset,
                RawOffset = rawOffset,

                IsConst = isConst,
                IsStatic = isStatic,
                Value = fieldValue,
                SourceClass = pMonoClass,
            };

            //    }



        }

        public string? GetMonoStaticFieldValue(
            bool isStatic, bool isConst,
            PMonoClass pMonoClass,
            PMonoField pMonoField,
            int fieldOffset,
            MonoClassInfoDTO fieldTypeClass,
            EnumMonoFieldOptions fieldOptions)
        {
            //不获取字段内容
            if (false == isStatic || fieldOptions == EnumMonoFieldOptions.None)
            {
                return default;
            }


            if (fieldTypeClass.IsEnum && (fieldOptions & EnumMonoFieldOptions.Enum) == EnumMonoFieldOptions.Enum)
            {
                //fixed read Enum Size 
                return this.GetMonoEnumFieldValue_String(pMonoField, fieldTypeClass.Size);
            }
            if (isConst)
            {
                if ((fieldOptions & EnumMonoFieldOptions.Const) != EnumMonoFieldOptions.Const)
                {
                    return default;
                }
            }
            else if ((fieldOptions & EnumMonoFieldOptions.Static) != EnumMonoFieldOptions.Static)
            {
                return default;
            }




            return fieldTypeClass switch
            {
                //{ IsEnum: true }
                //=> this.GetMonoEnumFieldValue<uint>(pMonoField).ToString(),

                //默认读<=64字符
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_STRING }
                => this.GetMonoStaticFieldValue_String(pMonoClass, pMonoField, 64),


                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_BOOLEAN }
                => this.GetMonoStaticFieldValue_Unmanaged<bool>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_CHAR }
                => this.GetMonoStaticFieldValue_Unmanaged<char>(pMonoClass, pMonoField).ToString(),


                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_I1 }
                => this.GetMonoStaticFieldValue_Unmanaged<sbyte>(pMonoClass, pMonoField).ToString(),
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_U1 }
                => this.GetMonoStaticFieldValue_Unmanaged<byte>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_I2 }
                => this.GetMonoStaticFieldValue_Unmanaged<short>(pMonoClass, pMonoField).ToString(),
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_U2 }
                => this.GetMonoStaticFieldValue_Unmanaged<ushort>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_I4 }
                => this.GetMonoStaticFieldValue_Unmanaged<int>(pMonoClass, pMonoField).ToString(),
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_U4 }
                => this.GetMonoStaticFieldValue_Unmanaged<uint>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_I8 }
                => this.GetMonoStaticFieldValue_Unmanaged<long>(pMonoClass, pMonoField).ToString(),
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_U8 }
                => this.GetMonoStaticFieldValue_Unmanaged<ulong>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_R4 }
                => this.GetMonoStaticFieldValue_Unmanaged<float>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_R8 }
                => this.GetMonoStaticFieldValue_Unmanaged<double>(pMonoClass, pMonoField).ToString(),

                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_I }
                => this.GetMonoStaticFieldValue_Unmanaged<nint>(pMonoClass, pMonoField).ToString("x8"),
                { TypeEnum: (uint)EnumMonoType.MONO_TYPE_U }
                => this.GetMonoStaticFieldValue_Unmanaged<nuint>(pMonoClass, pMonoField).ToString("x8"),



                {
                    TypeEnum: (uint)EnumMonoType.MONO_TYPE_VALUETYPE
                }
                => GetValueTypeValue_String(),


                {

                    TypeEnum:
                    (uint)EnumMonoType.MONO_TYPE_END
                    or (uint)EnumMonoType.MONO_TYPE_VOID
                    or (uint)EnumMonoType.MONO_TYPE_PTR
                    or (uint)EnumMonoType.MONO_TYPE_BYREF
                    or (uint)EnumMonoType.MONO_TYPE_CLASS
                    or (uint)EnumMonoType.MONO_TYPE_FNPTR
                    or (uint)EnumMonoType.MONO_TYPE_GENERICINST
                    or (uint)EnumMonoType.MONO_TYPE_ARRAY
                    or (uint)EnumMonoType.MONO_TYPE_SZARRAY

                }
                => GetReferenceTypePointer_String(),



                _ => this.GetMonoStaticFieldAddress(pMonoClass, fieldOffset).ToString("X8"),
            };


            string? GetValueTypeValue_String()
            {
                //fixed 缓存区溢出的情况?
                //read custom struct data  
                var buffer = (stackalloc byte[fieldTypeClass.Size]);
                if (false == this.GetMonoStaticFieldValue_Buffer(pMonoClass, pMonoField, buffer))
                {
                    return default;
                }

                if (fieldTypeClass.TypeName == typeof(decimal).FullName)
                {
                    return MemoryMarshal.Read<decimal>(buffer).ToString();
                    // return this.GetMonoStaticFieldValue_Unmanaged<decimal>(pMonoClass, pMonoField).ToString();
                }
                if (fieldTypeClass.TypeName == typeof(DateTime).FullName)
                {
                    return MemoryMarshal.Read<DateTime>(buffer).ToString("yyyy-MM-dd HH:mm:ss");
                    //return this.GetMonoStaticFieldValue_Unmanaged<DateTime>(pMonoClass, pMonoField).ToString("yyyy-MM-dd HH:mm:ss");
                }


                return Convert.ToHexString(buffer);
            }

            string? GetReferenceTypePointer_String()
            {
                return this.GetMonoStaticFieldValue_Unmanaged<PMonoAddress>(pMonoClass, pMonoField).ToString();
            }


        }

        #endregion

        #region IMonoRuntiemProvider->MonoClasses
        private MonoObjectInfoDTO GetMonoObjectInfoDTO(PMonoClass pMonoClass)
        {
            var pUtf8Class = this.RuntiemProvider.GetMonoClassName(pMonoClass);
            //  var pMonoType = this.RuntimeService.GetMonoClassType(pMonoClass);
            //  var typeName = this.RuntimeService.GetMonoTypeName(pMonoType);
            return new MonoObjectInfoDTO()
            {
                Pointer = pMonoClass,
                Name = pUtf8Class.ToString(),
                Utf8Name = pUtf8Class.ToArray(),
            };


        }

        private MonoInterfaceInfoDTO GetMonoInterfaceInfoDTO(PMonoClass pMonoClass)
            => GetMonoClassInfoDTO(pMonoClass, new MonoInterfaceInfoDTO(), true);

        private T_DTO GetMonoClassInfoDTO<T_DTO>(PMonoClass pMonoClass, PMonoType pMonoType, T_DTO classInfoDTO, bool iface)
            where T_DTO : MonoClassInfoDTO
        {
            classInfoDTO.Pointer = pMonoClass;

            var pMonoImage = this.RuntiemProvider.GetMonoClassImage(pMonoClass);
            var pUtf8ImageName = this.RuntiemProvider.GetMonoImageName(pMonoImage);
            classInfoDTO.ImageName = pUtf8ImageName.GetRawString();
            classInfoDTO.Utf8ImageName = pUtf8ImageName.ToArray();

            var pUtf8Namespace = this.RuntiemProvider.GetMonoClassNamespace(pMonoClass);
            classInfoDTO.Namespace = pUtf8Namespace.GetRawString();
            classInfoDTO.Utf8Namespace = pUtf8Namespace.ToArray();

            var pUtf8Class = this.RuntiemProvider.GetMonoClassName(pMonoClass);
            classInfoDTO.Name = pUtf8Class.GetRawString();
            classInfoDTO.Utf8Name = pUtf8Class.ToArray();

            //  var pMonoType = this.RuntimeService.GetMonoClassType(pMonoClass);
            var typeEnum = this.RuntiemProvider.GetMonoTypeEnum(pMonoType);
            classInfoDTO.TypeEnum = (uint)typeEnum;
            classInfoDTO.TypeName = this.RuntiemProvider.GetMonoTypeName(pMonoType);


            var classFlags = this.RuntiemProvider.GetMonoClassFlags(pMonoClass);
            classInfoDTO.Flags = classFlags;
            if (iface)
            {
                classInfoDTO.IsAbstract = true;
                classInfoDTO.IsStatic = false;
                classInfoDTO.IsInterface = true;
                classInfoDTO.IsEnum = false;
                classInfoDTO.IsValueType = false;
                classInfoDTO.Size = 0;

            }
            else
            {
                classInfoDTO.IsAbstract = IsAbstractClass(classFlags);
                classInfoDTO.IsStatic = IsStaticClass(classFlags);
                classInfoDTO.IsInterface = IsInterfaceClass(classFlags);
                classInfoDTO.IsEnum = this.RuntiemProvider.IsEnumClass(pMonoClass);
                classInfoDTO.IsValueType = this.RuntiemProvider.IsValueTypeClass(pMonoClass);
                classInfoDTO.Size = this.RuntiemProvider.GetMonoClassInstanceSize(pMonoClass);
            }

            classInfoDTO.IsGeneric = this.RuntiemProvider.IsGenericClass(pMonoClass);
            classInfoDTO.TypeToken = this.RuntiemProvider.GetMonoClassTypeToken(pMonoClass);


            return classInfoDTO;
        }

        private T_DTO GetMonoClassInfoDTO<T_DTO>(PMonoClass pMonoClass, T_DTO classInfoDTO, bool iface)
            where T_DTO : MonoClassInfoDTO
        {
            var pMonoType = this.RuntiemProvider.GetMonoClassType(pMonoClass);
            return GetMonoClassInfoDTO(pMonoClass, pMonoType, classInfoDTO, iface);
        }

        private T_DTO GetMonoClassInfoDTO<T_DTO>(PMonoType pMonoType, T_DTO monoTypeInfoDTO)
            where T_DTO : MonoClassInfoDTO
        {
            var typeClass = this.RuntiemProvider.GetMonoTypeClass(pMonoType);
            return GetMonoClassInfoDTO(typeClass, pMonoType, monoTypeInfoDTO, false);
        }

        private MonoClassInfoDTO GetMonoClassInfoDTO(PMonoClass pMonoClass) => GetMonoClassInfoDTO(pMonoClass, new MonoClassInfoDTO(), false);
        #endregion

        #region IMonoRuntiemProvider->MonoType


        #endregion

        #region IMonoRuntiemProvider->MonoMethods

        private MonoParameterTypeDTO GetMonoParameterTypeDTO(PMonoType pMonoType, string? parameterName)
        {
            var paramTypeDTO = this.GetMonoClassInfoDTO(pMonoType, new MonoParameterTypeDTO());
            paramTypeDTO.ParameterName = parameterName;
            return paramTypeDTO;
        }
        private IEnumerable<MonoParameterTypeDTO> EnumMonoParameterTypeDTO(IReadOnlyList<MonoMethodParamInfo> paramInfos)
        {
            foreach (var paramInfo in paramInfos)
            {
                yield return GetMonoParameterTypeDTO(paramInfo.ParamType, paramInfo.ParamName);
            }
        }
        private MonoReturnTypeDTO GetMonoReturnTypeDTO(PMonoType pMonoType)
        {
            return this.GetMonoClassInfoDTO(pMonoType, new MonoReturnTypeDTO());
        }
        private MonoMethodInfoDTO GetMonoMethodInfoDTO(PMonoClass pMonoClass, PMonoMethod pMonoMethod, bool fromParent)
        {
            var methodName = this.RuntiemProvider.GetMonoMethodName(pMonoMethod);

            var methodFlags = this.RuntiemProvider.GetMonoMethodFlags(pMonoMethod);
            var methodInfo = this.RuntiemProvider.GetMonoMethodInfo(pMonoMethod);
            var parameterTypes = EnumMonoParameterTypeDTO(methodInfo.ParamInfos).ToArray();

            var returnType = this.GetMonoReturnTypeDTO(methodInfo.ReturnType);
            var isStatic = IsStaticMethod(methodFlags);
            var isAbstract = IsAbstractMethod(methodFlags);
            var isPublic = IsPublicMethod(methodFlags);
            return new MonoMethodInfoDTO()
            {
                Pointer = pMonoMethod,
                Name = methodName,
                Flags = methodFlags,

                ParameterTypes = parameterTypes,
                ReturnType = returnType,

                IsStatic = isStatic,
                IsAbstract = isAbstract,
                IsPublic = isPublic,

                FromParent = fromParent,
                SourceClass = pMonoClass,
            };
        }

        #endregion

        #region MonoDataCollector

        public IEnumerable<MonoImageInfoDTO> EnumMonoImages()
        {
            var listAsm = this.RuntiemProvider.EnumMonoAssemblies(this.RootDomain);
            var listImage = this.RuntiemProvider.EnumMonoImages(listAsm);
            foreach (var pMonoImage in listImage)
            {
                yield return GetMonoImageInfoDTO(pMonoImage);
            }
        }

        public IEnumerable<MonoClassInfoDTO> EnumMonoClasses(PMonoImage pMonoImage)
        {
            var listClass = this.RuntiemProvider.EnumMonoClasses(pMonoImage);
            foreach (var pClass in listClass)
            {
                yield return this.GetMonoClassInfoDTO(pClass);
            }
        }

        public IEnumerable<MonoClassInfoDTO> EnumMonoParentClasses(PMonoClass pMonoClass)
        {
            var listParentClass = this.RuntiemProvider.EnumMonoParentClasses(pMonoClass);
            foreach (var parentClass in listParentClass)
            {
                yield return this.GetMonoClassInfoDTO(parentClass);
            }
        }

        public IEnumerable<MonoInterfaceInfoDTO> EnumMonoInterfaces(PMonoClass pMonoClass)
        {
            var listInterface = this.RuntiemProvider.EnumMonoInterfaces(pMonoClass);
            foreach (var @interface in listInterface)
            {
                yield return this.GetMonoInterfaceInfoDTO(@interface);
            }
        }

        public IEnumerable<MonoMethodInfoDTO> EnumMonoMethods(PMonoClass pMonoClass, bool valueType)
        {
            //my self
            var listMethod = this.RuntiemProvider.EnumMonoMethods(pMonoClass);
            foreach (var pMonoMethod in listMethod)
            {
                yield return GetMonoMethodInfoDTO(pMonoClass, pMonoMethod, false);
            }

            //parent 跳过系统默认基类
            //class : System.Object
            //struct : System.ValueType : System.Object
            //struct 不枚举
            if (false == valueType)
            {
                var parentClasses = this.RuntiemProvider.EnumMonoParentClasses(pMonoClass).SkipLast(1);
                foreach (var parentClass in parentClasses)
                {
                    var parentListMethod = this.RuntiemProvider.EnumMonoMethods(parentClass);
                    foreach (var pMonoMethod in parentListMethod)
                    {
                        yield return GetMonoMethodInfoDTO(parentClass, pMonoMethod, true);
                    }
                }
            }



        }

        public IEnumerable<MonoFieldInfoDTO> EnumMonoFields(PMonoClass pMonoClass, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.EnumAndConstAndStatic)
        {

            //my self
            var listField = this.RuntiemProvider.EnumMonoFields(pMonoClass);
            foreach (var pMonoField in listField)
            {
                yield return GetMonoFieldInfoDTO(pMonoClass, pMonoField, fieldOptions);
            }

            //parent
            var parentClasses = this.RuntiemProvider.EnumMonoParentClasses(pMonoClass);
            foreach (var parentClass in parentClasses)
            {
                var parentListField = this.RuntiemProvider.EnumMonoFields(parentClass);
                foreach (var pMonoField in parentListField)
                {
                    yield return GetMonoFieldInfoDTO(parentClass, pMonoField, fieldOptions);
                }
            }

        }

        public IEnumerable<MonoObjectInfoDTO> EnumMonoObjects(PMonoImage pMonoImage)
        {
            var listClass = this.RuntiemProvider.EnumMonoClasses(pMonoImage);
            foreach (var pMonoClass in listClass)
            {
                yield return GetMonoObjectInfoDTO(pMonoClass);
            }
        }

        public MonoClassDetailDTO GetMonoClassDetailDTO(PMonoClass pMonoClass, EnumMonoFieldOptions fieldOptions = EnumMonoFieldOptions.EnumAndConst)
        {
            var monoClassDetail = new MonoClassDetailDTO
            {
                ClassInfoDTO = this.GetMonoClassInfoDTO(pMonoClass),
            };

            //如果是泛型 只获取常量字段
            if (monoClassDetail.ClassInfoDTO.IsGeneric)
            {
                fieldOptions = EnumMonoFieldOptions.EnumAndConst;
            }
            monoClassDetail.FieldInfos = [.. this.EnumMonoFields(pMonoClass, fieldOptions).OrderByDescending(p => p.IsStatic).ThenBy(p => p.Offset)];

            if (false == monoClassDetail.ClassInfoDTO.IsEnum)
            {
                monoClassDetail.InterfaceInfos = [.. this.EnumMonoInterfaces(pMonoClass)];
            }

            if (false == monoClassDetail.ClassInfoDTO.IsValueType)
            {
                monoClassDetail.ParentClassInfos = [.. this.EnumMonoParentClasses(pMonoClass)];
                monoClassDetail.MethodInfos = [.. this.EnumMonoMethods(pMonoClass, false).OrderBy(p => p.FromParent).ThenByDescending(p => p.SourceClass).ThenBy(p => p.Name)];
            }
            return monoClassDetail;
        }

        public T_Struct GetMonoStaticFieldValue<T_Struct>(MonoCollectorClassInfo collectorClassInfo, Func<MonoFieldInfoDTO, bool> math)
            where T_Struct : unmanaged
        {
            if (collectorClassInfo.TryGetFirstStaticFieldInfo(math, out var static_field))
            {
                //fixed 2024年1月2日12点59分 获取字段值 使用字段成员SourceClass
                return this.GetMonoStaticFieldValue_Unmanaged<T_Struct>(static_field.SourceClass, static_field.Pointer);
            }
            return default;
        }

        public T_Struct GetMonoStaticFieldValue<T_Struct>(MonoCollectorClassInfo collectorClassInfo, string staticFieldName = "Instance")
            where T_Struct : unmanaged
        {
            if (collectorClassInfo.TryGetFirstStaticFieldInfo(staticFieldName, out var static_field))
            {
                //fixed 2024年1月2日12点59分 获取字段值 使用字段成员SourceClass
                return this.GetMonoStaticFieldValue_Unmanaged<T_Struct>(static_field.SourceClass, static_field.Pointer);
            }
            return default;
        }

        public bool TryGetFirstClassInfo(MonoImageInfoDTO imageInfoDTO, MonoCollecotrClassSettings classSettings, [MaybeNullWhen(false)] out MonoCollectorClassInfo collectorClassInfo)
        {
            collectorClassInfo = default;
            if (classSettings.TypeToken >= (uint)EnumMonoTokenType.MONO_TOKEN_TYPE_DEF)
            {
                if (this.RuntiemProvider.TryGetMonoClass(imageInfoDTO.Pointer, classSettings.TypeToken, out var pMonoClass))
                {
                    collectorClassInfo = GetMonoCollectorClassInfo(pMonoClass);
                }
            }
            else if (this.RuntiemProvider.TryGetMonoClass(imageInfoDTO.Pointer, classSettings.Utf8Namespace, classSettings.Utf8ClassName, out var pMonoClass))
            {
                collectorClassInfo = GetMonoCollectorClassInfo(pMonoClass);

            }
            return collectorClassInfo is not null;

            MonoCollectorClassInfo GetMonoCollectorClassInfo(PMonoClass pMonoClass)
            {
                var classInfoDTO = this.GetMonoClassInfoDTO(pMonoClass);

                var collectorClassInfo = new MonoCollectorClassInfo(classInfoDTO);
                collectorClassInfo.MethodInfos.AddRange(this.EnumMonoMethods(pMonoClass, classInfoDTO.IsValueType));
                collectorClassInfo.FieldInfos.AddRange(this.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.None));
                return collectorClassInfo;
            }

        }



        #endregion

        #region WebApi
        public MonoRuntimeWebApiService CreateWebApiService() => new(this);

        #endregion
    }
}
