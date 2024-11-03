using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    public sealed class VirtualActionApiCallbackReference : JavaClassReference<VirtualActionApiCallbackReference, VirtualActionApiCallbackMetadata>
    {


        public JBOOLEAN None(JOBJECT @this, JSTRING json) => this.Metadata.Callback_None(this.Jni, @this, json);


        public JBOOLEAN EnumImages(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumImages(this.Jni, @this, json);
        public JBOOLEAN EnumClasses(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClasses(this.Jni, @this, json);
        public JBOOLEAN EnumObjects(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumObjects(this.Jni, @this, json);
        public JBOOLEAN EnumClassDetail(JOBJECT @this, JSTRING json) => this.Metadata.Callback_EnumClassDetail(this.Jni, @this, json);


        public JBOOLEAN INFO(JOBJECT @this, JSTRING json) => this.Metadata.Callback_INFO(this.Jni, @this, json);
        public JBOOLEAN LoadResource(JOBJECT @this, JSTRING json) => this.Metadata.Callback_LoadResource(this.Jni, @this, json);
        public JBOOLEAN GetListCurrencyDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCurrencyDisplay(this.Jni, @this, json);
        public JBOOLEAN GetCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCurrencyInfo(this.Jni, @this, json);
        public JBOOLEAN UpdateCurrencyInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCurrencyInfo(this.Jni, @this, json);
        public JBOOLEAN GetListInventoryDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListInventoryDisplay(this.Jni, @this, json);
        public JBOOLEAN GetInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetInventoryInfo(this.Jni, @this, json);
        public JBOOLEAN UpdateInventoryInfo(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateInventoryInfo(this.Jni, @this, json);
        public JBOOLEAN GetListCharacterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListCharacterDisplay(this.Jni, @this, json);
        public JBOOLEAN GetCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterStatus(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterStatus(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterStatus(this.Jni, @this, json);
        public JBOOLEAN GetCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterEquipment(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterEquipment(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterEquipment(this.Jni, @this, json);
        public JBOOLEAN GetCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetCharacterSkill(this.Jni, @this, json);
        public JBOOLEAN UpdateCharacterSkill(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateCharacterSkill(this.Jni, @this, json);
        public JBOOLEAN GetListMonsterDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListMonsterDisplay(this.Jni, @this, json);
        public JBOOLEAN AddMonsterMember(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddMonsterMember(this.Jni, @this, json);
        public JBOOLEAN GetListSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSkillDisplay(this.Jni, @this, json);
        public JBOOLEAN AddSkillDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_AddSkillDisplay(this.Jni, @this, json);
        public JBOOLEAN GetListSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_GetListSwitchDisplay(this.Jni, @this, json);
        public JBOOLEAN UpdateSwitchDisplay(JOBJECT @this, JSTRING json) => this.Metadata.Callback_UpdateSwitchDisplay(this.Jni, @this, json);

    }

}
