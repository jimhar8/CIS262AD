using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:     CS7 List Processing
//Programmer:  Jim Harris
//Description: Declare and load a string List of names.
//             The user can sort the list by name and search by name.
//             Names can be deleted from the top of the list.


using System.IO;  // FileStream and StreamReader

namespace CS7
{
    public partial class CS7Form : Form
    {
        public CS7Form()
        {
            InitializeComponent();
        }

        //Declare class-level List
        List<string> cstrName = new List<string>();

        private void CS7Form_Load(object sender, EventArgs e)
        {
            //use a try catch to load the names from the file cs7.txt
            try
            {

                FileStream nameFile = new FileStream("cs7.txt", FileMode.Open);
                StreamReader nameStreamReader = new StreamReader(nameFile);

                while (nameStreamReader.Peek() != -1)
                {
                    cstrName.Add(nameStreamReader.ReadLine());
                }

                nameFile.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening file " + ex.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

 
            //display names in list box
            displayNames();  
        }


        void displayNames()
        {
            int i;

            //Listboxes need to be cleared because this procedure is also
            //called to redisplayed the data
            lstName.Items.Clear();

            //Use cstrName.Count to control loop
            for (i = 0; i < cstrName.Count; i++)
            {
                lstName.Items.Add(cstrName[i]);
            }

        }


        private void btnSortByName_Click(object sender, EventArgs e)
        {
            //Sort by name using the Sort method

            cstrName.Sort();

            //display names in list box
            displayNames();
        }


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            //delcare int variable to store the result returned by BinarySearch 
            int intIndex;

            //Call btnSortByName_Click() to sort and redisplay arrays
            btnSortByName_Click(sender, e);

            //Search using BinarySearch, and save result returned by the method
            //-1 returned if match not found else the zero-based index of the element is returned

            intIndex = cstrName.BinarySearch(txtSearchName.Text);


            //If a match was found select the matching name in the list box and display name found message
            //else just display a message that the name was not found. 

            if (intIndex >= 0)
            {
                txtSearchResults.Text =  "Matching name is selected in list box.";
                lstName.SelectedIndex = intIndex;
                
            }
            else
            {
                txtSearchResults.Text = "Match not found";
            }
 
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If the Count is > 0 remove the first item and redisplay names in list box
           {

               if (cstrName.Count > 0)
               {
                   cstrName.RemoveAt(0);
               }
                
                //display names in list box
                displayNames();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }//end of class
}//end of namespace
