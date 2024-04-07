namespace ZincBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablist = new System.Windows.Forms.FlowLayoutPanel();
            this.pagearea = new Siticone.UI.WinForms.SiticonePanel();
            this.pagecontrolarea = new Siticone.UI.WinForms.SiticonePanel();
            this.addressbar = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.menu = new Siticone.UI.WinForms.SiticonePanel();
            this.tabarea = new Siticone.UI.WinForms.SiticonePanel();
            this.tabcontrolarea = new Siticone.UI.WinForms.SiticonePanel();
            this.addr_e = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.tablist_e = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.misccontrols = new Siticone.UI.WinForms.SiticonePanel();
            this.zoomlbl = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.bookmarkdel = new Siticone.UI.WinForms.SiticoneButton();
            this.bookmarkadd = new Siticone.UI.WinForms.SiticoneButton();
            this.bookmarks = new Siticone.UI.WinForms.SiticoneButton();
            this.zoomin = new Siticone.UI.WinForms.SiticoneButton();
            this.zoomout = new Siticone.UI.WinForms.SiticoneButton();
            this.minside = new Siticone.UI.WinForms.SiticoneButton();
            this.closeall = new Siticone.UI.WinForms.SiticoneButton();
            this.newtab = new Siticone.UI.WinForms.SiticoneButton();
            this.incognito = new Siticone.UI.WinForms.SiticoneButton();
            this.gh = new Siticone.UI.WinForms.SiticoneButton();
            this.customisation = new Siticone.UI.WinForms.SiticoneButton();
            this.forward = new Siticone.UI.WinForms.SiticoneButton();
            this.reload = new Siticone.UI.WinForms.SiticoneButton();
            this.backward = new Siticone.UI.WinForms.SiticoneButton();
            this.pagecontrolarea.SuspendLayout();
            this.menu.SuspendLayout();
            this.tabarea.SuspendLayout();
            this.tabcontrolarea.SuspendLayout();
            this.misccontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablist
            // 
            this.tablist.BackColor = System.Drawing.Color.Transparent;
            this.tablist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablist.Location = new System.Drawing.Point(0, 0);
            this.tablist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablist.Name = "tablist";
            this.tablist.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablist.Size = new System.Drawing.Size(153, 450);
            this.tablist.TabIndex = 0;
            // 
            // pagearea
            // 
            this.pagearea.BackColor = System.Drawing.Color.Transparent;
            this.pagearea.BorderRadius = 10;
            this.pagearea.BorderThickness = 1;
            this.pagearea.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pagearea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pagearea.Location = new System.Drawing.Point(170, 62);
            this.pagearea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagearea.Name = "pagearea";
            this.pagearea.ShadowDecoration.Parent = this.pagearea;
            this.pagearea.Size = new System.Drawing.Size(629, 450);
            this.pagearea.TabIndex = 2;
            // 
            // pagecontrolarea
            // 
            this.pagecontrolarea.BackColor = System.Drawing.Color.Transparent;
            this.pagecontrolarea.BorderRadius = 10;
            this.pagecontrolarea.BorderThickness = 1;
            this.pagecontrolarea.Controls.Add(this.addressbar);
            this.pagecontrolarea.Controls.Add(this.forward);
            this.pagecontrolarea.Controls.Add(this.reload);
            this.pagecontrolarea.Controls.Add(this.backward);
            this.pagecontrolarea.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pagecontrolarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pagecontrolarea.Location = new System.Drawing.Point(170, 11);
            this.pagecontrolarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagecontrolarea.Name = "pagecontrolarea";
            this.pagecontrolarea.ShadowDecoration.Parent = this.pagecontrolarea;
            this.pagecontrolarea.Size = new System.Drawing.Size(629, 42);
            this.pagecontrolarea.TabIndex = 2;
            // 
            // addressbar
            // 
            this.addressbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addressbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressbar.DefaultText = "Search or type a URL...";
            this.addressbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressbar.DisabledState.Parent = this.addressbar;
            this.addressbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.addressbar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.addressbar.FocusedState.Parent = this.addressbar;
            this.addressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addressbar.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.addressbar.HoveredState.Parent = this.addressbar;
            this.addressbar.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.addressbar.Location = new System.Drawing.Point(120, 4);
            this.addressbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressbar.Name = "addressbar";
            this.addressbar.PasswordChar = '\0';
            this.addressbar.PlaceholderText = "Search or type a URL...";
            this.addressbar.SelectedText = "";
            this.addressbar.ShadowDecoration.Parent = this.addressbar;
            this.addressbar.Size = new System.Drawing.Size(507, 34);
            this.addressbar.TabIndex = 0;
            this.addressbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressbar_KeyDown);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BorderRadius = 10;
            this.menu.BorderThickness = 1;
            this.menu.Controls.Add(this.incognito);
            this.menu.Controls.Add(this.gh);
            this.menu.Controls.Add(this.customisation);
            this.menu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menu.Location = new System.Drawing.Point(11, 517);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.ShadowDecoration.Parent = this.menu;
            this.menu.Size = new System.Drawing.Size(150, 42);
            this.menu.TabIndex = 3;
            // 
            // tabarea
            // 
            this.tabarea.BackColor = System.Drawing.Color.Transparent;
            this.tabarea.BorderRadius = 10;
            this.tabarea.BorderThickness = 1;
            this.tabarea.Controls.Add(this.tablist);
            this.tabarea.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabarea.Location = new System.Drawing.Point(10, 62);
            this.tabarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabarea.Name = "tabarea";
            this.tabarea.ShadowDecoration.Parent = this.tabarea;
            this.tabarea.Size = new System.Drawing.Size(153, 450);
            this.tabarea.TabIndex = 4;
            // 
            // tabcontrolarea
            // 
            this.tabcontrolarea.BackColor = System.Drawing.Color.Transparent;
            this.tabcontrolarea.BorderRadius = 10;
            this.tabcontrolarea.BorderThickness = 1;
            this.tabcontrolarea.Controls.Add(this.minside);
            this.tabcontrolarea.Controls.Add(this.closeall);
            this.tabcontrolarea.Controls.Add(this.newtab);
            this.tabcontrolarea.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabcontrolarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabcontrolarea.Location = new System.Drawing.Point(10, 11);
            this.tabcontrolarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcontrolarea.Name = "tabcontrolarea";
            this.tabcontrolarea.ShadowDecoration.Parent = this.tabcontrolarea;
            this.tabcontrolarea.Size = new System.Drawing.Size(153, 42);
            this.tabcontrolarea.TabIndex = 4;
            // 
            // addr_e
            // 
            this.addr_e.BorderRadius = 10;
            this.addr_e.TargetControl = this.addressbar;
            // 
            // tablist_e
            // 
            this.tablist_e.BorderRadius = 10;
            this.tablist_e.TargetControl = this.tablist;
            // 
            // misccontrols
            // 
            this.misccontrols.BackColor = System.Drawing.Color.Transparent;
            this.misccontrols.BorderRadius = 10;
            this.misccontrols.BorderThickness = 1;
            this.misccontrols.Controls.Add(this.bookmarkdel);
            this.misccontrols.Controls.Add(this.zoomlbl);
            this.misccontrols.Controls.Add(this.bookmarkadd);
            this.misccontrols.Controls.Add(this.bookmarks);
            this.misccontrols.Controls.Add(this.zoomin);
            this.misccontrols.Controls.Add(this.zoomout);
            this.misccontrols.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.misccontrols.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.misccontrols.Location = new System.Drawing.Point(170, 517);
            this.misccontrols.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.misccontrols.Name = "misccontrols";
            this.misccontrols.ShadowDecoration.Parent = this.misccontrols;
            this.misccontrols.Size = new System.Drawing.Size(629, 42);
            this.misccontrols.TabIndex = 4;
            // 
            // zoomlbl
            // 
            this.zoomlbl.AutoSize = true;
            this.zoomlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zoomlbl.Location = new System.Drawing.Point(504, 11);
            this.zoomlbl.Name = "zoomlbl";
            this.zoomlbl.Size = new System.Drawing.Size(45, 20);
            this.zoomlbl.TabIndex = 12;
            this.zoomlbl.Text = "100%";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // bookmarkdel
            // 
            this.bookmarkdel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bookmarkdel.BorderRadius = 10;
            this.bookmarkdel.BorderThickness = 1;
            this.bookmarkdel.CheckedState.Parent = this.bookmarkdel;
            this.bookmarkdel.CustomImages.Parent = this.bookmarkdel;
            this.bookmarkdel.Enabled = false;
            this.bookmarkdel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bookmarkdel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookmarkdel.ForeColor = System.Drawing.Color.White;
            this.bookmarkdel.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bookmarkdel.HoveredState.Parent = this.bookmarkdel;
            this.bookmarkdel.Image = global::ZincBrowser.Properties.Resources.bookmark_minus;
            this.bookmarkdel.Location = new System.Drawing.Point(80, 2);
            this.bookmarkdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookmarkdel.Name = "bookmarkdel";
            this.bookmarkdel.ShadowDecoration.Parent = this.bookmarkdel;
            this.bookmarkdel.Size = new System.Drawing.Size(34, 37);
            this.bookmarkdel.TabIndex = 13;
            // 
            // bookmarkadd
            // 
            this.bookmarkadd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bookmarkadd.BorderRadius = 10;
            this.bookmarkadd.BorderThickness = 1;
            this.bookmarkadd.CheckedState.Parent = this.bookmarkadd;
            this.bookmarkadd.CustomImages.Parent = this.bookmarkadd;
            this.bookmarkadd.Enabled = false;
            this.bookmarkadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bookmarkadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookmarkadd.ForeColor = System.Drawing.Color.White;
            this.bookmarkadd.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bookmarkadd.HoveredState.Parent = this.bookmarkadd;
            this.bookmarkadd.Image = global::ZincBrowser.Properties.Resources.bookmark_plus;
            this.bookmarkadd.Location = new System.Drawing.Point(41, 2);
            this.bookmarkadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookmarkadd.Name = "bookmarkadd";
            this.bookmarkadd.ShadowDecoration.Parent = this.bookmarkadd;
            this.bookmarkadd.Size = new System.Drawing.Size(34, 37);
            this.bookmarkadd.TabIndex = 10;
            // 
            // bookmarks
            // 
            this.bookmarks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bookmarks.BorderRadius = 10;
            this.bookmarks.BorderThickness = 1;
            this.bookmarks.CheckedState.Parent = this.bookmarks;
            this.bookmarks.CustomImages.Parent = this.bookmarks;
            this.bookmarks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bookmarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookmarks.ForeColor = System.Drawing.Color.White;
            this.bookmarks.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.bookmarks.HoveredState.Parent = this.bookmarks;
            this.bookmarks.Image = global::ZincBrowser.Properties.Resources.bookmark;
            this.bookmarks.Location = new System.Drawing.Point(3, 2);
            this.bookmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookmarks.Name = "bookmarks";
            this.bookmarks.ShadowDecoration.Parent = this.bookmarks;
            this.bookmarks.Size = new System.Drawing.Size(34, 37);
            this.bookmarks.TabIndex = 9;
            this.bookmarks.Click += new System.EventHandler(this.bookmarks_Click);
            // 
            // zoomin
            // 
            this.zoomin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.zoomin.BorderRadius = 10;
            this.zoomin.BorderThickness = 1;
            this.zoomin.CheckedState.Parent = this.zoomin;
            this.zoomin.CustomImages.Parent = this.zoomin;
            this.zoomin.Enabled = false;
            this.zoomin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.zoomin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.zoomin.ForeColor = System.Drawing.Color.White;
            this.zoomin.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.zoomin.HoveredState.Parent = this.zoomin;
            this.zoomin.Image = global::ZincBrowser.Properties.Resources.zoom_in;
            this.zoomin.Location = new System.Drawing.Point(592, 2);
            this.zoomin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomin.Name = "zoomin";
            this.zoomin.ShadowDecoration.Parent = this.zoomin;
            this.zoomin.Size = new System.Drawing.Size(34, 37);
            this.zoomin.TabIndex = 8;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // zoomout
            // 
            this.zoomout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.zoomout.BorderRadius = 10;
            this.zoomout.BorderThickness = 1;
            this.zoomout.CheckedState.Parent = this.zoomout;
            this.zoomout.CustomImages.Parent = this.zoomout;
            this.zoomout.Enabled = false;
            this.zoomout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.zoomout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.zoomout.ForeColor = System.Drawing.Color.White;
            this.zoomout.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.zoomout.HoveredState.Parent = this.zoomout;
            this.zoomout.Image = global::ZincBrowser.Properties.Resources.zoom_out;
            this.zoomout.Location = new System.Drawing.Point(553, 2);
            this.zoomout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomout.Name = "zoomout";
            this.zoomout.ShadowDecoration.Parent = this.zoomout;
            this.zoomout.Size = new System.Drawing.Size(34, 37);
            this.zoomout.TabIndex = 7;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // minside
            // 
            this.minside.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.minside.BorderRadius = 10;
            this.minside.BorderThickness = 1;
            this.minside.CheckedState.Parent = this.minside;
            this.minside.CustomImages.Parent = this.minside;
            this.minside.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.minside.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minside.ForeColor = System.Drawing.Color.White;
            this.minside.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.minside.HoveredState.Parent = this.minside;
            this.minside.Image = global::ZincBrowser.Properties.Resources.sidebar_close;
            this.minside.Location = new System.Drawing.Point(80, 2);
            this.minside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minside.Name = "minside";
            this.minside.ShadowDecoration.Parent = this.minside;
            this.minside.Size = new System.Drawing.Size(34, 37);
            this.minside.TabIndex = 2;
            this.minside.Click += new System.EventHandler(this.minside_Click);
            // 
            // closeall
            // 
            this.closeall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.closeall.BorderRadius = 10;
            this.closeall.BorderThickness = 1;
            this.closeall.CheckedState.Parent = this.closeall;
            this.closeall.CustomImages.Parent = this.closeall;
            this.closeall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeall.ForeColor = System.Drawing.Color.White;
            this.closeall.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.closeall.HoveredState.Parent = this.closeall;
            this.closeall.Image = global::ZincBrowser.Properties.Resources.close_all;
            this.closeall.Location = new System.Drawing.Point(41, 2);
            this.closeall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeall.Name = "closeall";
            this.closeall.ShadowDecoration.Parent = this.closeall;
            this.closeall.Size = new System.Drawing.Size(34, 37);
            this.closeall.TabIndex = 1;
            this.closeall.Click += new System.EventHandler(this.closeall_Click);
            // 
            // newtab
            // 
            this.newtab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newtab.BorderRadius = 10;
            this.newtab.BorderThickness = 1;
            this.newtab.CheckedState.Parent = this.newtab;
            this.newtab.CustomImages.Parent = this.newtab;
            this.newtab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.newtab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newtab.ForeColor = System.Drawing.Color.White;
            this.newtab.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.newtab.HoveredState.Parent = this.newtab;
            this.newtab.Image = global::ZincBrowser.Properties.Resources._new;
            this.newtab.Location = new System.Drawing.Point(3, 2);
            this.newtab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newtab.Name = "newtab";
            this.newtab.ShadowDecoration.Parent = this.newtab;
            this.newtab.Size = new System.Drawing.Size(34, 37);
            this.newtab.TabIndex = 0;
            this.newtab.Click += new System.EventHandler(this.newtab_Click);
            // 
            // incognito
            // 
            this.incognito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.incognito.BorderRadius = 10;
            this.incognito.BorderThickness = 1;
            this.incognito.CheckedState.Parent = this.incognito;
            this.incognito.CustomImages.Parent = this.incognito;
            this.incognito.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.incognito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.incognito.ForeColor = System.Drawing.Color.White;
            this.incognito.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.incognito.HoveredState.Parent = this.incognito;
            this.incognito.Image = global::ZincBrowser.Properties.Resources.incognito;
            this.incognito.Location = new System.Drawing.Point(80, 2);
            this.incognito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incognito.Name = "incognito";
            this.incognito.ShadowDecoration.Parent = this.incognito;
            this.incognito.Size = new System.Drawing.Size(34, 37);
            this.incognito.TabIndex = 6;
            this.incognito.Click += new System.EventHandler(this.incognito_Click);
            // 
            // gh
            // 
            this.gh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gh.BorderRadius = 10;
            this.gh.BorderThickness = 1;
            this.gh.CheckedState.Parent = this.gh;
            this.gh.CustomImages.Parent = this.gh;
            this.gh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gh.ForeColor = System.Drawing.Color.White;
            this.gh.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.gh.HoveredState.Parent = this.gh;
            this.gh.Image = global::ZincBrowser.Properties.Resources.github;
            this.gh.Location = new System.Drawing.Point(41, 2);
            this.gh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gh.Name = "gh";
            this.gh.ShadowDecoration.Parent = this.gh;
            this.gh.Size = new System.Drawing.Size(34, 37);
            this.gh.TabIndex = 5;
            this.gh.Click += new System.EventHandler(this.gh_Click);
            // 
            // customisation
            // 
            this.customisation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.customisation.BorderRadius = 10;
            this.customisation.BorderThickness = 1;
            this.customisation.CheckedState.Parent = this.customisation;
            this.customisation.CustomImages.Parent = this.customisation;
            this.customisation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.customisation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customisation.ForeColor = System.Drawing.Color.White;
            this.customisation.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.customisation.HoveredState.Parent = this.customisation;
            this.customisation.Image = global::ZincBrowser.Properties.Resources.settings;
            this.customisation.Location = new System.Drawing.Point(3, 2);
            this.customisation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customisation.Name = "customisation";
            this.customisation.ShadowDecoration.Parent = this.customisation;
            this.customisation.Size = new System.Drawing.Size(34, 37);
            this.customisation.TabIndex = 4;
            this.customisation.Click += new System.EventHandler(this.customisation_Click);
            // 
            // forward
            // 
            this.forward.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.forward.BorderRadius = 10;
            this.forward.BorderThickness = 1;
            this.forward.CheckedState.Parent = this.forward;
            this.forward.CustomImages.Parent = this.forward;
            this.forward.Enabled = false;
            this.forward.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.forward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forward.ForeColor = System.Drawing.Color.White;
            this.forward.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.forward.HoveredState.Parent = this.forward;
            this.forward.Image = global::ZincBrowser.Properties.Resources.forward;
            this.forward.Location = new System.Drawing.Point(80, 2);
            this.forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forward.Name = "forward";
            this.forward.ShadowDecoration.Parent = this.forward;
            this.forward.Size = new System.Drawing.Size(34, 37);
            this.forward.TabIndex = 3;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // reload
            // 
            this.reload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.reload.BorderRadius = 10;
            this.reload.BorderThickness = 1;
            this.reload.CheckedState.Parent = this.reload;
            this.reload.CustomImages.Parent = this.reload;
            this.reload.Enabled = false;
            this.reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.reload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reload.ForeColor = System.Drawing.Color.White;
            this.reload.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.reload.HoveredState.Parent = this.reload;
            this.reload.Image = global::ZincBrowser.Properties.Resources.reload;
            this.reload.Location = new System.Drawing.Point(41, 2);
            this.reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reload.Name = "reload";
            this.reload.ShadowDecoration.Parent = this.reload;
            this.reload.Size = new System.Drawing.Size(34, 37);
            this.reload.TabIndex = 2;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // backward
            // 
            this.backward.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.backward.BorderRadius = 10;
            this.backward.BorderThickness = 1;
            this.backward.CheckedState.Parent = this.backward;
            this.backward.CustomImages.Parent = this.backward;
            this.backward.Enabled = false;
            this.backward.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.backward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backward.ForeColor = System.Drawing.Color.White;
            this.backward.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.backward.HoveredState.Parent = this.backward;
            this.backward.Image = global::ZincBrowser.Properties.Resources.back;
            this.backward.Location = new System.Drawing.Point(3, 2);
            this.backward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backward.Name = "backward";
            this.backward.ShadowDecoration.Parent = this.backward;
            this.backward.Size = new System.Drawing.Size(34, 37);
            this.backward.TabIndex = 2;
            this.backward.Click += new System.EventHandler(this.backward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this.misccontrols);
            this.Controls.Add(this.tabcontrolarea);
            this.Controls.Add(this.tabarea);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pagecontrolarea);
            this.Controls.Add(this.pagearea);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zinc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pagecontrolarea.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.tabarea.ResumeLayout(false);
            this.tabcontrolarea.ResumeLayout(false);
            this.misccontrols.ResumeLayout(false);
            this.misccontrols.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel pagearea;
        private Siticone.UI.WinForms.SiticonePanel pagecontrolarea;
        private System.Windows.Forms.FlowLayoutPanel tablist;
        private Siticone.UI.WinForms.SiticonePanel menu;
        private Siticone.UI.WinForms.SiticonePanel tabarea;
        private Siticone.UI.WinForms.SiticonePanel tabcontrolarea;
        private Siticone.UI.WinForms.SiticoneButton newtab;
        private Siticone.UI.WinForms.SiticoneButton closeall;
        private Siticone.UI.WinForms.SiticoneButton reload;
        public Siticone.UI.WinForms.SiticoneMaterialTextBox addressbar;
        private Siticone.UI.WinForms.SiticoneElipse addr_e;
        private Siticone.UI.WinForms.SiticoneElipse tablist_e;
        public Siticone.UI.WinForms.SiticoneButton forward;
        public Siticone.UI.WinForms.SiticoneButton backward;
        public Siticone.UI.WinForms.SiticoneButton customisation;
        public Siticone.UI.WinForms.SiticoneButton gh;
        public Siticone.UI.WinForms.SiticoneButton incognito;
        private Siticone.UI.WinForms.SiticoneButton minside;
        private Siticone.UI.WinForms.SiticonePanel misccontrols;
        public Siticone.UI.WinForms.SiticoneButton zoomout;
        public Siticone.UI.WinForms.SiticoneButton zoomin;
        private System.Windows.Forms.Timer update;
        public Siticone.UI.WinForms.SiticoneButton bookmarks;
        public Siticone.UI.WinForms.SiticoneButton bookmarkadd;
        private System.Windows.Forms.Label zoomlbl;
        public Siticone.UI.WinForms.SiticoneButton bookmarkdel;
    }
}