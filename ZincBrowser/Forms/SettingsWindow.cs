using System;
using System.Windows.Forms;
using ZincBrowser.Menus;
using static WinBlur.UI;

namespace ZincBrowser
{
    public partial class SettingsWindow : Form
    {
        public string page = "customisation";

        public SettingsWindow(string page)
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
            cm.setButtonColors(history);

            if (page == "customisation")
            {
                pagearea.Controls.Clear();
                Menu_Customisation mc = new Menu_Customisation();
                pagearea.Controls.Add(mc);
                mc.Dock = DockStyle.Fill;
            }
            else if (page == "history")
            {
                pagearea.Controls.Clear();
                Menu_History mh = new Menu_History();
                pagearea.Controls.Add(mh);
                mh.Dock = DockStyle.Fill;
            }
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.settingsOpen = false;
        }

        private void history_Click(object sender, EventArgs e)
        {
            pagearea.Controls.Clear();
            Menu_History mh = new Menu_History();
            pagearea.Controls.Add(mh);
            mh.Dock = DockStyle.Fill;
        }

        private void customisation_Click(object sender, EventArgs e)
        {
            pagearea.Controls.Clear();
            Menu_Customisation mc = new Menu_Customisation();
            pagearea.Controls.Add(mc);
            mc.Dock = DockStyle.Fill;
        }
    }
}
