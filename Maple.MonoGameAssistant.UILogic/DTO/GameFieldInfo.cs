using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameFieldInfo
{
    [NotNull]
    public MonoFieldInfoDTO? RawFieldInfo { get; set; }

}