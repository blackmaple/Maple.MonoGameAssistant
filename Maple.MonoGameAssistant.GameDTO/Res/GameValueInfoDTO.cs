using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System;
namespace Maple.MonoGameAssistant.GameDTO
{

    public class GameValueInfoDTO : GameUniqueIndexDTO
    {
        /// <summary>
        /// 对象名称
        /// </summary>
        public string? DisplayName { set; get; }
        /// <summary>
        /// 对象的值
        /// </summary>
        public string? DisplayValue { set; get; }

        /// <summary>
        /// 可编辑
        /// </summary>
        public bool CanWrite { set; get; }

        /// <summary>
        /// 可预览
        /// </summary>
        public bool CanPreview { set; get; }


        [JsonIgnore]
        public decimal DecimalValue
        {
            get => decimal.TryParse(DisplayValue, out var result) ? result : decimal.Zero;
            set => DisplayValue = value.ToString();
        }

        [JsonIgnore]
        public bool Loading { set; get; }


        [JsonIgnore]
        public bool? BoolValue
        {
            get
            {
                if (bool.TryParse(DisplayValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => DisplayValue = value.HasValue ? value.ToString() : string.Empty;
        }

    }
}
