using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_014_Challenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            //reset the total to 0 each click
            double total = 0.00;

            //assign initial price based on pizza size
            if (babyBob.Checked)
                total += 10;
            else if (momBob.Checked)
                total += 13;
            else if (popBob.Checked)
                total += 16;

            if (deepDish.Checked)
                total += 2;

            if (pepperoniBox.Checked)
                total += 1.5;
            if (onionBox.Checked)
                total += .75;
            if (greenBox.Checked)
                total += .5;
            if (redBox.Checked)
                total += .75;
            if (anchoviesBox.Checked)
                total += 2;

            if ((pepperoniBox.Checked && greenBox.Checked && anchoviesBox.Checked) || pepperoniBox.Checked && redBox.Checked && onionBox.Checked)
               total = total - 2;

            totalLabel.Text = total.ToString();



        }
    }
}