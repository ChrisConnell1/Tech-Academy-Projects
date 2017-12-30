using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_019_Challenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                // initializes calendars to their dates
                firstCalendar.SelectedDate = DateTime.Today;

                secondCalendar.SelectedDate = DateTime.Today.AddDays(14);
                secondCalendar.VisibleDate = DateTime.Today.AddDays(14);
                //Selected and visible to ensure it appears correctly even if into a different month.
                thirdCalendar.SelectedDate = DateTime.Today.AddDays(21);
                thirdCalendar.VisibleDate = DateTime.Today.AddDays(21);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string result = "";
            double total = 0;
            

            // if new assignment is less than 2 weeks from old, produce error
            //if more than 2 weeks, allow
            double timeOff = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate).TotalDays;
            double timeAssignment = thirdCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays;

            if (timeAssignment > 21) // This gives the bonus $1000 if the assignment is longer than 3 weeks
                total += 1000;

            total += 500 * timeAssignment; //This gives the standard 500/day.

            result += "The agent " + codeName.Text + " will be assigned to the mission " + assignmentName.Text + " with a budget of $" + total;

            resultLabel.Text = result;

            //This will determine if there are 2 weeks between the previous end date (today) and the next assignment start date.
            if (timeOff < 13)
            {
                resultLabel.Text = "Error!! You MUST allow the agent 2 full weeks off! Please select a date which is 2 weeks out from last assignment.";
                secondCalendar.SelectedDate = firstCalendar.SelectedDate.AddDays(14);
            }
        }
    }
}