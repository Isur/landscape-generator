namespace UI.View.UserControls.About
{
    partial class AboutUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUC));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAboutHeader = new System.Windows.Forms.Label();
            this.lblAboutPerlinText = new System.Windows.Forms.Label();
            this.lblAboutEngineText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(225, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAboutHeader
            // 
            this.lblAboutHeader.AutoSize = true;
            this.lblAboutHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutHeader.ForeColor = System.Drawing.Color.White;
            this.lblAboutHeader.Location = new System.Drawing.Point(190, 25);
            this.lblAboutHeader.Name = "lblAboutHeader";
            this.lblAboutHeader.Size = new System.Drawing.Size(221, 39);
            this.lblAboutHeader.TabIndex = 13;
            this.lblAboutHeader.Text = "O programie";
            // 
            // lblAboutPerlinText
            // 
            this.lblAboutPerlinText.BackColor = System.Drawing.Color.DimGray;
            this.lblAboutPerlinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutPerlinText.ForeColor = System.Drawing.Color.White;
            this.lblAboutPerlinText.Location = new System.Drawing.Point(75, 100);
            this.lblAboutPerlinText.Name = "lblAboutPerlinText";
            this.lblAboutPerlinText.Size = new System.Drawing.Size(450, 170);
            this.lblAboutPerlinText.TabIndex = 14;
            this.lblAboutPerlinText.Text = resources.GetString("lblAboutPerlinText.Text");
            // 
            // lblAboutEngineText
            // 
            this.lblAboutEngineText.BackColor = System.Drawing.Color.DimGray;
            this.lblAboutEngineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutEngineText.ForeColor = System.Drawing.Color.White;
            this.lblAboutEngineText.Location = new System.Drawing.Point(75, 313);
            this.lblAboutEngineText.Name = "lblAboutEngineText";
            this.lblAboutEngineText.Size = new System.Drawing.Size(450, 125);
            this.lblAboutEngineText.TabIndex = 15;
            this.lblAboutEngineText.Text = resources.GetString("lblAboutEngineText.Text");
            // 
            // AboutUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblAboutEngineText);
            this.Controls.Add(this.lblAboutPerlinText);
            this.Controls.Add(this.lblAboutHeader);
            this.Controls.Add(this.btnCancel);
            this.Name = "AboutUC";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAboutHeader;
        private System.Windows.Forms.Label lblAboutPerlinText;
        private System.Windows.Forms.Label lblAboutEngineText;
    }
}
