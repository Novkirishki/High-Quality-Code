// Task 1. In the Card class implement the ToString() method
// Use Test-Driven Development (TDD)
// Test all cases
namespace Poker.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        [TestCase(5, 1)]
        [TestCase(6, 1)]
        [TestCase(7, 1)]
        [TestCase(8, 1)]
        [TestCase(9, 1)]
        [TestCase(10, 1)]
        [TestCase(11, 1)]
        [TestCase(12, 1)]
        [TestCase(13, 1)]
        [TestCase(14, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(5, 2)]
        [TestCase(6, 2)]
        [TestCase(7, 2)]
        [TestCase(8, 2)]
        [TestCase(9, 2)]
        [TestCase(10, 2)]
        [TestCase(11, 2)]
        [TestCase(12, 2)]
        [TestCase(13, 2)]
        [TestCase(14, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        [TestCase(4, 3)]
        [TestCase(5, 3)]
        [TestCase(6, 3)]
        [TestCase(7, 3)]
        [TestCase(8, 3)]
        [TestCase(9, 3)]
        [TestCase(10, 3)]
        [TestCase(11, 3)]
        [TestCase(12, 3)]
        [TestCase(13, 3)]
        [TestCase(14, 3)]
        [TestCase(2, 4)]
        [TestCase(3, 4)]
        [TestCase(4, 4)]
        [TestCase(5, 4)]
        [TestCase(6, 4)]
        [TestCase(7, 4)]
        [TestCase(8, 4)]
        [TestCase(9, 4)]
        [TestCase(10, 4)]
        [TestCase(11, 4)]
        [TestCase(12, 4)]
        [TestCase(13, 4)]
        [TestCase(14, 4)]
        public void CheckIfCardToStringReturnsActualValue(int face, int suit)
        {
            ICard card = new Card((CardFace)face, (CardSuit)suit);
            
            string cardString = ((CardFace)face).ToString() + " of " + ((CardSuit)suit).ToString();

            Assert.AreEqual(cardString, card.ToString(), "Card toString() does not work as expected");
        }
    }
}
