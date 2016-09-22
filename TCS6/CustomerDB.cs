using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CustomerMaintenance
{
    class CustomerDB
    {

        public static Customer GetCustomer(int customerID)
        {
            SqlConnection connection = MMABooksDB.GetConnection();

            string selectStatement =
                "SELECT CustomerID, Name, Address, City, State, ZipCode" +
                " FROM Customers" +
                " WHERE CustomerID = @CustomerID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlParameter customerIDParam = new SqlParameter();
            customerIDParam.ParameterName = "@CustomerID";
            customerIDParam.Value = customerID;

            selectCommand.Parameters.Add(customerIDParam);

            try
            {

                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {

                    Customer customer = new Customer();

                    customer.Name = reader["Name"].ToString();
                    customer.Address = reader["Address"].ToString();
                    customer.City = reader["City"].ToString();
                    customer.State = reader["State"].ToString();
                    customer.ZipCode = reader["ZipCode"].ToString();
                    customer.CustomerID = customerID;

                    return customer;

                }
                else
                {
                    return null;
                }

                

            }
            catch (SqlException ex)
            {                
                throw ex;
            }
            finally
            {
                connection.Close();
            }           



        }

        public static bool UpdateCustomer(Customer origCustomer, Customer newCustomer)
        {

            SqlConnection connection = MMABooksDB.GetConnection();

            string updateStatement =
                "UPDATE Customers SET " +
                "Name = @NewName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
                "WHERE " +
                "Name = @OldName " +
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@NewName", newCustomer.Name);
            updateCommand.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            updateCommand.Parameters.AddWithValue("@NewCity", newCustomer.City);
            updateCommand.Parameters.AddWithValue("@NewState", newCustomer.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);

            updateCommand.Parameters.AddWithValue("@OldName", origCustomer.Name);
            updateCommand.Parameters.AddWithValue("@OldAddress", origCustomer.Address);
            updateCommand.Parameters.AddWithValue("@OldCity", origCustomer.City);
            updateCommand.Parameters.AddWithValue("@OldState", origCustomer.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", origCustomer.ZipCode);

            try
            {
                int count = 0;

                connection.Open();

                count = updateCommand.ExecuteNonQuery();

                return (count > 0) ? true : false;


            }
            catch (SqlException ex)
            {                
                throw ex;
            }
            finally
            {
                connection.Close();
            }




        }

        public static int AddCustomer(Customer newCustomer)
        {

            SqlConnection connection = MMABooksDB.GetConnection();

            string insertStatement =
                "INSERT Customers " +
                "(Name, Address, City, State, ZipCode) " +
                "VALUES (@Name, @Address, @City, @State, @ZipCode) ";


            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@Name", newCustomer.Name);
            insertCommand.Parameters.AddWithValue("@Address", newCustomer.Address);
            insertCommand.Parameters.AddWithValue("@City", newCustomer.City);
            insertCommand.Parameters.AddWithValue("@State", newCustomer.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", newCustomer.ZipCode);

            try
            {

                connection.Open();

                insertCommand.ExecuteNonQuery();

                string selectStatement = "SELECT IDENT_CURRENT('Customers') FROM Customers";

                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                return Convert.ToInt32(selectCommand.ExecuteScalar());


            }
            catch (SqlException ex)
            {                
                throw ex;
            }
            finally
            {
                connection.Close();
            }





        }

        public static bool DeleteCustomer(Customer customer)
        {

            SqlConnection connection = MMABooksDB.GetConnection();

            string deleteStatement =
                "DELETE FROM Customers " +
                "WHERE " +
                "Name = @Name " +
                "AND Address = @Address " +
                "AND City = @City " +
                "AND State = @State " +
                "AND ZipCode = @ZipCode";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            deleteCommand.Parameters.AddWithValue("@Name", customer.Name);
            deleteCommand.Parameters.AddWithValue("@Address", customer.Address);
            deleteCommand.Parameters.AddWithValue("@City", customer.City);
            deleteCommand.Parameters.AddWithValue("@State", customer.State);
            deleteCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

            try
            {

                int count = 0;

                connection.Open();

                count = deleteCommand.ExecuteNonQuery();

                return (count > 0) ? true : false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
