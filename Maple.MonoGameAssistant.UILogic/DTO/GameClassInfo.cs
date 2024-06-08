using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameClassInfo
{
    [NotNull]
    public MonoClassInfoDTO? RawClassInfo { get; set; }

    public GameParentClassInfo[]? ParentClassInfos { get; set; }
    public GameInterfaceInfo[]? InterfaceInfos { get; set; }
    public GameMethodInfo[]? MethodInfos { get; set; }
    public GameFieldInfo[]? FieldInfos { get; set; }

    [JsonIgnore]
    public GameFieldInfo[]? EnumFieldInfos { get; set; }
    [JsonIgnore]
    public GameFieldInfo[]? StaticFieldInfos { get; set; }
    [JsonIgnore]
    public GameFieldInfo[]? ConstFieldInfos { get; set; }
    [JsonIgnore]
    public GameFieldInfo[]? MemberFieldInfos { get; set; }

    //[JsonIgnore]
    //[NotNull]
    //public List<GameMethodInfo> SelectedMethods { set; get; } = [];



    [JsonIgnore]
    public bool Special { set; get; }

    public bool IsSingleton()
    {
        var rawClass = this.RawClassInfo;
        if (rawClass.IsAbstract)
        {
            return false;
        }

        if (this.StaticFieldInfos is null)
        {
            return false;
        }

        foreach (var fieldInfo in this.StaticFieldInfos)
        {
            var rawType = fieldInfo.RawFieldInfo.FieldType;
            if (rawClass.ImageName == rawType.ImageName
                && rawClass.Namespace == rawType.Namespace
                && rawClass.Name == rawType.Name
                && rawClass.FullName == rawType.TypeName)
            {
                return true;
            }
        }
        return false;
    }

    public bool IsC()
    {
        return this.RawClassInfo.FullName?.EndsWith("<>c", StringComparison.OrdinalIgnoreCase) == true;
    }

    public static bool SpecialClass(GameClassInfo gameClassInfo)
    {
        if (gameClassInfo.IsC() == false)
        {
            var rawClass = gameClassInfo.RawClassInfo;

            if (false == rawClass.IsValueType
              && rawClass.IsGeneric == false
              && rawClass.IsInterface == false

                )
            {
                if (rawClass.IsStatic || gameClassInfo.IsSingleton())
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static GameClassInfo FillGameClassInfo(MonoClassDetailDTO monoClassDetail, GameClassInfo? gameClassInfo = default)
    {
        gameClassInfo ??= new GameClassInfo() { RawClassInfo = monoClassDetail.ClassInfoDTO };

        if (gameClassInfo.FieldInfos is null && monoClassDetail.FieldInfos is not null)
        {
            var rawClass = monoClassDetail.ClassInfoDTO;

            var fieldInfoDTOs = monoClassDetail.FieldInfos;
            gameClassInfo.FieldInfos = fieldInfoDTOs.Select(p => new GameFieldInfo() { RawFieldInfo = p }).ToArray();
            gameClassInfo.EnumFieldInfos = MonoCollectorExtensions.GetEnumFieldInfos(rawClass, fieldInfoDTOs).Select(p => new GameFieldInfo() { RawFieldInfo = p }).ToArray();
            gameClassInfo.StaticFieldInfos = MonoCollectorExtensions.GetStaticFieldInfos(rawClass, fieldInfoDTOs).Select(p => new GameFieldInfo() { RawFieldInfo = p }).ToArray();
            gameClassInfo.ConstFieldInfos = MonoCollectorExtensions.GetConstFieldInfos(rawClass, fieldInfoDTOs).Select(p => new GameFieldInfo() { RawFieldInfo = p }).ToArray();
            gameClassInfo.MemberFieldInfos = MonoCollectorExtensions.GetMemberFieldInfos(rawClass, fieldInfoDTOs).Select(p => new GameFieldInfo() { RawFieldInfo = p }).ToArray();

        }
        if (gameClassInfo.MethodInfos is null && monoClassDetail.MethodInfos is not null)
        {
            gameClassInfo.MethodInfos = monoClassDetail.MethodInfos.Select(p => new GameMethodInfo()
            {
                RawMethodInfo = p,
                ParameterTypes = p.ParameterTypes.Select(p => new GameParameterType() { RawParameterType = p }).ToList()
            }).ToArray();

        }
        if (gameClassInfo.ParentClassInfos is null && monoClassDetail.ParentClassInfos is not null)
        {
            gameClassInfo.ParentClassInfos = monoClassDetail.ParentClassInfos.Select(p => new GameParentClassInfo() { RawClassInfo = p }).ToArray();

        }
        if (gameClassInfo.InterfaceInfos is null && monoClassDetail.InterfaceInfos is not null)
        {
            gameClassInfo.InterfaceInfos = monoClassDetail.InterfaceInfos.Select(p => new GameInterfaceInfo() { RawInterfaceInfo = p }).ToArray();

        }
        gameClassInfo.Special = SpecialClass(gameClassInfo);
        return gameClassInfo;


    }

    public void CopyTo(GameClassInfo dest)
    {
        dest.ParentClassInfos = this.ParentClassInfos;
        dest.InterfaceInfos = this.InterfaceInfos;
        dest.FieldInfos = this.FieldInfos;
        dest.MethodInfos = this.MethodInfos;

        dest.StaticFieldInfos = this.StaticFieldInfos;
        dest.EnumFieldInfos = this.EnumFieldInfos;
        dest.ConstFieldInfos = this.ConstFieldInfos;
        dest.MemberFieldInfos = this.MemberFieldInfos;

    }


    public string ShowCode()
    {
        var codes =
           MonoCollectorGeneratorV0.OutputStringBuilder(
           this.RawClassInfo,
           this.FieldInfos?.Select(p => p.RawFieldInfo).ToArray() ?? [],
           this.MethodInfos?.Select(p => p.RawMethodInfo).ToArray() ?? [],
           this.ParentClassInfos?.Select(p => p.RawClassInfo).ToArray() ?? [],
           this.InterfaceInfos?.Select(p => p.RawInterfaceInfo).ToArray() ?? []);
        return codes.ToString();
    }

    public Task<string> ShowCodeAsync()
    {
        return Task.Run(this.ShowCode);
    }

}
