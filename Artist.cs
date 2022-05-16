using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Artist
    {
        private string name;
        private string surname;
        private List<string> song;
        private List<string> genre;

        public Artist()
        {
        }

        public Artist(string name, string surname, List<string> song, List<string> genre)
        {
            this.Name = name;
            this.Surname = surname;
            this.Song = song;
            this.Genre = genre;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public List<string> Song { get => song; set => song = value; }
        public List<string> Genre { get => genre; set => genre = value; }
    }
}
