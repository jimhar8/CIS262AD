using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ThingDB
/// </summary>
public static class ThingDB
{
    public static List<Thing> GetThings()
    {
        List<Thing> things = new List<Thing>();

        SqlConnection connection = InternetOfThingsDB.GetConnection();

        string selectStatement = "SELECT ID, Description, IPAddress, MacAddress, OperatingSystem " +
                                 "FROM Things ";


        SqlCommand selectCommand =
            new SqlCommand(selectStatement, connection);

        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {

                Thing t = new Thing();

                t.ID = Convert.ToInt32(reader["ID"].ToString());
                t.Description = reader["Description"].ToString();
                t.IPAddress = reader["IPAddress"].ToString();
                t.MacAddress = reader["MacAddress"].ToString();
                t.OperatingSystem = reader["OperatingSystem"].ToString();
                things.Add(t);
            }

            reader.Close();
        }
        catch (SqlException ex)
        {
            
            throw ex;
        }
        finally
        {
            connection.Close();
        }

        return things;
    }

    public static Thing GetThing(int thingID)
    {
        SqlConnection connection = InternetOfThingsDB.GetConnection();
        string selectStatement
            = "SELECT ID, Description, IPAddress, MacAddress, OperatingSystem "
            + "FROM Things "
            + "WHERE ID = @ID";
        SqlCommand selectCommand =
            new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@ID", thingID);

        try
        {
            connection.Open();
            SqlDataReader thingReader =  selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            if (thingReader.Read())
            {
                string strDescription = thingReader["Description"].ToString();

                Thing thing;

                // Showing some inheritance methodology
                if (strDescription.ToUpper().Contains("DESKTOP"))
                {
                     thing = new Desktop();
                }
                else if (strDescription.ToUpper().Contains("LAPTOP"))
                {
                     thing = new Laptop();
                }
                else if (strDescription.ToUpper().Contains("TABLET"))
                {
                     thing = new Tablet();
                }
                else
                {
                     thing = new Other();
                }

                thing.ID = (int)thingReader["ID"];
                thing.IPAddress = thingReader["IPAddress"].ToString();
                thing.MacAddress = thingReader["MacAddress"].ToString();
                thing.OperatingSystem = thingReader["OperatingSystem"].ToString();
                thing.Description = thingReader["Description"].ToString();

                return thing;
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


}