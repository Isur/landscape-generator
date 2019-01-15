namespace UI.View.UserControls.Instructions
{
    partial class InstructionsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsUC));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInstructionsHeader = new System.Windows.Forms.Label();
            this.lblInstructionsText = new System.Windows.Forms.Label();
            this.lblInstructionsText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(225, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Wróć";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInstructionsHeader
            // 
            this.lblInstructionsHeader.AutoSize = true;
            this.lblInstructionsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsHeader.ForeColor = System.Drawing.Color.White;
            this.lblInstructionsHeader.Location = new System.Drawing.Point(210, 25);
            this.lblInstructionsHeader.Name = "lblInstructionsHeader";
            this.lblInstructionsHeader.Size = new System.Drawing.Size(177, 39);
            this.lblInstructionsHeader.TabIndex = 14;
            this.lblInstructionsHeader.Text = "Instrukcja";
            // 
            // lblInstructionsText
            // 
            this.lblInstructionsText.BackColor = System.Drawing.Color.DimGray;
            this.lblInstructionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsText.ForeColor = System.Drawing.Color.White;
            this.lblInstructionsText.Location = new System.Drawing.Point(75, 100);
            this.lblInstructionsText.Name = "lblInstructionsText";
            this.lblInstructionsText.Size = new System.Drawing.Size(450, 280);
            this.lblInstructionsText.TabIndex = 15;
            this.lblInstructionsText.Text = resources.GetString("lblInstructionsText.Text");
            // 
            // lblInstructionsText2
            // 
            this.lblInstructionsText2.BackColor = System.Drawing.Color.DimGray;
            this.lblInstructionsText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsText2.ForeColor = System.Drawing.Color.White;
            this.lblInstructionsText2.Location = new System.Drawing.Point(75, 425);
            this.lblInstructionsText2.Name = "lblInstructionsText2";
            this.lblInstructionsText2.Size = new System.Drawing.Size(450, 100);
            this.lblInstructionsText2.TabIndex = 16;
            this.lblInstructionsText2.Text = resources.GetString("lblInstructionsText2.Text");
            // 
            // InstructionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblInstructionsText2);
            this.Controls.Add(this.lblInstructionsText);
            this.Controls.Add(this.lblInstructionsHeader);
            this.Controls.Add(this.btnCancel);
            this.Name = "InstructionsUC";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInstructionsHeader;
        private System.Windows.Forms.Label lblInstructionsText;
        private System.Windows.Forms.Label lblInstructionsText2;
    }
}
