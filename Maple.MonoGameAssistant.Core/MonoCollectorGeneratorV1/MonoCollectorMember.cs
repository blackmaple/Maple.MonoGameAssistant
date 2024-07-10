using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.RawDotNet;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    /// <summary>
    /// 源生成器约定请勿修改 可追加 2024年1月4日21点41分
    /// </summary>
    public partial class MonoCollectorMember
    {
        public MonoRuntimeContext RuntimeContext => CollectorContext.RuntimeContext;
        internal ILogger Logger => this.RuntimeContext.Logger;
        internal MonoCollectorContext CollectorContext { get; }
        public MonoCollectorClassInfo ClassInfo { get; }

        [MonoCollectorFlag(EnumMonoCollectorFlag.MemberCtor)]
        public MonoCollectorMember(MonoCollectorContext collectorContext, MonoCollectorClassInfo classInfo)
        {
            this.CollectorContext = collectorContext;
            this.ClassInfo = classInfo;
            this.InitMember();
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.InitMember)]
        protected virtual void InitMember() { }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMethodPointer)]
        protected nint GetMethodPointer(string methodName, Func<MonoMethodInfoDTO, bool> math)
        {
            if (false == ClassInfo.MethodInfos.TryGetFirstMethodInfo(math, out var methodInfoDTO))
            {
                var errMsg = $"{this.GetType().FullName}.{nameof(GetMethodPointer)}:NOT FOUND {methodName}";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoMethodPointer>(errMsg);
            }
            var addr = this.RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            //   this.Logger.LogInformation("methodName:{methodName}=>methodInfoDTO:{methodInfoDTO.Pointer}=>addr:{addr}", methodName, methodInfoDTO.Pointer.ToString("X8"), addr.ToString());
            if (addr.Valid() == false)
            {
                var errMsg = $"{this.GetType().FullName}.{nameof(GetMethodPointer)}:ERROR {methodName} ADDRESS";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoMethodPointer>(errMsg);
            }

            return addr;
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMethodPointer)]
        protected nint GetMethodPointer(string methodName) => GetMethodPointer(methodName, (p) => p.Name == methodName);


        [MonoCollectorFlag(EnumMonoCollectorFlag.GetStaticMethodInvoker)]
        protected MonoStaticMethodInvoker GetStaticMethodInvoker(string methodName, Func<MonoMethodInfoDTO, bool> math)
        {
            if (false == ClassInfo.MethodInfos.TryGetFirstMethodInfo(math, out var methodInfoDTO))
            {
                var errMsg = $"{this.GetType().FullName}.{nameof(GetStaticMethodInvoker)}:NOT FOUND {methodName}";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoStaticMethodInvoker>(errMsg);
            }
            var addr = this.RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            //   this.Logger.LogInformation("methodName:{methodName}=>methodInfoDTO:{methodInfoDTO.Pointer}=>addr:{addr}", methodName, methodInfoDTO.Pointer.ToString("X8"), addr.ToString());
            if (addr.Valid() == false)
            {
                var errMsg = $"{this.GetType().FullName}.{nameof(GetStaticMethodInvoker)}:ERROR {methodName} ADDRESS";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<MonoStaticMethodInvoker>(errMsg);
            }
            return new MonoStaticMethodInvoker(methodInfoDTO.Pointer, addr);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetStaticMethodInvoker)]
        protected MonoStaticMethodInvoker GetStaticMethodInvoker(string methodName)
            => GetStaticMethodInvoker(methodName, (p) => p.Name == methodName);

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMonoStaticFieldValue)]
        protected T_MonoObject GetMonoStaticFieldValue<T_MonoObject>(string staticFieldName)
            where T_MonoObject : unmanaged
        {
            return this.RuntimeContext.GetMonoStaticFieldValue<T_MonoObject>(ClassInfo, staticFieldName);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.TryGetModuleBaseAddress)]
        protected static bool TryGetModuleBaseAddress(string moduleName, out nint baseAddress)
        {
            Unsafe.SkipInit(out baseAddress);
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Contains(moduleName, StringComparison.OrdinalIgnoreCase))
                {
                    baseAddress = module.BaseAddress;
                    return true;
                }
            }
            return default;

        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.GetModuleBaseAddress)]
        public static nint GetModuleBaseAddress(string moduleName)
        {
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Contains(moduleName, StringComparison.OrdinalIgnoreCase))
                {
                    return module.BaseAddress;
                }
            }
            return default;

        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject New<T_MonoObject>(bool execDefCtor)
            where T_MonoObject : unmanaged
        {
            return this.RuntimeContext.CreateMonoClass<T_MonoObject>(ClassInfo.ClassInfoDTO.Pointer, execDefCtor);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.Ctor)]
        public T_MonoObject Ctor<T_MonoObject>()
            where T_MonoObject : unmanaged
        {
            return this.RuntimeContext.CreateMonoClass<T_MonoObject>(ClassInfo.ClassInfoDTO.Pointer, true);
        }

        [MonoCollectorFlag(EnumMonoCollectorFlag.NewArray)]
        public Span<T_ARRAY> NewArray<T_ARRAY>(int count, out PMonoArray ptrRawArray)
            where T_ARRAY : unmanaged
        {
            return this.RuntimeContext.CreateMonoArray<T_ARRAY>(ClassInfo.ClassInfoDTO.Pointer, count, out ptrRawArray);

        }

        public PMonoString T(string str) => this.RuntimeContext.GetMonoString(str);
        public PMonoString T(in ReadOnlySpan<char> str) => this.RuntimeContext.GetMonoString(str);



        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMemberFieldOffset)]
        public int GetMemberFieldOffset(string? fieldName)
        {
            var memberInfo = this.ClassInfo.GetFirstMemberFieldInfo(fieldName);
            if (memberInfo is null)
            {
                var errMsg = $"{this.GetType().FullName}.{nameof(GetMemberFieldOffset)}:NOT FOUND {fieldName}";
                this.Logger.Error(errMsg);
                return MonoCollectorObjectException.Throw<int>(errMsg);
            }
            return memberInfo.Offset;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [MonoCollectorFlag(EnumMonoCollectorFlag.GetMemberFieldValue)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset)
            where T_FieldValue : unmanaged
        {
            ref var ref_Buffer = ref @this.AsRefStruct<byte>();
            ref var ref_Member = ref Unsafe.Add(ref ref_Buffer, fieldOffset);
            ref var ref_Value = ref Unsafe.As<byte, T_FieldValue>(ref ref_Member);
            return ref ref_Value;
        }

        public ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, string? fieldName)
            where T_FieldValue : unmanaged
        {
            var fieldOffset = GetMemberFieldOffset(fieldName);
            return ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
        }
        public void SetMemberFieldValue<T_FieldValue>(nint @this, string? fieldName, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldName);
            ref_Value = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [MonoCollectorFlag(EnumMonoCollectorFlag.SetMemberFieldValue)]
        public static void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
            ref_Value = value;
        }








    }
}
