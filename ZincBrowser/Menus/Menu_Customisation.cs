using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZincBrowser.Properties;
using ZincBrowser.UCs;

namespace ZincBrowser
{
    public partial class Menu_Customisation : UserControl
    {
        public Menu_Customisation()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        ColorMgr c = new ColorMgr();
        SecondaryStorageMgr ssmgr = new SecondaryStorageMgr();

        public bool tabbed;

        private void Menu_Customisation_Load(object sender, EventArgs e)
        {
            nothemes.Hide();
            if (Settings.Default.MaterialStyle == "tabbed")
            {
                tabbed = true;
                mat_tabbed.ForeColor = Color.White;
                mat_mica.ForeColor = Color.Gray;
            }
            else
            {
                tabbed = false;
                mat_mica.ForeColor= Color.White;
                mat_tabbed.ForeColor= Color.Gray;
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SiticoneMaterialTextBox)
                {
                    SiticoneElipse eli = new SiticoneElipse();
                    eli.TargetControl = ctrl;
                    eli.BorderRadius = Settings.Default.BorderRadius;
                    eli.SetElipse(ctrl);
                }
            }

            c.setButtonColors(mat_mica);
            c.setButtonColors(mat_tabbed);
            c.setButtonColors(sv);

            border_r.Text = Settings.Default.BorderColor_R.ToString();
            border_g.Text = Settings.Default.BorderColor_G.ToString();
            border_b.Text = Settings.Default.BorderColor_B.ToString();

            transp_val.Text = Settings.Default.BaseTransp.ToString();

            panelcol_r.Text = Settings.Default.PanelTint_R.ToString();
            panelcol_g.Text = Settings.Default.PanelTint_G.ToString();
            panelcol_b.Text = Settings.Default.PanelTint_B.ToString();

            borderthicc_val.Text = Settings.Default.BorderThickness.ToString();

            borderrad_val.Text = Settings.Default.BorderRadius.ToString();

            if (Settings.Default.MaterialStyle == "tabbed")
            {
                mat_tabbed.BorderColor = c.accent;
            }
            else
            {
                mat_mica.BorderColor = c.accent;
            }

            acc_r.Text = Settings.Default.AccentColor_R.ToString();
            acc_g.Text = Settings.Default.AccentColor_G.ToString();
            acc_b.Text = Settings.Default.AccentColor_B.ToString();

            transp_val.FocusedState.BorderColor = c.accent;
            borderthicc_val.FocusedState.BorderColor = c.accent;
            borderrad_val.FocusedState.BorderColor = c.accent;

            transp_val.HoveredState.BorderColor = c.accent;
            borderthicc_val.HoveredState.BorderColor = c.accent;
            borderrad_val.HoveredState.BorderColor = c.accent;

            foreach (Dictionary<string, object> config in ssmgr.loadThemes())
            {
                ThemeHandle th = new ThemeHandle(config);
                themes.Controls.Add(th);
            }

            if (themes.Controls.Count == 0)
            {
                nothemes.Show();
            }
        }

        private void mat_tabbed_Click(object sender, EventArgs e)
        {
            c.setButtonColors(mat_mica);
            mat_tabbed.BorderColor = c.accent;
            mat_mica.ForeColor = Color.Gray;
            mat_tabbed.ForeColor = Color.White;
            tabbed = true;
        }

        private void mat_mica_Click(object sender, EventArgs e)
        {
            c.setButtonColors(mat_tabbed);
            mat_mica.BorderColor = c.accent;
            mat_tabbed.ForeColor = Color.Gray;
            mat_mica.ForeColor = Color.White;
            tabbed = false;
        }

        private void Menu_Customisation_Resize(object sender, EventArgs e)
        {
            sv.Width = (ClientSize.Width - 10);
            sv.Location = new Point(5, Height - 40);
        }

        public void save()
        {
            try
            {
                Settings.Default.BorderColor_R = int.Parse(border_r.Text);
                Settings.Default.BorderColor_G = int.Parse(border_g.Text);
                Settings.Default.BorderColor_B = int.Parse(border_b.Text);

                Settings.Default.BaseTransp = int.Parse(transp_val.Text);
                Settings.Default.BorderRadius = int.Parse(borderrad_val.Text);
                Settings.Default.BorderThickness = int.Parse(borderthicc_val.Text);

                Settings.Default.PanelTint_R = int.Parse(panelcol_r.Text);
                Settings.Default.PanelTint_G = int.Parse(panelcol_g.Text);
                Settings.Default.PanelTint_B = int.Parse(panelcol_b.Text);

                Settings.Default.AccentColor_R = int.Parse(acc_r.Text);
                Settings.Default.AccentColor_G = int.Parse(acc_g.Text);
                Settings.Default.AccentColor_B = int.Parse(acc_b.Text);

                if (tabbed)
                {
                    Settings.Default.MaterialStyle = "tabbed";
                }
                else
                {
                    Settings.Default.MaterialStyle = "mica";
                }
            }
            catch
            {
                MessageBox.Show("All inputs must be integers 255 or lower.");
                return;
            }

            if (!f.incognitoMode)
            {
                // when i add search history, write it here with a function ig
            }

            Settings.Default.Save();

            if (MessageBox.Show("Zinc requires a restart to apply changes.\nWould you like to restart now?", "Zinc - Customisation Settings", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void sv_Click(object sender, EventArgs e)
        {
            save();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
