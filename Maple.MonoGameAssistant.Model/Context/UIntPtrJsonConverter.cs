using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{
    public class UIntPtrJsonConverter : JsonConverter<nuint>
    {
        public override nuint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            _ = nuint.TryParse(reader.GetString(), System.Globalization.NumberStyles.HexNumber, default, out var val);
            return val;
        }

        public override void Write(Utf8JsonWriter writer, nuint value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("X8"));
        }
    }
}
