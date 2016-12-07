using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Desktop
/// </summary>
public class Desktop : Thing       
{
    public Desktop()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string GetDisplayText()
    {
        return "This is a Desktop";
    }
}