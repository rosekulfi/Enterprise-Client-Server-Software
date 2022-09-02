using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lab5
{
    public partial class Lab5 : System.Web.UI.Page
    {
        List<string> FinalCart = new List<string>();

        //Load page with empty shopping cart and "Add to Cart" text
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["cart"] = FinalCart;
            Shopping.Text = "Add to Cart";
            AddCart.Text = "";
        }

        protected void Shopping_Click(object sender, EventArgs e)
        {
            //On click switch to "Add to Cart" and clear selection
            if(Shopping.Text == "Continue Shopping")
            {
                Shopping.Text = "Add to Cart";
                AddCart.Text = "";
                ListBox1.ClearSelection();
                return;
            }

            //On click switch FROM "Add to Cart" and view selection
            else if(Shopping.Text == "Add to Cart")
            {
                //nothing selected in listbox
                if(ListBox1.SelectedIndex == -1)
                {
                    AddCart.Text = "Please make a selection";
                }

                //something selected in listbox
                else
                {
                    string temp = ListBox1.SelectedItem.ToString();
                    FinalCart.Add(temp);
                    ListBox1.ClearSelection();
                    Shopping.Text = "Continue Shopping";
                    AddCart.Text = "Added";
                }
            }
        }

        //Display cart
        protected void ViewCart_Click(object sender, EventArgs e)
        {
            int temp = FinalCart.Count;
            for (int i = 1; i <= temp; i++)
            {
                CartList.Items.Add(FinalCart[i]);
            }
        }

        //Empty cart
        protected void EmptyCart_Click(object sender, EventArgs e)
        {
            FinalCart.Clear();
        }

        protected void CartList_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}