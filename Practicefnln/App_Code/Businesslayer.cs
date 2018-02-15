using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Businesslayer
/// </summary>
public class Businesslayer
{
    Databaselayer db = new Databaselayer();
    public string fname { get; set; }
    public string lname { get; set; }
	public Businesslayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bs_insert()
    {
        return db.db_insert();
    }
}