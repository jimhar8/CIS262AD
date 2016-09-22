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

namespace CustomerInvoiceDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }


        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(
                    customerIDToolStripTextBox.Text);

                this.customersTableAdapter.FillByCustomerID(
                    this.mMABooksDataSet.Customers, customerID);

                if (customersBindingSource.Count > 0)
                {
                    this.invoicesTableAdapter.FillByCustomerID(
                        this.mMABooksDataSet.Invoices, customerID);
                }
                else
                    MessageBox.Show("No customer found with this ID. "
                        + "Please try again.", "Customer Not Found");


                this.customersTableAdapter.FillByCustomerID(this.mMABooksDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be an integer.", "Entry error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }


    }
}
