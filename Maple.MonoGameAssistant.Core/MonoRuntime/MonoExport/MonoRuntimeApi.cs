
using Maple.MonoGameAssistant.Common;
using Microsoft.Extensions.Logging;

namespace Maple.MonoGameAssistant.Core
{


    /// <summary>
    /// 简单用CE源码让测试案例生成:20231123155148
    /// </summary>
    partial class MonoRuntimeApi
    {
        #region RTAPI
        internal PMONO_THREAD_ATTACH MONO_THREAD_ATTACH;

        internal PMONO_GET_ROOT_DOMAIN MONO_GET_ROOT_DOMAIN;

        internal PMONO_THREAD_DETACH MONO_THREAD_DETACH;

        internal PMONO_DOMAIN_FOREACH MONO_DOMAIN_FOREACH;

        internal PMONO_DOMAIN_GET MONO_DOMAIN_GET;

        internal PMONO_ASSEMBLY_FOREACH MONO_ASSEMBLY_FOREACH;

        internal PMONO_ASSEMBLY_GET_IMAGE MONO_ASSEMBLY_GET_IMAGE;

        internal PMONO_IMAGE_GET_ASSEMBLY MONO_IMAGE_GET_ASSEMBLY;

        internal PMONO_IMAGE_GET_NAME MONO_IMAGE_GET_NAME;

        internal PMONO_IMAGE_GET_FILENAME MONO_IMAGE_GET_FILENAME;

        internal PMONO_IMAGE_GET_TABLE_INFO MONO_IMAGE_GET_TABLE_INFO;

        internal PMONO_TABLE_INFO_GET_ROWS MONO_TABLE_INFO_GET_ROWS;

        internal PMONO_CLASS_FROM_NAME MONO_CLASS_FROM_NAME;

        internal PMONO_CLASS_GET_NAME MONO_CLASS_GET_NAME;

        internal PMONO_CLASS_GET_NAMESPACE MONO_CLASS_GET_NAMESPACE;

        internal PMONO_CLASS_GET MONO_CLASS_GET;

        internal PMONO_CLASS_GET_INTERFACES MONO_CLASS_GET_INTERFACES;

        internal PMONO_CLASS_GET_METHODS MONO_CLASS_GET_METHODS;

        internal PMONO_CLASS_GET_METHOD_FROM_NAME MONO_CLASS_GET_METHOD_FROM_NAME;

        internal PMONO_CLASS_GET_FIELDS MONO_CLASS_GET_FIELDS;

        internal PMONO_CLASS_GET_PARENT MONO_CLASS_GET_PARENT;

        internal PMONO_CLASS_VTABLE MONO_CLASS_VTABLE;

        internal PMONO_CLASS_INSTANCE_SIZE MONO_CLASS_INSTANCE_SIZE;

        internal PMONO_CLASS_FROM_MONO_TYPE MONO_CLASS_FROM_MONO_TYPE;

        internal PMONO_CLASS_IS_GENERIC MONO_CLASS_IS_GENERIC;

        internal PMONO_CLASS_IS_ENUM MONO_CLASS_IS_ENUM;

        internal PMONO_CLASS_IS_VALUETYPE MONO_CLASS_IS_VALUETYPE;

        internal PMONO_FIELD_GET_NAME MONO_FIELD_GET_NAME;

        internal PMONO_FIELD_GET_TYPE MONO_FIELD_GET_TYPE;

        internal PMONO_FIELD_GET_OFFSET MONO_FIELD_GET_OFFSET;

        internal PMONO_TYPE_GET_NAME MONO_TYPE_GET_NAME;

        internal PMONO_TYPE_GET_TYPE MONO_TYPE_GET_TYPE;

        internal PMONO_FIELD_GET_FLAGS MONO_FIELD_GET_FLAGS;

        internal PMONO_FIELD_GET_VALUE_OBJECT MONO_FIELD_GET_VALUE_OBJECT;

        internal PMONO_METHOD_GET_NAME MONO_METHOD_GET_NAME;

        internal PMONO_COMPILE_METHOD MONO_COMPILE_METHOD;

        internal PMONO_METHOD_GET_FLAGS MONO_METHOD_GET_FLAGS;

        internal PMONO_METHOD_SIG MONO_METHOD_SIG;

        internal PMONO_METHOD_GET_PARAM_NAMES MONO_METHOD_GET_PARAM_NAMES;

