namespace ZincBrowser.Menus
{
    partial class Menu_History
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clr = new Siticone.UI.WinForms.SiticoneButton();
            this.searches = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // clr
            // 
            this.clr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.clr.BorderRadius = 10;
            this.clr.BorderThickness = 1;
            this.clr.CheckedState.Parent = this.clr;
            this.clr.CustomImages.Parent = this.clr;
            this.clr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clr.ForeColor = System.Drawing.Color.White;
            this.clr.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.clr.HoveredState.Parent = this.clr;
            this.clr.Location = new System.Drawing.Point(3, 747);
            this.clr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clr.Name = "clr";
            this.clr.ShadowDecoration.Parent = this.clr;
            this.clr.Size = new System.Drawing.Size(821, 40);
            this.clr.TabIndex = 27;
            this.clr.Text = "Clear history";
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // searches
            // 
            this.searches.Location = new System.Drawing.Point(0, 0);
            this.searches.Name = "searches";
            this.searches.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.searches.Size = new System.Drawing.Size(827, 742);
            this.searches.TabIndex = 29;
            // 
            // Menu_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searches);
            this.Controls.Add(this.clr);
            this.Name = "Menu_History";
            this.Size = new System.Drawing.Size(827, 789);
            this.Load += new System.EventHandler(this.Menu_History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton clr;
        private System.Windows.Forms.FlowLayoutPanel searches;
    }
}
