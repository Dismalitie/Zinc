using System;
using System.Windows.Forms;
using static WinBlur.UI;

namespace ZincBrowser
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        ColorMgr cm = new ColorMgr();
        Form1 f = new Form1();

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MaterialStyle == "tabbed")
            {
                SetBlurStyle(cntrl: this, blurType: BlurType.Tabbed, designMode: Mode.DarkMode);
            }
            if (Properties.Settings.Default.MaterialStyle == "mica")
            {
                SetBlurStyle(cntrl: this, blurType: BlurType.Mica, designMode: Mode.DarkMode);
            }

            cm.setButtonColors(customisation);

            Menu_Customisation mc = new Menu_Customisation();
            pagearea.Controls.Add(mc);
            mc.Dock = DockStyle.Fill;
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.settingsOpen = false;
        }
    }
}
