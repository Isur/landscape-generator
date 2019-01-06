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
            this.chkBxTemplate = new System.Windows.Forms.CheckBox();
            this.grpMainSettings = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.trckBrTemplate = new System.Windows.Forms.TrackBar();
            this.cmbBxTemplate = new System.Windows.Forms.ComboBox();
            this.grpMainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBxTemplate
            // 
            this.chkBxTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBxTemplate.Location = new System.Drawing.Point(3, 16);
            this.chkBxTemplate.Name = "chkBxTemplate";
            this.chkBxTemplate.Size = new System.Drawing.Size(478, 24);
            this.chkBxTemplate.TabIndex = 1;
            this.chkBxTemplate.Text = "CheckBox";
            this.chkBxTemplate.UseVisualStyleBackColor = true;
            // 
            // grpMainSettings
            // 
            this.grpMainSettings.Controls.Add(this.cmbBxTemplate);
            this.grpMainSettings.Controls.Add(this.trckBrTemplate);
            this.grpMainSettings.Controls.Add(this.chkBxTemplate);
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
            // trckBrTemplate
            // 
            this.trckBrTemplate.Location = new System.Drawing.Point(3, 46);
            this.trckBrTemplate.Maximum = 5;
            this.trckBrTemplate.Name = "trckBrTemplate";
            this.trckBrTemplate.Size = new System.Drawing.Size(104, 45);
            this.trckBrTemplate.TabIndex = 3;
            // 
            // cmbBxTemplate
            // 
            this.cmbBxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTemplate.FormattingEnabled = true;
            this.cmbBxTemplate.Items.AddRange(new object[] {
            "optionA",
            "optionB",
            "optionC",
            "optionD",
            "optionE"});
            this.cmbBxTemplate.Location = new System.Drawing.Point(174, 46);
            this.cmbBxTemplate.Name = "cmbBxTemplate";
            this.cmbBxTemplate.Size = new System.Drawing.Size(121, 21);
            this.cmbBxTemplate.TabIndex = 4;
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
            this.grpMainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBxTemplate;
        private System.Windows.Forms.GroupBox grpMainSettings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TrackBar trckBrTemplate;
        private System.Windows.Forms.ComboBox cmbBxTemplate;
    }
}