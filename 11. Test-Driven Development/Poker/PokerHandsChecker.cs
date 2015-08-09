using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    var card = hand.Cards[i];

                    for (int j = i + 1; j < 5; j++)
                    {
                        var otheCard = hand.Cards[j];
                        if (card.Face == otheCard.Face && card.Suit == otheCard.Suit)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            return IsStraight(hand) && IsFlush(hand);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            var firstFace = hand.Cards[0].Face;
            CardFace secondFace = CardFace.Ace;
            int firstFaceCounter = 0;
            int secondFaceCounter = 0;

            foreach (var card in hand.Cards)
            {
                if (card.Face == firstFace)
                {
                    firstFaceCounter++;
                }
                else
                {
                    if (secondFaceCounter == 0)
                    {
                        secondFaceCounter++;
                        secondFace = card.Face;
                    }
                    else if (card.Face == secondFace)
                    {
                        secondFaceCounter++;
                    }
                }
            }

            return (firstFaceCounter == 4 || secondFaceCounter == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            IList<ICard> firstCards = new List<ICard>();
            IList<ICard> secondCards = new List<ICard>();

            foreach (var card in hand.Cards)
            {
                if (firstCards.Count == 0)
                {
                    firstCards.Add(card);
                }
                else if (card.Face == firstCards[0].Face)
                {
                    firstCards.Add(card);
                }
                else if (secondCards.Count == 0)
                {
                    secondCards.Add(card);
                }
                else if (card.Face == secondCards[0].Face)
                {
                    secondCards.Add(card);
                }
            }

            return ((firstCards.Count == 2 && secondCards.Count == 3)
                || (firstCards.Count == 3 && secondCards.Count == 2));
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            List<ICard> sortedCards = hand.Cards.OrderBy(c => c.Face).ToList();



            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (sortedCards[i].Face + 1 != sortedCards[i + 1].Face)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }           
            
            for (int i = 0; i < 3; i++)
            {
                var currentCard = hand.Cards[i];
                var counter = 1;

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (currentCard.Face == hand.Cards[j].Face)
                    {
                        counter++;
                    }
                }

                if (counter == 3)
                {
                    return true;
                }

                counter = 1;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int[] array = { 1, 1, 1, 1, 1 };

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var card = hand.Cards[i];

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (card.Face == hand.Cards[j].Face)
                    {
                        ++array[i];
                    }
                }
            }

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            if (array.Sum() == 7)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var card = hand.Cards[i];

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (card.Face == hand.Cards[j].Face)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            return (!IsFlush(hand)
                && !IsFourOfAKind(hand)
                && !IsFullHouse(hand)
                && !IsOnePair(hand)
                && !IsStraight(hand)
                && !IsStraightFlush(hand)
                && !IsThreeOfAKind(hand)
                && !IsTwoPair(hand));
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
