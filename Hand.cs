using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Hand
    {

        private List<Card> hand = new List<Card>();

        public void SortByValue() {
            hand = hand.OrderBy(c => c.Value).ToList();
        }

        public void SortByColor() {
            hand = hand.OrderBy(c => c.Color).ToList();
        }

        public void SortByAll() {
            hand = hand.OrderBy(c => c.Color).ThenBy(c => c.Value).ToList();
        }

        public void AddCard(Card card) {
            hand.Add(card);
        }

        public List<Card> GetHand() {
            return hand;
        }

        public override string ToString()
        {
            String str = "";
            foreach (var card in hand)
            {
                str += card + "\n";
            }
            return str;
        }
    }
}
