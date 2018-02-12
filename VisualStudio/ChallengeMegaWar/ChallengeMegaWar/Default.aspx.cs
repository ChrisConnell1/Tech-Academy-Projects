using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeMegaWar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Game Game = new Game();
            Battle Battle = new Battle();

            Deck MainDeck = new Deck();  // Instantiate the main deck, now populate deck.

            Random random = new Random();

            MainDeck.PopulateDeck();
            // After populating, can randomly distribute between 2 players

            //Each Player object has the property of a Deck, which has the property of a List<Card>
            Player player1 = new Player() { PlayerDeck = new Deck() { Cards = new List<Card>() } };
            Player player2 = new Player() { PlayerDeck = new Deck() { Cards = new List<Card>() } };


            //Now deal the deck between the two players
            resultLabel.Text += MainDeck.DealDeck(MainDeck, player1, player2, random);


            // Players both have 2 decks now, containing 26 random cards.
            // Now need to pit each card against each other, determining who wins the bounty.


            for (int j = 0; j < 15; j++) // Cannot foreach this, because the size of collection will change! So just go for a determined amount of rounds.
            {
                resultLabel.Text += Game.moveBounty(player1, player2, j);  //Pass in j, which will be the loop counter and also the collection member index.
            }

            resultLabel.Text += Game.endGame(player1, player2);
           
           


        }
    }
}