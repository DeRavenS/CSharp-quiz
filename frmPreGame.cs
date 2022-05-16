// --------------------------------------
// Re Raven 24/08/2021
//
// AlbrechtOhsiek 578445 30/08/2021
// Generate Game1 choices while on preGame display.
//
// --------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project
{
    public partial class frmPreGame : Form 
    { 

        public frmPreGame()
        {
            InitializeComponent();      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGame1 frmGame1 = new frmGame1();
            GlobalVariables.activePlayer = GlobalVariables.playerList[0];
            frmGame1.Show();
            this.Close();
        }

        private void frmPreGame_Load(object sender, EventArgs e)
        {
            lblPlayer1Name.Text = GlobalVariables.playerList[0].Username;
            if(GlobalVariables.playerList.Count()==2)
            {
                lblPlayer2.Show();
                lblPlayer2Name.Show();
                lblPlayer2Name.Text = GlobalVariables.playerList[1].Username;
            }
            else
            {
                lblPlayer2.Hide();
                lblPlayer2Name.Hide();
            }
        }

        

        private void btnPreGameLogOut_Click_1(object sender, EventArgs e)
        {
            GlobalVariables.playerList.Clear();
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();
        }
    }
}
