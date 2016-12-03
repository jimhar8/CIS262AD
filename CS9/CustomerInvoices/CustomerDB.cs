using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CustomerInvoices
{
    // This class definition is already complete

    public static class CustomerDB
    {
        //@ stands for verbatim.
        //private const string Dir = @"C:\C# 2010\Files\";  File included in project folder
        private const string Dir = @""; 
        private const string Path = Dir + "CustomersX23.txt";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.CustomerID = Convert.ToInt32(columns[0]);
                customer.Name = columns[1];
                customers.Add(customer);
            }

            textIn.Close();
            return customers;
        }
    }
}
