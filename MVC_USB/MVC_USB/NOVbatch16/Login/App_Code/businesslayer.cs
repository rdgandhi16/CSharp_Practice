using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for businesslayer
/// </summary>
public class businesslayer
{
    databaselayer db = new databaselayer();
    public int id { get; set; }
    public string uname { get; set; }
    public string pwd { get; set; }
	public businesslayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bs_login(businesslayer bs)
    {
        return db.db_login(bs);
    }
}