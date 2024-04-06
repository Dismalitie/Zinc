namespace ZincBrowser.UCs
{
    partial class SearchHandle
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.eli = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.open = new Siticone.UI.WinForms.SiticoneButton();
            this.ico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ico)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.title.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(49, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(58, 20);
            this.title.TabIndex = 1;
            this.title.Text = "Google";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.url.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.ForeColor = System.Drawing.Color.DimGray;
            this.url.Location = new System.Drawing.Point(113, 16);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(178, 20);
            this.url.TabIndex = 2;
            this.url.Text = "https://www.google.com/";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.time.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(690, 16);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(72, 20);
            this.time.TabIndex = 3;
            this.time.Text = "Yesterday";
            // 
            // eli
            // 
            this.eli.BorderRadius = 15;
            this.eli.TargetControl = this;
            // 
            // open
            // 
            this.open.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.open.BorderRadius = 10;
            this.open.BorderThickness = 1;
            this.open.CheckedState.Parent = this.open;
            this.open.CustomImages.Parent = this.open;
            this.open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.open.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.open.ForeColor = System.Drawing.Color.White;
            this.open.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.open.HoveredState.Parent = this.open;
            this.open.Image = global::ZincBrowser.Properties.Resources.copy;
            this.open.Location = new System.Drawing.Point(768, 5);
            this.open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open.Name = "open";
            this.open.ShadowDecoration.Parent = this.open;
            this.open.Size = new System.Drawing.Size(40, 40);
            this.open.TabIndex = 4;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // ico
            // 
            this.ico.BackColor = System.Drawing.Color.Transparent;
            this.ico.BackgroundImage = global::ZincBrowser.Properties.Resources.history;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ico.Location = new System.Drawing.Point(3, 5);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(40, 40);
            this.ico.TabIndex = 0;
            this.ico.TabStop = false;
            // 
            // SearchHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.open);
            this.Controls.Add(this.time);
            this.Controls.Add(this.url);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ico);
            this.Name = "SearchHandle";
            this.Size = new System.Drawing.Size(811, 50);
            this.Load += new System.EventHandler(this.SearchHandle_Load);
            this.Click += new System.EventHandler(this.SearchHandle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ico;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Label time;
        private Siticone.UI.WinForms.SiticoneElipse eli;
        private Siticone.UI.WinForms.SiticoneButton open;
    }
}
