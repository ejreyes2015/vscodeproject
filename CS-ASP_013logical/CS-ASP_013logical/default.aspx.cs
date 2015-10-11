using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013logical
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            comparisonTypeLabel.Text = "equal to ";
            //comparisonTypeLabel.Text = "not equal to ";
            //comparisonTypeLabel.Text = "not equal to ";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";

            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";


            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);

            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";

            //resultLabel.Text = (CheckBox1.Checked) ? "Yes" : "No";

            //resultLabel.Text = (!CheckBox1.Checked) ? "No" : "Yes";
            /*the statement is looking for the opposite 
             the checkBox1.Checked returns a true value when the box
            is checked but with the ! it is looking for the box not to be checked
            */

            /*
            if (CheckBox1.Checked 
                && firstTextBox.Text == "Bob" 
                && secondTextBox.Text == "Tabor")
                //logical and --> && states all situations have to be true
            {
                resultLabel.Text = "Perfect trifecta";
            }
            */

            /*
            if (CheckBox1.Checked
                || firstTextBox.Text == "Bob"
                || secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "one out of three isnt bad";
            }
            */

            /*
            if (CheckBox1.Checked
                || firstTextBox.Text == "Bob"
                && secondTextBox.Text == "Tabor")
                //and has higher priority than the or
            {
                resultLabel.Text = "two out of three isnt bad";
            }
            */

            if ((CheckBox1.Checked
                || firstTextBox.Text == "Bob")
                && secondTextBox.Text == "Tabor")
                //and has higher priority than the or
                //add () around what you want to group together to change priority 
                //above the checkox has to be checked or Bob has to be in the first text box 
                   // AND ALWAYS Tabor in the second box
            {
                resultLabel.Text = "two out of three isnt bad";
            }
        }
    }
}