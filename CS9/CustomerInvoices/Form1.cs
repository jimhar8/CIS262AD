using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerInvoices
{
    // This is the starting point for exercise 23-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string customerName = "";
            int i = 0;

            List<Invoice> invoiceList = InvoiceDB.GetInvoices();
            List<Customer> customerList = CustomerDB.GetCustomers();

            var invoices = from invoice in invoiceList
                           join customer in customerList
                           on invoice.CustomerID equals customer.CustomerID
                           orderby customer.Name, invoice.InvoiceTotal descending
                           select new
                           {
                               customer.Name,
                               invoice.InvoiceID,
                               invoice.InvoiceDate,
                               invoice.InvoiceTotal
                           };

            foreach (var invoice in invoices)
            {
                if (invoice.Name != customerName)
                {
                    lvInvoices.Items.Add(invoice.Name);
                    customerName = invoice.Name;
                }
                else
                {
                    lvInvoices.Items.Add("");
                }


                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceID.ToString());
                lvInvoices.Items[i].SubItems.Add(
                    Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());

                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("C"));

                i++;                
            }
        }
    }
}
