using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lab4
{
    public partial class Default : System.Web.UI.Page
    {
        protected const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Lab4DB.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
 
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            //set everything back to default/empty
            ErrorMsg.Text = "";
            FinConversion.Text = "";

            //find entered conversion value and check for any errors
            try
            {
                double test = Convert.ToDouble(convertFrom.Text);
            }

            catch (System.FormatException)
            {
                ErrorMsg.Text = "THe input must be a number. Please try again.";
                return;
            }
            catch (System.OverflowException)
            {
                ErrorMsg.Text = "The number is too large. Please try a smaller value.";
                return;
            }

            double input = Convert.ToDouble(convertFrom.Text);

            if(input <= 0)
            {
                ErrorMsg.Text = "Please enter a nonzero value greater than 0.";
                return;
            }

            //find conversion units and check for any errors
            if(ConvFrom_DropDown.Text == ConvTo_DropDown.Text)
            {
                ErrorMsg.Text = "Please choose two different conversion units.";
                return;
            }

            //access database and get factor data
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DataRow row = dv.Table.Rows[ConvFrom_DropDown.SelectedIndex];
            string temp = Convert.ToString(row["Factor"]);
            double startingFactor = Convert.ToDouble(temp); //TO BE MULTIPLIED//

            row = dv.Table.Rows[ConvTo_DropDown.SelectedIndex];
            temp = Convert.ToString(row["Factor"]);
            double endingFactor = Convert.ToDouble(temp); //TO BE DIVIDED//

            double fin = (input * startingFactor) / endingFactor;
            FinConversion.Text = "" + fin;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
 
        }
    }
}