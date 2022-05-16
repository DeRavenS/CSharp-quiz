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
    public partial class frmPlayerSelect : Form
    {
        frmLogin frmlog = new frmLogin();
        public frmPlayerSelect()
        {
            InitializeComponent();
        }


        private void playerSelectBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            GlobalVariables.playerList.Clear();
            frmlog.Show();
        }

        private void pickPlayer2btn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmlog.Show();
        }

        private void pickPlayer1btn_Click(object sender, EventArgs e)
        {   frmPreGame pregame = new frmPreGame();
            pregame.Show();
            this.Close();
            
        }

    }
}
