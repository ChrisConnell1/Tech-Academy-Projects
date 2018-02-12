using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaWar
{
    public class Battle
    {
        public string War(Deck p1Deck, Deck p2Deck, Card p1Card, Card p2Card, int j)
        {
            string result = "";
            Deck Bounty = new Deck() { Cards = new List<Card>() };

            for (int i = j; i < j + 3; i++)
            {
                // In this loop, I want to add 3 cards from each player to the bounty, and take them out of their hands.
                Bounty.Cards.Add(p1Deck.Cards.ElementAt(i));
                p1Deck.Cards.RemoveAt(i);
                Bounty.Cards.Add(p2Deck.Cards.ElementAt(i));
                p2Deck.Cards.RemoveAt(i);
            }

            // Now check the 4th card, after the 3 removed, and compare them.
            result += String.Format("<br/>Player 1 hits with a {0} of {1}, player 2 hits back with the {2} of {3}!<br/><br/>Bounty: <br/>",
                p1Deck.Cards.ElementAt(j + 4).CardFaceValue,
                p1Deck.Cards.ElementAt(j + 4).CardSuit,
                p2Deck.Cards.ElementAt(j + 4).CardFaceValue,
                p2Deck.Cards.ElementAt(j + 4).CardSuit);



            if (p1Deck.Cards.ElementAt(j + 4).CardNumberValue > p2Deck.Cards.ElementAt(j + 4).CardNumberValue)
            {
                p1Deck.Cards.AddRange(Bounty.Cards);
                foreach (Card Card in Bounty.Cards)
                {
                    result += String.Format("{0} of {1}<br />", Card.CardFaceValue, Card.CardSuit);
                }
                Bounty.Cards.Clear();
                return result + "<b>Player 1 wins war!</b><br />"; 
            }
       
          
            else
           {
                p2Deck.Cards.AddRange(Bounty.Cards);

                foreach (Card Card in Bounty.Cards)
                {
                    result += String.Format("{0} of {1}<br />", Card.CardFaceValue, Card.CardSuit);
                }
                Bounty.Cards.Clear();
                return result + "<b>Player 2 wins war!</b><br />";
            }
        }

    }
}