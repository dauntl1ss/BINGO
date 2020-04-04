namespace BINGO
{
    partial class WeHaveAWinner
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
            this.winnerLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winnerLabel.BackgroundImage = global::BINGO.Properties.Resources.Download_Confetti_PNG_Transparent_Picture;
            this.winnerLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winnerLabel.FlatAppearance.BorderSize = 0;
            this.winnerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winnerLabel.Font = new System.Drawing.Font("Showcard Gothic", 150F);
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(0, 2);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(1148, 662);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "BINGO!";
            this.winnerLabel.UseVisualStyleBackColor = true;
            this.winnerLabel.Click += new System.EventHandler(this.WinnerLabel_Click);
            // 
            // WeHaveAWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 664);
            this.Controls.Add(this.winnerLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeHaveAWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Have a Winner!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WeHaveAWinner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button winnerLabel;
    }
}