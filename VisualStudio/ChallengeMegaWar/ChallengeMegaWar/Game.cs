using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaWar
{
    public class Game
    {
        public string moveBounty(Player player1, Player player2, int j)
        {
            // This is to make the rest easier to read. These card instances represent the current played card.
            Card p1Card = player1.PlayerDeck.Cards.ElementAt(j);
            Card p2Card = player2.PlayerDeck.Cards.ElementAt(j);
            Battle Battle = new Battle();

            if (p1Card.CardNumberValue > p2Card.CardNumberValue)  //If player1 card > player2 card, player 1 adds player 2s card, and player 2 deletes theirs.
            {
                player1.PlayerDeck.Cards.Add(p2Card);
                player2.PlayerDeck.Cards.RemoveAt(j);

                return String.Format("<br /><br />Player 1 wins! The {0} of {1} beats the {2} of {3}<br />{4} -- {5}<br />",
                    p1Card.CardFaceValue,
                    p1Card.CardSuit,
                    p2Card.CardFaceValue,
                    p2Card.CardSuit,
                    player1.PlayerDeck.Cards.Count,
                    player2.PlayerDeck.Cards.Count);
                //Return a string that tells what happened
            }

            else if (p2Card.CardNumberValue > p1Card.CardNumberValue)  //Same thing here
            {
                player2.PlayerDeck.Cards.Add(player1.PlayerDeck.Cards.ElementAt(j));
                player1.PlayerDeck.Cards.RemoveAt(j);
                return String.Format("<br /><br />Player 2 wins! The {0} of {1} beats the {2} of {3}<br />{4} -- {5}",
                    p2Card.CardFaceValue,
                    p2Card.CardSuit,
                    p1Card.CardFaceValue,
                    p1Card.CardSuit,
                    player1.PlayerDeck.Cards.Count,
                    player2.PlayerDeck.Cards.Count);

            }



           
            else //Special case: WAR!
            {
               string warText = Battle.War(player1.PlayerDeck, player2.PlayerDeck, p1Card, p2Card, j);
                return String.Format("<br /><br />WAR! Between the {0} of {1} and the {2} of {3}!<br /><br />{4}", p1Card.CardFaceValue, p1Card.CardSuit, p2Card.CardFaceValue, p2Card.CardSuit, warText);
               

            }
        }

        public string endGame(Player player1, Player player2)
        {
            string result = String.Format("<br/><br/><b>Player 1: {0}<br/> Player2: {1}<b/><br/><br/>", player1.PlayerDeck.Cards.Count, player2.PlayerDeck.Cards.Count);

            if (player1.PlayerDeck.Cards.Count > player2.PlayerDeck.Cards.Count)
            {
                result += "<br/><b>Player 1 wins!!</b>";
                return result;
            }

            else if (player2.PlayerDeck.Cards.Count > player1.PlayerDeck.Cards.Count)
            {
                result += "<br/><b>Player 2 wins!!</b>";
                return result;
            }

            else result += "<b>DRAW!!</b>";
            return result;
        }
    }
}
