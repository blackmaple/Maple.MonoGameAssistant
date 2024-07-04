using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    [JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = false,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    PropertyNameCaseInsensitive = true,
    Converters = [typeof(IntPtrJsonConverter), typeof(UIntPtrJsonConverter)])]


    [JsonSerializable(typeof(MonoResultDTO<GameSessionInfoDTO>))]
    [JsonSerializable(typeof(GameSessionInfoDTO))]
    [JsonSerializable(typeof(GameSessionObjectDTO))]
    [JsonSerializable(typeof(GameUniqueIndexDTO))]

    [JsonSerializable(typeof(GameObjectDisplayDTO))]
    [JsonSerializable(typeof(GameValueInfoDTO))]
    [JsonSerializable(typeof(GameValueInfoDTO[]))]
    [JsonSerializable(typeof(GameSkillDisplayDTO))]
    [JsonSerializable(typeof(GameSkillDisplayDTO[]))]


    [JsonSerializable(typeof(GameCurrencyInfoDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCurrencyInfoDTO>))]
    [JsonSerializable(typeof(GameCurrencyDisplayDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCurrencyDisplayDTO[]>))]
    [JsonSerializable(typeof(GameCurrencyModifyDTO))]
    [JsonSerializable(typeof(GameCurrencyObjectDTO))]


    [JsonSerializable(typeof(GameInventoryInfoDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameInventoryInfoDTO>))]
    [JsonSerializable(typeof(GameInventoryDisplayDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameInventoryDisplayDTO[]>))]
    [JsonSerializable(typeof(GameInventoryModifyDTO))]
    [JsonSerializable(typeof(GameInventoryObjectDTO))]

    [JsonSerializable(typeof(GameCharacterInfoDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCharacterInfoDTO>))]
    [JsonSerializable(typeof(GameCharacterStatusDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCharacterStatusDTO>))]
    [JsonSerializable(typeof(GameCharacterEquipmentDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCharacterEquipmentDTO>))]
    [JsonSerializable(typeof(GameCharacterEquipmentDTO))]
    [JsonSerializable(typeof(GameEquipmentInfoDTO))]
    [JsonSerializable(typeof(GameEquipmentInfoDTO[]))]

    [JsonSerializable(typeof(GameCharacterSkillDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCharacterSkillDTO>))]
    [JsonSerializable(typeof(GameCharacterDisplayDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameCharacterDisplayDTO[]>))]
    [JsonSerializable(typeof(GameCharacterObjectDTO))]


    [JsonSerializable(typeof(GameMonsterDisplayDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameMonsterDisplayDTO[]>))]

    [JsonSerializable(typeof(GameSkillDisplayDTO))]
    [JsonSerializable(typeof(MonoResultDTO<GameSkillDisplayDTO[]>))]
    [JsonSerializable(typeof(GameSkillInfoDTO))]
    [JsonSerializable(typeof(GameSkillInfoDTO[]))]


    [JsonSerializable(typeof(GameSwitchModifyDTO))]
    [JsonSerializable(typeof(GameSwitchDisplayDTO))]
    [JsonSerializable(typeof(GameSwitchDisplayDTO[]))]
    [JsonSerializable(typeof(MonoResultDTO<GameSwitchDisplayDTO[]>))]
    [JsonSerializable(typeof(MonoResultDTO<GameSwitchDisplayDTO>))]
    
    public partial class GameJsonContext: JsonSerializerContext
    {

    }
}
