using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{  
    
    public partial class frmGame1 : Form
    {
        private List<Artist> myArtistData = new List<Artist>();
        private List<string[]> questionGenres = new List<string[]>();
        private int count = 0;
       

        public frmGame1()
        {
            InitializeComponent();

            // Creates and gets question
            Game1Controller myGame1Controller = new Game1Controller();
            myGame1Controller.GenerateArtistInfo();
            myGame1Controller.GenerateQuestionOptions();
            myArtistData = myGame1Controller.Game1RawInfo;
            questionGenres = myGame1Controller.QuestionOptions;          
    }


        private void frmGame1_Load(object sender, EventArgs e)
        {
            count = 0;
            textControl(count);
            lblTimer1.Text = "Time: 30";
            TimerClass timer = new TimerClass(lblTimer1, this,1);
            timer.timerThread = new Thread(timer.timerMethod);
            timer.timerThread.Start();
            lblScore.Text = "Score: " + GlobalVariables.activePlayer.Score.ToString();
        }
               
        private void game1nxtBtn_Click(object sender, EventArgs e)
        {
            checkAnswer(count);
            lblScore.Text = "Score: " + GlobalVariables.activePlayer.Score.ToString();
            count++;
            if (count <= 9)
            {                
                textControl(count);
            }
            else if(count == 10)
            {
                frmIntermission newIntermission = new frmIntermission();          
                newIntermission.Show();            
                this.Close();
            }
           
        }

        private void textControl(int num)
        {
            Artist myArtist = new Artist();
            myArtist = myArtistData[num];

            // change Artist
            artistLabel.Text = myArtist.Name + ' ' + myArtist.Surname;
                string[] tempArr = new string[3];
            tempArr = questionGenres.ElementAt(num);

            // changes catagory names
            cat1CheckBox.Text = tempArr[0];
            cat2CheckBox.Text = tempArr[1];
            cat3CheckBox.Text = tempArr[2];

        }

        private void checkAnswer(int num)
        {
            Artist myArtist = new Artist();
            myArtist = myArtistData[num];

            
            bool bscore = true;//used to see correct answer
          
                if(cat1CheckBox.Checked && !myArtist.Genre.Contains(cat1CheckBox.Text))
                {                       
                    bscore = false;                 
                }
            
                if (cat2CheckBox.Checked && !myArtist.Genre.Contains(cat2CheckBox.Text))
                {  
                    bscore = false;   
                }


                if (cat3CheckBox.Checked && !myArtist.Genre.Contains(cat3CheckBox.Text))
                {
                    bscore = false;              
                }

            if (!cat1CheckBox.Checked && !cat3CheckBox.Checked && !cat2CheckBox.Checked)
                bscore = false;

            cat1CheckBox.Checked = false;
            cat2CheckBox.Checked = false;
            cat3CheckBox.Checked = false;
            if (bscore)
                GlobalVariables.activePlayer.IncScore();
        }

        private void game1BackBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in GlobalVariables.playerList)
            {
                item.Score = 0;
            }
            GlobalVariables.activePlayer = null;
            frmPreGame newPreGameForm = new frmPreGame();            
            newPreGameForm.Show();
            this.Close();
        }

        public static void GameEnd(Form form)//for timer thread
        {
            frmIntermission newIntermission = new frmIntermission();
            newIntermission.Show();
            form.Hide();
        }
    }
}
