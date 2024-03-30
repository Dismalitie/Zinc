using Microsoft.Web.WebView2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using ZincBrowser.Properties;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static WinBlur.UI;

namespace ZincBrowser
{
    public partial class Form1 : Form
    {
        public List<TabHandle> tabhandles = new List<TabHandle>();
        public List<WebView2> pages = new List<WebView2>();
        public WebView2 currentPage = null;
        public List<string> history = new List<string>(); // too lazy, implement later

        public bool sidebarMinimised = false;
        public bool incognitoMode = false;
        public bool settingsOpen = false;

        ColorMgr c = new ColorMgr();

        public Form1()
        {
            InitializeComponent();
        }

        public void setPanelColors(SiticonePanel panel)
        {
            panel.BorderColor = c.border;
            panel.BorderRadius = Settings.Default.BorderRadius;
            panel.BorderThickness = Settings.Default.BorderThickness;
            panel.FillColor = c.panelTint;
        }

        public void setButtonColors(SiticoneButton btn)
        {
            btn.HoveredState.BorderColor = c.accent;
            btn.BorderColor = c.border;
            btn.BorderRadius = Settings.Default.BorderRadius;
            btn.BorderThickness = Settings.Default.BorderThickness;
            btn.FillColor = c.panelTint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MaterialStyle == "tabbed")
            {
                SetBlurStyle(cntrl: this, blurType: BlurType.Tabbed, designMode: Mode.DarkMode);
            }
            if (Properties.Settings.Default.MaterialStyle == "mica")
            {
                SetBlurStyle(cntrl: this, blurType: BlurType.Mica, designMode: Mode.DarkMode);
            }

            foreach (SiticonePanel panel in Controls)
            {
                setPanelColors(panel);
            }

            setButtonColors(newtab);
            setButtonColors(closeall);
            setButtonColors(minside);

            setButtonColors(reload);
            setButtonColors(forward);
            setButtonColors(backward);
            addressbar.HoveredState.BorderColor = c.accent;
            addressbar.FocusedState.BorderColor = c.accent;
            addressbar.BorderColor = c.border;

            setButtonColors(incognito);
            setButtonColors(searchhistory);
            setButtonColors(customisation);

            setButtonColors(zoomin);
            setButtonColors(zoomout);

            setButtonColors(bookmarks);
            setButtonColors(bookmarkadd);

            tablist_e.BorderRadius = Settings.Default.BorderRadius;
            addr_e.BorderRadius = Settings.Default.BorderRadius;
        }

