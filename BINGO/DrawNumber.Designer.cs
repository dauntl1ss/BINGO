namespace BINGO
{
    partial class DrawNumber
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPressToContinue = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.panelLetter = new System.Windows.Forms.Panel();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.panelLetter.SuspendLayout();
            this.panelNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumber.Font = new System.Drawing.Font("Impact", 220F);
            this.lblNumber.ForeColor = System.Drawing.Color.Violet;
            this.lblNumber.Location = new System.Drawing.Point(3, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(631, 629);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumber.Click += new System.EventHandler(this.LblNumber_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(508, 714);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(904, 38);
            this.progressBar.TabIndex = 2;
            // 
            // lblPressToContinue
            // 
            this.lblPressToContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPressToContinue.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblPressToContinue.ForeColor = System.Drawing.Color.White;
            this.lblPressToContinue.Location = new System.Drawing.Point(381, 656);
            this.lblPressToContinue.Name = "lblPressToContinue";
            this.lblPressToContinue.Size = new System.Drawing.Size(904, 96);
            this.lblPressToContinue.TabIndex = 2;
            this.lblPressToContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPressToContinue.Click += new System.EventHandler(this.LblPressToContinue_Click);
            // 
            // lblLetter
            // 
            this.lblLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLetter.Font = new System.Drawing.Font("Impact", 390F);
            this.lblLetter.ForeColor = System.Drawing.Color.White;
            this.lblLetter.Location = new System.Drawing.Point(3, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(488, 696);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLetter.Click += new System.EventHandler(this.LblLetter_Click);
            // 
            // panelLetter
            // 
            this.panelLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLetter.Controls.Add(this.lblLetter);
            this.panelLetter.Location = new System.Drawing.Point(282, -47);
            this.panelLetter.Name = "panelLetter";
            this.panelLetter.Size = new System.Drawing.Size(494, 696);
            this.panelLetter.TabIndex = 0;
            // 
            // panelNumber
            // 
            this.panelNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNumber.Controls.Add(this.lblNumber);
            this.panelNumber.Location = new System.Drawing.Point(782, 63);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(637, 617);
            this.panelNumber.TabIndex = 1;
            // 
            // DrawNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1918, 750);
            this.Controls.Add(this.lblPressToContinue);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelNumber);
            this.Controls.Add(this.panelLetter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1918, 750);
            this.MinimumSize = new System.Drawing.Size(1918, 750);
            this.Name = "DrawNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawNumber";
            this.Load += new System.EventHandler(this.DrawNumber_Load);
            this.Click += new System.EventHandler(this.DrawNumber_Click);
            this.panelLetter.ResumeLayout(false);
            this.panelNumber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPressToContinue;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Panel panelLetter;
        private System.Windows.Forms.Panel panelNumber;
    }
}