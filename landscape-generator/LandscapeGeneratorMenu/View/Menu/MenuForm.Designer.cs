namespace LandscapeGeneratorMenu.View
{
    partial class MenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerateTerrain = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGenerationSettings = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(2, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(584, 115);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Landscape Generator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateTerrain
            // 
            this.btnGenerateTerrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateTerrain.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTerrain.Location = new System.Drawing.Point(3, 16);
            this.btnGenerateTerrain.Name = "btnGenerateTerrain";
            this.btnGenerateTerrain.Size = new System.Drawing.Size(578, 75);
            this.btnGenerateTerrain.TabIndex = 1;
            this.btnGenerateTerrain.Text = "Generate Terrain";
            this.btnGenerateTerrain.UseVisualStyleBackColor = true;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.btnExit);
            this.groupBoxMain.Controls.Add(this.btnDonate);
            this.groupBoxMain.Controls.Add(this.btnAbout);
            this.groupBoxMain.Controls.Add(this.btnGenerationSettings);
            this.groupBoxMain.Controls.Add(this.btnGenerateTerrain);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMain.Location = new System.Drawing.Point(0, 143);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(584, 418);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Pick an option";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(578, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonate.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.Location = new System.Drawing.Point(3, 241);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(578, 75);
            this.btnDonate.TabIndex = 4;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(3, 166);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(578, 75);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnGenerationSettings
            // 
            this.btnGenerationSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerationSettings.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerationSettings.Location = new System.Drawing.Point(3, 91);
            this.btnGenerationSettings.Name = "btnGenerationSettings";
            this.btnGenerationSettings.Size = new System.Drawing.Size(578, 75);
            this.btnGenerationSettings.TabIndex = 2;
            this.btnGenerationSettings.Text = "Generation Settings";
            this.btnGenerationSettings.UseVisualStyleBackColor = true;
            this.btnGenerationSettings.Click += new System.EventHandler(this.btnGenerationSettings_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "MenuForm";
            this.Text = "MainMenu";
            this.groupBoxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerateTerrain;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGenerationSettings;
    }
}