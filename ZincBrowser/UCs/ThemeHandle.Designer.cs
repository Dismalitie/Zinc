namespace ZincBrowser.UCs
{
    partial class ThemeHandle
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
            this.main = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.main.BorderRadius = 10;
            this.main.BorderThickness = 1;
            this.main.CheckedState.Parent = this.main;
            this.main.CustomImages.Parent = this.main;
            this.main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main.ForeColor = System.Drawing.Color.White;
            this.main.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.main.HoveredState.Parent = this.main;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Name = "main";
            this.main.ShadowDecoration.Parent = this.main;
            this.main.Size = new System.Drawing.Size(177, 41);
            this.main.TabIndex = 25;
            this.main.Text = "Theme";
            this.main.UseTransparentBackground = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // ThemeHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.main);
            this.Name = "ThemeHandle";
            this.Size = new System.Drawing.Size(177, 41);
            this.Load += new System.EventHandler(this.ThemeHandle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton main;
    }
}
