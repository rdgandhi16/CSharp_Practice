using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for business
/// </summary>
public class business
{
    Dataaccess da = new Dataaccess();

    public int sid { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string stream { get; set; }
    public string state { get; set; }
    public string hobby { get; set; }

	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int blayer_allcontrolinsert(business blayer)
    {
        return da.daccess_allcontrolinsert(blayer);
    }
    public DataSet blayer_displayallcontrol()
    {
        return da.db_displayallcontrol();
    }


}