using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public readonly struct VirtualActionApiCallbackReference : IJavaClassReference<VirtualActionApiCallbackReference, VirtualActionApiCallbackMetadata>
    {

        public VirtualActionApiCallbackMetadata Metadata { get; init; }
        public PTR_JNI_ENV JNI_ENV { get; init; }


        public static VirtualActionApiCallbackReference CreateReference(in JniEnvironmentContext jniEnvironmentContext, VirtualActionApiCallbackMetadata metadata)
        {
            return jniEnvironmentContext.GetReference<VirtualActionApiCallbackReference, VirtualActionApiCallbackMetadata>(metadata);
        }


        public JBOOLEAN None(JOBJECT @this, JSTRING json) => this.Metadata.Callback_None(this.JNI_ENV, @this, json);


        public JBOOLEAN EnumImages(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumImages(this.JNI_ENV, @this, json);
        public JBOOLEAN EnumClasses(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClasses(this.JNI_ENV, @this, json);
        public JBOOLEAN EnumObjects(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumObjects(this.JNI_ENV, @this, json);
        public JBOOLEAN EnumClassDetail(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClassDetail(this.JNI_ENV, @this, json);


        public JBOOLEAN INFO(JOBJECT @this, JSTRING json) => this.Metadata.Callback_INFO(this.JNI_ENV, @this, json);
        public JBOOLEAN LoadResource(JOBJECT @this, JSTRING json) => this.Metadata.Callback_LoadResource(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListCurrencyDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCurrencyDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN GetCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCurrencyInfo(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCurrencyInfo(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListInventoryDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListInventoryDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN GetInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetInventoryInfo(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateInventoryInfo(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListCharacterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCharacterDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN GetCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterStatus(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterStatus(this.JNI_ENV, @this, json);
        public JBOOLEAN GetCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterEquipment(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterEquipment(this.JNI_ENV, @this, json);
        public JBOOLEAN GetCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterSkill(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterSkill(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListMonsterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListMonsterDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN AddMonsterMember(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddMonsterMember(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSkillDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN AddSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddSkillDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN GetListSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSwitchDisplay(this.JNI_ENV, @this, json);
        public JBOOLEAN UpdateSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateSwitchDisplay(this.JNI_ENV, @this, json);

    }

}
