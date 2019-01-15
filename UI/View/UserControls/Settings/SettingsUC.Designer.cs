namespace UI.View.UserControls.Settings
{
    partial class SettingsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUC));
            this.lblStepness = new System.Windows.Forms.Label();
            this.lblMountainousness = new System.Windows.Forms.Label();
            this.lblEnvElements = new System.Windows.Forms.Label();
            this.lblLandscapeSize = new System.Windows.Forms.Label();
            this.trBarStepness = new System.Windows.Forms.TrackBar();
            this.trBarMountainousness = new System.Windows.Forms.TrackBar();
            this.trBarEnvironmentElements = new System.Windows.Forms.TrackBar();
            this.cmbBoxLandscapeSize = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trBarStepness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarMountainousness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarEnvironmentElements)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStepness
            // 
            this.lblStepness.AutoSize = true;
            this.lblStepness.BackColor = System.Drawing.Color.Transparent;
            this.lblStepness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepness.ForeColor = System.Drawing.Color.White;
            this.lblStepness.Location = new System.Drawing.Point(50, 310);
            this.lblStepness.Name = "lblStepness";
            this.lblStepness.Size = new System.Drawing.Size(137, 31);
            this.lblStepness.TabIndex = 1;
            this.lblStepness.Text = "Stromość";
            // 
            // lblMountainousness
            // 
            this.lblMountainousness.AutoSize = true;
            this.lblMountainousness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMountainousness.ForeColor = System.Drawing.Color.White;
            this.lblMountainousness.Location = new System.Drawing.Point(50, 170);
            this.lblMountainousness.Name = "lblMountainousness";
            this.lblMountainousness.Size = new System.Drawing.Size(162, 31);
            this.lblMountainousness.TabIndex = 2;
            this.lblMountainousness.Text = "Górzystość";
            // 
            // lblEnvElements
            // 
            this.lblEnvElements.AutoSize = true;
            this.lblEnvElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEnvElements.ForeColor = System.Drawing.Color.White;
            this.lblEnvElements.Location = new System.Drawing.Point(50, 30);
            this.lblEnvElements.Name = "lblEnvElements";
            this.lblEnvElements.Size = new System.Drawing.Size(358, 31);
            this.lblEnvElements.TabIndex = 3;
            this.lblEnvElements.Text = "Ilość elementów otoczenia";
            // 
            // lblLandscapeSize
            // 
            this.lblLandscapeSize.AutoSize = true;
            this.lblLandscapeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLandscapeSize.ForeColor = System.Drawing.Color.White;
            this.lblLandscapeSize.Location = new System.Drawing.Point(50, 450);
            this.lblLandscapeSize.Name = "lblLandscapeSize";
            this.lblLandscapeSize.Size = new System.Drawing.Size(222, 31);
            this.lblLandscapeSize.TabIndex = 4;
            this.lblLandscapeSize.Text = "Wielkość terenu";
            // 
            // trBarStepness
            // 
            this.trBarStepness.Location = new System.Drawing.Point(140, 360);
            this.trBarStepness.Name = "trBarStepness";
            this.trBarStepness.Size = new System.Drawing.Size(321, 45);
            this.trBarStepness.TabIndex = 6;
            // 
            // trBarMountainousness
            // 
            this.trBarMountainousness.Location = new System.Drawing.Point(140, 220);
            this.trBarMountainousness.Name = "trBarMountainousness";
            this.trBarMountainousness.Size = new System.Drawing.Size(321, 45);
            this.trBarMountainousness.TabIndex = 7;
            // 
            // trBarEnvironmentElements
            // 
            this.trBarEnvironmentElements.Location = new System.Drawing.Point(140, 80);
            this.trBarEnvironmentElements.Maximum = 2;
            this.trBarEnvironmentElements.Name = "trBarEnvironmentElements";
            this.trBarEnvironmentElements.Size = new System.Drawing.Size(321, 45);
            this.trBarEnvironmentElements.TabIndex = 8;
            // 
            // cmbBoxLandscapeSize
            // 
            this.cmbBoxLandscapeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLandscapeSize.FormattingEnabled = true;
            this.cmbBoxLandscapeSize.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000"});
            this.cmbBoxLandscapeSize.Location = new System.Drawing.Point(140, 500);
            this.cmbBoxLandscapeSize.Name = "cmbBoxLandscapeSize";
            this.cmbBoxLandscapeSize.Size = new System.Drawing.Size(321, 21);
            this.cmbBoxLandscapeSize.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(50, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Silver;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(400, 580);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 50);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generuj teren";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Silver;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(225, 580);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 50);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Zapisz";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbBoxLandscapeSize);
            this.Controls.Add(this.trBarEnvironmentElements);
            this.Controls.Add(this.trBarMountainousness);
            this.Controls.Add(this.trBarStepness);
            this.Controls.Add(this.lblLandscapeSize);
            this.Controls.Add(this.lblEnvElements);
            this.Controls.Add(this.lblMountainousness);
            this.Controls.Add(this.lblStepness);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(600, 700);
            ((System.ComponentModel.ISupportInitialize)(this.trBarStepness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarMountainousness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarEnvironmentElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStepness;
        private System.Windows.Forms.Label lblMountainousness;
        private System.Windows.Forms.Label lblEnvElements;
        private System.Windows.Forms.Label lblLandscapeSize;
        private System.Windows.Forms.TrackBar trBarStepness;
        private System.Windows.Forms.TrackBar trBarMountainousness;
        private System.Windows.Forms.TrackBar trBarEnvironmentElements;
        private System.Windows.Forms.ComboBox cmbBoxLandscapeSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnApply;
    }
}
