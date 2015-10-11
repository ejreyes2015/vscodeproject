using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012ternary
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";
            //? is called the  - it returns the value of a boolean expression
            // condition ? first_expression(if condition met do this) : second_expression (if condition NOT met do this) (MSDN)

            /*
            resultLabel.Text = (oldCheckBox.Checked)
                ? "I'm teaching an old dog new tricks"
                : "Young whippersnapper! Get off my lawn!";
            //initial condition of the checked box is false
            //oldCheckBox.Checked - stating if oldCheckBox is checked aka true 
            */

            int result = (firstTextBox.Text == secondTextBox.Text) ? 100 : 50;
            // if the two text boxes are evaluated true then result is 100 otherwise it's 50

            resultLabel.Text = result.ToString();

        }
    }
}