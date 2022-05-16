using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmIntermission : Form
    {
        public frmIntermission()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void frmIntermission_Load(object sender, EventArgs e)
        {
            //Display Player Scores And Enables Multiplayer for game 1
            lblPlayer1Intermission.Text = GlobalVariables.playerList[0].Username + ":";
            lblIntermissionPLayer1Score.Text = GlobalVariables.playerList[0].Score.ToString();
           
            if (GlobalVariables.playerList.Count == 2)
            {
                lblIntermissionPLayer2Score.Show();
                lblPlayer2Intermission.Show();
                lblPlayer2Intermission.Text = GlobalVariables.playerList[1].Username + ":";
                lblIntermissionPLayer2Score.Text = GlobalVariables.playerList[1].Score.ToString();

                if (GlobalVariables.activePlayer.Equals(GlobalVariables.playerList[0]))
                {
                    btnIntermission.Text = "Player 2 Start";
                    GlobalVariables.activePlayer = GlobalVariables.playerList[1];
                }
                else
                {
                    btnIntermission.Text = "Start Section 2";
                }
                
            }
            else
            {
                lblIntermissionPLayer2Score.Hide();
                lblPlayer2Intermission.Hide();
                btnIntermission.Text = "Start Section 2";
            }
            
        }

        private void btnIntermission_Click(object sender, EventArgs e)
        {
            if (btnIntermission.Text == "Player 2 Start")
            {
                frmGame1 frm = new frmGame1();
                frm.Show();
                this.Hide();
            }
            else
            {
                Game2 frm = new Game2();
                GlobalVariables.activePlayer = GlobalVariables.playerList[0];
                frm.Show();
                this.Hide();
            }
                
                
        }
    }
}
