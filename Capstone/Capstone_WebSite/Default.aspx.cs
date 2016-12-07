using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IOT : System.Web.UI.Page
{
    private List<Thing> things;
    private static int currentID = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Set label description
        lblServerTime.Text = "Capstone Project - Jim Harris";

        if (!Page.IsPostBack)
        {
            // Clear combobox
            ThingList.Items.Clear();

            // get things from database
            things = ThingDB.GetThings();

            // Add items to combobox
            foreach (var thing in things)
            {
                ThingList.Items.Add(new ListItem(thing.Description, thing.ID.ToString()));
            }

            // set default thing
            ThingList_SelectedIndexChanged(null, null);

        }

    }
    protected void ButtonPing_Click(object sender, EventArgs e)
    {
        LabelResponse.Text = "";

        Thing thing = ThingDB.GetThing(IOT.currentID);            

        // Ping class
        Ping ping = new Ping();

        try
        {            
            PingReply reply = ping.Send(thing.IPAddress.Trim());
            LabelResponse.Text = reply.Status.ToString();
            
        }
        catch (PingException)
        {

        }

    }

    protected void ThingList_SelectedIndexChanged(object sender, EventArgs e)
    {
        IOT.currentID = Convert.ToInt32(ThingList.SelectedValue);

        Thing thing = ThingDB.GetThing(IOT.currentID);

        LabelAddress.Text = thing.IPAddress.Trim();

        // Example of polymorphism
        LabelType.Text = thing.GetDisplayText();

    }
}