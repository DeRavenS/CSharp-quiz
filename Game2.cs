using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project
{

    public partial class Game2 : Form
    {
        private List<Artist> myArtistData = new List<Artist>();
        private List<string[]> questionArtist = new List<string[]>();
        private int count = 0;


        public Game2()
        {
            InitializeComponent();

            // Creates and gets question
            Game2Controller myGame2Controller = new Game2Controller();
            myGame2Controller.GenerateSongInfo();
            myGame2Controller.GenerateQuestionOptions();
            myArtistData = myGame2Controller.Game1RawInfo;
            questionArtist = myGame2Controller.QuestionOptions;
        }

        private void textControl(int num)
        {
            Artist myArtist = new Artist();
            myArtist = myArtistData[num];

            // change Artist
            if (myArtist.Song.Count() == 2)
            {
                Random random = new Random();
                int randomnumber = random.Next(0, 2);
                songNameLabel.Text = Convert.ToString(myArtist.Song[randomnumber]);
            }
            else
            {
                songNameLabel.Text = Convert.ToString(myArtist.Song[0]);
            }
            string[] tempArr = new string[3];
            tempArr = questionArtist.ElementAt(num);
            Random Randomnum = new Random();
            int RandomNumb = Randomnum.Next(0, 3);
            if (RandomNumb == 0)
            {
                radioButton1.Text = tempArr[0];
                radioButton2.Text = tempArr[1];
                radioButton3.Text = tempArr[2];
            }
            else if (RandomNumb == 1)
            {
                radioButton1.Text = tempArr[1];
                radioButton2.Text = tempArr[0];
                radioButton3.Text = tempArr[2];
            }
            else if (RandomNumb == 2)
            {
                radioButton1.Text = tempArr[2];
                radioButton2.Text = tempArr[1];
                radioButton3.Text = tempArr[0];
            }
        }

        private void checkAnswer(int num)
        {
            Artist myArtist = new Artist();
            myArtist = myArtistData[num];


            bool bscore = true;//used to see correct answer
           
            if (radioButton1.Checked && myArtist.Name + ' ' + myArtist.Surname != radioButton1.Text)
            {
                bscore = false;
            }

            if (radioButton2.Checked && myArtist.Name + ' ' + myArtist.Surname != radioButton2.Text)
            {
                bscore = false;
            }


            if (radioButton3.Checked && myArtist.Name + ' ' + myArtist.Surname != radioButton3.Text)
            {
                bscore = false;
            }

            if (!radioButton1.Checked && !radioButton3.Checked && !radioButton2.Checked)
                bscore = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            if (bscore)
                GlobalVariables.activePlayer.IncScore();
        }

        public static void GameEnd(Form form)//for timer thread
        {
            frmIntermission newIntermission = new frmIntermission();
            newIntermission.Show();
            form.Hide();
        }

        private void game1BackBtn_Click_1(object sender, EventArgs e)
        {
            foreach (var item in GlobalVariables.playerList)
            {
                item.Score = 0;
            }
            frmPreGame newPreGameForm = new frmPreGame();
            newPreGameForm.Show();
            this.Close();
        }

        private void game2song1btn_Click(object sender, EventArgs e)
        {
            checkAnswer(count);
            lblScore.Text = "Score: " + GlobalVariables.activePlayer.Score.ToString();
            count++;
            if (count <= 9)
            {
                textControl(count);
            }
            else if (count == 10)
            {
                frmWinnerScreen frmWinner = new frmWinnerScreen();
                frmWinner.Show();
                this.Hide();
            }

        }

        private void Game2_Load_1(object sender, EventArgs e)
        {
            count = 0;
            textControl(count);
            game2TimerLable.Text = "30";
            TimerClass timer = new TimerClass(game2TimerLable, this,2);
            timer.timerThread = new Thread(timer.timerMethod);
            timer.timerThread.Start();
            lblScore.Text = "Score: " + GlobalVariables.activePlayer.Score.ToString();
        }

        public static void Game2End(Form form)//for timer thread
        {
            frmWinnerScreen frmWinner = new frmWinnerScreen();
            frmWinner.Show();
            form.Hide();
        }
    }
}

