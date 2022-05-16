// -----------------------------------------------
// De Raven 24/08/2021
// Implemented Login
//
// Albrecht Ohsiek 26/08/2021
// Changed user account information to Dictonary database
// 
// -----------------------------------------------

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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string inputUsername = tbxUserName.Text;
            string inputPassword = tbxPassWord.Text;
            //Global Variables is a class created to store global variables
            if (GlobalVariables.playerList.Count != 0)
            {
                try//ensuring same player doesnt log in twice
                {
                    if (inputUsername != GlobalVariables.playerList[0].Username)
                    {
                        checkLogIn(inputUsername, inputPassword);//method to chech login details
                    }
                    else
                    {
                        throw new LogInException("User Already Logged in");
                    }
                    
                }
                catch (LogInException m)
                {
                    lblLogInFeedBack.ForeColor = Color.Maroon;
                    lblLogInFeedBack.Text = m.Message;
                }
                
            }
            else
            {
                checkLogIn(inputUsername, inputPassword);
            }
        }


        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbxUserName.Clear();
            tbxPassWord.Clear();
            lblLogInFeedBack.Text = "";
            tbxUserName.Focus();
            if (GlobalVariables.playerList.Count() == 1)
                groupBox1.Text = "PLayer 2 LOGIN";
        }

        private void checkLogIn(string inputUsername, string inputPassword)//method for checking login details
        {
            UserAccountInfo users = new UserAccountInfo();
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            userInfo = users.Accounts;  // Initializes usernames and passwords

            if (userInfo.ContainsKey(inputUsername))
            {
                // Gets Password associated with key
                string value = "";
                userInfo.TryGetValue(inputUsername, out value);

                if (inputPassword == value)
                {
                    Player player = new Player(inputUsername, 0);
                    GlobalVariables.playerList.Add(player);//generating player object
                    if (GlobalVariables.playerList.Count() == 2)//accounting for multiple players
                    {
                        frmPreGame preGame = new frmPreGame();
                        this.Hide();
                        preGame.Show();
                        
                    }
                    else
                    {
                        frmPlayerSelect pselect = new frmPlayerSelect();
                        this.Hide();
                        pselect.Show();
                    }
                }
                else
                {
                    lblLogInFeedBack.ForeColor = Color.Maroon;
                    lblLogInFeedBack.Text = "Incorrect username or password";
                }
            }
            else
            {
                lblLogInFeedBack.ForeColor = Color.Maroon;
                lblLogInFeedBack.Text = "Incorrect username or password";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblLogInFeedBack_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
