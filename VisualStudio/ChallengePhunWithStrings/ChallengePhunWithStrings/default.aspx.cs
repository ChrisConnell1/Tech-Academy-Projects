using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Reverse name so it appears "llennoC sirhC"
            string name = "Chris Connell";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }

            ReverseStarWars();


        }

        private void ReverseStarWars()
        {
            //Reverse the string to read "Chewbacca,Han,Leia,Luke"
            string names = "Luke,Leia,Han,Chewbacca";
            string reversed = "";

            string[] splitnames = names.Split(',');
            //["Luke","Leia","Han","Chewbacca"]
            //Names are now in a string array with 4 elements, now reverse the order, and turn back to string separated by a comma

            for (int i = splitnames.Length - 1; i >=0; i--)
            {
                reversed += splitnames[i] + ",";
            }

            reversed = reversed.Remove(reversed.Length - 1, 1);
            resultLabel2.Text += reversed;


            StarWarsAsciiArt();

        }

        private void StarWarsAsciiArt()
        {
            string allNames = "Luke,Leia,Han,Chewbacca";
            //Display and pad each name for a total of 14 chars, with ** filling the void

            string[] eachName = allNames.Split(',');
            //Now have an array of each name

            string result = "";
          

            for (int i = 0; i < eachName.Length; i++)
            {
                int padLeft = (14 - eachName[i].Length) / 2;
                string temp = eachName[i].PadLeft(eachName[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";

                
               
            }

            resultLabel3.Text += result;
            PuzzleSentence();

            
        }

        private void PuzzleSentence()
        {
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";

            puzzle = puzzle.ToLower().Remove(10,9).Replace('z', 't').Replace("now", "Now");

            resultLabel4.Text += puzzle;
        }
    }
}