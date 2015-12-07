﻿using System;
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
                    cards.Add(new Card(c, v));
                }
            }
        }

        //Shuffle
        void Shuffle()
        {
            Random rnd = new Random();
            int getIndex = rnd.Next(0, 51);
            int putIndex = rnd.Next(0, 50);

            var item = cards[getIndex];
            cards.RemoveAt(getIndex);
            cards.Insert(putIndex, item);
        }

        //Draw
        Card Draw()
        {
            return cards.FirstOrDefault();
        }
    }
}
