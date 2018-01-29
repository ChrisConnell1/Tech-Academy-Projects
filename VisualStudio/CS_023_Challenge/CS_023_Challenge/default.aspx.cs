using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_023_Challenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] elections = new double[0];
                ViewState.Add("Elections", elections);

                double[] acts = new double[0];
                ViewState.Add("Acts", acts);

                string[] name = new string[0];
                ViewState.Add("Name", name);
            }
        }

        protected void addAsset_Click(object sender, EventArgs e)
        {

            double[] elections = (double[])ViewState["Elections"];
            double[] acts = (double[])ViewState["Acts"];
            string[] name = (string[])ViewState["Name"];

            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);
            Array.Resize(ref name, name.Length + 1);

            int newestItem = name.GetUpperBound(0);

            name[newestItem] = assetNameBox.Text;
            elections[newestItem] = double.Parse(electionsRiggedBox.Text);
            acts[newestItem] = double.Parse(actsPerformedBox.Text);

            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;
            ViewState["Name"] = name;

            resultLabel.Text = String.Format("Total elections rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />Last added asset: {2}"
                , elections.Sum(),
                acts.Average(),
                name[newestItem]);

            assetNameBox.Text = "";
            electionsRiggedBox.Text = "";
            actsPerformedBox.Text = "";


        }
    }
}