// 100% code coverage for Deck class;)
namespace SantaseDeckClass.Tests
{
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using System;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void CheckNewDeckCardsCount()
        {
            Deck deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft, "New deck has more or less than 32 cards");
        }

        [Test]
        public void CheckIfAllCardsFromDeckAreValid()
        {
            Deck deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                var card = deck.GetNextCard();
                var suit = card.Suit;
                var type = card.Type;

                var isSuitValid = Enum.IsDefined(typeof(CardSuit), suit);
                var isTypeValid = Enum.IsDefined(typeof(CardType), type);
                var isCardValid = isSuitValid && isTypeValid;

                if (!isCardValid)
                {
                    Assert.Fail();
                }
            }
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(15)]
        [TestCase(24)]
        [TestCase(25, ExpectedException=typeof(Santase.Logic.InternalGameException))]
        public void CheckIfCardsLeftCountIsCorrect(int cardsToDraw)
        {
            Deck deck = new Deck();

            for (int i = 0; i < cardsToDraw; i++)
            {
                deck.GetNextCard();
            }

            var cardsExpectedToBeLeft = 24 - cardsToDraw;
            Assert.AreEqual(cardsExpectedToBeLeft, deck.CardsLeft, "Incorrect number of cards left");
        }

        [Test]
        public void CheckIfTrumCardIsChanged()
        {
            Deck deck = new Deck();
            var card = deck.GetNextCard();

            deck.ChangeTrumpCard(card);

            Assert.AreSame(card, deck.GetTrumpCard, "Trump card does not change");
        }
    }
}
