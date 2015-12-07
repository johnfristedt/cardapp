using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    
    class Program
    {
        private enum Colors
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs
        }

        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.Shuffle();
            Console.Write(deck);
        }
    }
}
