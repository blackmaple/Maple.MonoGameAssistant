using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;
namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSwitchDisplayDTO : GameObjectDisplayDTO
    {
        public string? ContentValue { set; get; }
        public bool CanWrite { set; get; }
        public List<GameValueInfoDTO>? SelectedContents { set; get; }

        [JsonIgnore]
        public bool SwitchValue
        {
            get
            {
                if (bool.TryParse(ContentValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => ContentValue = value.ToString();
        }
        [JsonIgnore]
        public decimal DecimalValue
        {
            get
            {
                if (decimal.TryParse(ContentValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => ContentValue = value.ToString();
        }
        [JsonIgnore]
        public uint UIntContent
        {
            get
            {
                if (uint.TryParse(ContentValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set => ContentValue = value.ToString();
        }
        [JsonIgnore]
        public string? CacheValue { set; get; }

        [JsonIgnore]
        public int IntCache
        {
            get
            {
                if (int.TryParse(CacheValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.CacheValue = value.ToString();
            }
        }

        [JsonIgnore]
        public float FloatCache
        {
            get
            {
                if (float.TryParse(CacheValue, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.CacheValue = value.ToString();
            }
        }

        [JsonIgnore]
        public bool ButtonType => UIType == (int)EnumGameSwitchUIType.Button;
        [JsonIgnore]
        public bool LabelType => UIType == (int)EnumGameSwitchUIType.Label;
        [JsonIgnore]
        public bool TextEditorType => UIType == (int)EnumGameSwitchUIType.TextEditor;
        [JsonIgnore]
        public bool SwitchesType => UIType == (int)EnumGameSwitchUIType.Switches;
        [JsonIgnore]
        public bool SelectsType => UIType == (int)EnumGameSwitchUIType.Selects && SelectedContents is not null;


        [JsonIgnore]
        public bool Loading { set; get; }

        [JsonIgnore]
        public int UIType
        {
            get
            {
                if (int.TryParse(DisplayCategory, out var result))
                {
                    return result;
                }
                return default;
            }
            set
            {
                this.DisplayCategory = value.ToString();
            }
        }
    }


    public enum EnumGameSwitchUIType
    {
        /// <summary>
        /// 标签
        /// </summary>
        Label = 0,
        /// <summary>
        /// 文本编辑框
        /// </summary>
        TextEditor = 1,
        /// <summary>
        /// 按钮
        /// </summary>
        Button = 2,
        /// <summary>
        /// 选择
        /// </summary>
        Switches = 3,
        /// <summary>
        /// 列表
        /// </summary>
        Selects = 4,

    }
}
