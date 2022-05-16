
namespace Project
{
    partial class frmGame1
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
            this.lblTimer1 = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.cat1CheckBox = new System.Windows.Forms.CheckBox();
            this.cat2CheckBox = new System.Windows.Forms.CheckBox();
            this.cat3CheckBox = new System.Windows.Forms.CheckBox();
            this.game1BackBtn = new System.Windows.Forms.Button();
            this.game1nxtBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer1.Location = new System.Drawing.Point(9, 31);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(60, 25);
            this.lblTimer1.TabIndex = 0;
            this.lblTimer1.Text = "Timer";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.BackColor = System.Drawing.Color.Teal;
            this.artistLabel.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistLabel.Location = new System.Drawing.Point(3, 13);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(226, 26);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist Placeholder";
            // 
            // cat1CheckBox
            // 
            this.cat1CheckBox.AutoSize = true;
            this.cat1CheckBox.BackColor = System.Drawing.Color.Teal;
            this.cat1CheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cat1CheckBox.Location = new System.Drawing.Point(45, 55);
            this.cat1CheckBox.Name = "cat1CheckBox";
            this.cat1CheckBox.Size = new System.Drawing.Size(135, 32);
            this.cat1CheckBox.TabIndex = 4;
            this.cat1CheckBox.Text = "Catagory 1";
            this.cat1CheckBox.UseVisualStyleBackColor = false;
            // 
            // cat2CheckBox
            // 
            this.cat2CheckBox.AutoSize = true;
            this.cat2CheckBox.BackColor = System.Drawing.Color.Teal;
            this.cat2CheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cat2CheckBox.Location = new System.Drawing.Point(45, 93);
            this.cat2CheckBox.Name = "cat2CheckBox";
            this.cat2CheckBox.Size = new System.Drawing.Size(135, 32);
            this.cat2CheckBox.TabIndex = 5;
            this.cat2CheckBox.Text = "Catagory 2";
            this.cat2CheckBox.UseVisualStyleBackColor = false;
            // 
            // cat3CheckBox
            // 
            this.cat3CheckBox.AutoSize = true;
            this.cat3CheckBox.BackColor = System.Drawing.Color.Teal;
            this.cat3CheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cat3CheckBox.Location = new System.Drawing.Point(45, 131);
            this.cat3CheckBox.Name = "cat3CheckBox";
            this.cat3CheckBox.Size = new System.Drawing.Size(135, 32);
            this.cat3CheckBox.TabIndex = 6;
            this.cat3CheckBox.Text = "Catagory 3";
            this.cat3CheckBox.UseVisualStyleBackColor = false;
            // 
            // game1BackBtn
            // 
            this.game1BackBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game1BackBtn.Location = new System.Drawing.Point(401, 381);
            this.game1BackBtn.Name = "game1BackBtn";
            this.game1BackBtn.Size = new System.Drawing.Size(97, 46);
            this.game1BackBtn.TabIndex = 7;
            this.game1BackBtn.Text = "Back";
            this.game1BackBtn.UseVisualStyleBackColor = true;
            this.game1BackBtn.Click += new System.EventHandler(this.game1BackBtn_Click);
            // 
            // game1nxtBtn
            // 
            this.game1nxtBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game1nxtBtn.Location = new System.Drawing.Point(31, 213);
            this.game1nxtBtn.Name = "game1nxtBtn";
            this.game1nxtBtn.Size = new System.Drawing.Size(173, 36);
            this.game1nxtBtn.TabIndex = 8;
            this.game1nxtBtn.Text = "ConfirmAnswer";
            this.game1nxtBtn.UseVisualStyleBackColor = true;
            this.game1nxtBtn.Click += new System.EventHandler(this.game1nxtBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.lblTimer1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(414, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.lblScore);
            this.groupBox2.Controls.Add(this.game1BackBtn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 433);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Correct Genres";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(136, 91);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 20);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cat1CheckBox);
            this.panel1.Controls.Add(this.game1nxtBtn);
            this.panel1.Controls.Add(this.artistLabel);
            this.panel1.Controls.Add(this.cat2CheckBox);
            this.panel1.Controls.Add(this.cat3CheckBox);
            this.panel1.Location = new System.Drawing.Point(136, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 256);
            this.panel1.TabIndex = 10;
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.frmGame1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.CheckBox cat1CheckBox;
        private System.Windows.Forms.CheckBox cat2CheckBox;
        private System.Windows.Forms.CheckBox cat3CheckBox;
        private System.Windows.Forms.Button game1BackBtn;
        private System.Windows.Forms.Button game1nxtBtn;
        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
    }
}