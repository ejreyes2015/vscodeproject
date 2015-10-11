using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011if
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ""; // setting the code to an empty text will clear out code every
                                   // time the ok button is chosen
                                   /*
                                   if (firstTextBox.Text == secondTextBox.Text)
                                   {
                                       resultLabel.Text = "Yes! they're equal!";
                                   }
                                   else
                                   {
                                       {
                                           resultLabel.Text = "No! they're NOT equal!";
                                       }
                                   }
                                   */

            /*
            if (coolCheckBox.Checked == true) 
            {
                resultLabel.Text = "yes, you are cool!";
            }
            else
            {
                resultLabel.Text = "don't be so hard on yourself";
            }
            */

            /*Checked property is already returning true or false
              if dealing with a variable or property of a control that by nature is boolean then 
              you dont have to put ==true or ==false
            */

            /*
            if (coolCheckBox.Checked) // if the box is checked otherwise goes to else
            {
                resultLabel.Text = "yes, you are cool!";
            }
            else
            {
                resultLabel.Text = "don't be so hard on yourself";
            }
            */

            //radio button below has to be under the same group name to make sure only one is choosen
            if (pizzaRadioButton.Checked)//originally the button will be unchecked aka false 
            {
                resultLabel.Text = "You must be from Chicago!";
            }
            else if (saladRadioButton.Checked)
            {
                resultLabel.Text = "You must be healthy";
            }
            else if (pbjRadioButton.Checked)
            {
                resultLabel.Text = "you must be a funb loving person";
            }
            else //else is always the last item 
            {
                resultLabel.Text = "Please select one of the options";
            }
        }

      
    }
}