using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Maple.MonoGameAssistant.MonoCollectorGeneratorV2
{
    internal class MonoCollectorMethodData
    {
        public string EntryPoint { set; get; }
        public string MethodName { set; get; }
        public bool IsStatic { set; get; }


        public string CallConvs { set; get; }
        public string Search { set; get; }

        public string FuncStructName { set; get; }
        public string FuncName { set; get; }


        public string Desc { set; get; }

        public bool BaseClassMethod { set; get; }

        public bool IsVirtual { set; get; }
        [Obsolete("remove...")]
        public int VirtualOffset { set; get; }
        public string VTableField { set; get; }
        public int MethodOffset { set; get; }


        public bool BaseAddress { set; get; }
        public bool RealTime { set; get; }
        public string ModuleName { set; get; }
        public int BaseOffset { set; get; }
        public int[] Offsets { set; get; }


        public bool NotInitMethod => IsVirtual || (BaseAddress && RealTime);

        public bool FromRuntimeMethod { set; get; }

        public List<MonoCollectorMethodParamData> ParamDatas { set; get; } = new List<MonoCollectorMethodParamData>();
        public MonoCollectorMethodReturnData ReturnData { set; get; }

        public string OutputDelegate()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var param in this.ParamDatas)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(param.OutputDelegate());
            }
            if (sb.Length > 0)
            {
                sb.Append(", ");
            }
            sb.Append(this.ReturnData.Output(out _));
            string unmanagedCallConv = string.Empty;
            if (string.IsNullOrEmpty(this.CallConvs) == false)
            {
                unmanagedCallConv = $"unmanaged[{this.CallConvs}]";
            }

            var def = $"delegate*{unmanagedCallConv}<{sb}>";
            return $"readonly {def} {MonoCollecotrConvString.DisplayName_DelegateMember} = ({def}){MonoCollecotrConvString.DisplayName_DelegatePtrArg};";
        }
        public string OutputInvoke()
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (var param in this.ParamDatas)
            {
                if (sb1.Length > 0)
                {
                    sb1.Append(", ");
                }

                sb1.Append(param.OutputInvoke());

                if (sb2.Length > 0)
                {
                    sb2.Append(", ");
                }
                sb2.Append(param.OutputCall());
            }

            var def = $"{this.ReturnData.Output(out var retRef)} {MonoCollecotrConvString.DisplayName_DelegateInvoke}({sb1}) => {retRef} {MonoCollecotrConvString.DisplayName_DelegateMember}({sb2});";
            return def;

        }
        public string OutputVTableInvoke()
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (var param in this.ParamDatas)
            {
                if (sb1.Length > 0)
                {
                    sb1.Append(", ");
                }

                sb1.Append(param.OutputInvoke());

                if (sb2.Length > 0)
                {
                    sb2.Append(", ");
                }
                sb2.Append(param.OutputCall());
            }

            var def = $"{this.ReturnData.Output(out var retRef)} {MonoCollecotrConvString.DisplayName_DelegateInvoke}({sb1}) => {retRef} {this.FuncName}.{MonoCollecotrConvString.DisplayName_DelegateInvoke}({sb2});";
            return def;

        }

        public string OutputCall()
        {

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            var staticInvoker = this.IsStatic && this.FromRuntimeMethod;
            foreach (var param in this.ParamDatas)
            {
                if (sb1.Length > 0)
                {
                    sb1.Append(", ");
                }
                if (param.IsThis == false)
                {
                    sb1.Append(param.OutputInvoke());
                }

                if (sb2.Length > 0)
                {
                    sb2.Append(", ");
                }
                if (param.IsThis)
                {
                    if (staticInvoker)
                    {
                        var monoMethod = $"{this.FuncName}.{nameof(MonoStaticMethodInvoker.MonoMethod)}";
                        sb2.Append(monoMethod);
                    }
                    else
                    {
                        sb2.Append("this");
                    }
                }
                else
                {
                    sb2.Append(param.OutputCall());
                }
            }
            string funcMethod;
            if (staticInvoker)
            {
                funcMethod = $"({this.FuncName}.{nameof(MonoStaticMethodInvoker.GetInvoker)}<{this.FuncStructName}>())";
            }
            else
            {
                funcMethod = this.FuncName;
            }
            var def = $"{(this.IsStatic ? "static" : string.Empty)} {this.ReturnData.Output(out var retRef)} {this.MethodName}({sb1}) => {retRef} {funcMethod}.{MonoCollecotrConvString.DisplayName_DelegateInvoke}({sb2});";

            return def;

        }

        //public string OutputVirtual()
        //{
        //    var v = VirtualOffset >= 0 ? "+" : "-";
        //    var m = MethodOffset >= 0 ? "+" : "-";
        //    return $"*(nint*)(*(nint*)(this {v} {System.Math.Abs(VirtualOffset)}) {m} {System.Math.Abs(MethodOffset)});";
        //}

        public string OutputBaseAddress(string searchMethod = "GetModuleBaseAddress")
        {
            var addr = "addr";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Offsets.Length; ++i)
            {
                var offset = Offsets[i];
                var v = offset >= 0 ? "+" : "-";
                sb.AppendLine($@"
            {addr} = *(nint*)({addr} {v} {Math.Abs(offset)});");
                if (i + 1 != Offsets.Length)
                {
                    sb.AppendLine($@"
            if({addr} == nint.Zero) return default;");
                }
            }

            return $@"
            var {addr} = {searchMethod}(""{ModuleName}"") + {BaseOffset};
            {sb}
            return {addr};";




        }

        public string OutputArgs()
            => string.Join(", ", ParamDatas.Select(p => $"{p.OutputDelegate()} {p.ParamName}"));
        public string GenericOutputCall(string[] genericTypes, params string[] args)
        {
            return $"{this.MethodName}<{string.Join(", ", genericTypes)}>({string.Join(", ", args)})";
        }

    }

    public class MonoCollectorMethodParamData
    {
        public string RefParam { get; set; }
        public string TypeName { get; set; }
        public string ParamName { get; set; }
        public bool IsThis { set; get; }

        public string OutputDelegate()
        {

            if (RefParam == "Ref")
            {
                return $"ref {TypeName}";
            }
            else if (RefParam == "Out")
            {
                return $"out {TypeName}";
            }
            else if (RefParam == "In")
            {
                return $"in {TypeName}";
            }
            else if (RefParam == "RefReadOnlyParameter")
            {
                return $"ref readonly {TypeName}";
            }
            else
            {
                return TypeName;
            }
        }

        public string OutputInvoke()
        {
            var invoke = $"{TypeName} {ParamName}";
            if (RefParam == "Ref")
            {
                return $"ref {invoke}";
            }
            else if (RefParam == "Out")
            {
                return $"out {invoke}";
            }
            else if (RefParam == "In")
            {
                return $"in {invoke}";
            }
            else if (RefParam == "RefReadOnlyParameter")
            {
                return $"ref readonly {invoke}";
            }
            else
            {
                return invoke;
            }
        }

        public string OutputCall()
        {
            var kind = string.Empty;
            if (RefParam == "Ref")
            {
                kind = "ref";
            }
            else if (RefParam == "Out")
            {
                kind = "out";
            }
            else if (RefParam == "In")
            {
                kind = "in";
            }
            else if (RefParam == "RefReadOnlyParameter")
            {
                kind = "ref readonly";
            }

            if (string.IsNullOrEmpty(kind))
            {
                return ParamName;
            }
            return $"{kind} {ParamName}";
        }

    }

    public class MonoCollectorMethodReturnData
    {
        public string ReturnTypeName { set; get; }
        public string RefReturn { set; get; }


        public string Output(out string refName)
        {
            refName = default;
            if (RefReturn == "Ref")
            {
                refName = "ref";
            }
            else if (RefReturn == "RefReadOnly")
            {
                refName = "ref readonly";
            }
            if (false == string.IsNullOrEmpty(refName))
            {
                return $"{refName} {ReturnTypeName}";
            }
            return ReturnTypeName;
        }
    }

}
