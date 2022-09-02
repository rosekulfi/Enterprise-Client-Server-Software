using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //clear button will clear both the textboxes and any error message
        protected void clearButton_Click(object sender, EventArgs e)
        {
            fahTextBox.Text = "";
            celTextBox.Text = "";
            errorMsg.Text = "";
        }

        //convert button will convert the temperature
        protected void convertButton_Click(object sender, EventArgs e) 
        {
            //if neither textbox has text, throw error "Enter one value."
            if (fahTextBox.Text == "" && celTextBox.Text == "")
            {
                errorMsg.Text = "Enter one value.";

            }

            //if both textboxes have text, throw error "Enter one value."
            else if (fahTextBox.Text != "" && celTextBox.Text != "") 
            {
                errorMsg.Text = "Enter one value.";   
            }

            //if only one textbox has text and it is not a float, throw error "Please enter a correct value."
            else if (fahTextBox.Text != "" && celTextBox.Text == "") 
            {
                float i = 0;
                string s = fahTextBox.Text;
                bool result = float.TryParse(s, out i);

                if(result == false) 
                {
                    errorMsg.Text = "Please enter a correct value.";
                }
                else if(result == true) 
                {
                    errorMsg.Text = "";
                    //float k = 5 / 9;
                    float j = (i - 32F) * (5F/9F);
                    celTextBox.Text = j.ToString();
                }
            }
            else if (fahTextBox.Text == "" && celTextBox.Text != "") 
            {
                float i = 0;
                string s = celTextBox.Text;
                bool result = float.TryParse(s, out i);

                if(result == false) 
                {
                    errorMsg.Text = "Please enter a correct value";
                }
                else if(result == true) 
                {
                    errorMsg.Text = "";
                    float j = i * (9F/5F) + 32F;
                    fahTextBox.Text = j.ToString();
                }
            }

        }

    }
}