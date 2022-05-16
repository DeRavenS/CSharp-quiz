// ---------------------------------------------------
// Albrecht Ohsiek 578445 26/08/2021
// Created Template for Artist Database
//
// Katlego 29/30/2021
// Added 13 Dummy artists
// ---------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ArtistData
    {
        private List<Artist> allArtistData = new List<Artist>();

        public List<Artist> AllArtistData { get => allArtistData; set => allArtistData = value; }

        public ArtistData() 
        {
            // Format for artist, song, and genre information
            AllArtistData.Add(new Artist("Elvis", "Presley", new List<string> { "My Hapiness", "I'll never stand in your way" }, new List<string> { "Rock and Roll", "Pop" }));

// -------------------------------------------------------------
            AllArtistData.Add(new Artist("A.K.A", "Forbes", new List<string> { "Cross My Heart", "Fela in Versace" }, new List<string> { "Hip Hop", "Kwaito" }));
            AllArtistData.Add(new Artist("Alex", "Baker", new List<string> { "Inflorescent" }, new List<string> { "Electronic", "Dance" }));
            AllArtistData.Add(new Artist("Anderson ", ".Paak", new List<string> { "Tints ft Kendrick Lamar", "Leave the door open" }, new List<string> { "Hip Hop", "R&B" }));
            AllArtistData.Add(new Artist("Beyonce", "", new List<string> { "Crazy in Love tf Jay Z", "NILE" }, new List<string> { "Pop", "Hip Hop" }));
            AllArtistData.Add(new Artist("Blac", "Youngsta", new List<string> { "Pure ft Swae Lee", "Code Red" }, new List<string> { "Hip Hop" }));
            AllArtistData.Add(new Artist("Black", "Coffee", new List<string> { "Wish you were here ft Msaki", "Drive" }, new List<string> { "Dance", "House" }));
            AllArtistData.Add(new Artist("Calvin", "Harris", new List<string> { "How Deep IS Your Love", "Summer" }, new List<string> { "Dance", "House" }));
            AllArtistData.Add(new Artist("Childish", "Gambino", new List<string> { "Me and Your Mama", "This is America" }, new List<string> { "R&B", "Hip Hop" }));
            AllArtistData.Add(new Artist("Ctrlgang", "", new List<string> { "Taco Tuesday in Paradise", "60++" }, new List<string> { "Hip Hop" }));
            AllArtistData.Add(new Artist("Paul", "Rudder", new List<string> { "Summer Rain", "Don't let love" }, new List<string> { "Electronic", "Dance" }));
            AllArtistData.Add(new Artist("Buzzcocks", "", new List<string> { "Ever Fallen in Love", "Just Lust" }, new List<string> { "Rock", "Punk" }));
            AllArtistData.Add(new Artist("The", "Cramps", new List<string> { "Goo Goo", "Human Fly" }, new List<string> { "Alternative", "Rock" }));
            AllArtistData.Add(new Artist("The", "Jam", new List<string> { "In the City", "Art School" }, new List<string> { "Rock", "Punk" }));
// --------------------------------------------------------------
        }

    }

}
