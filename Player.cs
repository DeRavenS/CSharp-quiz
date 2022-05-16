using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Player:IComparable
    {
        private string username;
        private int score;

        public Player()
        {
        }
            

        public Player(string username, int score)
        {
            this.Username = username;
            this.Score = score;
        }

        public string Username { get => username; set => username = value; }
        public int Score { get => score; set => score = value; }

        public void IncScore()
        {
            this.Score++;
        }

        public int CompareTo(object obj)
        {
            Player objPlayer = obj as Player;
            return this.Score.CompareTo(objPlayer.Score);
            
            
        }
    }
}
