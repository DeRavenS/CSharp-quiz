
namespace Project
{
    partial class frmPlayerSelect
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
            this.pickPlayer1btn = new System.Windows.Forms.Button();
            this.pickPlayer2btn = new System.Windows.Forms.Button();
            this.playerSelectBackBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickPlayer1btn
            // 
            this.pickPlayer1btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickPlayer1btn.Location = new System.Drawing.Point(31, 60);
            this.pickPlayer1btn.Name = "pickPlayer1btn";
            this.pickPlayer1btn.Size = new System.Drawing.Size(187, 52);
            this.pickPlayer1btn.TabIndex = 0;
            this.pickPlayer1btn.Text = "Singleplayer";
            this.pickPlayer1btn.UseVisualStyleBackColor = true;
            this.pickPlayer1btn.Click += new System.EventHandler(this.pickPlayer1btn_Click);
            // 
            // pickPlayer2btn
            // 
            this.pickPlayer2btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickPlayer2btn.Location = new System.Drawing.Point(31, 118);
            this.pickPlayer2btn.Name = "pickPlayer2btn";
            this.pickPlayer2btn.Size = new System.Drawing.Size(187, 52);
            this.pickPlayer2btn.TabIndex = 1;
            this.pickPlayer2btn.Text = "Multiplayer";
            this.pickPlayer2btn.UseVisualStyleBackColor = true;
            this.pickPlayer2btn.Click += new System.EventHandler(this.pickPlayer2btn_Click);
            // 
            // playerSelectBackBtn
            // 
            this.playerSelectBackBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerSelectBackBtn.Location = new System.Drawing.Point(204, 193);
            this.playerSelectBackBtn.Name = "playerSelectBackBtn";
            this.playerSelectBackBtn.Size = new System.Drawing.Size(87, 45);
            this.playerSelectBackBtn.TabIndex = 2;
            this.playerSelectBackBtn.Text = "Back";
            this.playerSelectBackBtn.UseVisualStyleBackColor = true;
            this.playerSelectBackBtn.Click += new System.EventHandler(this.playerSelectBackBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.playerSelectBackBtn);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Number of Players";
            // 
            // frmPlayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(320, 264);
            this.Controls.Add(this.pickPlayer2btn);
            this.Controls.Add(this.pickPlayer1btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPlayerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerSelect";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pickPlayer1btn;
        private System.Windows.Forms.Button pickPlayer2btn;
        private System.Windows.Forms.Button playerSelectBackBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}