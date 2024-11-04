using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Common;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public sealed class VirtualActionApiCallbackMetadata : JavaClassMetadata<VirtualActionApiCallbackMetadata>
    {



        JMETHODID Method_None;
        //MONO
        JMETHODID Method_EnumImages;
        JMETHODID Method_EnumClasses;
        JMETHODID Method_EnumObjects;
        JMETHODID Method_EnumClassDetail;
        //GAME
        JMETHODID Method_INFO;
        JMETHODID Method_LoadResource;
        JMETHODID Method_GetListCurrencyDisplay;
        JMETHODID Method_GetCurrencyInfo;
        JMETHODID Method_UpdateCurrencyInfo;
        JMETHODID Method_GetListInventoryDisplay;
        JMETHODID Method_GetInventoryInfo;
        JMETHODID Method_UpdateInventoryInfo;
        JMETHODID Method_GetListCharacterDisplay;
        JMETHODID Method_GetCharacterStatus;
        JMETHODID Method_UpdateCharacterStatus;
        JMETHODID Method_GetCharacterEquipment;
        JMETHODID Method_UpdateCharacterEquipment;
        JMETHODID Method_GetCharacterSkill;
        JMETHODID Method_UpdateCharacterSkill;
        JMETHODID Method_GetListMonsterDisplay;
        JMETHODID Method_AddMonsterMember;
        JMETHODID Method_GetListSkillDisplay;
        JMETHODID Method_AddSkillDisplay;
        JMETHODID Method_GetListSwitchDisplay;
        JMETHODID Method_UpdateSwitchDisplay;

        protected override void FindMethods(in JniEnvironmentContext context)
        {
            //boolean Method( String json)
            var methodDesc = "(Ljava/lang/String;)Z\0"u8;

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "None\0"u8, methodDesc, out Method_None);

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumImages\0"u8, methodDesc, out Method_EnumImages);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumClasses\0"u8, methodDesc, out Method_EnumClasses);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumObjects\0"u8, methodDesc, out Method_EnumObjects);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "EnumClassDetail\0"u8, methodDesc, out Method_EnumClassDetail);

            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "INFO\0"u8, methodDesc, out Method_INFO);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "LoadResource\0"u8, methodDesc, out Method_LoadResource);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListCurrencyDisplay\0"u8, methodDesc, out Method_GetListCurrencyDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCurrencyInfo\0"u8, methodDesc, out Method_GetCurrencyInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCurrencyInfo\0"u8, methodDesc, out Method_UpdateCurrencyInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListInventoryDisplay\0"u8, methodDesc, out Method_GetListInventoryDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetInventoryInfo\0"u8, methodDesc, out Method_GetInventoryInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateInventoryInfo\0"u8, methodDesc, out Method_UpdateInventoryInfo);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListCharacterDisplay\0"u8, methodDesc, out Method_GetListCharacterDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterStatus\0"u8, methodDesc, out Method_GetCharacterStatus);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterStatus\0"u8, methodDesc, out Method_UpdateCharacterStatus);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterEquipment\0"u8, methodDesc, out Method_GetCharacterEquipment);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterEquipment\0"u8, methodDesc, out Method_UpdateCharacterEquipment);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetCharacterSkill\0"u8, methodDesc, out Method_GetCharacterSkill);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateCharacterSkill\0"u8, methodDesc, out Method_UpdateCharacterSkill);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListMonsterDisplay\0"u8, methodDesc, out Method_GetListMonsterDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "AddMonsterMember\0"u8, methodDesc, out Method_AddMonsterMember);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListSkillDisplay\0"u8, methodDesc, out Method_GetListSkillDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "AddSkillDisplay\0"u8, methodDesc, out Method_AddSkillDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "GetListSwitchDisplay\0"u8, methodDesc, out Method_GetListSwitchDisplay);
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "UpdateSwitchDisplay\0"u8, methodDesc, out Method_UpdateSwitchDisplay);
        }

        public JBOOLEAN Callback_None(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_None, json);
        public JBOOLEAN Callback_EnumImages(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_EnumImages, json);
        public JBOOLEAN Callback_EnumClasses(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_EnumClasses, json);
        public JBOOLEAN Callback_EnumObjects(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_EnumObjects, json);
        public JBOOLEAN Callback_EnumClassDetail(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_EnumClassDetail, json);
        public JBOOLEAN Callback_INFO(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_INFO, json);
        public JBOOLEAN Callback_LoadResource(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_LoadResource, json);
        public JBOOLEAN Callback_GetListCurrencyDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListCurrencyDisplay, json);
        public JBOOLEAN Callback_GetCurrencyInfo(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetCurrencyInfo, json);
        public JBOOLEAN Callback_UpdateCurrencyInfo(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateCurrencyInfo, json);
        public JBOOLEAN Callback_GetListInventoryDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListInventoryDisplay, json);
        public JBOOLEAN Callback_GetInventoryInfo(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetInventoryInfo, json);
        public JBOOLEAN Callback_UpdateInventoryInfo(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateInventoryInfo, json);
        public JBOOLEAN Callback_GetListCharacterDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListCharacterDisplay, json);
        public JBOOLEAN Callback_GetCharacterStatus(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetCharacterStatus, json);
        public JBOOLEAN Callback_UpdateCharacterStatus(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateCharacterStatus, json);
        public JBOOLEAN Callback_GetCharacterEquipment(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetCharacterEquipment, json);
        public JBOOLEAN Callback_UpdateCharacterEquipment(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateCharacterEquipment, json);
        public JBOOLEAN Callback_GetCharacterSkill(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetCharacterSkill, json);
        public JBOOLEAN Callback_UpdateCharacterSkill(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateCharacterSkill, json);
        public JBOOLEAN Callback_GetListMonsterDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListMonsterDisplay, json);
        public JBOOLEAN Callback_AddMonsterMember(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_AddMonsterMember, json);
        public JBOOLEAN Callback_GetListSkillDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListSkillDisplay, json);
        public JBOOLEAN Callback_AddSkillDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_AddSkillDisplay, json);
        public JBOOLEAN Callback_GetListSwitchDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_GetListSwitchDisplay, json);
        public JBOOLEAN Callback_UpdateSwitchDisplay(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_UpdateSwitchDisplay, json);

    }

}
