using System;

namespace Maple.MonoGameAssistant.MonoCollectorDataV2
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class MonoCollectorFlagAttribute : Attribute
    {
        public MonoCollectorFlagAttribute(EnumMonoCollectorFlag flag)
        {
            Flag = flag;
        }

        public EnumMonoCollectorFlag Flag { get; }

    }
    public enum EnumMonoCollectorFlag
    {
        None,
        ContextCtor,
        GetClassInfo,
        Throw,

        MemberCtor,
        InitMember,
        GetMethodPointer,
        GetStaticMethodInvoker,
        GetMonoStaticFieldValue,
        TryGetModuleBaseAddress,
        GetModuleBaseAddress,
        New,
        Ctor,
        NewArray,
        GetMemberFieldOffset,
        GetMemberFieldValue,
        SetMemberFieldValue
    }
}
