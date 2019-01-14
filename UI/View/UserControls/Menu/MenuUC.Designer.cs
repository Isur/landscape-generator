namespace UI.View.UserControls.MenuOptions
{
    partial class MenuUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUC));
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadLandscape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(45, 25);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(510, 55);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "Landscape Generator";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSettings.Location = new System.Drawing.Point(75, 100);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(450, 50);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Set terrain settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInstructions.Location = new System.Drawing.Point(75, 300);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(450, 50);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAbout.Location = new System.Drawing.Point(75, 400);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(450, 50);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(74, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(450, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadLandscape
            // 
            this.btnLoadLandscape.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLoadLandscape.Location = new System.Drawing.Point(75, 200);
            this.btnLoadLandscape.Name = "btnLoadLandscape";
            this.btnLoadLandscape.Size = new System.Drawing.Size(450, 50);
            this.btnLoadLandscape.TabIndex = 2;
            this.btnLoadLandscape.Text = "Load Landscape";
            this.btnLoadLandscape.UseVisualStyleBackColor = false;
            this.btnLoadLandscape.Click += new System.EventHandler(this.btnLoadLandscape_Click);
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnLoadLandscape);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblProjectTitle);
            this.Name = "MenuUC";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadLandscape;
    }
}
