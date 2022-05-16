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
    public partial class frmWinnerScreen : Form
    {
        public frmWinnerScreen()
        {
            InitializeComponent();
        }

        private void frmWinnerScreen_Load(object sender, EventArgs e)
        {
            lblPlayer1Winner.Text = GlobalVariables.playerList[0].Username + ":";
            lblWinnerPLayer1Score.Text = GlobalVariables.playerList[0].Score.ToString();

            if (GlobalVariables.playerList.Count == 2)
            {
                lblWinnerPLayer2Score.Show();
                lblPlayer2Winner.Show();
                lblPlayer2Winner.Text = GlobalVariables.playerList[1].Username + ":";
                lblWinnerPLayer2Score.Text = GlobalVariables.playerList[1].Score.ToString();

                if (GlobalVariables.activePlayer.Equals(GlobalVariables.playerList[0]))
                {
                    btnWinner.Text = "Player 2 Start";
                    GlobalVariables.activePlayer = GlobalVariables.playerList[1];
                }
                else
                {
                    if (GlobalVariables.playerList[0].Score== GlobalVariables.playerList[1].Score)
                    {
                        MessageBox.Show("Its a Tie!");
                    }
                    else
                    {
                        GlobalVariables.playerList.Sort();
                        MessageBox.Show("WINNER!\n" + GlobalVariables.playerList[0].Username);
                    }
                    
                    btnWinner.Text = "End Game";
                }

            }
            else
            {
                lblWinnerPLayer2Score.Hide();
                lblPlayer2Winner.Hide();
                btnWinner.Text = "End Game";
            }
        }

        private void btnWinner_Click(object sender, EventArgs e)
        {
            if (btnWinner.Text == "Player 2 Start")
            {
                Game2 frm = new Game2();
                frm.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
