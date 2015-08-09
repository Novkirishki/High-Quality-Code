// Task 2. In the Hand class implement the ToString() method
// Use Test-Driven Development (TDD)
// Test all cases
namespace Poker.Tests
{
	using NUnit.Framework;
	using System.Collections.Generic;

	[TestFixture]
    class HandTests
    {
		[Test]
		public void CheckHandToStringWithRandomCards()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Ace, CardSuit.Clubs),
				new Card(CardFace.Ten, CardSuit.Diamonds),
				new Card(CardFace.Four, CardSuit.Clubs),
				new Card(CardFace.Jack, CardSuit.Spades),
				new Card(CardFace.Queen, CardSuit.Hearts)
            });

            string handString = "Ace of Clubs, Ten of Diamonds, Four of Clubs, Jack of Spades, Queen of Hearts";
            Assert.AreEqual(handString, hand.ToString(), "Hand toString() does not works as expected");
        }

        [Test]
        public void CheckHandToStringWithOneCard()
        {
            IHand hand = new Hand(new List<ICard> { 
				new Card(CardFace.Seven, CardSuit.Hearts)
            });

            string handString = "Seven of Hearts";
            Assert.AreEqual(handString, hand.ToString(), "Hand toString() does not works as expected");
        }

        [Test]
        public void CheckHandToStringWithNoCards()
        {
            IHand hand = new Hand(new List<ICard>());

            Assert.AreEqual("No cards in hand", hand.ToString(), "Hand toString() does not works as expected");
        }
    }
}
