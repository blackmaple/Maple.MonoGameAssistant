using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;

namespace Maple.MonoGameAssistant.GameShared.Service
{

    internal static class GameUIExtensions
    {
        private static MarkupString EmptyMarkupString { get; } = new MarkupString(nameof(string.Empty));
        public static MarkupString ToDisplayName(this GameDisplayDTO? gameDisplay)
        {

            if (gameDisplay is null || string.IsNullOrEmpty(gameDisplay.DisplayName))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameDisplay.DisplayName);
        }
        public static MarkupString ToDisplayDesc(this GameDisplayDTO? gameDisplay)
        {
            if (gameDisplay is null || string.IsNullOrEmpty(gameDisplay.DisplayDesc))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameDisplay.DisplayDesc);
        }
        public static MarkupString ToDisplayName(this GameValueInfoDTO gameValueInfo)
        {
            if (string.IsNullOrEmpty(gameValueInfo.DisplayName))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameValueInfo.DisplayName);
        }

        public static MarkupString ToDisplayValue(this GameValueInfoDTO gameValueInfo)
        {
            if (string.IsNullOrEmpty(gameValueInfo.DisplayValue))
            {
                return EmptyMarkupString;
            }
            return new MarkupString(gameValueInfo.DisplayValue);
        }
        public static IEnumerable<T> GetItemAttributes<T>(this IReadOnlyList<T>? gameValueInfos, bool onlyPreview = false)
            where T: GameValueInfoDTO
        {

            if (gameValueInfos is not null)
            {
                foreach (var itemAtt in gameValueInfos)
                {
                    if (onlyPreview)
                    {
                        if (itemAtt.CanPreview)
                        {
                            yield return itemAtt;
                        }
                    }
                    else
                    {
                        yield return itemAtt;
                    }
                }
            }
        }



        public static bool ContainsGameDisplay(this GameDisplayDTO gameDisplay, string searchContent, string? displayCategory)
        {
            if (false == string.IsNullOrEmpty(gameDisplay.DisplayName) && gameDisplay.DisplayName.Contains(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (false == string.IsNullOrEmpty(gameDisplay.DisplayDesc) && gameDisplay.DisplayDesc.Contains(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (false == string.IsNullOrEmpty(displayCategory) && displayCategory.Equals(searchContent, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }


        public static void ReplaceRange<T>(this List<T> list, IEnumerable<T> datas)
        { 
            list.Clear();
            list.AddRange(datas);
        }
    }


}
