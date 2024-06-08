using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model;

public class IntPtrJsonConverter : JsonConverter<nint>
{
    public override nint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        _ = nint.TryParse(reader.GetString(), System.Globalization.NumberStyles.HexNumber, default, out var val);
        return val;
    }

    public override void Write(Utf8JsonWriter writer, nint value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("X8"));
    }
}