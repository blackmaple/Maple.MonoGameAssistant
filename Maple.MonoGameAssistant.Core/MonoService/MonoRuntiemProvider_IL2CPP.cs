using Microsoft.Extensions.Logging;
using System.Drawing;

namespace Maple.MonoGameAssistant.Core
{

    internal sealed class MonoRuntiemProvider_IL2CPP(ILogger logger, MonoRuntimeApi runtime) : MonoRuntiemProvider_MONO(logger, runtime), IMonoRuntiemProvider
    {
        #region MonoDomains
        public sealed override PMonoDomain GetMonoRootDomain()
        {
            return this.Runtime.MONO_DOMAIN_GET.Invoke();
        }
        public sealed override IEnumerable<PMonoDomain> EnumMonoDomains()
        {
            yield return this.GetMonoRootDomain();
        }
        #endregion

        #region MonoAssemblies
        public sealed override IEnumerable<PMonoAssembly> EnumMonoAssemblies(PMonoDomain pMonoDomain)
        {
            var span = this.Runtime.IL2CPP_DOMAIN_GET_ASSEMBLIES.Invoke(pMonoDomain);
            return span.ToArray();
        }
        #endregion

        #region MonoClasses
        public sealed override bool TryGetMonoClass(PMonoImage pMonoImage, uint type_token, out PMonoClass pMonoClass)
        {
            uint row = type_token & (~(uint)EnumMonoTokenType.MONO_TOKEN_TYPE_DEF);
            int index = (int)(row - 1);
            pMonoClass = this.Runtime.IL2CPP_IMAGE_GET_CLASS.Invoke(pMonoImage, index);
            return pMonoClass.Valid();
        }

        public sealed override IEnumerable<PMonoClass> EnumMonoClasses(PMonoImage pMonoImage)
        {
            var count = this.Runtime.IL2CPP_IMAGE_GET_CLASS_COUNT.Invoke(pMonoImage);
            for (int i = 0; i < count; ++i)
            {
                var pMonoClass = this.Runtime.IL2CPP_IMAGE_GET_CLASS.Invoke(pMonoImage, i);
                if (pMonoClass.Valid())
                {
                    yield return pMonoClass;
                }
            }
        }

        #endregion

        #region MonoMethods
        public sealed override MonoMethodPointer GetMonoMethodAddress(PMonoMethod pMonoMethod)
            => pMonoMethod.GetMonoMethodPointer_IL2CPP();
        private IEnumerable<MonoMethodParamInfo> EnumMonoMethodParameters(PMonoMethod pMonoMethod)
        {
            var count = this.Runtime.IL2CPP_METHOD_GET_PARAM_COUNT.Invoke(pMonoMethod);
            for (int i = 0; i < count; ++i)
            {
                var paramType = this.Runtime.IL2CPP_METHOD_GET_PARAM.Invoke(pMonoMethod, i);
                var paramName = this.Runtime.IL2CPP_METHOD_GET_PARAM_NAME.Invoke(pMonoMethod, i);
                yield return new(paramType, paramName.ToString());
            }
        }
        private PMonoType GetMonoMethodReturnType(PMonoMethod pMonoMethod)
        {
            return this.Runtime.IL2CPP_METHOD_GET_RETURN_TYPE.Invoke(pMonoMethod);
        }
        public sealed override MonoMethodDescInfo GetMonoMethodInfo(PMonoMethod pMonoMethod)
        {
            var returnType = GetMonoMethodReturnType(pMonoMethod);
            var paramInfos = EnumMonoMethodParameters(pMonoMethod);
            return new MonoMethodDescInfo(returnType, paramInfos.ToArray());
        }

        #endregion

        #region MonoField->Enum&Const&Static
        /*
            IL2CPP_FIELD_STATIC_GET_VALUE 没传递长度 直接copy 是否存在溢出？
         */
        T_STRUCT GetMonoStaticFieldValue<T_STRUCT>(PMonoField pMonoField)
           where T_STRUCT : unmanaged
           => this.Runtime.IL2CPP_FIELD_STATIC_GET_VALUE.Invoke<T_STRUCT>(pMonoField);
        bool GetMonoStaticFieldValue_Buffer(PMonoField pMonoField, Span<byte> buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }
            this.Runtime.IL2CPP_FIELD_STATIC_GET_VALUE.Invoke_Buffer(pMonoField, buffer);
            return true;

        }

        public sealed override T_STRUCT GetMonoEnumFieldValue<T_STRUCT>(PMonoDomain pMonoDomain, PMonoField pMonoField)
            => GetMonoStaticFieldValue<T_STRUCT>(pMonoField);
        public sealed override bool GetMonoEnumFieldValue_Buffer(PMonoDomain pMonoDomain, PMonoField pMonoField, Span<byte> buffer)
             => GetMonoStaticFieldValue_Buffer(pMonoField, buffer);


        public sealed override T_STRUCT GetMonoStaticFieldValue<T_STRUCT>(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField)
            => GetMonoStaticFieldValue<T_STRUCT>(pMonoField);
        public sealed override bool GetMonoStaticFieldValue_Buffer(PMonoDomain pMonoDomain, PMonoClass pMonoClass, PMonoField pMonoField, Span<byte> buffer)
            => GetMonoStaticFieldValue_Buffer(pMonoField, buffer);


        public sealed override PMonoAddress GetMonoStaticFieldAddress(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int fieldOffset)
        {
            return nint.Zero;
        }
        #endregion

        #region New Object
        public sealed override PMonoObject CreateMonoClassOnly(PMonoDomain pMonoDomain, PMonoClass pMonoClass)
        {
            return this.Runtime.IL2CPP_OBJECT_NEW.Invoke(pMonoClass);
        }

        public sealed override PMonoArray CreateMonoArray(PMonoDomain pMonoDomain, PMonoClass pMonoClass, int count)
        {
            return this.Runtime.IL2CPP_ARRAY_NEW.Invoke(pMonoClass, (uint)count);
        }

        public sealed override PMonoString GetMonoString(PMonoDomain pMonoDomain, string str)
        {
            return this.Runtime.IL2CPP_STRING_NEW.Invoke(str);
        }
        public sealed override PMonoString GetMonoString(PMonoDomain pMonoDomain, ReadOnlySpan<char> str)
        {
            return base.GetMonoString(pMonoDomain, str);
        }

        public sealed override PDelegatePointer GetInternalCall(string signature)
        {
            return this.Runtime.IL2CPP_RESOLVE_ICALL.Invoke(signature);
        }
        #endregion


    }

}
