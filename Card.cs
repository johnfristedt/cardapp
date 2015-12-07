using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Card
    {
        private enum Colors
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs
        }

        public int Color { get; set; }
        public int Value { get; set; }

        public Card(int value, int color)
        {
            this.Value = value;
            this.Color = color;
        }

        public static bool SameColor(Card card1, Card card2)
        {
            return card1.Color == card2.Color;
        }

        public static bool SameValue(Card card1, Card card2)
        {
            return card1.Value == card2.Value;
        }

        public bool LessThan(Card compare)
        {
            return this.Value < compare.Value;
        }

        public bool HigherThan(Card compare)
        {
            return this.Value > compare.Value;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", this.Value, ((Colors)this.Color).ToString());
        }
    }
}
