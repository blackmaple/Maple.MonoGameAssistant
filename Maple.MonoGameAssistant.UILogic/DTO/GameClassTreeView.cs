using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public class GameClassTreeView
{
    public string? ParentCode { set; get; }
    public string? Code { set; get; }

    public string? FieldName { set; get; }

    [NotNull]
    public GameClassInfo? GameClassInfo { get; set; }

    [NotNull]
    public MonoClassInfoDTO? RawClassInfo => GameClassInfo.RawClassInfo;

}
