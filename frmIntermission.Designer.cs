
namespace Project
{
    partial class frmIntermission
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
            this.gbxPlayerScores = new System.Windows.Forms.GroupBox();
            this.lblIntermissionPLayer2Score = new System.Windows.Forms.Label();
            this.lblIntermissionPLayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Intermission = new System.Windows.Forms.Label();
            this.lblPlayer1Intermission = new System.Windows.Forms.Label();
            this.btnIntermission = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxPlayerScores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlayerScores
            // 
            this.gbxPlayerScores.BackColor = System.Drawing.Color.Teal;
            this.gbxPlayerScores.Controls.Add(this.lblIntermissionPLayer2Score);
            this.gbxPlayerScores.Controls.Add(this.lblIntermissionPLayer1Score);
            this.gbxPlayerScores.Controls.Add(this.lblPlayer2Intermission);
            this.gbxPlayerScores.Controls.Add(this.lblPlayer1Intermission);
            this.gbxPlayerScores.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxPlayerScores.Location = new System.Drawing.Point(18, 18);
            this.gbxPlayerScores.Name = "gbxPlayerScores";
            this.gbxPlayerScores.Size = new System.Drawing.Size(228, 173);
            this.gbxPlayerScores.TabIndex = 0;
            this.gbxPlayerScores.TabStop = false;
            this.gbxPlayerScores.Text = "Player Scores";
            this.gbxPlayerScores.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIntermissionPLayer2Score
            // 
            this.lblIntermissionPLayer2Score.AutoSize = true;
            this.lblIntermissionPLayer2Score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntermissionPLayer2Score.Location = new System.Drawing.Point(88, 109);
            this.lblIntermissionPLayer2Score.Name = "lblIntermissionPLayer2Score";
            this.lblIntermissionPLayer2Score.Size = new System.Drawing.Size(62, 20);
            this.lblIntermissionPLayer2Score.TabIndex = 3;
            this.lblIntermissionPLayer2Score.Text = "label2";
            // 
            // lblIntermissionPLayer1Score
            // 
            this.lblIntermissionPLayer1Score.AutoSize = true;
            this.lblIntermissionPLayer1Score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntermissionPLayer1Score.Location = new System.Drawing.Point(88, 59);
            this.lblIntermissionPLayer1Score.Name = "lblIntermissionPLayer1Score";
            this.lblIntermissionPLayer1Score.Size = new System.Drawing.Size(62, 20);
            this.lblIntermissionPLayer1Score.TabIndex = 2;
            this.lblIntermissionPLayer1Score.Text = "label1";
            // 
            // lblPlayer2Intermission
            // 
            this.lblPlayer2Intermission.AutoSize = true;
            this.lblPlayer2Intermission.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Intermission.Location = new System.Drawing.Point(8, 109);
            this.lblPlayer2Intermission.Name = "lblPlayer2Intermission";
            this.lblPlayer2Intermission.Size = new System.Drawing.Size(82, 20);
            this.lblPlayer2Intermission.TabIndex = 1;
            this.lblPlayer2Intermission.Text = "Player2:";
            // 
            // lblPlayer1Intermission
            // 
            this.lblPlayer1Intermission.AutoSize = true;
            this.lblPlayer1Intermission.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Intermission.Location = new System.Drawing.Point(8, 59);
            this.lblPlayer1Intermission.Name = "lblPlayer1Intermission";
            this.lblPlayer1Intermission.Size = new System.Drawing.Size(82, 20);
            this.lblPlayer1Intermission.TabIndex = 0;
            this.lblPlayer1Intermission.Text = "Player1:";
            // 
            // btnIntermission
            // 
            this.btnIntermission.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIntermission.Location = new System.Drawing.Point(18, 215);
            this.btnIntermission.Name = "btnIntermission";
            this.btnIntermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIntermission.Size = new System.Drawing.Size(225, 53);
            this.btnIntermission.TabIndex = 1;
            this.btnIntermission.Text = "Player 2 Start";
            this.btnIntermission.UseVisualStyleBackColor = true;
            this.btnIntermission.Click += new System.EventHandler(this.btnIntermission_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnIntermission);
            this.panel1.Controls.Add(this.gbxPlayerScores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 290);
            this.panel1.TabIndex = 2;
            // 
            // frmIntermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.panel1);
            this.Name = "frmIntermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.frmIntermission_Load);
            this.gbxPlayerScores.ResumeLayout(false);
            this.gbxPlayerScores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlayerScores;
        private System.Windows.Forms.Label lblPlayer2Intermission;
        private System.Windows.Forms.Label lblPlayer1Intermission;
        private System.Windows.Forms.Label lblIntermissionPLayer2Score;
        private System.Windows.Forms.Label lblIntermissionPLayer1Score;
        private System.Windows.Forms.Button btnIntermission;
        private System.Windows.Forms.Panel panel1;
    }
}