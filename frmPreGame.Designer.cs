
namespace Project
{
    partial class frmPreGame
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.gbxPlayerNames = new System.Windows.Forms.GroupBox();
            this.btnPreGameLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxPlayerNames.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Teal;
            this.lblPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.Location = new System.Drawing.Point(6, 42);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(85, 20);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.Location = new System.Drawing.Point(6, 94);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(85, 20);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2:";
            this.lblPlayer2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartQuiz.Location = new System.Drawing.Point(17, 143);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(208, 52);
            this.btnStartQuiz.TabIndex = 2;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Name.Location = new System.Drawing.Point(97, 42);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(54, 20);
            this.lblPlayer1Name.TabIndex = 3;
            this.lblPlayer1Name.Text = "Temp";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Name.Location = new System.Drawing.Point(97, 94);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(54, 20);
            this.lblPlayer2Name.TabIndex = 4;
            this.lblPlayer2Name.Text = "Temp";
            // 
            // gbxPlayerNames
            // 
            this.gbxPlayerNames.BackColor = System.Drawing.Color.Teal;
            this.gbxPlayerNames.Controls.Add(this.lblPlayer1Name);
            this.gbxPlayerNames.Controls.Add(this.lblPlayer2Name);
            this.gbxPlayerNames.Controls.Add(this.lblPlayer1);
            this.gbxPlayerNames.Controls.Add(this.lblPlayer2);
            this.gbxPlayerNames.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxPlayerNames.Location = new System.Drawing.Point(30, 12);
            this.gbxPlayerNames.Name = "gbxPlayerNames";
            this.gbxPlayerNames.Size = new System.Drawing.Size(208, 139);
            this.gbxPlayerNames.TabIndex = 5;
            this.gbxPlayerNames.TabStop = false;
            this.gbxPlayerNames.Text = "Active Players";
            // 
            // btnPreGameLogOut
            // 
            this.btnPreGameLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreGameLogOut.Location = new System.Drawing.Point(155, 201);
            this.btnPreGameLogOut.Name = "btnPreGameLogOut";
            this.btnPreGameLogOut.Size = new System.Drawing.Size(70, 24);
            this.btnPreGameLogOut.TabIndex = 6;
            this.btnPreGameLogOut.Text = "Log Out";
            this.btnPreGameLogOut.UseVisualStyleBackColor = true;
            this.btnPreGameLogOut.Click += new System.EventHandler(this.btnPreGameLogOut_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPreGameLogOut);
            this.panel1.Controls.Add(this.btnStartQuiz);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 236);
            this.panel1.TabIndex = 7;
            // 
            // frmPreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(262, 256);
            this.Controls.Add(this.gbxPlayerNames);
            this.Controls.Add(this.panel1);
            this.Name = "frmPreGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            this.Load += new System.EventHandler(this.frmPreGame_Load);
            this.gbxPlayerNames.ResumeLayout(false);
            this.gbxPlayerNames.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.GroupBox gbxPlayerNames;
        private System.Windows.Forms.Button btnPreGameLogOut;
        private System.Windows.Forms.Panel panel1;
    }
}