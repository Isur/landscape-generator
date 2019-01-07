﻿namespace UI.View.UserControls.MenuOptions
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
            this.lblProjectTitle.Location = new System.Drawing.Point(54, 43);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(110, 13);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "Landscape Generator";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(168, 102);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(236, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Set terrain settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(251, 203);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(75, 23);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(251, 232);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadLandscape
            // 
            this.btnLoadLandscape.Location = new System.Drawing.Point(57, 145);
            this.btnLoadLandscape.Name = "btnLoadLandscape";
            this.btnLoadLandscape.Size = new System.Drawing.Size(462, 52);
            this.btnLoadLandscape.TabIndex = 2;
            this.btnLoadLandscape.Text = "Load Landscape";
            this.btnLoadLandscape.UseVisualStyleBackColor = true;
            this.btnLoadLandscape.Click += new System.EventHandler(this.btnLoadLandscape_Click);
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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