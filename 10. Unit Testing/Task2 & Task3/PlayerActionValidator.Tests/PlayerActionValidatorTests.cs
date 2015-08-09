using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Santase.Logic.Players;
using Santase.Logic.Cards;
using Santase.Logic;
using Santase.ConsoleUI;
using Santase.Logic.RoundStates;

namespace PlayerActionValidator.Tests
{
    [TestFixture]
    public class PlayerActionValidatorTests
    {
        [Test]
        public void CheckPlayerGivesCardThatIsNotInHisHand()
        {
            // playerAction
            Card card = new Card(CardSuit.Heart, CardType.King);
            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, card, Announce.None);

            // Context
            var playerOne = new ConsolePlayer(5, 10);
            var playerTwo = new ConsolePlayer(10, 10);
            var round = new GameRound(playerOne, playerTwo, PlayerPosition.NoOne);
            var state = new StartRoundState(round);
            Card trumpCard = new Card(CardSuit.Spade, CardType.Jack);
            PlayerTurnContext context = new PlayerTurnContext(state, trumpCard, 10);

            // playerCards
            var cards = new List<Card>();

            PlayerActionValidater validator = new PlayerActionValidater();
            var isValid = validator.IsValid(action, context, cards);

            Assert.IsFalse(isValid, "Player can play a card that is not in his hand");
        }

        [Test]
        public void CheckPlayerGivesCardThatIsInHisHandStartRoundState()
        {
            // playerAction
            Card card = new Card(CardSuit.Heart, CardType.King);
            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, card, Announce.None);

            // Context
            var playerOne = new ConsolePlayer(5, 10);
            var playerTwo = new ConsolePlayer(10, 10);
            var round = new GameRound(playerOne, playerTwo, PlayerPosition.NoOne);
            var state = new StartRoundState(round);
            Card trumpCard = new Card(CardSuit.Spade, CardType.Jack);
            PlayerTurnContext context = new PlayerTurnContext(state, trumpCard, 10);

            // playerCards
            var cards = new List<Card>();
            cards.Add(card);
            playerOne.AddCard(card);

            PlayerActionValidater validator = new PlayerActionValidater();
            var isValid = validator.IsValid(action, context, cards);

            Assert.IsTrue(isValid, "Player can't play a card that is in his hand");
        }

        [Test]
        public void CheckPlayerGivesCardThatIsInHisHandMoreThanTwoCardsLeftRoundState()
        {
            // playerAction
            Card card = new Card(CardSuit.Heart, CardType.King);
            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, card, Announce.Twenty);

            // Context
            var playerOne = new ConsolePlayer(5, 10);
            var playerTwo = new ConsolePlayer(10, 10);
            var round = new GameRound(playerOne, playerTwo, PlayerPosition.NoOne);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            Card trumpCard = new Card(CardSuit.Spade, CardType.Jack);
            PlayerTurnContext context = new PlayerTurnContext(state, trumpCard, 10);

            // playerCards
            var cards = new List<Card>();
            cards.Add(card);
            playerOne.AddCard(card);

            PlayerActionValidater validator = new PlayerActionValidater();
            var isValid = validator.IsValid(action, context, cards);

            Assert.IsTrue(isValid, "Player can't play a card that is in his hand");
        }
    }
}
