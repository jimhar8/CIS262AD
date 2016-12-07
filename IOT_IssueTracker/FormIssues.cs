using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOT_IssueTracker
{
    public partial class frmIssueTracker : Form
    {
        public frmIssueTracker()
        {
            InitializeComponent();
        }

        private void issuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (issuesBindingSource.Count > 0)
            {
                if (IsValidData())
                {

                    try
                    {
                        this.issuesBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.internetOfThingsDataSet);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else // No issues
            {
                try
                {
                    this.tableAdapterManager.UpdateAll(this.internetOfThingsDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
            
        }


        // Validate data
        public bool IsValidData()
        {
            bool result = false;

            result = 
                IsPresent(statusComboBox, "Status") &&
                IsPresent(homeUserComboBox, "Home User") &&
                IsPresent(thingComboBox, "Thing") &&
                IsPresent(descriptionTextBox, "Description");

            return result;

        }

        // Ensure user filled out fields
        public bool IsPresent(Control control, string name)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox) control;  // cast to textbox

                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Operator error");
                    textBox.Focus();
                    return false;
                }
              
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {

                ComboBox comboBox = (ComboBox) control;  // cast to combobox

                if (comboBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Operator error");
                    comboBox.Focus();
                    return false;
                }

            }

            return true;
        }

        private void frmIssueTracker_Load(object sender, EventArgs e)
        {

            // Ensure all comboboxes aren't set to anything if there is no data
            statusComboBox.SelectedIndex = -1;
            homeUserComboBox.SelectedIndex = -1;
            thingComboBox.SelectedIndex = -1;

            // TODO: This line of code loads data into the 'internetOfThingsDataSet.Things' table. You can move, or remove it, as needed.
            this.thingsTableAdapter.Fill(this.internetOfThingsDataSet.Things);
            // TODO: This line of code loads data into the 'internetOfThingsDataSet.HomeUsers' table. You can move, or remove it, as needed.
            this.homeUsersTableAdapter.Fill(this.internetOfThingsDataSet.HomeUsers);
            // TODO: This line of code loads data into the 'internetOfThingsDataSet.Statuses' table. You can move, or remove it, as needed.
            this.statusesTableAdapter.Fill(this.internetOfThingsDataSet.Statuses);
            // TODO: This line of code loads data into the 'internetOfThingsDataSet.Issues' table. You can move, or remove it, as needed.
            this.issuesTableAdapter.Fill(this.internetOfThingsDataSet.Issues);           


            // All filling dataset based on Home User   
            this.homeUserToolStripComboBox.ComboBox.BindingContext = this.BindingContext;
            this.homeUserToolStripComboBox.ComboBox.DisplayMember = "Name";
            this.homeUserToolStripComboBox.ComboBox.ValueMember = "ID";
            this.homeUserToolStripComboBox.ComboBox.DataSource = internetOfThingsDataSet.Tables["HomeUsers"];

        }


        // Parameterized query by user 
        private void fillByUserToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(this.homeUserToolStripComboBox.ComboBox.SelectedValue);
                this.issuesTableAdapter.FillByUser(this.internetOfThingsDataSet.Issues, userID);

                if (issuesBindingSource.Count == 0)
                {
                    MessageBox.Show("No issues found for this User", "Not found!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error #" + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }

        }

        // Retrieve all issues into dataset
        private void toolStripButtonAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.issuesTableAdapter.Fill(this.internetOfThingsDataSet.Issues);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Database error " + ex.Number + ":" + ex.Message);
            }
        }

        // Cancel an operation
        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            this.issuesBindingSource.CancelEdit();
        }


        private void btnIssueReport_Click(object sender, EventArgs e)
        {

            FormReportViewer frm = new FormReportViewer();
            frm.Show();

        }





    }
}