        internal PMONO_SIGNATURE_GET_DESC MONO_SIGNATURE_GET_DESC;

        internal PMONO_SIGNATURE_GET_PARAMS MONO_SIGNATURE_GET_PARAMS;

        internal PMONO_SIGNATURE_GET_PARAM_COUNT MONO_SIGNATURE_GET_PARAM_COUNT;

        internal PMONO_SIGNATURE_GET_RETURN_TYPE MONO_SIGNATURE_GET_RETURN_TYPE;

        internal PMONO_VTABLE_GET_STATIC_FIELD_DATA MONO_VTABLE_GET_STATIC_FIELD_DATA;

        internal PMONO_STRING_NEW MONO_STRING_NEW;

        internal PMONO_ARRAY_NEW MONO_ARRAY_NEW;

        internal PMONO_OBJECT_NEW MONO_OBJECT_NEW;

        internal PMONO_RUNTIME_OBJECT_INIT MONO_RUNTIME_OBJECT_INIT;

        internal PMONO_FIELD_STATIC_GET_VALUE MONO_FIELD_STATIC_GET_VALUE;

        internal PMONO_OBJECT_UNBOX MONO_OBJECT_UNBOX;

        internal PMONO_OBJECT_ISINST MONO_OBJECT_ISINST;

        internal PMONO_GET_ENUM_CLASS MONO_GET_ENUM_CLASS;

        internal PMONO_CLASS_GET_IMAGE MONO_CLASS_GET_IMAGE;

        internal PMONO_CLASS_GET_TYPE_TOKEN MONO_CLASS_GET_TYPE_TOKEN;

        internal PMONO_CLASS_GET_TYPE MONO_CLASS_GET_TYPE;

        internal PMONO_CLASS_GET_FLAGS MONO_CLASS_GET_FLAGS;


        internal PIL2CPP_FIELD_STATIC_GET_VALUE IL2CPP_FIELD_STATIC_GET_VALUE;

        internal PIL2CPP_FIELD_STATIC_SET_VALUE IL2CPP_FIELD_STATIC_SET_VALUE;

        internal PIL2CPP_DOMAIN_GET_ASSEMBLIES IL2CPP_DOMAIN_GET_ASSEMBLIES;

        internal PIL2CPP_IMAGE_GET_CLASS_COUNT IL2CPP_IMAGE_GET_CLASS_COUNT;

        internal PIL2CPP_IMAGE_GET_CLASS IL2CPP_IMAGE_GET_CLASS;

        internal PIL2CPP_METHOD_GET_PARAM_COUNT IL2CPP_METHOD_GET_PARAM_COUNT;

        internal PIL2CPP_METHOD_GET_PARAM_NAME IL2CPP_METHOD_GET_PARAM_NAME;

        internal PIL2CPP_METHOD_GET_PARAM IL2CPP_METHOD_GET_PARAM;

        internal PIL2CPP_METHOD_GET_RETURN_TYPE IL2CPP_METHOD_GET_RETURN_TYPE;

        internal PIL2CPP_STRING_NEW IL2CPP_STRING_NEW;

        internal PIL2CPP_ARRAY_NEW IL2CPP_ARRAY_NEW;

        internal PIL2CPP_OBJECT_NEW IL2CPP_OBJECT_NEW;

        internal PIL2CPP_RESOLVE_ICALL IL2CPP_RESOLVE_ICALL;
        #endregion

