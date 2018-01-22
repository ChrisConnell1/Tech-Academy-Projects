using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = ageText.Text;
            string money = moneyText.Text;

            string result = "Wow, I would have expected by " + age + " " + "you would have more than $" + money + " " + "in your pocket!";

            resultLabel.Text = result;
        
        }
    }
}