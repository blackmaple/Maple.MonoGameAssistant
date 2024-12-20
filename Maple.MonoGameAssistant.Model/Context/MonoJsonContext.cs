using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.Model
{

    [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        WriteIndented = false,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        PropertyNameCaseInsensitive = true,
        Converters = [typeof(IntPtrJsonConverter), typeof(UIntPtrJsonConverter)])]
    [JsonSerializable(typeof(MonoResultDTO))]
    [JsonSerializable(typeof(MonoResultDTO<string>))]
    [JsonSerializable(typeof(MonoResultDTO<bool>))]

    //[JsonSerializable(typeof(MonoConstFieldInfoDTO))]
    //[JsonSerializable(typeof(MonoConstFieldInfoDTO[]))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoConstFieldInfoDTO>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoConstFieldInfoDTO[]>))]

    //[JsonSerializable(typeof(MonoEnumFieldInfoDTO))]
    //[JsonSerializable(typeof(MonoEnumFieldInfoDTO[]))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoEnumFieldInfoDTO>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoEnumFieldInfoDTO[]>))]

    [JsonSerializable(typeof(MonoClassInfoDTO))]
    [JsonSerializable(typeof(MonoClassInfoDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoClassInfoDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoClassInfoDTO[]>))]

    [JsonSerializable(typeof(MonoFieldInfoDTO))]
    [JsonSerializable(typeof(MonoFieldInfoDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoFieldInfoDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoFieldInfoDTO[]>))]

    [JsonSerializable(typeof(MonoImageInfoDTO))]
    [JsonSerializable(typeof(MonoImageInfoDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoImageInfoDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoImageInfoDTO[]>))]

    [JsonSerializable(typeof(MonoMethodInfoDTO))]
    [JsonSerializable(typeof(MonoMethodInfoDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoMethodInfoDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoMethodInfoDTO[]>))]


    [JsonSerializable(typeof(MonoObjectInfoDTO))]
    [JsonSerializable(typeof(MonoObjectInfoDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoObjectInfoDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoObjectInfoDTO[]>))]

    [JsonSerializable(typeof(MonoObjectPointerDTO))]
    [JsonSerializable(typeof(MonoObjectPointerDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoObjectPointerDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoObjectPointerDTO[]>))]

    [JsonSerializable(typeof(MonoParameterTypeDTO))]
    [JsonSerializable(typeof(MonoParameterTypeDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoParameterTypeDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoParameterTypeDTO[]>))]

    [JsonSerializable(typeof(MonoReturnTypeDTO))]
    [JsonSerializable(typeof(MonoReturnTypeDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoReturnTypeDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoReturnTypeDTO[]>))]


    //[JsonSerializable(typeof(MonoStaticFieldInfoDTO))]
    //[JsonSerializable(typeof(MonoStaticFieldInfoDTO[]))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoStaticFieldInfoDTO>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoStaticFieldInfoDTO[]>))]

    //[JsonSerializable(typeof(MonoTypeInfoDTO))]
    //[JsonSerializable(typeof(MonoTypeInfoDTO[]))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoTypeInfoDTO>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoTypeInfoDTO[]>))]



    [JsonSerializable(typeof(MonoRequestDTO))]
    [JsonSerializable(typeof(MonoPointerRequestDTO))]
    [JsonSerializable(typeof(MonoClassDetailRequestDTO))]

    //[JsonSerializable(typeof(MonoWebApiToken))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoWebApiToken>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoWebApiToken[]>))]


    [JsonSerializable(typeof(GameUniqueIndexDTO))]
    [JsonSerializable(typeof(GameSessionInfoDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameSessionInfoDTO>))]

    [JsonSerializable(typeof(MonoClassDetailDTO))]
    [JsonSerializable(typeof(MonoClassDetailDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<MonoClassDetailDTO>))]
    [JsonSerializable(typeof(MonoResultDTO<MonoClassDetailDTO[]>))]



    //[JsonSerializable(typeof(MonoPageRequestDTO<nint>))]
    //[JsonSerializable(typeof(MonoResultDTO<MonoPageResponseDTO<MonoClassInfoDTO>>))]


    [JsonSerializable(typeof(MonoResultDTO<byte[]>))]

    [JsonSerializable(typeof(MonoSearchMemberDTO))]
    [JsonSerializable(typeof(MonoSearchClassDTO))]
    [JsonSerializable(typeof(MonoSearchMethodDTO))]
    [JsonSerializable(typeof(MonoSearchFieldDTO))]
    [JsonSerializable(typeof(MonoSearchCollectionDTO))]
    [JsonSerializable(typeof(MonoResultDTO<MonoSearchCollectionDTO>))]

    public partial class MonoJsonContext : JsonSerializerContext
    {

    }
}
