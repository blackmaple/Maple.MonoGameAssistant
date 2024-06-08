using DevExpress.Office.Utils;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public partial class PageCodeEditor : DevExpress.XtraEditors.XtraUserControl
    {
        public PageCodeEditor()
        {
            InitializeComponent();
        }


        public void SetCodeView(string code)
        {
            this.CodeEditor.Text= code;
            this.CodeEditor.UpdateTextHighlight();
        }


        private void CodeEditor_Properties_CustomHighlightText(object sender, TextEditCustomHighlightTextEventArgs e)
        {
            HighlightKeyword(e);
            HighlightNumbers(e);
            HighlightStrings(e);
            HighlightComment(e);

        }


        static Color KeywordColor { get; } = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
        static Color StringColor { get; } = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
        static Color CommentColor { get; } = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
        static Color NumberColor { get; } = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
        const char StringStartChar = '\'';
        static string[] KeywordList { get; } = 
            [
                "abstract",
                "as",
                "base",
                "bool",
                "break",
                "byte",
                "case",
                "catch",
                "char",
                "checked",
                "class",
                "const",
                "continue",
                "decimal",
                "default",
                "delegate",
                "do",
                "double",
                "else",
                "enum",
                "event",
                "explicit",
                "extern",
                "FALSE",
                "finally",
                "fixed",
                "float",
                "for",
                "foreach",
                "goto",
                "if",
                "implicit",
                "in",
                "int",
                "interface",
                "internal",
                "is",
                "lock",
                "long",
                "namespace",
                "new",
                "null",
                "object",
                "operator",
                "out",
                "override",
                "params",
                "private",
                "protected",
                "public",
                "readonly",
                "ref",
                "return",
                "sbyte",
                "sealed",
                "short",
                "sizeof",
                "stackalloc",
                "static",
                "string",
                "struct",
                "switch",
                "this",
                "throw",
                "TRUE",
                "try",
                "typeof",
                "uint",
                "ulong",
                "unchecked",
                "unsafe",
                "ushort",
                "using",
                "virtual",
                "void",
                "volatile",
                "while",
                "add",
                "and",
                "alias",
                "ascending",
                "args",
                "async",
                "await",
                "by",
                "descending",
                "dynamic",
                "equals",
                "file",
                "from",
                "get",
                "global",
                "group",
                "init",
                "into",
                "join",
                "let",
                "managed",
                "nameof",
                "nint",
                "not",
                "notnull",
                "nuint",
                "on",
                "or",
                "orderby",
                "partial",
                "partial",
                "record",
                "remove",
                "required",
                "scoped",
                "select",
                "set",
                "unmanaged",
                "unmanaged",
                "value",
                "var",
                "when",
                "where",
                "where",
                "with",
                "yield",


            ];
        static void HighlightComment(TextEditCustomHighlightTextEventArgs e)
        {
            string text = e.Text;
            int index = text.IndexOf("//");
            if (index != -1)
                e.HighlightRange(index, text.Length - index, CommentColor);
        }
        static void HighlightKeyword(TextEditCustomHighlightTextEventArgs e)
        {
            for (int i = 0; i < KeywordList.Length; i++)
            {
                e.HighlightWords(KeywordList[i], KeywordColor);
            }
        }
        static void HighlightStrings(TextEditCustomHighlightTextEventArgs e)
        {
            string text = e.Text;
            int length = text.Length;
            int startTextIndex = -1;
            while (startTextIndex < length)
            {
                startTextIndex = text.IndexOf(StringStartChar, startTextIndex + 1);
                if (startTextIndex == -1) break;
                int endTextIndex = text.IndexOf(StringStartChar, startTextIndex + 1);
                if (endTextIndex == -1)
                    endTextIndex = length;
                e.HighlightRange(startTextIndex, endTextIndex - startTextIndex + 1, StringColor);
                startTextIndex = endTextIndex;
            }
        }
        static void HighlightNumbers(TextEditCustomHighlightTextEventArgs e)
        {
            string text = e.Text;
            int length = text.Length;
            int startWordIndex = 0;
            for (int i = 0; i < length; i++)
            {
                var ch = text[i];
                if (char.IsWhiteSpace(ch) || char.IsSeparator(ch) || char.IsPunctuation(ch))
                {
                    if (startWordIndex != -1 && i - startWordIndex > 0)
                        e.HighlightRange(startWordIndex, i - startWordIndex, NumberColor);
                    startWordIndex = i + 1;
                    continue;
                }
                if (!char.IsNumber(ch)) startWordIndex = -1;
            }
            if (startWordIndex != -1)
                e.HighlightRange(startWordIndex, length - startWordIndex, NumberColor);
        }
    }
}