        private void update_Tick(object sender, EventArgs e)
        {
            // do checking and error prevention here
            if (currentPage == null && tablist.Controls.Count > 0)
            {
                TabHandle newpage = (TabHandle)tablist.Controls[tablist.Controls.Count - 1];
                currentPage = newpage.page;
            }
            if (currentPage == null || tablist.Controls.Count == 0)
            {
                reload.Enabled = false;
                forward.Enabled = false;
                backward.Enabled = false;
                zoomin.Enabled = false;
                zoomout.Enabled = false;
                bookmarkadd.Enabled = false;
            }
            else
            {
                if (currentPage.CanGoForward)
                {
                    forward.Enabled = true;
                }
                if (currentPage.CanGoBack)
                {
                    backward.Enabled = true;
                }
                reload.Enabled = true;
                zoomin.Enabled = true;
                zoomout.Enabled = true;
                zoomlbl.Text = (currentPage.ZoomFactor * 100).ToString() + "%"; // convert zoomfactor max 2 to 200 and add %
                bookmarkadd.Enabled = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // abomination 🤌
            tabarea.Width = 256;
            tabarea.Height = ClientSize.Height - 130;
            tabarea.Location = new Point(10, 65);

            pagecontrolarea.Width = ClientSize.Width - 281;
            pagecontrolarea.Height = 50;
            pagecontrolarea.Location = new Point(tabarea.Location.X + tabarea.Width + 5, 10);

            menu.Width = tabarea.Width;
            menu.Height = 50;
            menu.Location = new Point(10, tabarea.Height + tabarea.Location.Y + 5);

            pagearea.Width = ClientSize.Width - 281;
            pagearea.Height = ClientSize.Height - 130;
            pagearea.Location = new Point(tabarea.Location.X + tabarea.Width + 5, 65);

            tabcontrolarea.Width = tabarea.Width;
            tabcontrolarea.Height = pagecontrolarea.Height;
            tabcontrolarea.Location = new Point(10, 10);

            newtab.Height = tabcontrolarea.Height - 10;
            newtab.Width = 78;
            newtab.Location = new Point(5, 5);

            closeall.Height = newtab.Height;
            closeall.Width = 78;
            closeall.Location = new Point(newtab.Width + 10, 5);

            minside.Height = closeall.Height;
            minside.Width = 78;
            minside.Location = new Point(newtab.Width + closeall.Width + 15, 5);

            backward.Height = newtab.Height;
            backward.Width = backward.Height;
            backward.Location = new Point(5, 5);

            reload.Height = newtab.Height;
            reload.Width = reload.Height;
            reload.Location = new Point(backward.Width + 10, 5);

            forward.Height = newtab.Height;
            forward.Width = forward.Height;
            forward.Location = new Point(backward.Width + reload.Width + 15, 5);

            addressbar.Height = newtab.Height;
            addressbar.Width = pagecontrolarea.Width - (backward.Width + reload.Width + forward.Width + 30);
            addressbar.Location = new Point(backward.Width + reload.Width + forward.Width + 20, 5);

            customisation.Height = newtab.Height;
            customisation.Width = 78;
            customisation.Location = new Point(5, 5);

            searchhistory.Height = customisation.Height;
            searchhistory.Width = 78;
            searchhistory.Location = new Point(customisation.Width + 10, 5);

            incognito.Height = searchhistory.Height;
            incognito.Width = 78;
            incognito.Location = new Point(customisation.Width + searchhistory.Width + 15, 5);

            misccontrols.Height = pagecontrolarea.Height;
            misccontrols.Width = pagecontrolarea.Width;
            misccontrols.Location = new Point(pagecontrolarea.Location.X, menu.Location.Y);

            zoomin.Height = incognito.Height;
            zoomin.Width = zoomin.Height;
            zoomin.Location = new Point(misccontrols.Width - zoomin.Width - 5, 5);

            zoomout.Size = zoomin.Size;
            zoomout.Location = new Point(zoomin.Location.X - 5 - zoomout.Width, 5);

            zoomlbl.Location = new Point(zoomout.Location.X - 5 - zoomout.Width, (zoomlbl.Parent.Height / 2) - (zoomlbl.Height / 2));

            bookmarks.Size = zoomout.Size;
            bookmarks.Location = new Point(5, 5);

            bookmarkadd.Size = bookmarks.Size;
            bookmarkadd.Location = new Point(bookmarks.Location.X + 5 + bookmarks.Width, 5);

            foreach (Control ctrl in pagearea.Controls)
            {
                ctrl.Width = ctrl.Parent.Width - 10;
                ctrl.Height = ctrl.Parent.Height - 10;
                ctrl.Location = new Point(5, 5);
            }
        }

        private void newtab_Click(object sender, EventArgs e)
        {
            WebView2 page = new WebView2();

            page.Source = new Uri("https://www.google.com/");
            page.Parent = pagearea;
            page.Size = new Size(pagearea.Width - 10, pagearea.Height - 10);
            page.Location = new Point(5, 5);

            page.BringToFront();
            currentPage = page;

            SiticoneElipse eli = new SiticoneElipse();
            eli.TargetControl = page;
            eli.BorderRadius = Settings.Default.BorderRadius;
            eli.SetElipse(page);

            TabHandle tabhandle = new TabHandle("https://www.google.com/", page, addressbar);
            tabhandle.Parent = tablist;

            tabhandles.Add(tabhandle);
            pages.Add(page);
        }

        private void closeall_Click(object sender, EventArgs e)
        {
            tablist.Hide();
            pagearea.Hide();
            foreach (TabHandle tabhandle in tabhandles)
            {
                tabhandle.Dispose();
                pages[tabhandles.IndexOf(tabhandle)].Dispose();
            }
            tablist.Show();
            pagearea.Show();
        }

        private void addressbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && currentPage == null)
            { 
                WebView2 page = new WebView2();

                Regex searchRegex = new Regex(@"^[a-zA-Z0-9\s]+$");
                Regex urlRegex = new Regex(@"^https?://");
                if (searchRegex.IsMatch(addressbar.Text))
                {
                    page.Source = new Uri($"https://www.google.com/search?q={HttpUtility.UrlEncode(addressbar.Text)}");
                }
                if (urlRegex.IsMatch(addressbar.Text))
                {
                    page.Source = new Uri(addressbar.Text);
                }
                page.Source = new Uri($"https://www.google.com/search?q={HttpUtility.UrlEncode(addressbar.Text)}");

                page.Parent = pagearea;
                page.Size = new Size(pagearea.Width - 10, pagearea.Height - 10);
                page.Location = new Point(5, 5);

                page.BringToFront();
                currentPage = page;

                SiticoneElipse eli = new SiticoneElipse();
                eli.TargetControl = page;
                eli.BorderRadius = Settings.Default.BorderRadius;
                eli.SetElipse(page);

                TabHandle tabhandle = new TabHandle("https://www.google.com/", page, addressbar);
                tabhandle.Parent = tablist;

                tabhandles.Add(tabhandle);
                pages.Add(page);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Regex searchRegex = new Regex(@"^[a-zA-Z0-9\s]+$");
                Regex urlRegex = new Regex(@"^https?://");
                if (searchRegex.IsMatch(addressbar.Text))
                {
                    currentPage.Source = new Uri($"https://www.google.com/search?q={HttpUtility.UrlEncode(addressbar.Text)}");
                }
                if (urlRegex.IsMatch(addressbar.Text))
                {
                    currentPage.Source = new Uri(addressbar.Text);
                }
                currentPage.Source = new Uri($"https://www.google.com/search?q={HttpUtility.UrlEncode(addressbar.Text)}");
            }
        }

        private void backward_Click(object sender, EventArgs e)
        {
            currentPage.GoBack();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            currentPage.Reload();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            currentPage.GoForward();
        }

        private void minside_Click(object sender, EventArgs e)
        {
            sidebarMinimised = !sidebarMinimised;
            if (sidebarMinimised)
            {
                tabarea.Width = 0;
                minside.Image = Resources.sidebar_open;

                pagearea.Width = ClientSize.Width - 20;
                pagearea.Location = new Point(10, pagearea.Location.Y);
                foreach (Control ctrl in pagearea.Controls)
                {
                    ctrl.Width = ctrl.Parent.Width - 10;
                    ctrl.Height = ctrl.Parent.Height - 10;
                    ctrl.Location = new Point(5, 5);
                }
            }
            else
            {
                tabarea.Width = 256;
                minside.Image = Resources.sidebar_close;

                pagearea.Location = new Point(tabarea.Location.X + tabarea.Width + 5, 65);
                pagearea.Width = ClientSize.Width - 281;
                foreach (Control ctrl in pagearea.Controls)
                {
                    ctrl.Width = ctrl.Parent.Width - 10;
                    ctrl.Height = ctrl.Parent.Height - 10;
                    ctrl.Location = new Point(5, 5);
                }
            }
        }

        private void customisation_Click(object sender, EventArgs e)
        {
            settingsOpen = !settingsOpen;
            if (!settingsOpen)
            {
                foreach (Control ctrl in pagearea.Controls)
                {
                    if (ctrl is Menu_Customisation)
                    {
                        Menu_Customisation mc = (Menu_Customisation)ctrl;
                        mc.save();
                        ctrl.Dispose();
                        return;
                    }
                }
            }
            else
            {
                Menu_Customisation mc = new Menu_Customisation();
                pagearea.Controls.Add(mc);
                mc.Dock = DockStyle.Fill;
                mc.BringToFront();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllLines(".\\history.ln", history);
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            currentPage.ZoomFactor = currentPage.ZoomFactor + 0.05; // WE ARE NOT ADDING A SLIDER TOO MANY PROBLEMS
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            currentPage.ZoomFactor = currentPage.ZoomFactor - 0.05;
        }
    }
}
