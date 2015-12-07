using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Deck
    {
        //public Card[] cards = new Card[52];
        public List<Card> cards = new List<Card>();

        //Konstruktor
        public Deck()
        {
            //Skapa kortleken
            for (int c = 0; c < 4; c++)
            {
                for (int v = 2; v <= 14; v++)
                {
                    cards.Add(new Card())
                }
            }



        }


        //Shuffle

        //Draw


    }
}

