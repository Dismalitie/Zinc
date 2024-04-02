using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZincBrowser.Properties;

namespace ZincBrowser
{
    internal class ColorMgr
    {
        public Color accent = Color.FromArgb(Settings.Default.BaseTransp + 20, Settings.Default.AccentColor_R, Settings.Default.AccentColor_G, Settings.Default.AccentColor_B);
        public Color border = Color.FromArgb(Settings.Default.BaseTransp + 10, Settings.Default.BorderColor_R, Settings.Default.BorderColor_G, Settings.Default.BorderColor_B);
        public Color panelTint = Color.FromArgb(Settings.Default.BaseTransp, Settings.Default.PanelTint_R, Settings.Default.PanelTint_G, Settings.Default.PanelTint_B);

        public void setPanelColors(SiticonePanel panel)
        {
            panel.BorderColor = border;
            panel.BorderRadius = Settings.Default.BorderRadius;
            panel.BorderThickness = Settings.Default.BorderThickness;
            panel.FillColor = panelTint;
        }

        public void setButtonColors(SiticoneButton btn)
        {
            btn.HoveredState.BorderColor = accent;
            btn.BorderColor = border;
            btn.BorderRadius = Settings.Default.BorderRadius;
            btn.BorderThickness = Settings.Default.BorderThickness;
            btn.FillColor = panelTint;
        }
    }
}
