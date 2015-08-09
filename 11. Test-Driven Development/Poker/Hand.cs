using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (this.Cards.Count > 0)
            {
                List<string> cards = new List<string>();

                foreach (var card in this.Cards)
                {
                    cards.Add(card.ToString());
                }

                result = string.Join(", ", cards);
            }
            else
            {
                result = "No cards in hand";
            }

            return result;
        }
    }
}
