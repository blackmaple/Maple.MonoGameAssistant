using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameParameterType
{
    [NotNull]
    public MonoParameterTypeDTO? RawParameterType { set; get; }

}
