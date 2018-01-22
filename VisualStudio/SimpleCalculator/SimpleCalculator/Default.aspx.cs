using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstNumber.Text);
            double second = double.Parse(secondNumber.Text);

            double result = first + second;

            resultLabel.Text = result.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            double sFirst = double.Parse(firstNumber.Text);
            double sSecond = double.Parse(secondNumber.Text);

            double sResult = sFirst - sSecond;

            resultLabel.Text = sResult.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double mFirst = double.Parse(firstNumber.Text);
            double mSecond = double.Parse(secondNumber.Text);
            double mResult;

            checked
            {
               mResult = mFirst * mSecond;
            }

            resultLabel.Text = mResult.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double dFirst = double.Parse(firstNumber.Text);
            double dSecond = double.Parse(secondNumber.Text);

            double dResult;

            checked
            {
                dResult = dFirst / dSecond;
            }

            resultLabel.Text = dResult.ToString();
        }
    }
}