        private partial bool LoadMonoRuntime_MONO_Imp(nint hModule)
        {
            var init = true;

            init &= TryCreate(hModule, PMONO_GET_ROOT_DOMAIN.mono, out MONO_GET_ROOT_DOMAIN);

            init &= TryCreate(hModule, PMONO_THREAD_DETACH.mono, out MONO_THREAD_DETACH);

            init &= TryCreate(hModule, PMONO_DOMAIN_FOREACH.mono, out MONO_DOMAIN_FOREACH);

            init &= TryCreate(hModule, PMONO_DOMAIN_GET.mono, out MONO_DOMAIN_GET);

            init &= TryCreate(hModule, PMONO_ASSEMBLY_FOREACH.mono, out MONO_ASSEMBLY_FOREACH);

            init &= TryCreate(hModule, PMONO_ASSEMBLY_GET_IMAGE.mono, out MONO_ASSEMBLY_GET_IMAGE);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_ASSEMBLY.mono, out MONO_IMAGE_GET_ASSEMBLY);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_NAME.mono, out MONO_IMAGE_GET_NAME);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_FILENAME.mono, out MONO_IMAGE_GET_FILENAME);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_TABLE_INFO.mono, out MONO_IMAGE_GET_TABLE_INFO);

            init &= TryCreate(hModule, PMONO_TABLE_INFO_GET_ROWS.mono, out MONO_TABLE_INFO_GET_ROWS);

            init &= TryCreate(hModule, PMONO_CLASS_FROM_NAME.mono, out MONO_CLASS_FROM_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_NAME.mono, out MONO_CLASS_GET_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_NAMESPACE.mono, out MONO_CLASS_GET_NAMESPACE);

            init &= TryCreate(hModule, PMONO_CLASS_GET.mono, out MONO_CLASS_GET);

            init &= TryCreate(hModule, PMONO_CLASS_GET_INTERFACES.mono, out MONO_CLASS_GET_INTERFACES);

            init &= TryCreate(hModule, PMONO_CLASS_GET_METHODS.mono, out MONO_CLASS_GET_METHODS);

            init &= TryCreate(hModule, PMONO_CLASS_GET_METHOD_FROM_NAME.mono, out MONO_CLASS_GET_METHOD_FROM_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_FIELDS.mono, out MONO_CLASS_GET_FIELDS);

            init &= TryCreate(hModule, PMONO_CLASS_GET_PARENT.mono, out MONO_CLASS_GET_PARENT);

            init &= TryCreate(hModule, PMONO_CLASS_VTABLE.mono, out MONO_CLASS_VTABLE);

            init &= TryCreate(hModule, PMONO_CLASS_INSTANCE_SIZE.mono, out MONO_CLASS_INSTANCE_SIZE);

            init &= TryCreate(hModule, PMONO_CLASS_FROM_MONO_TYPE.mono, out MONO_CLASS_FROM_MONO_TYPE);

            init &= TryCreate(hModule, PMONO_CLASS_IS_GENERIC.mono, out MONO_CLASS_IS_GENERIC);

            init &= TryCreate(hModule, PMONO_CLASS_IS_ENUM.mono, out MONO_CLASS_IS_ENUM);

            init &= TryCreate(hModule, PMONO_CLASS_IS_VALUETYPE.mono, out MONO_CLASS_IS_VALUETYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_NAME.mono, out MONO_FIELD_GET_NAME);

            init &= TryCreate(hModule, PMONO_FIELD_GET_TYPE.mono, out MONO_FIELD_GET_TYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_OFFSET.mono, out MONO_FIELD_GET_OFFSET);

            init &= TryCreate(hModule, PMONO_TYPE_GET_NAME.mono, out MONO_TYPE_GET_NAME);

            init &= TryCreate(hModule, PMONO_TYPE_GET_TYPE.mono, out MONO_TYPE_GET_TYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_FLAGS.mono, out MONO_FIELD_GET_FLAGS);

            init &= TryCreate(hModule, PMONO_FIELD_GET_VALUE_OBJECT.mono, out MONO_FIELD_GET_VALUE_OBJECT);

            init &= TryCreate(hModule, PMONO_METHOD_GET_NAME.mono, out MONO_METHOD_GET_NAME);

            init &= TryCreate(hModule, PMONO_COMPILE_METHOD.mono, out MONO_COMPILE_METHOD);

            init &= TryCreate(hModule, PMONO_METHOD_GET_FLAGS.mono, out MONO_METHOD_GET_FLAGS);

            init &= TryCreate(hModule, PMONO_METHOD_SIG.mono, out MONO_METHOD_SIG);

            init &= TryCreate(hModule, PMONO_METHOD_GET_PARAM_NAMES.mono, out MONO_METHOD_GET_PARAM_NAMES);

            init &= TryCreate(hModule, PMONO_SIGNATURE_GET_DESC.mono, out MONO_SIGNATURE_GET_DESC);

            init &= TryCreate(hModule, PMONO_SIGNATURE_GET_PARAMS.mono, out MONO_SIGNATURE_GET_PARAMS);

            init &= TryCreate(hModule, PMONO_SIGNATURE_GET_PARAM_COUNT.mono, out MONO_SIGNATURE_GET_PARAM_COUNT);

            init &= TryCreate(hModule, PMONO_SIGNATURE_GET_RETURN_TYPE.mono, out MONO_SIGNATURE_GET_RETURN_TYPE);

            init &= TryCreate(hModule, PMONO_VTABLE_GET_STATIC_FIELD_DATA.mono, out MONO_VTABLE_GET_STATIC_FIELD_DATA);

            init &= TryCreate(hModule, PMONO_STRING_NEW.mono, out MONO_STRING_NEW);

            init &= TryCreate(hModule, PMONO_ARRAY_NEW.mono, out MONO_ARRAY_NEW);

            init &= TryCreate(hModule, PMONO_OBJECT_NEW.mono, out MONO_OBJECT_NEW);

            init &= TryCreate(hModule, PMONO_RUNTIME_OBJECT_INIT.mono, out MONO_RUNTIME_OBJECT_INIT);

            init &= TryCreate(hModule, PMONO_FIELD_STATIC_GET_VALUE.mono, out MONO_FIELD_STATIC_GET_VALUE);

            //init &= TryCreate(hModule, PMONO_FIELD_STATIC_SET_VALUE.mono, out MONO_FIELD_STATIC_SET_VALUE);

            init &= TryCreate(hModule, PMONO_OBJECT_UNBOX.mono, out MONO_OBJECT_UNBOX);

            init &= TryCreate(hModule, PMONO_OBJECT_ISINST.mono, out MONO_OBJECT_ISINST);

            init &= TryCreate(hModule, PMONO_GET_ENUM_CLASS.mono, out MONO_GET_ENUM_CLASS);

            init &= TryCreate(hModule, PMONO_CLASS_GET_IMAGE.mono, out MONO_CLASS_GET_IMAGE);

            init &= TryCreate(hModule, PMONO_CLASS_GET_TYPE_TOKEN.mono, out MONO_CLASS_GET_TYPE_TOKEN);

            init &= TryCreate(hModule, PMONO_CLASS_GET_TYPE.mono, out MONO_CLASS_GET_TYPE);

            init &= TryCreate(hModule, PMONO_CLASS_GET_FLAGS.mono, out MONO_CLASS_GET_FLAGS);

            return init;
        }


        private partial bool LoadMonoRuntime_IL2CPP_Imp(nint hModule)
        {
            var init = true;

            init &= TryCreate(hModule, PMONO_THREAD_DETACH.il2cpp, out MONO_THREAD_DETACH);

            init &= TryCreate(hModule, PMONO_DOMAIN_GET.il2cpp, out MONO_DOMAIN_GET);

            init &= TryCreate(hModule, PMONO_ASSEMBLY_GET_IMAGE.il2cpp, out MONO_ASSEMBLY_GET_IMAGE);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_ASSEMBLY.il2cpp, out MONO_IMAGE_GET_ASSEMBLY);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_NAME.il2cpp, out MONO_IMAGE_GET_NAME);

            init &= TryCreate(hModule, PMONO_IMAGE_GET_FILENAME.il2cpp, out MONO_IMAGE_GET_FILENAME);

            init &= TryCreate(hModule, PMONO_CLASS_FROM_NAME.il2cpp, out MONO_CLASS_FROM_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_NAME.il2cpp, out MONO_CLASS_GET_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_NAMESPACE.il2cpp, out MONO_CLASS_GET_NAMESPACE);

            init &= TryCreate(hModule, PMONO_CLASS_GET_INTERFACES.il2cpp, out MONO_CLASS_GET_INTERFACES);

            init &= TryCreate(hModule, PMONO_CLASS_GET_METHODS.il2cpp, out MONO_CLASS_GET_METHODS);

            init &= TryCreate(hModule, PMONO_CLASS_GET_METHOD_FROM_NAME.il2cpp, out MONO_CLASS_GET_METHOD_FROM_NAME);

            init &= TryCreate(hModule, PMONO_CLASS_GET_FIELDS.il2cpp, out MONO_CLASS_GET_FIELDS);

            init &= TryCreate(hModule, PMONO_CLASS_GET_PARENT.il2cpp, out MONO_CLASS_GET_PARENT);

            init &= TryCreate(hModule, PMONO_CLASS_INSTANCE_SIZE.il2cpp, out MONO_CLASS_INSTANCE_SIZE);

            init &= TryCreate(hModule, PMONO_CLASS_IS_GENERIC.il2cpp, out MONO_CLASS_IS_GENERIC);

            init &= TryCreate(hModule, PMONO_CLASS_IS_ENUM.il2cpp, out MONO_CLASS_IS_ENUM);

            init &= TryCreate(hModule, PMONO_CLASS_IS_VALUETYPE.il2cpp, out MONO_CLASS_IS_VALUETYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_NAME.il2cpp, out MONO_FIELD_GET_NAME);

            init &= TryCreate(hModule, PMONO_FIELD_GET_TYPE.il2cpp, out MONO_FIELD_GET_TYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_OFFSET.il2cpp, out MONO_FIELD_GET_OFFSET);

            init &= TryCreate(hModule, PMONO_TYPE_GET_NAME.il2cpp, out MONO_TYPE_GET_NAME);

            init &= TryCreate(hModule, PMONO_TYPE_GET_TYPE.il2cpp, out MONO_TYPE_GET_TYPE);

            init &= TryCreate(hModule, PMONO_FIELD_GET_FLAGS.il2cpp, out MONO_FIELD_GET_FLAGS);

            init &= TryCreate(hModule, PMONO_METHOD_GET_NAME.il2cpp, out MONO_METHOD_GET_NAME);

            init &= TryCreate(hModule, PMONO_METHOD_GET_FLAGS.il2cpp, out MONO_METHOD_GET_FLAGS);

            init &= TryCreate(hModule, PIL2CPP_STRING_NEW.il2cpp, out IL2CPP_STRING_NEW);

            init &= TryCreate(hModule, PIL2CPP_ARRAY_NEW.il2cpp, out IL2CPP_ARRAY_NEW);

            init &= TryCreate(hModule, PIL2CPP_OBJECT_NEW.il2cpp, out IL2CPP_OBJECT_NEW);

            init &= TryCreate(hModule, PMONO_RUNTIME_OBJECT_INIT.il2cpp, out MONO_RUNTIME_OBJECT_INIT);

            init &= TryCreate(hModule, PIL2CPP_FIELD_STATIC_GET_VALUE.il2cpp, out IL2CPP_FIELD_STATIC_GET_VALUE);

            init &= TryCreate(hModule, PIL2CPP_FIELD_STATIC_SET_VALUE.il2cpp, out IL2CPP_FIELD_STATIC_SET_VALUE);

            init &= TryCreate(hModule, PMONO_OBJECT_UNBOX.il2cpp, out MONO_OBJECT_UNBOX);

            init &= TryCreate(hModule, PMONO_CLASS_GET_TYPE_TOKEN.il2cpp, out MONO_CLASS_GET_TYPE_TOKEN);

            init &= TryCreate(hModule, PIL2CPP_DOMAIN_GET_ASSEMBLIES.il2cpp, out IL2CPP_DOMAIN_GET_ASSEMBLIES);

            init &= TryCreate(hModule, PIL2CPP_IMAGE_GET_CLASS_COUNT.il2cpp, out IL2CPP_IMAGE_GET_CLASS_COUNT);

            init &= TryCreate(hModule, PIL2CPP_IMAGE_GET_CLASS.il2cpp, out IL2CPP_IMAGE_GET_CLASS);

            init &= TryCreate(hModule, PIL2CPP_METHOD_GET_PARAM_COUNT.il2cpp, out IL2CPP_METHOD_GET_PARAM_COUNT);

            init &= TryCreate(hModule, PIL2CPP_METHOD_GET_PARAM_NAME.il2cpp, out IL2CPP_METHOD_GET_PARAM_NAME);

            init &= TryCreate(hModule, PIL2CPP_METHOD_GET_PARAM.il2cpp, out IL2CPP_METHOD_GET_PARAM);

            init &= TryCreate(hModule, PIL2CPP_METHOD_GET_RETURN_TYPE.il2cpp, out IL2CPP_METHOD_GET_RETURN_TYPE);

            init &= TryCreate(hModule, PMONO_CLASS_FROM_MONO_TYPE.il2cpp, out MONO_CLASS_FROM_MONO_TYPE);

            init &= TryCreate(hModule, PMONO_CLASS_GET_IMAGE.il2cpp, out MONO_CLASS_GET_IMAGE);

            init &= TryCreate(hModule, PMONO_CLASS_GET_TYPE.il2cpp, out MONO_CLASS_GET_TYPE);


            init &= TryCreate(hModule, PMONO_CLASS_GET_FLAGS.il2cpp, out MONO_CLASS_GET_FLAGS);

            init &= TryCreate(hModule, PIL2CPP_RESOLVE_ICALL.il2cpp, out IL2CPP_RESOLVE_ICALL);

            

            return init;
        }

    }

}