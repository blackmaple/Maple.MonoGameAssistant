using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public class GameObjectInfo
{
    [NotNull]
    public MonoObjectInfoDTO? RawObjectInfo { set; get; }


    public string? ImageName { set; get; }
}