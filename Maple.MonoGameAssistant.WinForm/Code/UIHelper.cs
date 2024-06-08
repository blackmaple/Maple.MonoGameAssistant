using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Maple.MonoGameAssistant.Model;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public static class UIHelper
    {
        public static EditorButton CreateEditorButton(Color foreColor, string name, bool left = true)
        {
            var editorButtonImageOptions1 = new EditorButtonImageOptions();

            var serializableAppearanceObject1 = new SerializableAppearanceObject
            {
                FontStyleDelta = System.Drawing.FontStyle.Bold,
                ForeColor = foreColor,
            };
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject1.Options.UseForeColor = true;

            var serializableAppearanceObject2 = new SerializableAppearanceObject();
            var serializableAppearanceObject3 = new SerializableAppearanceObject();
            var serializableAppearanceObject4 = new SerializableAppearanceObject();
            return new EditorButton(ButtonPredefines.Glyph, name, -1, false, true, left, editorButtonImageOptions1, new KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, ToolTipAnchor.Default);

        }



        public static UISplashScreen ShowSplashScreen(this Form @this) => new(@this);
        public static void SetGridViewRowNumber(this DevExpress.XtraGrid.Views.Grid.GridView @this)
        {
            @this.IndicatorWidth = 40;
            @this.TopRowChanged += static (sender, e) =>
            {
                if (sender is DevExpress.XtraGrid.Views.Grid.GridView gv)
                {
                    var graphics = new Control().CreateGraphics();

                    var count = gv.TopRowIndex + gv.RowCount;
                    if (count == 0)
                    {
                        count = 40;
                    }
                    var sizeF = graphics.MeasureString(count.ToString(), gv.Appearance.Row.Font);
                    int width = Convert.ToInt32(sizeF.Width) + 20;
                    if ((gv.IndicatorWidth - 4 < width || gv.IndicatorWidth + 4 > width) && gv.IndicatorWidth != width)
                    {
                        gv.IndicatorWidth = width;
                    }
                }
            };
            @this.CustomDrawRowIndicator += static (sender, e) =>
            {
                if (sender is DevExpress.XtraGrid.Views.Grid.GridView gv)
                {
                    var row = e.RowHandle;
                    if (e.Info.IsRowIndicator && row >= 0)
                    {
                        e.Info.DisplayText = (row + 1).ToString();
                    }
                }
            };
        }

        public static void GridView_CustomRowCellEdit<T_RawObject, T_ClassInfo>(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e,
            DevExpress.XtraGrid.Columns.GridColumn gridColumn,
            Func<T_RawObject, T_ClassInfo> getClassInfo)
            where T_RawObject : class
            where T_ClassInfo : MonoClassInfoDTO
        {
            if (sender is not GridView gv)
            {
                return;
            }
            if (e.Column.Name != gridColumn.Name)
            {
                return;
            }

            if (e.RepositoryItem is UIClassDisplay)
            {
                return;
            }
            if (gv.GetRow(e.RowHandle) is not T_RawObject rawObject)
            {
                return;
            }
            T_ClassInfo classInfo = getClassInfo(rawObject);
            e.RepositoryItem = UIClassDisplay.Create(classInfo);
        }

        public static void GridView_RowCellClick<T_RawObject>(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e,
            DevExpress.XtraGrid.Columns.GridColumn gridColumn, Action<T_RawObject> action)
            where T_RawObject : class
        {
            if (e.Clicks < 2)
            {
                return;
            }
            if (e.Column.Name != gridColumn.Name)
            {
                return;
            }
            if (sender is not GridView gv)
            {
                return;
            }
            if (gv.GetRow(e.RowHandle) is not T_RawObject rawObject)
            {
                return;
            }
            action(rawObject);
        }

        public static bool TryGetDoubleClickedRowCellObject<T_OBJECT>(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e, GridColumn? gridColumn, [MaybeNullWhen(false)] out T_OBJECT obj)
            where T_OBJECT : class
        {
            Unsafe.SkipInit(out obj);
            if (e.Clicks < 2)
            {
                return false;
            }
            if (gridColumn is not null && gridColumn.Name != e.Column.Name)
            {
                return false;
            }
            if (sender is not DevExpress.XtraGrid.Views.Grid.GridView gv)
            {
                return false;
            }
            if (gv.GetRow(e.RowHandle) is not T_OBJECT selectedObj || selectedObj is null)
            {
                return false;
            }
            obj = selectedObj;
            return true;
        }



        public static bool TryOpenFolderBrowserDialog(this Form frm, out string selectedPath)
        {
            XtraFolderBrowserDialog dialog = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                UseParentFormIcon = false,
            };
            var dialogResult = dialog.ShowDialog(frm);
            selectedPath = dialog.SelectedPath;
            return dialogResult == DialogResult.OK;
        }
    }

}
