// --------------------------------------
// Albrecht Ohsiek 578445 30/08/2021
// --------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Game1Controller:Controller
    {
        // Artist Information
        private List<Artist> game1RawInfo = new List<Artist>();
        private int score = 0;
        private string[] allGenres = new string[]{ "Rock and Roll", "Pop", "Hip Hop", "Kwaito", "Electronic", "Dance", "RnB", "House", "Punk", "Rock"};
        private List<string[]> questionOptions = new List<string[]>();

        public List<Artist> Game1RawInfo { get => game1RawInfo; set => game1RawInfo = value; }
        public int Score { get => score; set => score = value; }
        public string[] AllGenres { get => allGenres; } //Read Only
        public List<string[]> QuestionOptions { get => questionOptions; set => questionOptions = value; } // hold the 3 options for catagories in game1

        public Game1Controller()
        {
        }

        public void GenerateArtistInfo()
        {
            // Gets question information on application start --- could use threading
            Game1GenerateQuestions myList = new Game1GenerateQuestions();
            Game1RawInfo = myList.RandomList;
        }

        public void GenerateQuestionOptions()
        {
            var RNG = new Random();
            var RNG_AllGenres = new Random();
            var RNG_CurrentArtistGenres = new Random();

            Artist tempArtist = new Artist();

            foreach (Artist item in Game1RawInfo)
            {
                tempArtist = item;
                int lenght = tempArtist.Genre.Count;

                string[] tempStringArr = new string[3];
                               
                tempStringArr[0] = tempArtist.Genre[RNG_CurrentArtistGenres.Next(lenght)];
                tempStringArr[1] = AllGenres[RNG_AllGenres.Next(9)];

                //Ensures no duplicates
                while (tempStringArr[0] == tempStringArr[1])
                {
                    tempStringArr[1] = AllGenres[RNG_AllGenres.Next(9)];
                }

                tempStringArr[2] = AllGenres[RNG_AllGenres.Next(9)]; // -- replace with actual genre

                while ((tempStringArr[0] == tempStringArr[2]) || (tempStringArr[1] == tempStringArr[2]))
                {
                    tempStringArr[2] = AllGenres[RNG_AllGenres.Next(9)];
                }


                List<string> tempArtistList = new List<string>();
                tempArtistList = tempStringArr.ToList<string>();

                var rand = tempArtistList.OrderBy(x => RNG.Next(3)); // Randomisez order

                tempArtistList = new List<string>();

                foreach (string tempItem in rand)
                {
                    tempArtistList.Add(tempItem);
                }

                tempStringArr = tempArtistList.ToArray();

                QuestionOptions.Add(tempStringArr);
            }

        }

    }
}

