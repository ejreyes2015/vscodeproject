using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeRadioButton
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "Way to be old school graphite";
                resultImage.ImageUrl = "Images/pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "Way to be old school ink";
                resultImage.ImageUrl = "Images/pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "How do you take notes on your phone?";
                resultImage.ImageUrl = "Images/phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "Do you have a keyboard for your tablet?";
                resultImage.ImageUrl = "Images/tablet.png";
            }
            else
            {
                resultLabel.Text = " You really need to make a choice";
            }
        }
    }
}