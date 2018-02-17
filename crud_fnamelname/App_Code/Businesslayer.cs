using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Businesslayer
/// </summary>
public class Businesslayer
{
    Dataaccess daccess = new Dataaccess();

    public int sid { get; set; }
    public string fname { get; set; }
    public string mname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string hobby { get; set; }
    public string state { get; set; }

	public Businesslayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bs_insertform(Businesslayer bslayer)
    {
        return daccess.db_insertform(bslayer);
    }
    public DataTable blayer_displayfnamelname()
    {
        return daccess.db_displayfnamelname();
    }
    public int blayer_updatefnamelname(Businesslayer blayer)
    {
        return daccess.db_updatefnamelname(blayer);
    }
    public int blayer_deletefnamelname(Businesslayer blayer)
    {
        return daccess.db_deletefnamelname(blayer);
    }


}