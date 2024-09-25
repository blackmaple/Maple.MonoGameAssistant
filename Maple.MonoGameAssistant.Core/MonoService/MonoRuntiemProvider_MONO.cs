using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Buffers;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{

    internal class MonoRuntiemProvider_MONO(ILogger logger, MonoRuntimeApi runtime) : IMonoRuntiemProvider
    {
        //private static ConcurrentDictionary<string, PMonoString> MonoStringCache { get; } = new ConcurrentDictionary<string, PMonoString>();

        #region Props
        protected MonoRuntimeApi Runtime { get; } = runtime;
        public ILogger Logger { get; } = logger;
        public EnumMonoRuntimeType RuntimeType => this.Runtime.RuntimeType;
        #endregion

        #region MonoDomains
        public unsafe virtual IEnumerable<PMonoDomain> EnumMonoDomains()
        {
            var listMonoDomain = new List<PMonoDomain>(256);
            using var ref_listMonoDomain = new MapleObjectUnmanaged_Ref(listMonoDomain);

            this.Runtime.MONO_DOMAIN_FOREACH.Invoke(&CalbackMonoDomainFunc, new(ref_listMonoDomain));
            return listMonoDomain;

        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        static unsafe void CalbackMonoDomainFunc(PMonoDomain pMonoDomain, PMonoUserData pUserData)
        {
            if (MapleObjectUnmanaged_Ref.TryGet<List<PMonoDomain>>(pUserData, out var list))
            {
                list.Add(pMonoDomain);
            }
        }


        public virtual PMonoDomain GetMonoRootDomain()
        {
            return this.Runtime.MONO_GET_ROOT_DOMAIN.Invoke();
        }
        public PMonoThread MonoAttachThread(PMonoDomain pMonoDomain)
        {
            return this.Runtime.MONO_THREAD_ATTACH.Invoke(pMonoDomain);
        }
        public void MonoDetachThread(PMonoThread pMonoThread)
        {
            this.Runtime.MONO_THREAD_DETACH.Invoke(pMonoThread);
        }

        #endregion

        #region MonoAssemblies
        public unsafe virtual IEnumerable<PMonoAssembly> EnumMonoAssemblies(PMonoDomain _)
        {
            var listMonoAssembly = new List<PMonoAssembly>(256);
            using var ref_listMonoAssembly = new MapleObjectUnmanaged_Ref(listMonoAssembly);
            PMonoUserData pUserData = new(ref_listMonoAssembly);
            this.Runtime.MONO_ASSEMBLY_FOREACH.Invoke(&CalbackMonoAssemblyFunc, pUserData);
            return listMonoAssembly;


            [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
            unsafe static void CalbackMonoAssemblyFunc(PMonoAssembly pMonoAssembly, PMonoUserData pUserData)
            {
                if (MapleObjectUnmanaged_Ref.TryGet<List<PMonoAssembly>>(pUserData, out var list))
                {
                    list.Add(pMonoAssembly);
                }
            }



        }
        #endregion

        #region MonoImages
        public IEnumerable<PMonoImage> EnumMonoImages(IEnumerable<PMonoAssembly> pMonoAssemblies)
        {
            foreach (var pAssembly in pMonoAssemblies)
            {
                var pImage = this.Runtime.MONO_ASSEMBLY_GET_IMAGE.Invoke(pAssembly);
                if (pImage.Valid())
                {
                    yield return pImage;
                }
            }
        }
        public PMonoUtf8Char GetMonoImageName(PMonoImage pMonoImage)
        {
            var pImageName = this.Runtime.MONO_IMAGE_GET_NAME.Invoke(pMonoImage);
            return pImageName;
        }
        public string? GetMonoImageFileName(PMonoImage pMonoImage)
        {
            var pImageFileName = this.Runtime.MONO_IMAGE_GET_FILENAME.Invoke(pMonoImage);
            return pImageFileName.ToString();
        }
        //public bool TryGetMonoImage(PMonoAssembly pMonoAssembly, string imageName, out PMonoImage pMonoImage)
        //{
        //    pMonoImage = this.Runtime.MONO_ASSEMBLY_GET_IMAGE.Invoke(pMonoAssembly);
        //    if (pMonoImage.Valid() == false)
        //    {
        //        return false;
        //    }
        //    var pMonoUtf8Char = this.Runtime.MONO_IMAGE_GET_NAME.Invoke(pMonoImage);
        //    var monoImageName = pMonoUtf8Char.ToString();
        //    return !string.IsNullOrEmpty(monoImageName) && monoImageName.Contains(imageName, StringComparison.OrdinalIgnoreCase);
        //}
        //public bool TryGetMonoImage(string imageName, out PMonoImage pMonoImage)
        //{
        //    Unsafe.SkipInit(out pMonoImage);

        //    var listAsm = this.EnumMonoAssemblies();
        //    foreach (var pAsm in listAsm)
        //    {
        //        if (this.TryGetMonoImage(pAsm, imageName, out pMonoImage))
        //        {
        //            return pMonoImage.Valid();
        //        }
        //    }
        //    return false;
        //}

        #endregion

        #region  MonoClasses
        public IEnumerable<PMonoInterface> EnumMonoInterfaces(PMonoClass pMonoClass)
        {
            PMonoIterator pMonoIterator = default;
            do
            {
                var pInterface = this.Runtime.MONO_CLASS_GET_INTERFACES.Invoke(pMonoClass, ref pMonoIterator);
                if (false == pInterface.Valid())
                {
                    yield break;
                }
                yield return pInterface;

            } while (true);
        }
        public bool TryGetMonoClass(PMonoImage pMonoImage, ReadOnlySpan<byte> utf8Namespace, ReadOnlySpan<byte> utf8ClassName, out PMonoClass pMonoClass)
        {
            pMonoClass = this.Runtime.MONO_CLASS_FROM_NAME.Invoke(pMonoImage, utf8Namespace, utf8ClassName);
            return pMonoClass.Valid();
        }



        public virtual bool TryGetMonoClass(PMonoImage pMonoImage, uint type_token, out PMonoClass pMonoClass)
        {
            pMonoClass = this.Runtime.MONO_CLASS_GET.Invoke(pMonoImage, type_token);
            return pMonoClass.Valid();
        }

        public virtual IEnumerable<PMonoClass> EnumMonoClasses(PMonoImage pMonoImage)
        {
            var pTableInfo = this.Runtime.MONO_IMAGE_GET_TABLE_INFO.Invoke(pMonoImage, EnumMonoMetaTable.MONO_TABLE_TYPEDEF);
            if (pTableInfo.Valid())
            {
                var tableCount = this.Runtime.MONO_TABLE_INFO_GET_ROWS.Invoke(pTableInfo);
                for (int row = 0; row < tableCount; ++row)
                {

                    uint tokenIndex = (uint)EnumMonoTokenType.MONO_TOKEN_TYPE_DEF | (uint)(row + 1);
                    var pClass = this.Runtime.MONO_CLASS_GET.Invoke(pMonoImage, tokenIndex);
                    if (pClass.Valid())
                    {
                        yield return pClass;
                    }
                }
            }
        }

        public bool IsGenericClass(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_IS_GENERIC.Invoke(pMonoClass);
        }
        public bool IsEnumClass(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_IS_ENUM.Invoke(pMonoClass);
        }
        public bool IsValueTypeClass(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_IS_VALUETYPE.Invoke(pMonoClass);

        }

        public bool HasParentClass(PMonoClass pMonoClass)
        {
            pMonoClass = this.Runtime.MONO_CLASS_GET_PARENT.Invoke(pMonoClass);
            return pMonoClass.Valid();
        }
        //public bool IsSubClassOf(PMonoClass PMonoClass, PMonoClass pParentClass, bool checkInteface)
        //{
        //    return this.Runtime.MONO_CLASS_IS_SUBCLASS_OF.Invoke(PMonoClass, pParentClass, checkInteface);
        //}
        //public PMonoNestingType GetMonoClassNesting(PMonoClass pMonoClass)
        //{
        //    return this.Runtime.MONO_CLASS_GET_NESTING_TYPE.Invoke(pMonoClass);
        //}
        public PMonoUtf8Char GetMonoClassName(PMonoClass pMonoClass)
        {
            var pClassName = this.Runtime.MONO_CLASS_GET_NAME.Invoke(pMonoClass);
            return pClassName;
        }
        public PMonoUtf8Char GetMonoClassNamespace(PMonoClass pMonoClass)
        {
            var pNamespace = this.Runtime.MONO_CLASS_GET_NAMESPACE.Invoke(pMonoClass);
            return pNamespace;
        }
        public IEnumerable<PMonoClass> EnumMonoParentClasses(PMonoClass pMonoClass)
        {

            do
            {
                pMonoClass = this.Runtime.MONO_CLASS_GET_PARENT.Invoke(pMonoClass);

                if (false == pMonoClass.Valid())
                {
                    yield break;
                }
                yield return pMonoClass;
            } while (true);
        }
        public int GetMonoClassInstanceSize(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_INSTANCE_SIZE.Invoke(pMonoClass);
        }





        public uint GetMonoClassTypeToken(PMonoClass pMonoClass)
            => this.Runtime.MONO_CLASS_GET_TYPE_TOKEN.Invoke(pMonoClass);




        public PMonoImage GetMonoClassImage(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_GET_IMAGE.Invoke(pMonoClass);
        }


        public uint GetMonoClassFlags(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_GET_FLAGS.Invoke(pMonoClass);
        }

        public PMonoType GetMonoClassType(PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_GET_TYPE.Invoke(pMonoClass);
        }
        #endregion

        #region MonoMethods
        //public bool TryGetMonoMethod(PMonoClass pMonoClass, string methodName, out PMonoMethod pMonoMethod, int paramCount = -1)
        //{
        //    pMonoMethod = this.Runtime.MONO_CLASS_GET_METHOD_FROM_NAME.Invoke(pMonoClass, methodName, paramCount);
        //    return pMonoMethod.Valid();

        //}
        public IEnumerable<PMonoMethod> EnumMonoMethods(PMonoClass pMonoClass)
        {
            PMonoIterator pMonoIterator = default;

            do
            {
                var pMethod = this.Runtime.MONO_CLASS_GET_METHODS.Invoke(pMonoClass, ref pMonoIterator);
                if (false == pMethod.Valid())
                {
                    yield break;
                }
                yield return pMethod;

            } while (true);
        }
        //public IEnumerable<PMonoMethod> EnumMonoMethods(PMonoClass pMonoClass, IEnumerable<PMonoClass> pParentClasses)
        //{
        //    //返回self Method
        //    var selfMethods = this.EnumMonoMethods(pMonoClass);
        //    foreach (var pMethod in selfMethods)
        //    {
        //        yield return pMethod;
        //    }
        //    //返回ParentClass Method
        //    foreach (var pParentClass in pParentClasses)
        //    {
        //        var parentMethods = this.EnumMonoMethods(pParentClass);
        //        foreach (var pMethod in parentMethods)
        //        {
        //            yield return pMethod;
        //        }
        //    }
        //}
        public string? GetMonoMethodName(PMonoMethod pMonoMethod)
        {
            var pMethodName = this.Runtime.MONO_METHOD_GET_NAME.Invoke(pMonoMethod);
            return pMethodName.ToString();
        }
        public uint GetMonoMethodFlags(PMonoMethod pMonoMethod)
        {
            return this.Runtime.MONO_METHOD_GET_FLAGS.Invoke(pMonoMethod);
        }
        MonoMethodParamInfo[] EnumMonoMethodParameters(PMonoMethod pMonoMethod, PMethodSignature pMethodSignature)
        {
            int paramCount = this.Runtime.MONO_SIGNATURE_GET_PARAM_COUNT.Invoke(pMethodSignature);
            if (paramCount == 0)
            {
                return [];
            }


            var paramNames = (stackalloc PMonoUtf8Char[paramCount]);
            this.Runtime.MONO_METHOD_GET_PARAM_NAMES.Invoke(pMonoMethod, paramNames);


            var paramInfos = new MonoMethodParamInfo[paramCount];
            Debug.Assert(typeof(MonoMethodParamInfo).IsValueType);
            PMonoIterator pMonoIterator = default;
            for (int i = 0; i < paramCount; ++i)
            {
                var paramType = this.Runtime.MONO_SIGNATURE_GET_PARAMS.Invoke(pMethodSignature, ref pMonoIterator);
                ref var paramInfo = ref paramInfos[i % paramInfos.Length];
                paramInfo.ParamType = paramType;
                paramInfo.ParamName = paramNames[i % paramNames.Length].ToString();
            }
            return paramInfos;

        }
        private PMonoType GetMonoMethodReturnType(PMethodSignature pMethodSignature)
        {
            return this.Runtime.MONO_SIGNATURE_GET_RETURN_TYPE.Invoke(pMethodSignature);
        }
        private PMethodSignature GetMonoMethodSignature(PMonoMethod pMonoMethod)
        {
            return this.Runtime.MONO_METHOD_SIG.Invoke(pMonoMethod);
        }
        public virtual MonoMethodDescInfo GetMonoMethodInfo(PMonoMethod pMonoMethod)
        {
            var pMethodSignature = this.GetMonoMethodSignature(pMonoMethod);
            if (pMethodSignature.Valid())
            {
                var returnType = GetMonoMethodReturnType(pMethodSignature);
                var paramInfos = EnumMonoMethodParameters(pMonoMethod, pMethodSignature);
                return new MonoMethodDescInfo(returnType, paramInfos);
            }
            return new MonoMethodDescInfo(nint.Zero, []);
        }

        //public PMonoMethodHeader GetMonoMethodHeader(PMonoMethod pMonoMethod)
        //{
        //    return this.Runtime.MONO_METHOD_GET_HEADER.Invoke(pMonoMethod);
        //}


        public virtual MonoMethodPointer GetMonoMethodAddress(PMonoMethod pMonoMethod)
        {

            return this.Runtime.MONO_COMPILE_METHOD.Invoke(pMonoMethod);
        }
        //public bool TryGetFirstMonoMethodPointer(PMonoImage pMonoImage, string nameSpace, string className, string methodName, out MonoMethodPointer methodPointer, int paramCount = -1)
        //{
        //    Unsafe.SkipInit(out methodPointer);

        //    if (false == this.TryGetMonoClass(pMonoImage, nameSpace, className, out var pMonoClass))
        //    {
        //        return false;
        //    }
        //    if (false == this.TryGetMonoMethod(pMonoClass, methodName, out var pMonoMethod, paramCount))
        //    {
        //        return false;
        //    }
        //    methodPointer = this.GetMonoMethodAddress(pMonoMethod);
        //    return methodPointer.Valid();

        //}

        #endregion

        #region MonoField

        public IEnumerable<PMonoField> EnumMonoFields(PMonoClass pMonoClass)
        {
            PMonoIterator pMonoIterator = default;
            do
            {
                var pField = this.Runtime.MONO_CLASS_GET_FIELDS.Invoke(pMonoClass, ref pMonoIterator);
                if (false == pField.Valid())
                {
                    yield break;
                }
                yield return pField;

            } while (true);
        }

        //public IEnumerable<PMonoField> EnumMonoFields(PMonoClass pMonoClass, IEnumerable<PMonoClass> pParentClasses)
        //{
        //    //返回self Field
        //    var selfFields = this.EnumMonoFields(pMonoClass);
        //    foreach (var pField in selfFields)
        //    {
        //        yield return pField;
        //    }
        //    //返回ParentClass Field
        //    foreach (var pParentClass in pParentClasses)
        //    {
        //        var parentFields = this.EnumMonoFields(pParentClass);
        //        foreach (var pField in parentFields)
        //        {
        //            yield return pField;
        //        }
        //    }
        //}

        public PMonoType GetMonoFieldType(PMonoField pMonoField)
        {
            return this.Runtime.MONO_FIELD_GET_TYPE.Invoke(pMonoField);
        }
        //public PMonoField GetMonoFieldParent(PMonoField pMonoField)
        //{
        //    return this.Runtime.MONO_FIELD_GET_PARENT.Invoke(pMonoField);
        //}
        public int GetMonoFieldOffset(PMonoField pMonoField)
        {
            return this.Runtime.MONO_FIELD_GET_OFFSET.Invoke(pMonoField);
        }
        public uint GetMonoFieldFlags(PMonoField pMonoField)
        {
            return this.Runtime.MONO_FIELD_GET_FLAGS.Invoke(pMonoField);
        }
        public string? GetMonoFieldName(PMonoField pMonoField)
        {
            var pFieldName = this.Runtime.MONO_FIELD_GET_NAME.Invoke(pMonoField);
            return pFieldName.ToString();
        }
        #endregion

        #region MonoField->Enum&Const&Static
        public virtual T_STRUCT GetMonoEnumFieldValue<T_STRUCT>(PMonoDomain pMonoDomain, PMonoField pMonoField)
            where T_STRUCT : unmanaged
        {
            var pMonoObject = this.Runtime.MONO_FIELD_GET_VALUE_OBJECT.Invoke(pMonoDomain, pMonoField);
            //equ=>if(pMonoObject is pEnumClass pObject)
            var pEnumClass = this.Runtime.MONO_GET_ENUM_CLASS.Invoke();
            var pObject = this.Runtime.MONO_OBJECT_ISINST.Invoke(pMonoObject, pEnumClass);
            if (false == pObject.Valid())
            {
                return default;
            }
            var pMonoAddress = this.Runtime.MONO_OBJECT_UNBOX.Invoke(pObject);
            return pMonoAddress.ReadValue<T_STRUCT>();
        }

        public virtual bool GetMonoEnumFieldValue_Buffer(PMonoDomain pMonoDomain, PMonoField pMonoField, Span<byte> buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }
            var pMonoObject = this.Runtime.MONO_FIELD_GET_VALUE_OBJECT.Invoke(pMonoDomain, pMonoField);
            //equ=>if(pMonoObject is pEnumClass pObject)
            var pEnumClass = this.Runtime.MONO_GET_ENUM_CLASS.Invoke();
            var pObject = this.Runtime.MONO_OBJECT_ISINST.Invoke(pMonoObject, pEnumClass);
            if (false == pObject.Valid())
            {
                return false;
            }

            var pMonoAddress = this.Runtime.MONO_OBJECT_UNBOX.Invoke(pObject);
            pMonoAddress.CopyTo(buffer);
            return true;
        }


        public virtual PMonoAddress GetMonoStaticFieldAddress(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int fieldOffset)
        {
            var pMonoVirtualTable = this.GetMonoVirtualTable(pMonoDomain, pMonoClass);
            var pMonoStaticFieldData = this.GetMonoStaticFieldData(pMonoVirtualTable);
            return new nint(pMonoStaticFieldData + fieldOffset);
        }

        public virtual bool GetMonoStaticFieldValue_Buffer(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField, Span<byte> buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }
            var pMonoVirtualTable = this.GetMonoVirtualTable(pMonoDomain, pMonoClass);
            var pMonoStaticFieldData = this.GetMonoStaticFieldData(pMonoVirtualTable);
            PMonoStaticFieldData minStaticFieldData = new(0x10000);
            if (pMonoStaticFieldData <= minStaticFieldData)
            {
                return false;
            }
            else if (pMonoStaticFieldData > minStaticFieldData)
            {
                //ref T_STRUCT ref_data = ref this.Runtime.MONO_FIELD_STATIC_GET_VALUE.Invoke<T_STRUCT>(pMonoVirtualTable, pMonoField);
                //return ref ref_data;
            }
            this.Runtime.MONO_FIELD_STATIC_GET_VALUE.Invoke_Buffer(pMonoVirtualTable, pMonoField, buffer);
            return true;
        }

        public virtual unsafe T_STRUCT GetMonoStaticFieldValue<T_STRUCT>(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField)
            where T_STRUCT : unmanaged
        {
            var pMonoVirtualTable = this.GetMonoVirtualTable(pMonoDomain, pMonoClass);
            var pMonoStaticFieldData = this.GetMonoStaticFieldData(pMonoVirtualTable);
            PMonoStaticFieldData minStaticFieldData = new(0x10000);
            if (pMonoStaticFieldData <= minStaticFieldData)
            {
                return default;
            }
            else if (pMonoStaticFieldData > minStaticFieldData)
            {
                //T_STRUCT ref_data = this.Runtime.MONO_FIELD_STATIC_GET_VALUE.Invoke<T_STRUCT>(pMonoVirtualTable, pMonoField);
                //return ref_data;
            }


            
            T_STRUCT ref_data = this.Runtime.MONO_FIELD_STATIC_GET_VALUE.Invoke2<T_STRUCT>(pMonoVirtualTable, pMonoField);
            return ref_data;


        }
        public string? GetMonoStaticFieldValue_String(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField, int readSize = -1)
        {
            var pMonoString = this.GetMonoStaticFieldValue<PMonoString>(pMonoDomain, pMonoClass, pMonoField);
            if (pMonoString.Valid() == false)
            {
                return default;
            }
            if (readSize == -1)
            {
                return pMonoString.GetString();
            }
            return pMonoString.GetString(readSize);


        }
        private PMonoVirtualTable GetMonoVirtualTable(PMonoDomain pMonoDomain, PMonoClass pMonoClass)
        {
            return this.Runtime.MONO_CLASS_VTABLE.Invoke(pMonoDomain, pMonoClass);
        }
        private PMonoStaticFieldData GetMonoStaticFieldData(PMonoVirtualTable pMonoVirtualTable)
        {
            return this.Runtime.MONO_VTABLE_GET_STATIC_FIELD_DATA.Invoke(pMonoVirtualTable);
        }

        #endregion

        #region MonoType
        public PMonoClass GetMonoTypeClass(PMonoType pMonoType)
        {
            return this.Runtime.MONO_CLASS_FROM_MONO_TYPE.Invoke(pMonoType);
        }
        public string? GetMonoTypeName(PMonoType pMonoType)
        {
            var pTypeName = this.Runtime.MONO_TYPE_GET_NAME.Invoke(pMonoType);
            return pTypeName.ToString();
        }
        public EnumMonoType GetMonoTypeEnum(PMonoType pMonoFieldType)
        {
            return this.Runtime.MONO_TYPE_GET_TYPE.Invoke(pMonoFieldType);
        }

        #endregion

        #region New Object
        public virtual PMonoObject CreateMonoClassOnly(PMonoDomain pMonoDomain, PMonoClass pMonoClass)
            => this.Runtime.MONO_OBJECT_NEW.Invoke(pMonoDomain, pMonoClass);

        public T_Struct CreateMonoClass<T_Struct>(PMonoDomain pMonoDomain, PMonoClass pMonoClass, bool execDefCtor)
            where T_Struct : unmanaged
        {

            var pMonoObject = this.CreateMonoClassOnly(pMonoDomain, pMonoClass);
            if (pMonoObject.Valid())
            {
                if (execDefCtor)
                {
                    this.Runtime.MONO_RUNTIME_OBJECT_INIT.Invoke(pMonoObject);
                }
                return pMonoObject.To<T_Struct>();
            }
            return default;
        }

        public virtual PMonoArray CreateMonoArray(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int count)
        {
            return this.Runtime.MONO_ARRAY_NEW.Invoke(pMonoDomain, pMonoClass, (uint)count);
        }

        public virtual PMonoString GetMonoString(PMonoDomain pMonoDomain, string str)
        {
            return this.Runtime.MONO_STRING_NEW.Invoke(pMonoDomain, str);
        }
        public virtual PMonoString GetMonoString(PMonoDomain pMonoDomain, ReadOnlySpan<char> str)
        {
            return this.Runtime.MONO_STRING_NEW.Invoke(pMonoDomain, str);
        }
        public virtual PDelegatePointer GetInternalCall(string signature)
        {
            return default;
        }

        public REF_MONO_GC_HANDLE MonoGCHandle(PMonoObject pMonoObject, bool pinned)
        {
            return this.Runtime.MONO_GCHANDLE_NEW.Invoke(pMonoObject, pinned);
        }


        public PMonoObject MonoGCHandleTarget(REF_MONO_GC_HANDLE gchandle)
        {
            return this.Runtime.MONO_GCHANDLE_GET_TARGET.Invoke(gchandle);
        }

        public void MonoGCHandleFree(REF_MONO_GC_HANDLE gchandle)
        {
            this.Runtime.MONO_GCHANDLE_FREE.Invoke(gchandle);
        }
        #endregion



    }

}
