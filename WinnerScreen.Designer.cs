
namespace Project
{
    partial class frmWinnerScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWinner = new System.Windows.Forms.Button();
            this.gbxPlayerScores = new System.Windows.Forms.GroupBox();
            this.lblWinnerPLayer2Score = new System.Windows.Forms.Label();
            this.lblWinnerPLayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Winner = new System.Windows.Forms.Label();
            this.lblPlayer1Winner = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxPlayerScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnWinner);
            this.panel1.Controls.Add(this.gbxPlayerScores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 290);
            this.panel1.TabIndex = 4;
            // 
            // btnWinner
            // 
            this.btnWinner.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWinner.Location = new System.Drawing.Point(18, 215);
            this.btnWinner.Name = "btnWinner";
            this.btnWinner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnWinner.Size = new System.Drawing.Size(225, 53);
            this.btnWinner.TabIndex = 1;
            this.btnWinner.Text = "Player 2 Start";
            this.btnWinner.UseVisualStyleBackColor = true;
            this.btnWinner.Click += new System.EventHandler(this.btnWinner_Click);
            // 
            // gbxPlayerScores
            // 
            this.gbxPlayerScores.BackColor = System.Drawing.Color.Teal;
            this.gbxPlayerScores.Controls.Add(this.lblWinnerPLayer2Score);
            this.gbxPlayerScores.Controls.Add(this.lblWinnerPLayer1Score);
            this.gbxPlayerScores.Controls.Add(this.lblPlayer2Winner);
            this.gbxPlayerScores.Controls.Add(this.lblPlayer1Winner);
            this.gbxPlayerScores.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxPlayerScores.Location = new System.Drawing.Point(18, 18);
            this.gbxPlayerScores.Name = "gbxPlayerScores";
            this.gbxPlayerScores.Size = new System.Drawing.Size(228, 173);
            this.gbxPlayerScores.TabIndex = 0;
            this.gbxPlayerScores.TabStop = false;
            this.gbxPlayerScores.Text = "Final Scores";
            // 
            // lblWinnerPLayer2Score
            // 
            this.lblWinnerPLayer2Score.AutoSize = true;
            this.lblWinnerPLayer2Score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinnerPLayer2Score.Location = new System.Drawing.Point(88, 109);
            this.lblWinnerPLayer2Score.Name = "lblWinnerPLayer2Score";
            this.lblWinnerPLayer2Score.Size = new System.Drawing.Size(62, 20);
            this.lblWinnerPLayer2Score.TabIndex = 3;
            this.lblWinnerPLayer2Score.Text = "label2";
            // 
            // lblWinnerPLayer1Score
            // 
            this.lblWinnerPLayer1Score.AutoSize = true;
            this.lblWinnerPLayer1Score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinnerPLayer1Score.Location = new System.Drawing.Point(88, 59);
            this.lblWinnerPLayer1Score.Name = "lblWinnerPLayer1Score";
            this.lblWinnerPLayer1Score.Size = new System.Drawing.Size(62, 20);
            this.lblWinnerPLayer1Score.TabIndex = 2;
            this.lblWinnerPLayer1Score.Text = "label1";
            // 
            // lblPlayer2Winner
            // 
            this.lblPlayer2Winner.AutoSize = true;
            this.lblPlayer2Winner.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Winner.Location = new System.Drawing.Point(8, 109);
            this.lblPlayer2Winner.Name = "lblPlayer2Winner";
            this.lblPlayer2Winner.Size = new System.Drawing.Size(82, 20);
            this.lblPlayer2Winner.TabIndex = 1;
            this.lblPlayer2Winner.Text = "Player2:";
            // 
            // lblPlayer1Winner
            // 
            this.lblPlayer1Winner.AutoSize = true;
            this.lblPlayer1Winner.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Winner.Location = new System.Drawing.Point(8, 59);
            this.lblPlayer1Winner.Name = "lblPlayer1Winner";
            this.lblPlayer1Winner.Size = new System.Drawing.Size(82, 20);
            this.lblPlayer1Winner.TabIndex = 0;
            this.lblPlayer1Winner.Text = "Player1:";
            // 
            // frmWinnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(283, 313);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmWinnerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Scores";
            this.Load += new System.EventHandler(this.frmWinnerScreen_Load);
            this.panel1.ResumeLayout(false);
            this.gbxPlayerScores.ResumeLayout(false);
            this.gbxPlayerScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWinner;
        private System.Windows.Forms.GroupBox gbxPlayerScores;
        private System.Windows.Forms.Label lblWinnerPLayer2Score;
        private System.Windows.Forms.Label lblWinnerPLayer1Score;
        private System.Windows.Forms.Label lblPlayer2Winner;
        private System.Windows.Forms.Label lblPlayer1Winner;
    }
}