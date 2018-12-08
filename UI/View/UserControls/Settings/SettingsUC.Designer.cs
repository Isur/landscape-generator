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
            this.lblWaterLevel = new System.Windows.Forms.Label();
            this.lblStepness = new System.Windows.Forms.Label();
            this.lblMountainousness = new System.Windows.Forms.Label();
            this.lblEnvElements = new System.Windows.Forms.Label();
            this.lblLandscapeSize = new System.Windows.Forms.Label();
            this.trBarWaterLevel = new System.Windows.Forms.TrackBar();
            this.trBarStepness = new System.Windows.Forms.TrackBar();
            this.trBarMountainousness = new System.Windows.Forms.TrackBar();
            this.trBarEnvironmentElements = new System.Windows.Forms.TrackBar();
            this.cmbBoxLandscapeSize = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarStepness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarMountainousness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarEnvironmentElements)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWaterLevel
            // 
            this.lblWaterLevel.AutoSize = true;
            this.lblWaterLevel.Location = new System.Drawing.Point(50, 50);
            this.lblWaterLevel.Name = "lblWaterLevel";
            this.lblWaterLevel.Size = new System.Drawing.Size(61, 13);
            this.lblWaterLevel.TabIndex = 0;
            this.lblWaterLevel.Text = "Water level";
            // 
            // lblStepness
            // 
            this.lblStepness.AutoSize = true;
            this.lblStepness.Location = new System.Drawing.Point(50, 100);
            this.lblStepness.Name = "lblStepness";
            this.lblStepness.Size = new System.Drawing.Size(51, 13);
            this.lblStepness.TabIndex = 1;
            this.lblStepness.Text = "Stepness";
            // 
            // lblMountainousness
            // 
            this.lblMountainousness.AutoSize = true;
            this.lblMountainousness.Location = new System.Drawing.Point(50, 150);
            this.lblMountainousness.Name = "lblMountainousness";
            this.lblMountainousness.Size = new System.Drawing.Size(90, 13);
            this.lblMountainousness.TabIndex = 2;
            this.lblMountainousness.Text = "Mountainousness";
            // 
            // lblEnvElements
            // 
            this.lblEnvElements.AutoSize = true;
            this.lblEnvElements.Location = new System.Drawing.Point(50, 200);
            this.lblEnvElements.Name = "lblEnvElements";
            this.lblEnvElements.Size = new System.Drawing.Size(111, 13);
            this.lblEnvElements.TabIndex = 3;
            this.lblEnvElements.Text = "Environment elements";
            // 
            // lblLandscapeSize
            // 
            this.lblLandscapeSize.AutoSize = true;
            this.lblLandscapeSize.Location = new System.Drawing.Point(50, 250);
            this.lblLandscapeSize.Name = "lblLandscapeSize";
            this.lblLandscapeSize.Size = new System.Drawing.Size(81, 13);
            this.lblLandscapeSize.TabIndex = 4;
            this.lblLandscapeSize.Text = "Landscape size";
            // 
            // trBarWaterLevel
            // 
            this.trBarWaterLevel.Location = new System.Drawing.Point(200, 50);
            this.trBarWaterLevel.Name = "trBarWaterLevel";
            this.trBarWaterLevel.Size = new System.Drawing.Size(321, 45);
            this.trBarWaterLevel.TabIndex = 5;
            // 
            // trBarStepness
            // 
            this.trBarStepness.Location = new System.Drawing.Point(200, 100);
            this.trBarStepness.Name = "trBarStepness";
            this.trBarStepness.Size = new System.Drawing.Size(321, 45);
            this.trBarStepness.TabIndex = 6;
            // 
            // trBarMountainousness
            // 
            this.trBarMountainousness.Location = new System.Drawing.Point(200, 150);
            this.trBarMountainousness.Name = "trBarMountainousness";
            this.trBarMountainousness.Size = new System.Drawing.Size(321, 45);
            this.trBarMountainousness.TabIndex = 7;
            // 
            // trBarEnvironmentElements
            // 
            this.trBarEnvironmentElements.Location = new System.Drawing.Point(200, 200);
            this.trBarEnvironmentElements.Name = "trBarEnvironmentElements";
            this.trBarEnvironmentElements.Size = new System.Drawing.Size(321, 45);
            this.trBarEnvironmentElements.TabIndex = 8;
            // 
            // cmbBoxLandscapeSize
            // 
            this.cmbBoxLandscapeSize.FormattingEnabled = true;
            this.cmbBoxLandscapeSize.Location = new System.Drawing.Point(200, 250);
            this.cmbBoxLandscapeSize.Name = "cmbBoxLandscapeSize";
            this.cmbBoxLandscapeSize.Size = new System.Drawing.Size(321, 21);
            this.cmbBoxLandscapeSize.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(53, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndGenerate
            // 
            this.btnSaveAndGenerate.Location = new System.Drawing.Point(383, 607);
            this.btnSaveAndGenerate.Name = "btnSaveAndGenerate";
            this.btnSaveAndGenerate.Size = new System.Drawing.Size(138, 23);
            this.btnSaveAndGenerate.TabIndex = 11;
            this.btnSaveAndGenerate.Text = "Save and Generate";
            this.btnSaveAndGenerate.UseVisualStyleBackColor = true;
            this.btnSaveAndGenerate.Click += new System.EventHandler(this.btnSaveAndGenerate_Click);
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveAndGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbBoxLandscapeSize);
            this.Controls.Add(this.trBarEnvironmentElements);
            this.Controls.Add(this.trBarMountainousness);
            this.Controls.Add(this.trBarStepness);
            this.Controls.Add(this.trBarWaterLevel);
            this.Controls.Add(this.lblLandscapeSize);
            this.Controls.Add(this.lblEnvElements);
            this.Controls.Add(this.lblMountainousness);
            this.Controls.Add(this.lblStepness);
            this.Controls.Add(this.lblWaterLevel);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(600, 700);
            ((System.ComponentModel.ISupportInitialize)(this.trBarWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarStepness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarMountainousness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarEnvironmentElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaterLevel;
        private System.Windows.Forms.Label lblStepness;
        private System.Windows.Forms.Label lblMountainousness;
        private System.Windows.Forms.Label lblEnvElements;
        private System.Windows.Forms.Label lblLandscapeSize;
        private System.Windows.Forms.TrackBar trBarWaterLevel;
        private System.Windows.Forms.TrackBar trBarStepness;
        private System.Windows.Forms.TrackBar trBarMountainousness;
        private System.Windows.Forms.TrackBar trBarEnvironmentElements;
        private System.Windows.Forms.ComboBox cmbBoxLandscapeSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndGenerate;
    }
}
