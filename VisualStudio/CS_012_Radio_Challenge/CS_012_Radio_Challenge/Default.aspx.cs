using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_012_Radio_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (PencilBox.Checked)
            {
                resultLabel.Text = "You selected pencil, a true classic!";
                imageResult.ImageUrl = "~/pencil.png";
            }

            else if (PenBox.Checked)
            {
                resultLabel.Text = "You selected pen, hope you don't make any mistakes!";
                imageResult.ImageUrl = "~/pen.png";
            }
            
            else if (phoneBox.Checked)
            {
                resultLabel.Text = "You selected phone, sounds like you aren't into notes!";
                imageResult.ImageUrl = "~/phone.png";
            }
            else if (tabletBox.Checked)
            {
                resultLabel.Text = "You selected tablet, how chic!";
                imageResult.ImageUrl = "~/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select one!";
                imageResult.ImageUrl = "";
            }

        }
    }
}