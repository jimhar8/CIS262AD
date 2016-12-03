using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:     CS8 Queue Processing
//Programmer:  Jim Harris
//Description: Declare and load a string Queue of names.
//             The user can sort the queue by name and search by name.
//             Names can be deleted from the top of the list.


using System.IO;  // FileStream and StreamReader

namespace CS8
{
    public partial class CS8Form : Form
    {
        public CS8Form()
        {
            InitializeComponent();
        }

        //Declare class-level Queue
        Queue<string> cstrName = new Queue<string>();


        private void CS8Form_Load(object sender, EventArgs e)
        {
            //use a try catch to load the names from the file cs8.txt 

            try
            {

                FileStream nameFile = new FileStream("cs8.txt", FileMode.Open);
                StreamReader nameStreamReader = new StreamReader(nameFile);

                while (nameStreamReader.Peek() != -1)
                {
                    cstrName.Enqueue(nameStreamReader.ReadLine());
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

            //Listboxes need to be cleared because this procedure is also
            //called to redisplayed the data
            lstName.Items.Clear();

            //Use a foreach statement to process the Queue
            foreach (string strName in cstrName)
            {
                lstName.Items.Add(strName);
            } 
        }

 
        private void btnSortByName_Click(object sender, EventArgs e)
        {

            /*
            btnSortByName does NOT need to be implemented, because there isn't a sort method for queues.
            However if the student desires to implement the option consider the following:

                Copy the Queue into an an Array using ToArray or CopyTo.
                Sort the array as shown in CS7 Arrays
                Clear the existing Queue.
                Enqueue the items in the sorted array back into the Queue.
            */

            // Jim Harris - went ahead and implemented sort

            int i;
            int i2;
            string strHoldValue;
            string strMinName;
            int intMinSubscript;

            string[] cstrArrayName = cstrName.ToArray();
            int cintNumberOfNames = cstrArrayName.Length;

            //outer loop keeps track of where the next value
            //should be placed.
            for (i = 0; i < cintNumberOfNames - 1; i++)
            {
                intMinSubscript = i;
                strMinName = cstrArrayName[i];

                //inner loop finds the lowest value to move up
                for (i2 = i + 1; i2 < cintNumberOfNames; i2++)
                {
                    //Only == and != can be used with strings, use CompareTo 
                    if (cstrArrayName[i2].CompareTo(strMinName) < 0)
                    {
                        //save the new low value found
                        strMinName = cstrArrayName[i2];
                        intMinSubscript = i2;
                    }
                }//next i2 

                strHoldValue = cstrArrayName[i];
                cstrArrayName[i] = cstrArrayName[intMinSubscript];
                cstrArrayName[intMinSubscript] = strHoldValue;

            }//next i

            cstrName.Clear();

            foreach (string item in cstrArrayName)
            {
                cstrName.Enqueue(item);
            }            

            //display names in list box
            displayNames();

  
        }


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            //delcare int variable to use as the index for the list box 
            int intIndex;

            //Use an if statement with the Contains method to check if the name in the search box is in the queue
            //In the else display a message that the name is not in the list.           

            if (cstrName.Contains(txtSearchName.Text))
            {

                //If Contains is true
                //Initialize intIndex to zero
                //Use foreach to walk through queue

                intIndex = 0;

                //Inside foreach, use an if statement to check if the item matches the name in the search box.
                //If a match is found use intIndex to select the matching entry in listbox and 
                //display a message indicating the name was found.

                foreach (string item in cstrName)
                {
                    if (item == txtSearchName.Text)
                    {
                        txtSearchResults.Text = "Matching name is selected in list box.";
                        lstName.SelectedIndex = intIndex;
                        break;
                        
                    }

                    intIndex++;
                }
                
            }
            else
            {
                txtSearchResults.Text = "Match not found";
            }                       
   
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If the Count is > 0 Dequeue the first item and redisplay names in list box
            if (cstrName.Count > 0)
            {
                cstrName.Dequeue();
            }

            //display names in list box
            displayNames();
 
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }//end of class
}//end of namespace
