using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Thing
/// </summary>
public class Thing
{
	public Thing()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int ID { get; set; }
    public string Description { get; set; }
    public string IPAddress { get; set; }
    public string MacAddress { get; set; }
    public string OperatingSystem { get; set; }

    public virtual string GetDisplayText()
    {
        return Description;
    }
}