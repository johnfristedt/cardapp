using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{

    class Program
    {
        const int NUM_CARDS = 3;

        private enum values
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        private enum colors
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs
        }

        static Deck deck = new Deck();

        private static Hand AddCardToHand(Hand hand)
        {
            hand.AddCard(deck.Draw());
            return hand;
        }

        private static int Evaluate(Hand hand)
        {
            hand.SortByValue();
            if (Card.SameValue(hand.GetHand().First(), hand.GetHand().Last()))
                return 3;

            hand.SortByColor();
            if (Card.SameColor(hand.GetHand().First(), hand.GetHand().Last()))
                return 2;

            for (int i = 0; i < NUM_CARDS; i++)
            {
                var h = hand.GetHand();
                if (h.Count(c => c.Value == h[i].Value) > 1)
                    return 1;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            deck.Shuffle();
            Hand hand = new Hand();

            Task<Hand> t1 = new Task<Hand>(() => AddCardToHand(hand));
            var t2 = t1.ContinueWith((t) => AddCardToHand(t1.Result));
            var t3 = t2.ContinueWith((t) => AddCardToHand(t2.Result));
            var t4 = t3.ContinueWith((t) => Evaluate(t3.Result));
            t1.Start();

            var score = t4.Result;

            Console.WriteLine(hand.ToString());
            Console.WriteLine(score);
        }
    }
}
