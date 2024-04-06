namespace ZincBrowser
{
    partial class SettingsWindow
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
            this.pagearea = new System.Windows.Forms.Panel();
            this.customisation = new Siticone.UI.WinForms.SiticoneButton();
            this.history = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // pagearea
            // 
            this.pagearea.Location = new System.Drawing.Point(235, 12);
            this.pagearea.Name = "pagearea";
            this.pagearea.Size = new System.Drawing.Size(827, 789);
            this.pagearea.TabIndex = 7;
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
            this.customisation.Image = global::ZincBrowser.Properties.Resources.customization;
            this.customisation.Location = new System.Drawing.Point(12, 11);
            this.customisation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customisation.Name = "customisation";
            this.customisation.ShadowDecoration.Parent = this.customisation;
            this.customisation.Size = new System.Drawing.Size(217, 40);
            this.customisation.TabIndex = 5;
            this.customisation.Text = "Personalisation";
            this.customisation.Click += new System.EventHandler(this.customisation_Click);
            // 
            // history
            // 
            this.history.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.history.BorderRadius = 10;
            this.history.BorderThickness = 1;
            this.history.CheckedState.Parent = this.history;
            this.history.CustomImages.Parent = this.history;
            this.history.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.history.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.history.HoveredState.Parent = this.history;
            this.history.Image = global::ZincBrowser.Properties.Resources.history;
            this.history.Location = new System.Drawing.Point(12, 55);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.ShadowDecoration.Parent = this.history;
            this.history.Size = new System.Drawing.Size(217, 40);
            this.history.TabIndex = 8;
            this.history.Text = "History";
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1074, 813);
            this.Controls.Add(this.history);
            this.Controls.Add(this.pagearea);
            this.Controls.Add(this.customisation);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_FormClosing);
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Siticone.UI.WinForms.SiticoneButton customisation;
        private System.Windows.Forms.Panel pagearea;
        public Siticone.UI.WinForms.SiticoneButton history;
    }
}