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

        public void SortByNumber() {

        }

        public void SortByType() {

        }

        public void SortByAll() {

        }

        public void AddCard(Card card) {
            hand.Add(card);
        }

        public List<Card> GetHand() {
            return hand;
        }

    }
}
