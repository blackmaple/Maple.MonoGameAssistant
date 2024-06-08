using System;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    public partial class MonoCollecotrConvString
    {

        //public static int DisplayName_ValueTypeOffsetFix { get; } = IntPtr.Size + IntPtr.Size;

        public static string DisplayName_MethodInline { get; }= $"[{typeof(MethodImplAttribute).FullName}({typeof(MethodImplOptions).FullName}.{nameof(MethodImplOptions.AggressiveInlining)})]";

        public const string DisplayName_ConstImageName = "Const_ImageName";
        public const string DisplayName_ConstNamespaceName = "Const_Namespace";
        public const string DisplayName_ConstClassName = "Const_ClassName";
        public const string DisplayName_ConstTypeToken = "Const_TypeToken";

        public const string DisplayName_StaticImageName = "Static_ImageName";
        public const string DisplayName_StaticNamespaceName = "Static_Namespace";
        public const string DisplayName_StaticClassName = "Static_ClassName";
 


        public const string DisplayName_ClassName = "ClassName";
        public const string DisplayName_RefClassName = "RefClassName";

        public const string DisplayName_ConstHeader = "Const_";
        public const string DisplayName_StaticHeader = "Static_";
        public const string DisplayName_RefHeader = "Ref_";
        public const string DisplayName_PtrHeader = "Ptr_";
        public const string DisplayName_NameHeader = "Name_";
        public const string DisplayName_VTableHeader = "VTable_";
        public const string DisplayName_LazyHeader = "Lazy";
        public const string DisplayName_SearchHeader = "Search_";

        public const string DisplayName_FieldOffsetHeader = "FieldOffset_";
        public const string DisplayName_FieldHeader = "Field_";


        public const string DisplayName_InterfaceHeader = "I";

        public const string DisplayName_SettingsHeader = "Settings_";
        public const string DisplayName_BaseAddressHeader = "BaseAddress_";


        public const string DisplayName_PartialStruct = "readonly unsafe partial struct";
        public const string DisplayName_Enum = "enum";
        public const string DisplayName_PartialClass = "partial class";
        public const string DisplayName_PartialInterface = "partial interface";
        public const string DisplayName_InterfaceBuildOn = "BuildOn";
        public const string DisplayName_StaticClass = "static class";

        public const string DisplayName_ConstString = "const string";
        public const string DisplayName_StaticByteArray = "static byte[]";

        public const string DisplayName_ConstUInt32 = "const uint";
        public const string DisplayName_StaticInt32 = "static int";


        public const string DisplayName_PtrClassName = "PtrClassName";
        public const string DisplayName_PtrClassMember = "_ptr";

        public const string DisplayName_EntryPoint = "EntryPoint";
        public const string DisplayName_IsStatic = "IsStatic";
        public const string DisplayName_IsUnmanaged = "IsUnmanaged";
        public const string DisplayName_CallConv = "CallConv";

        public const string DisplayName_internal = "internal";
        public const string DisplayName_public = "public";

        public const string DisplayName_DelegateMember = "_func";
        public const string DisplayName_DelegateInvoke = "Invoke";
        public const string DisplayName_DelegatePtrArg = "ptr";


        public const string DisplayName_FuncHeader = "Func_";
        public const string DisplayName_FuncStructHeader = "Ptr_Func_";
        public const string DisplayName_FuncAsRef = "AsRef()";


        public const string DisplayName_StaticFieldDataHeader = "Get";



        public const string DisplayName_IntPtr = "nint";
        public const string DisplayName_UIntPtr = "nuint";


      

    }


}
