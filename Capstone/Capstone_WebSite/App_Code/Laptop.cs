using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Laptop
/// </summary>
public class Laptop : Thing 
{
	public Laptop()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string GetDisplayText()
    {
        return "This is a Laptop";
    }
}