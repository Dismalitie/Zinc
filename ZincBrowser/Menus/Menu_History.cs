using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZincBrowser.UCs;

namespace ZincBrowser.Menus
{
    public partial class Menu_History : UserControl
    {
        public Menu_History()
        {
            InitializeComponent();
        }

        SecondaryStorageMgr ssmgr = new SecondaryStorageMgr();
        ColorMgr cm = new ColorMgr();

        private void Menu_History_Load(object sender, EventArgs e)
        {
            cm.setButtonColors(clr);
            foreach (Dictionary<string, string> search in ssmgr.getSearches())
            {
                SearchHandle sh = new SearchHandle(search["title"], search["url"], search["time"]);
                searches.Controls.Add(sh);
            }

            // reverse the controls so it show the most recent entry at the top
            Control[] controls = searches.Controls.Cast<Control>().ToArray();

            searches.Controls.Clear();

            for (int i = controls.Length - 1; i >= 0; i--)
            {
                searches.Controls.Add(controls[i]);
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(".\\secondaryStorage\\history.ini", false))
            {
                sw.WriteLine(":)");
            }
            searches.Controls.Clear();
        }
    }
}
