using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MonoCollector
{
    public static class MonoCollectorExtensions
    {
        #region Helper

        public static bool EquClassInfo(this MonoClassInfoDTO leftClass, MonoClassInfoDTO rightClass, bool pointer = false)
        {
            if (leftClass.ImageName != rightClass.ImageName)
            {
                return false;
            }
            if (leftClass.Namespace != rightClass.Namespace)
            {
                return false;
            }
            if (leftClass.Name != rightClass.Name)
            {
                return false;
            }

            return !pointer || (leftClass.Pointer == rightClass.Pointer);

        }

        public static bool SingletonPattern(this MonoClassDetailDTO @this)
        {
            if (@this.FieldInfos?.Length > 0 != true)
            {
                return false;
            }
            foreach (var staticField in GetStaticFieldInfos(@this.ClassInfoDTO, @this.FieldInfos))
            {
                var fieldType = staticField.FieldType;
                if (@this.ClassInfoDTO.EquClassInfo(fieldType, true))
                {
                    if (@this.ClassInfoDTO.TypeName == fieldType.TypeName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        #endregion


        #region MonoMethodInfoDTO
        public static IEnumerable<MonoMethodInfoDTO> GetStaticMethodInfos(this MonoCollectorClassInfo collectorClassInfo)
            => collectorClassInfo.MethodInfos.GetStaticMethodInfos();
        public static IEnumerable<MonoMethodInfoDTO> GetStaticMethodInfos(this IEnumerable<MonoMethodInfoDTO> methodInfoDTOs)
            => methodInfoDTOs.Where(p => p.IsStatic);
        public static IEnumerable<MonoMethodInfoDTO> GetAbstractMethodInfos(this MonoCollectorClassInfo collectorClassInfo)
            => collectorClassInfo.MethodInfos.GetAbstractMethodInfos();
        public static IEnumerable<MonoMethodInfoDTO> GetAbstractMethodInfos(this IEnumerable<MonoMethodInfoDTO> methodInfoDTOs)
            => methodInfoDTOs.Where(p => p.IsAbstract);
        public static IEnumerable<MonoMethodInfoDTO> GetMemberMethodInfos(this MonoCollectorClassInfo collectorClassInfo)
            => collectorClassInfo.MethodInfos.GetMemberMethodInfos();
        public static IEnumerable<MonoMethodInfoDTO> GetMemberMethodInfos(this IEnumerable<MonoMethodInfoDTO> methodInfoDTOs)
            => methodInfoDTOs.Where(p => p.IsStatic == false && p.IsAbstract == false);

        public static bool SearchMonoMethodInfo(this MonoMethodInfoDTO methodInfoDTO, string? methodName, params string[] typeNames)
        {
            if (methodInfoDTO.Name != methodName)
            {
                return false;
            }
            var parameterTypes = methodInfoDTO.ParameterTypes;
            if (parameterTypes.Length != typeNames.Length)
            {
                return false;
            }
            for (int i = 0; i < parameterTypes.Length; ++i)
            {
                if (parameterTypes[i % parameterTypes.Length].TypeName != typeNames[i % typeNames.Length])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SearchMonoMethodInfoEx(this MonoMethodInfoDTO methodInfoDTO, string? methodName, string returnTypeName)
        {
            if (methodInfoDTO.Name != methodName)
            {
                return false;
            }
            var returnType = methodInfoDTO.ReturnType;

            return returnType.TypeName == returnTypeName;
        }

        #endregion

        #region MonoFieldInfoDTO
        public static string? GetEnumTypeName(IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            return fieldInfoDTOs.Where(p => p.Name == "value__").FirstOrDefault()?.FieldType?.FullName ?? typeof(uint).FullName;
        }
        public static IEnumerable<MonoFieldInfoDTO> GetEnumFieldInfos(this MonoCollectorClassInfo collectorClassInfo)
        {
            return collectorClassInfo.ClassInfoDTO.GetEnumFieldInfos(collectorClassInfo.FieldInfos);
        }
        public static IEnumerable<MonoFieldInfoDTO> GetEnumFieldInfos(this MonoClassInfoDTO classInfoDTO, IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            if (classInfoDTO.IsEnum)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    if (field.IsStatic && field.FieldType.IsEnum)
                    {
                        yield return field;
                    }
                }
            }
        }
        public static bool IsEnumFieldInfo(this MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO fieldInfoDTO)
        {
            return classInfoDTO.IsEnum && fieldInfoDTO.IsStatic && fieldInfoDTO.FieldType.IsEnum;
        }

        public static IEnumerable<MonoFieldInfoDTO> GetStaticFieldInfos(this MonoCollectorClassInfo collectorClassInfo)
        {
            return collectorClassInfo.ClassInfoDTO.GetStaticFieldInfos(collectorClassInfo.FieldInfos);
        }
        public static IEnumerable<MonoFieldInfoDTO> GetStaticFieldInfos(this MonoClassInfoDTO classInfoDTO, IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            if (classInfoDTO.IsEnum == false)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    if (field.IsStatic && field.IsConst == false)
                    {
                        yield return field;
                    }
                }
            }
        }
        public static bool IsStaticFieldInfo(this MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO fieldInfoDTO)
        {
            return false == classInfoDTO.IsEnum && fieldInfoDTO.IsStatic && fieldInfoDTO.IsConst == false;
        }


        public static IEnumerable<MonoFieldInfoDTO> GetConstFieldInfos(this MonoCollectorClassInfo collectorClassInfo)
        {
            return collectorClassInfo.ClassInfoDTO.GetConstFieldInfos(collectorClassInfo.FieldInfos);

        }
        public static IEnumerable<MonoFieldInfoDTO> GetConstFieldInfos(this MonoClassInfoDTO classInfoDTO, IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            if (classInfoDTO.IsEnum == false)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    if (field.IsStatic && field.IsConst)
                    {
                        yield return field;
                    }
                }
            }
        }
        public static bool IsConstFieldInfo(this MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO fieldInfoDTO)
        {
            return false == classInfoDTO.IsEnum && fieldInfoDTO.IsStatic && fieldInfoDTO.IsConst;
        }

        public static IEnumerable<MonoFieldInfoDTO> GetMemberFieldInfos(this MonoCollectorClassInfo collectorClassInfo)
        {
            return collectorClassInfo.ClassInfoDTO.GetMemberFieldInfos(collectorClassInfo.FieldInfos);
        }
        public static MonoFieldInfoDTO? GetFirstMemberFieldInfo(this MonoCollectorClassInfo collectorClassInfo, string? fieldName)
        {
            return collectorClassInfo.ClassInfoDTO.GetMemberFieldInfos(collectorClassInfo.FieldInfos)
                .FirstOrDefault(p => p.Name == fieldName);
        }

        public static IEnumerable<MonoFieldInfoDTO> GetMemberFieldInfos(this MonoClassInfoDTO classInfoDTO, IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs)
        {
            if (classInfoDTO.IsEnum == false)
            {
                foreach (var field in fieldInfoDTOs)
                {
                    if (field.IsStatic == false)
                    {
                        yield return field;
                    }
                }
            }
        }
        public static bool IsMemberFieldInfo(this MonoClassInfoDTO classInfoDTO, MonoFieldInfoDTO fieldInfoDTO)
        {
            return false == classInfoDTO.IsEnum && false == fieldInfoDTO.IsStatic;
        }
        #endregion

        #region TryGet

        public static bool TryGetFirstImageClasses(this IReadOnlyList<MonoCollectorImageInfo> imageInfos, string imageName, [MaybeNullWhen(false)] out IReadOnlyList<MonoCollectorClassInfo> classInfos)
        {
            classInfos = imageInfos.FirstOrDefault(p => p.ImageInfoDTO.Name == imageName)?.ListClassInfo;
            return classInfos is not null;
        }

        public static bool TryGetFirstClass(this IReadOnlyList<MonoCollectorClassInfo> classInfos, string nameSpace, string className, [MaybeNullWhen(false)] out MonoCollectorClassInfo classInfo)
        {
            classInfo = classInfos.FirstOrDefault(p => p.ClassInfoDTO.Namespace == nameSpace && p.ClassInfoDTO.Name == className);
            return classInfo is not null;
        }


        public static bool TryGetFirstMethodInfo(this IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs, Func<MonoMethodInfoDTO, bool> math, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            methodInfoDTO = methodInfoDTOs.FirstOrDefault(math);
            return methodInfoDTO is not null;
        }
        //public static bool TryGetFirstMethodInfo(this IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs, string methodName, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        //{
        //    return methodInfoDTOs.TryGetFirstMethodInfo(p => p.Name == methodName, out methodInfoDTO);
        //}

        //[Obsolete("MethodAddress error")]
        //public static bool TryGetMethodPointer<T_MethodPointer>(this MonoMethodInfoDTO methodInfoDTO, out T_MethodPointer methodPointer)
        //    where T_MethodPointer : unmanaged
        //{
        //    var addr = methodInfoDTO.MethodAddress;
        //    methodPointer = Unsafe.As<nint, T_MethodPointer>(ref addr);
        //    return addr != nint.Zero;
        //}
        //[Obsolete("MethodAddress error")]
        //public static bool TryGetMethodPointer<T_MethodPointer>(this IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs, string methodName, out T_MethodPointer methodPointer)
        //    where T_MethodPointer : unmanaged
        //{
        //    return methodInfoDTOs.TryGetMethodPointer(p => p.Name == methodName, out methodPointer);
        //}
        //[Obsolete("MethodAddress error")]
        //public static bool TryGetMethodPointer<T_MethodPointer>(this IReadOnlyList<MonoMethodInfoDTO> methodInfoDTOs, Func<MonoMethodInfoDTO, bool> math, out T_MethodPointer methodPointer)
        //    where T_MethodPointer : unmanaged
        //{
        //    methodPointer = default;
        //    if (methodInfoDTOs.TryGetFirstMethodInfo(math, out var methodInfoDTO))
        //    {
        //        if (methodInfoDTO.TryGetMethodPointer(out methodPointer))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public static bool TryGetFirstFieldInfo(this IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs, Func<MonoFieldInfoDTO, bool> math, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            fieldInfoDTO = fieldInfoDTOs.FirstOrDefault(math);
            return fieldInfoDTO is not null;
        }
        public static bool TryGetFirstFieldInfo(this IReadOnlyList<MonoFieldInfoDTO> fieldInfoDTOs, string fieldName, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            return fieldInfoDTOs.TryGetFirstFieldInfo(p => p.Name == fieldName, out fieldInfoDTO);
        }

        public static bool TryGetFirstStaticFieldInfo(this MonoCollectorClassInfo collectorClassInfo, Func<MonoFieldInfoDTO, bool> math, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            fieldInfoDTO = collectorClassInfo.GetStaticFieldInfos().FirstOrDefault(math);
            return fieldInfoDTO is not null;
        }
        public static bool TryGetFirstStaticFieldInfo(this MonoCollectorClassInfo collectorClassInfo, string fieldName, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            fieldInfoDTO = collectorClassInfo.GetStaticFieldInfos().FirstOrDefault(p => p.Name == fieldName);
            return fieldInfoDTO is not null;
        }

        public static bool TryGetFirstImageInfo(this IReadOnlyList<MonoImageInfoDTO> imageInfoDTOs, byte[]? utf8Name, [MaybeNullWhen(false)] out MonoImageInfoDTO imageInfoDTO)
        {
            imageInfoDTO = imageInfoDTOs.Where(p => SequenceEqual(p.Utf8Name, utf8Name)).FirstOrDefault();
            return imageInfoDTO is not null;
            static bool SequenceEqual(ReadOnlySpan<byte> dest, ReadOnlySpan<byte> findSearch)
            {
                if (MemoryExtensions.SequenceEqual<byte>(dest, findSearch))
                {
                    return true;
                }
                return findSearch.EndsWith(".dll"u8) && MemoryExtensions.SequenceEqual<byte>(dest, findSearch[..^4]);
            }
        }

        #endregion
    }
}
