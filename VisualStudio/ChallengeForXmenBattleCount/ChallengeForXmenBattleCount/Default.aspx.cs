using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;
            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[largestNumberIndex])
                    { largestNumberIndex = i; }

                if (numbers[i] < numbers[smallestNumberIndex])
                    { smallestNumberIndex = i; }
            }

            result += String.Format("{0} has the most battles with a total of: {1}", names[largestNumberIndex], numbers[largestNumberIndex]);
            result += String.Format("<br />{0} has the least battles with a total of: {1}", names[smallestNumberIndex], numbers[smallestNumberIndex]);

            resultLabel.Text = result;
        }
    }
}