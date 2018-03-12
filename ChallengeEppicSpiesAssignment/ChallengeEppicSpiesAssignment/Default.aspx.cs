using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEppicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                previousCalendar.SelectedDate = DateTime.Today;
                startCalendar.SelectedDate = DateTime.Today.AddDays(14);
                endCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            Boolean vali = true;
            string error = "";
            string name = nameTextBox.Text;
            string assignment = assignmentTextBox.Text;
            DateTime previousAssEnd = previousCalendar.SelectedDate;
            DateTime startAss = startCalendar.SelectedDate;
            DateTime endAss = endCalendar.SelectedDate;

            TimeSpan preAssPeriod = startAss.Subtract(previousAssEnd);
            TimeSpan assPeriod = endAss.Subtract(startAss);

            double budget = assPeriod.Days * 500; // $500/day
            if (assPeriod.Days > 21) budget += 1000;

            string result = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C2}",
                                name, assignment, budget);

            // validate
            // Checking if Code Name or New Assignment Name is empty
            if (name == "" || assignment == "")
            {
                vali = false;
                error += "Error: Must input Spy Code Name and New Assignment Name.<br />";
            }
            // Checking if it allows more than two weeks between two assignments
            if (preAssPeriod.Days < 14)
            {
                vali = false;
                error += "Error: Must allow at least two weeks between previous assignment and new assignment.<br />";
            }
            // Checking if End Date of Assignment comes after Start Date
            if (assPeriod.Days < 1)
            {
                vali = false;
                error += "Error: End Date must comes afte Start date.";
            }
            // End validate

            resultLabel.Text = (vali) ? result : error;
                
        }

        protected void startCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime startAss = startCalendar.SelectedDate;
            DateTime endAss = endCalendar.SelectedDate;
            TimeSpan assPeriod = endAss.Subtract(startAss);
            periodLabel.Text = assPeriod.Days.ToString();
        }

        protected void endCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime startAss = startCalendar.SelectedDate;
            DateTime endAss = endCalendar.SelectedDate;
            TimeSpan assPeriod = endAss.Subtract(startAss);
            periodLabel.Text = assPeriod.Days.ToString();
        }
    }
}