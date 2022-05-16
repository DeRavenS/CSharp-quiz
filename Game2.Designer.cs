
namespace Project
{
    partial class Game2
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
            this.game2TimerLable = new System.Windows.Forms.Label();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.game2song1btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.game1BackBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // game2TimerLable
            // 
            this.game2TimerLable.AutoSize = true;
            this.game2TimerLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.game2TimerLable.Location = new System.Drawing.Point(6, 31);
            this.game2TimerLable.Name = "game2TimerLable";
            this.game2TimerLable.Size = new System.Drawing.Size(60, 25);
            this.game2TimerLable.TabIndex = 0;
            this.game2TimerLable.Text = "Timer";
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.songNameLabel.Location = new System.Drawing.Point(12, 13);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(225, 26);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "Song placeholder";
            // 
            // game2song1btn
            // 
            this.game2song1btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game2song1btn.Location = new System.Drawing.Point(50, 187);
            this.game2song1btn.Name = "game2song1btn";
            this.game2song1btn.Size = new System.Drawing.Size(187, 45);
            this.game2song1btn.TabIndex = 2;
            this.game2song1btn.Text = "Confirm Answer";
            this.game2song1btn.UseVisualStyleBackColor = true;
            this.game2song1btn.Click += new System.EventHandler(this.game2song1btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.game2song1btn);
            this.panel1.Controls.Add(this.songNameLabel);
            this.panel1.Location = new System.Drawing.Point(105, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 237);
            this.panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(12, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(156, 32);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(12, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(12, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(105, 78);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(60, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // game1BackBtn
            // 
            this.game1BackBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game1BackBtn.Location = new System.Drawing.Point(333, 380);
            this.game1BackBtn.Name = "game1BackBtn";
            this.game1BackBtn.Size = new System.Drawing.Size(170, 44);
            this.game1BackBtn.TabIndex = 5;
            this.game1BackBtn.Text = "Leave Quiz";
            this.game1BackBtn.UseVisualStyleBackColor = true;
            this.game1BackBtn.Click += new System.EventHandler(this.game1BackBtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.game2TimerLable);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(414, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.game1BackBtn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblScore);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Correct Artists";
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "Game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label game2TimerLable;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Button game2song1btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button game1BackBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}