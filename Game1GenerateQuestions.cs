﻿// ----------------------------------------------------
// Albrecht Ohsiek 578445 30/08/2021
// ----------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Game1GenerateQuestions
    {
        private List<Artist> randomList = new List<Artist>();
        private int listSize = 10;

        public List<Artist> RandomList { get => randomList; set => randomList = value; }
        public int ListSize { get => listSize; }

        //Default Constructor
        public Game1GenerateQuestions() 
        {
            ArtistData myArtistDate = new ArtistData();
            List<Artist> tempList = myArtistDate.AllArtistData;
            //Sets size
            setListSize(tempList, ListSize);
            //Randomize methode
            RandomList = randomizeList(tempList);

            
        }

        //Randomisez inputed List
        public List<Artist> randomizeList (List<Artist> myList)
       {
            var RNG = new Random();
            int size = myList.Count;

            var randList = myList.OrderBy(Artist => RNG.Next(size));

            myList = new List<Artist>();

            foreach (var item in randList)
            {
                myList.Add(item);
            }

            return myList;
        }

        public void setListSize (List<Artist> myList, int ListSize)
        {
            foreach (Artist newArtist in myList)
            {
                int count = 0;
                if (count < ListSize)
                {
                    count++;

                    RandomList.Add(newArtist);
                }
            }
        }

    }
}
