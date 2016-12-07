using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Other
/// </summary>
public class Other : Thing  
{
	public Other()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string GetDisplayText()
    {
        return "This is another type of device";
    }
}