using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{

  //  [JsonConverter(typeof(JsonStringEnumConverter<EnumMonoFieldOptions>))]
    public enum EnumMonoFieldOptions
    {

        None = 0,
        Enum = 1 << 0,
        Const = 1 << 1,
        EnumAndConst = Enum |Const,
        Static = 1 << 2,
        EnumAndConstAndStatic = Enum | Const | Static,
        EnumAll = EnumAndConstAndStatic
    }
}
