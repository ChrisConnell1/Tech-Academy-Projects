using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //When event happens start calculateVolume()
            //Multiply width * height * length
            //Then send the volume variable as a parameter into totalCost()
        }


        protected void handleChange(object sender, EventArgs e)
        {
            performChanged();
        }

        private void performChanged()
        {//Do the numbers in the text and check boxes exist?
            if (!valuesExist()) return;
            //What is the volume?
            int volume = 0;
            if (!tryGetVolume(out volume)) return;

            //What is the multiplier?
            double postageMultiplier = getPostageMultiplier();

            double cost = volume * postageMultiplier;
            //Show user
            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
        }

        

        private bool valuesExist()
        {
            if (!airRadio.Checked && !groundRadio.Checked && !nextDayRadio.Checked)
                return false;
            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0)
                return false;
            return true;
        }


          private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width))
                return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height))
                return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;

            return true;
        }

        private double getPostageMultiplier()
        {
            if (groundRadio.Checked) return .15;
            else if (airRadio.Checked) return .25;
            else if (nextDayRadio.Checked) return .45;
            else return 0;
        }


    } 
}