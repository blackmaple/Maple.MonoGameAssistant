using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameImageInfo
{
    [NotNull]
    public MonoImageInfoDTO? RawImageInfo { get; set; }
    public GameClassInfo[]? GameClassInfos { get; set; }

    static string[] SystemKeys => ["System", "mscorlib", "netstandard",];
    public bool IsSystem => SystemKeys.Any(p => true == RawImageInfo.Name?.StartsWith(p, StringComparison.OrdinalIgnoreCase));

    static string[] UnityKeys => ["Unity", "UnityEngine", "Mono", "__Generated",];
    public bool IsUnity => UnityKeys.Any(p => true == RawImageInfo.Name?.StartsWith(p, StringComparison.OrdinalIgnoreCase));

    static string[] LibraryKeys => [
        "Newtonsoft",
        "zlib.net",
        "protobuf-net",
        "spine-unity",
        "spine-csharp",
        "unitask",
        "ICSharpCode.SharpZipLib",
        "Entitas",
        "Kcp",
        "LitJSON",
        "DesperateDevs",

        "websocket-sharp",
        "XGamingRuntime",
        "Whinarn.UnityMeshSimplifier.Runtime",
        "Plugins.Voxelizer",
        "Plugins.ProceduralNoise",
        "Plugins.MarchingCubes",
        "Rewired_Windows_Functions",
        "Rewired_Windows",
        "Rewired_Core",
        "OdinSerializer",
        "OdinAOTSupport",
        "NavMeshComponents",
        "MeshExtension",
        "MeshCombineStudio.Runtime",
        "HBAO.Universal.Runtime",
        "DomainReloadHelper.Runtime",
        "AK.Wwise.",
        "AOTTypes",
        "Bzk.Async",
        "VerletRope",
        "TechArt.Runtime",
        "Pathfinding.",
        "LeTai.",
        "AmplifyShaderEditor.",
        "com.rlabrecque.steamworks.net",
        "JimmysUnityUtilities",
        "NaughtyAttributes.",
        "XNode",
        "TextMeshProEffect",
        "NaughtyAttributes",
        "FancyTextRendering",
        "sc.stylizedgrass.",
        "sc.stylizedwater2.",
        "FMODUnity",
        "Murdoc.",
        "Nementic.SelectionUtility.",
        "LinqTools",
        "Elringus.BlendModes.Runtime",
        "Sirenix.",
        "DOTWeen"
    ];
    public bool IsLibrary => LibraryKeys.Any(p => true == RawImageInfo.Name?.StartsWith(p, StringComparison.OrdinalIgnoreCase));

    public bool IsGame => !(IsSystem || IsUnity || IsLibrary);
}





