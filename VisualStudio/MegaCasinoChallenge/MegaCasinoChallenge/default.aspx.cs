using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if (!Page.IsPostBack)
            {
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }
        }


        //EVERYTHING WORKS EXCEPT VIEWSTATE???

        int bet =  0;
        protected void leverButton_Click(object sender, EventArgs e)
        {
            if (betAmountTextBox.Text == "")
                return;
            bet = int.Parse(betAmountTextBox.Text); 

            string image1 = SelectNameForReel();
            string image2 = SelectNameForReel();
            string image3 = SelectNameForReel();
            resultLabel.Text = image1 + ", " + image2 + ", & " + image3;

            SelectImageForReel(image1, image2, image3);

            
        }

        Random random = new Random();  //This is outside each function, otherwise all images are the same!

        protected string SelectNameForReel()
        {
            // This will generate a random NAME of image
            string[] images = new string[12] { "Strawberry", "Bar", "Lemon", "Clover", "Bell", "Diamond", "HorseShoe", "Cherry", "Orange", "Plum", "Seven", "Watermelon" };
            return images[random.Next(0, 12)];
        }


        private void SelectImageForReel(string image1, string image2, string image3)
        {
            //This function takes in the value of string1, hopefully to return a picture that will be the value of reel 1.
            // This can match the name of image to the image itself! And doesn't require to know which one was chosen!
            Reel1Image.ImageUrl = image1 + ".png";
            Reel2Image.ImageUrl = image2 + ".png";
            Reel3Image.ImageUrl = image3 + ".png";

            DetermineValueOfSpin(image1, image2, image3);
            //Now let's pass the values into a value function to see how much this spin is worth.


        }

        private void DetermineValueOfSpin(string image1, string image2, string image3)
        {
            if (DoesBarExist(image1, image2, image3) == true)
                return;
            ///Is there a bar at all? If so, we don't care about cherries.

            else  //If no bar, let's check for cherries and jackpot.
            {
                int TotalCherries = DoesCherryExist(image1, image2, image3); //Is there and how many cherries?
                resultLabel.Text += String.Format("<br />Number of cherries: {0}", TotalCherries);
                DoesJackpotExist(image1,image2,image3);
            }
         }



        protected bool DoesBarExist(string image1, string image2, string image3)
        {
            string[] barCheck = new string[] { image1, image2, image3 };

            if (barCheck.Contains("Bar"))
            {
                BarEndText();  //If the roll contains a bar, the win will be 0 regardless, so exit to bar end screen.
                return true;
            }
            else return false; // If the roll does not contain bar, a win is still possible.
        }


        protected void BarEndText()  //If bar was rolled, this is the end of the line.
        {
            resultLabel.Text += "<br />You rolled a bar, you lose! Better luck next time!";
            //Affect wallet here
            return;
        }

        protected int DoesCherryExist(string image1, string image2, string image3)
        {
            //This function will iterate through the reels and determine how many, if any, cherries were rolled.
            int CherryCount = HowManyOfThisInArray(image1, image2, image3, "Cherry");
            SetNewMoneyTotal("Cherry", bet, CherryCount);
            return CherryCount;

        }

        private void DoesJackpotExist(string image1, string image2, string image3)
        {
            int SevenCount = HowManyOfThisInArray(image1, image2, image3, "Seven");
            if (SevenCount == 3)
            {
                resultLabel.Text += "<br />JACKPOT!!";
                SetNewMoneyTotal("Jackpot", bet);
            }
            else return;
        }

        //This will pass in values to determine if there are cherries or 7s, BAR is boolean so is its own function.
        private int HowManyOfThisInArray(string image1, string image2, string image3, string CherryOrSeven)
        {
            string[] CountCheck = new string[] { image1, image2, image3 };
            int Count = 0;

            for (int i = 0; i < CountCheck.Length; i++)
            {
                if (CountCheck[i] == CherryOrSeven)
                    Count++;
            }

            return Count;
        
        }



        private void SetNewMoneyTotal(string WinCondition, int bet, int HowMany = 0)
        {
            int TotalMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            ViewState["PlayersMoney"] = TotalMoney;
            
            TotalMoney -= bet;
            if (WinCondition == "Jackpot")
                TotalMoney += bet * 100;
            else if (WinCondition == "Cherry")
                if (HowMany == 1)
                    TotalMoney += bet * 2;
                else if (HowMany == 2)
                    TotalMoney += bet * 3;
                else if (HowMany == 4)
                    TotalMoney += bet * 4;

            moneyLabel.Text = String.Format("Players money: {0:C}", TotalMoney);
  
        }

        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

       
    }    
        
}