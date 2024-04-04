using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ZincBrowser.UCs
{
    public partial class ThemeHandle : UserControl
    {
        public Dictionary<string, object> theme = new Dictionary<string, object>();
        public string matStyle = "tabbed";

        public ThemeHandle(Dictionary<string, object> theme)
        {
            InitializeComponent();
            this.theme = theme;
        }

        private void ThemeHandle_Load(object sender, EventArgs e)
        {
            // so many casts
            main.Text = (string)theme["DisplayName"];

            main.BorderColor = Color.FromArgb((int)theme["BorderColor_R"], (int)theme["BorderColor_G"], (int)theme["BorderColor_B"]);
            main.FillColor = Color.FromArgb((int)theme["BaseTransp"], (int)theme["PanelTint_R"], (int)theme["PanelTint_G"], (int)theme["PanelTint_B"]);
            main.HoveredState.BorderColor = Color.FromArgb((int)theme["AccentColor_R"], (int)theme["AccentColor_G"], (int)theme["AccentColor_B"]);
            main.BorderThickness = (int)theme["BorderThickness"];
            main.BorderRadius = (int)theme["BorderRadius"];
            if ((string)theme["BorderStyle"] == "solid")
            {
                main.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else if ((string)theme["BorderStyle"] == "dash")
            {
                main.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if ((string)theme["BorderStyle"] == "dot")
            {
                main.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }

            if ((string)theme["MaterialStyle"] == "tabbed")
            {
                matStyle = "tabbed";
            }
            else if ((string)theme["MaterialStyle"] == "mica")
            {
                matStyle = "mica";
            }
        }

        private void main_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BorderColor_R = main.BorderColor.R;
            Properties.Settings.Default.BorderColor_G = main.BorderColor.G;
            Properties.Settings.Default.BorderColor_B = main.BorderColor.B;

            Properties.Settings.Default.PanelTint_R = main.FillColor.R;
            Properties.Settings.Default.PanelTint_G = main.FillColor.G;
            Properties.Settings.Default.PanelTint_B = main.FillColor.B;

            Properties.Settings.Default.AccentColor_R = main.HoveredState.BorderColor.R;
            Properties.Settings.Default.AccentColor_G = main.HoveredState.BorderColor.G;
            Properties.Settings.Default.AccentColor_B = main.HoveredState.BorderColor.B;

            Properties.Settings.Default.BorderThickness = main.BorderThickness;
            Properties.Settings.Default.BorderStyle = (string)theme["BorderStyle"]; // fetch directly instead of if statements
            Properties.Settings.Default.BorderRadius = main.BorderRadius;

            Properties.Settings.Default.BaseTransp = main.FillColor.A; // gets the alpha channel from the paneltint
            Properties.Settings.Default.MaterialStyle = matStyle;

            Properties.Settings.Default.Save();

            if (MessageBox.Show("Zinc requires a restart to apply the selected theme.\nWould you like to restart now?", "Zinc - Customisation Settings", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    WorkingDirectory = Environment.CurrentDirectory,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = Process.Start(psi);
                process.StandardInput.WriteLine("start ZincBrowser.exe");
                process.StandardInput.WriteLine("exit");
                process.WaitForExit();
                Application.Exit();
            }
        }
    }
}
