using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab;
using DevExpress.Utils;
using DevExpress.XtraTab.ViewInfo;

namespace WindowsApplication1
{
    public class MySkinTabPainter : SkinTabPainter
    {

        public MySkinTabPainter(DevExpress.XtraTab.IXtraTab tabControl)
            : base(tabControl)
        {

        }

        protected override void DrawHeader(TabDrawArgs e)
        {
            base.DrawHeader(e);
            Rectangle bounds = e.Bounds;
            string headerText = "----------------------- Custom draw header -----------------------";
            e.Graphics.DrawString(headerText, new Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold), Brushes.Black, bounds);
            bounds.Offset(-2, -2);
            e.Graphics.DrawString(headerText, new Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold), Brushes.White, bounds);
            foreach (BaseTabRowViewInfo rowInfo in e.ViewInfo.HeaderInfo.Rows)
            {
                for (int i = 0; i < rowInfo.Pages.Count; i++)
                {
                    Rectangle pageBounds = rowInfo.Pages[i].Bounds;
                    pageBounds.Offset(0, 20);
                    e.Graphics.DrawString(Environment.NewLine + "Custom draw", AppearanceObject.DefaultFont, Brushes.Black, pageBounds);
                    pageBounds.Offset(-1, -1);
                    e.Graphics.DrawString(Environment.NewLine + "Custom draw", AppearanceObject.DefaultFont, Brushes.Yellow, pageBounds);
                }
            }

        }

    }
}
