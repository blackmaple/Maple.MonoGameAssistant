using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{
    public static class MonoJsonExtensions
    {
        public static JsonSerializerOptions AddMonoJsonContext(this JsonSerializerOptions options)
           => options.AddCommonJsonContext(MonoJsonContext.Default);

        public static JsonSerializerOptions AddCommonJsonContext(this JsonSerializerOptions options, JsonSerializerContext context)
        {
            foreach (var converter in context.Options.Converters)
            {
                options.Converters.Add(converter);
            }
            options.PropertyNamingPolicy = context.Options.PropertyNamingPolicy;
            options.WriteIndented = context.Options.WriteIndented;
            options.DefaultIgnoreCondition = context.Options.DefaultIgnoreCondition;
            options.PropertyNameCaseInsensitive = context.Options.PropertyNameCaseInsensitive;
            options.TypeInfoResolverChain.Insert(0, context);
            return options;




        }

        public static string GetPipeName(Process process)
        {
            return $"0x{process.Id:X8}-{process.ProcessName}";
        }
        public static string ToJson<T>(this T obj)
            where T : class
        {
            return JsonSerializer.Serialize(obj, typeof(T), MonoJsonContext.Default);
        }
        public static byte[] ToBufferJson<T>(this T obj)
            where T : class
        {
            return JsonSerializer.SerializeToUtf8Bytes(obj, typeof(T), MonoJsonContext.Default);
        }

        public  static ValueTask<MonoResultDTO<MonoClassDetailDTO>?> GetClassDetailFromStreamAsync(this Stream stream)
        {
            return JsonSerializer.DeserializeAsync(stream, MonoJsonContext.Default.MonoResultDTOMonoClassDetailDTO);
        }


        public static void Test()
        {
            var dto = new MonoObjectInfoDTO() { Pointer = new nint(0x100000), Name = "1", Utf8Name = [1, 2, 3] };
            var json = System.Text.Json.JsonSerializer.Serialize(dto, MonoJsonContext.Default.MonoObjectInfoDTO);
            var new_dto = System.Text.Json.JsonSerializer.Deserialize(json, MonoJsonContext.Default.MonoObjectInfoDTO);

            var dtos = new MonoObjectInfoDTO[]
            {
             new MonoObjectInfoDTO() { Pointer = new nint(0x100000), Name = "1",Utf8Name = [1,2,3] },
              new MonoObjectInfoDTO() { Pointer = nint.Zero, Name = "2" ,Utf8Name = [1,2,3]},
            };

            json = System.Text.Json.JsonSerializer.Serialize(dtos, MonoJsonContext.Default.MonoObjectInfoDTOArray);
            var new_dtos = System.Text.Json.JsonSerializer.Deserialize(json, MonoJsonContext.Default.MonoObjectInfoDTOArray);

        }

        public static MonoResultDTO<T_DTO> GetOk<T_DTO>(this T_DTO dto)
             where T_DTO : notnull
        {
            return new MonoResultDTO<T_DTO>()
            {
                CODE = (int)EnumMonoCommonCode.OK,
                DATA = dto
            };
        }
    }
}
