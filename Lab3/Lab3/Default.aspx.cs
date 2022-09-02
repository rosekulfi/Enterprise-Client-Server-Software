using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class Default : System.Web.UI.Page
    {
        int anagramTotal = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Swap characters in order to create new anagrams
        private string Swap(int length, string str, int frontVal, int backVal) 
        {
            char frontValCopy = str[frontVal];
            char backValCopy = str[backVal];
            string finalStr = "";

            for (int i = 0; i < length; i++) 
            {
                if(i == frontVal)
                {
                    finalStr = finalStr + backValCopy;
                }
                else if(i == backVal)
                {
                    finalStr = finalStr + frontValCopy;
                }
                else
                {
                    finalStr = finalStr + str[i];
                } 
            }

            return finalStr;
        }

        private void AnagramCalculator(string str, bool noDups, int frontVal, int backVal) 
        {
            int length = str.Length;
            if(frontVal == backVal)
            {
                //check for duplicates by searching in listbox
                if (noDups)
                {
                    ListItem temp = anagramsList.Items.FindByText(str);
                    if (temp != null) return;
                }

                anagramsList.Items.Add(str);
                anagramTotal++;
                return;
            }

            for(int i = frontVal; i <= backVal; i++)
            {
                str = Swap(length, str, frontVal, i);
                AnagramCalculator(str, noDups, frontVal + 1, backVal);
                str = Swap(length, str, frontVal, i);
            }
        }

        protected void findAnagrams_Click(object sender, EventArgs e)
        {
            //clear list box and bottom text message
            anagramsList.Items.Clear();
            anagramTotal = 0;
            bottomText.Text = "";

            //check string is between 1-6 chars
            string input = stringInput.Text;
            stringInput.Text = "";
            int inputLen = input.Length;

            if (input.Length > 6 || input.Length < 1)
            {
                bottomText.Text = "Please enter a string from 1 to 6 characters";
                return;
            }
            
            //check if checkbox is clicked
            bool noDups = elimDups.Checked;

            //find anagrams
            AnagramCalculator(input, noDups, 0, inputLen-1);

            //print out total number of anagrams and clear textbox
            bottomText.Text = anagramTotal + " anagrams found.";
        }

        protected void anagramsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}