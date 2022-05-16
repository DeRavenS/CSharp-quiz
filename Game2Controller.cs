using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Game2Controller:Controller
    {
        // Artist Information
        private List<Artist> game1RawInfo = new List<Artist>();
        private int score = 0;
        private string[] allArtists = new string[] { "A.K.A Forbes", "Alex Baker", "Anderson .Paak", "Beyonce", "Blac Youngsta", "Black Coffee", "Calvin Harris", "Childish Gambino", "Ctrlgang", "Paul Rudder", "Buzzcocks", "The Cramps", "The Jam" };
        private List<string[]> questionOptions = new List<string[]>();

        public List<Artist> Game1RawInfo { get => game1RawInfo; set => game1RawInfo = value; }
        public int Score { get => score; set => score = value; }
        public string[] AllArtists { get => allArtists; } //Read Only
        public List<string[]> QuestionOptions { get => questionOptions; set => questionOptions = value; } // hold the 3 options for catagories in game1

        public Game2Controller()
        {
        }

        public void GenerateSongInfo()
        {
            // Gets question information on application start --- could use threading
            Game2GenerateQuestions myList = new Game2GenerateQuestions();
            Game1RawInfo = myList.RandomList;
        }

        public void GenerateQuestionOptions()
        {
            var RNG = new Random();
            var RNG_AllArtists = new Random();
            var RNG_CurrentSongArtists = new Random();
            Artist tempSong = new Artist();
            foreach (Artist item in Game1RawInfo)
            {
                    tempSong = item;
                    int lenght = tempSong.Song.Count;

                    string[] tempStringArr = new string[3];

                    tempStringArr[0] = tempSong.Name + " " + tempSong.Surname;
                    tempStringArr[1] = AllArtists[RNG_AllArtists.Next(9)];

                    //Ensures no duplicates
                    while (tempStringArr[0] == tempStringArr[1])
                    {
                        tempStringArr[1] = AllArtists[RNG_AllArtists.Next(9)];
                    }

                    tempStringArr[2] = AllArtists[RNG_AllArtists.Next(9)]; // -- replace with actual genre

                    while ((tempStringArr[0] == tempStringArr[2]) || (tempStringArr[1] == tempStringArr[2]))
                    {
                        tempStringArr[2] = AllArtists[RNG_AllArtists.Next(9)];
                    }

            tempStringArr.OrderBy(x => RNG.Next(3)); // Randomisez order

            QuestionOptions.Add(tempStringArr);
            }
        }

    }
}
