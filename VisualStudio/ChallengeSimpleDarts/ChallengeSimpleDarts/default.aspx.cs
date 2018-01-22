using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public void okButton_Click(object sender, EventArgs e)
        {
            Dart dart = new Dart();
            Game game = new Game();
            
            game.ThreeHundred(dart);
            int doubleBand = dart.DoubleBand;
            int tripleBand = dart.TripleBand;

            resultLabel.Text = "";
            resultLabel.Text += String.Format("Player 1 score:{0} <br />Player 2 score:{1}<br />Player 1 Wins?: {2}<br />Number of double bands: {3}<br />Number of triple bands: {4}",
                game.playerOneScore,
                game.playerTwoScore,
                game.Player1Wins,
                doubleBand,
                tripleBand);

        }


        public class Game
        {

            public int playerOneScore { get; set; }
            public int playerTwoScore { get; set; }
            public bool Player1Wins { get; set; }


            public void ThreeHundred(Dart dart)
            {
                
                while (playerOneScore <= 300 && playerTwoScore <= 300)
                {
                    // Add score to players until 1 reaches 300.
                  
                    Random DartThrow = new Random();

                    dart.Throw(DartThrow.Next(0, 20));
                    playerOneScore += dart.Score;

                    dart.Throw(DartThrow.Next(0, 20));
                    playerTwoScore += dart.Score;

                }


                if (playerOneScore > playerTwoScore)
                    Player1Wins = true;
                else Player1Wins = false;
               
            }

        }
    }
}