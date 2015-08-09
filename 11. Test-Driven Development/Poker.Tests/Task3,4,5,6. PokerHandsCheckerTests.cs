using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Poker.Tests
{
    [TestFixture]
    class PokerHandsCheckerTests
    {
        // isValid
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void CheckIsHandValidWithLessThanFiveCards(int count)
        {
            IList<ICard> cards= new List<ICard>();

            for (int i = 0; i < count; i++)
            {
                ICard card = new Card((CardFace)(i + 2), CardSuit.Hearts);
                cards.Add(card);
            }

            IHand hand = new Hand(cards);
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand), "Hand with less than 5 cards is valid");
        }

        [Test]
        public void CheckIsHandValidWithFiveDifferentCards()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ten, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Clubs),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand), "Hand with 5 different cards is not valid");
        }

        [Test]
        public void CheckIsHandValidWithFiveNonDifferentCards()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand), "Hand with 2 equal cards is valid");
        }

        // flush
        [Test]
        public void CheckIsHandValidFlush()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ten, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Clubs),
				new Card(CardFace.Jack, CardSuit.Clubs),
				new Card(CardFace.Queen, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand), "Hand with flush is not valid flush");
        }

        [Test]
        public void CheckIsHandValidFlushWhenNoFlush()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand), "Hand with no flush is valid flush");
        }

        [Test]
        public void CheckIsHandValidFlushWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand), "Hand with no flush is valid flush");
        }

        // four of a kind
        [Test]
        public void CheckIsHandValidFourOfKind()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Hearts),
				new Card(CardFace.Ace, CardSuit.Diamonds),
				new Card(CardFace.Ace, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand), "Hand with four of a kind is not valid");
        }

        [Test]
        public void CheckIsHandValidFourOfKindWhenNoFourOfKind()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand), "Hand with no 4ofKind is valid 4ofKind");
        }

        [Test]
        public void CheckIsHandValidFourOfKindWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand), "Hand with no 4ofKind is valid 4ofKind");
        }

        // full house
        [Test]
        public void CheckIsHandValidFullHouse()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Hearts),
				new Card(CardFace.Queen, CardSuit.Diamonds),
				new Card(CardFace.Queen, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFullHouse(hand), "Hand with FullHouse is not valid");
        }

        [Test]
        public void CheckIsHandValidFullHouseWhenNoFullHouse()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand), "Hand with no FullHouse is valid FullHouse");
        }

        [Test]
        public void CheckIsHandValidFullHouseWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand), "Hand with no FullHouse is valid FullHouse");
        }

        // straight
        [Test]
        public void CheckIsHandValidStraight()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Five, CardSuit.Clubs),
				new Card(CardFace.Six, CardSuit.Hearts),
				new Card(CardFace.Seven, CardSuit.Diamonds),
				new Card(CardFace.Nine, CardSuit.Spades),
				new Card(CardFace.Eight, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraight(hand), "Hand with Straight is not valid");
        }

        [Test]
        public void CheckIsHandValidStraightWhenNoStraight()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand), "Hand with no Straight is valid Straight");
        }

        [Test]
        public void CheckIsHandValidStraightWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand), "Hand with no Straight is valid Straight");
        }

        // 3ofAKind
        [Test]
        public void CheckIsHandValidThreeOfKind()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Seven, CardSuit.Hearts),
				new Card(CardFace.Seven, CardSuit.Diamonds),
				new Card(CardFace.Seven, CardSuit.Spades),
				new Card(CardFace.Ace, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsThreeOfAKind(hand), "Hand with ThreeOfKind is not valid");
        }

        [Test]
        public void CheckIsHandValidThreeOfKindWhenNoThreeOfKind()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand), "Hand with no ThreeOfKind is valid ThreeOfKind");
        }

        [Test]
        public void CheckIsHandValidThreeOfKindWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand), "Hand with no ThreeOfKind is valid ThreeOfKind");
        }

        // pair
        [Test]
        public void CheckIsHandValidPair()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Seven, CardSuit.Hearts),
				new Card(CardFace.Seven, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Spades),
				new Card(CardFace.Ace, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsOnePair(hand), "Hand with Pair is not valid");
        }

        [Test]
        public void CheckIsHandValidPairWhenNoPair()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand), "Hand with no Pair is valid Pair");
        }

        [Test]
        public void CheckIsHandValidPairWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand), "Hand with no Pair is valid Pair");
        }

        // two pairs
        [Test]
        public void CheckIsHandValidTwoPairs()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Seven, CardSuit.Hearts),
				new Card(CardFace.Seven, CardSuit.Diamonds),
				new Card(CardFace.King, CardSuit.Spades),
				new Card(CardFace.Ace, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsTwoPair(hand), "Hand with TwoPairs is not valid");
        }

        [Test]
        public void CheckIsHandValidTwoPairsWhenNoTwoPairs()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand), "Hand with no TwoPairs is valid TwoPairs");
        }

        [Test]
        public void CheckIsHandValidTwoPairsWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand), "Hand with no TwoPairs is valid TwoPairs");
        }

        // high card
        [Test]
        public void CheckIsHandValidHighCard()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Seven, CardSuit.Hearts),
				new Card(CardFace.Six, CardSuit.Diamonds),
				new Card(CardFace.King, CardSuit.Spades),
				new Card(CardFace.Two, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsHighCard(hand), "Hand with HighCard is not valid");
        }

        [Test]
        public void CheckIsHandValidHighCardWhenNoHighCard()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsHighCard(hand), "Hand with no HighCard is valid HighCard");
        }

        [Test]
        public void CheckIsHandValidHighCardWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsHighCard(hand), "Hand with no HighCard is valid HighCard");
        }

        // straight flush
        [Test]
        public void CheckIsHandValidStraightFlush()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.Queen, CardSuit.Clubs),
				new Card(CardFace.Jack, CardSuit.Clubs),
				new Card(CardFace.Ten, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraightFlush(hand), "Hand with StraightFlush is not valid");
        }

        [Test]
        public void CheckIsHandValidStraightFlushWhenNoStraightFlush()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Clubs),
				new Card(CardFace.King, CardSuit.Diamonds),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand), "Hand with no StraightFlush is valid StraightFlush");
        }

        [Test]
        public void CheckIsHandValidStraightFlushWhenCardsAreNotFive()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Four, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand), "Hand with no StraightFlush is valid StraightFlush");
        }
    }
}
