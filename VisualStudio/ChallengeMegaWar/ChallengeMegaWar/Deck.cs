using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaWar
{
    public class Deck
    {
        public List<Card> Cards { get; set; }  // A deck is just that, a list of cards, right?

        public void PopulateDeck()
        {
            Cards = new List<Card>();

            string[] Suit = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] Value = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                // Don't think we have to hard code every card...
                //Create loop that adds a new card to the deck until it has 52 cards.
                //How can we set values to the new card within loop?
                for (int i = 0; i < Suit.Length; i++)
                {
                    for (int j = 0; j < Value.Length; j++)
                    {

                        Card singleCard = new Card()
                        {
                        CardSuit = Suit[i],
                        CardFaceValue = Value[j],
                        CardNumberValue = j + 2  // Index 0 is deuce, index 1 is "3", etc etc.
                        };

                        Cards.Add(singleCard);

                    }
                }
          }

        public string DealDeck(Deck MainDeck, Player player1, Player player2, Random random)
        {
            int i = 0; // This is a counter variable for the foreach.
            string result = "";

            foreach (Card Card in MainDeck.Cards.OrderBy(x => random.Next()))  //Found this snippet on StackOverflow for randomizing the order of the foreach.
            {
                if (i % 2 == 0)  // This will split the cards between the two players
                {
                    i++;
                    player1.PlayerDeck.Cards.Add(Card);
                    result += String.Format("{0} of {1} to player 1<br />", Card.CardFaceValue, Card.CardSuit);
                }

                else
                {
                    i++;
                    player2.PlayerDeck.Cards.Add(Card);
                    result += String.Format("{0} of {1} to player 2<br />", Card.CardFaceValue, Card.CardSuit);
                }
            }

            return result;
        }        
      }

}
