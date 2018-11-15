namespace LandscapeGeneratorMenu.View.Settings
{
    partial class SettingsForm
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
            this.chkBoxDrawTextures = new System.Windows.Forms.CheckBox();
            this.grpMainSettings = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMainSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxDrawTextures
            // 
            this.chkBoxDrawTextures.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBoxDrawTextures.Location = new System.Drawing.Point(3, 16);
            this.chkBoxDrawTextures.Name = "chkBoxDrawTextures";
            this.chkBoxDrawTextures.Size = new System.Drawing.Size(478, 24);
            this.chkBoxDrawTextures.TabIndex = 1;
            this.chkBoxDrawTextures.Text = "Draw textures";
            this.chkBoxDrawTextures.UseVisualStyleBackColor = true;
            // 
            // grpMainSettings
            // 
            this.grpMainSettings.Controls.Add(this.chkBoxDrawTextures);
            this.grpMainSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMainSettings.Location = new System.Drawing.Point(0, 0);
            this.grpMainSettings.Name = "grpMainSettings";
            this.grpMainSettings.Size = new System.Drawing.Size(484, 100);
            this.grpMainSettings.TabIndex = 2;
            this.grpMainSettings.TabStop = false;
            this.grpMainSettings.Text = "Main settings";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(484, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpMainSettings);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.grpMainSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBoxDrawTextures;
        private System.Windows.Forms.GroupBox grpMainSettings;
        private System.Windows.Forms.Button btnClose;
    }
}