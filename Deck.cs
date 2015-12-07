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
                    cards.Add(new Card(v, c));
                }
            }
        }

        //Shuffle
        public void Shuffle()
        {
            Random rnd = new Random();

            for (int i=0; i<100000; i++)
            {
                int getIndex = rnd.Next(0, 51);
                int putIndex = rnd.Next(0, 50);
                var item = cards[getIndex];
                cards.RemoveAt(getIndex);
                cards.Insert(putIndex, item);
            }
        }

        //Draw
        public Card Draw()
        {
            var card = cards.FirstOrDefault();
            cards.RemoveAt(0);
            return card;
        }

        public override string ToString()
        {
            String str = "";

            foreach (var card  in cards)
            {
                str += card + "\n";
            }

            return str;
        }


    }
}

