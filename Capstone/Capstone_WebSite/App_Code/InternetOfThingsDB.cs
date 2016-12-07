using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InternetOfThingsDB
/// </summary>
public static class InternetOfThingsDB
{

    public static SqlConnection GetConnection()
    {
        try
        {
            string connectionString =
            "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\InternetOfThings.mdf;" +
            "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }
        catch (Exception)
        {

            return null;
        }

        
    }
}