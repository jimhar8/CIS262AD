using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tablet
/// </summary>
public class Tablet : Thing 
{
	public Tablet()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string GetDisplayText()
    {
        return "This is a Tablet";
    }
}