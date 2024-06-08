namespace Maple.MonoGameAssistant.Core
{
    public struct MonoMethodParamInfo(PMonoType prarmType, string? paramName)
    {
        public PMonoType ParamType { get; set; } = prarmType;
        public string? ParamName { get; set; } = paramName;
    }

    public readonly struct MonoMethodDescInfo(PMonoType returnType, IReadOnlyList<MonoMethodParamInfo> paramInfos)
    {
        public PMonoType ReturnType { get; } = returnType;
        public IReadOnlyList<MonoMethodParamInfo> ParamInfos { get; } = paramInfos;
    }
}
