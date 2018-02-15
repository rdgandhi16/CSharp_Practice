using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Business
/// </summary>
public class Business
{
    database db = new database();

    public int srno { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string hobby { get; set; }
    public string image { get; set; }
    public int id { get; set; }
	public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bs_insert()
    {
        return db.db_insert();
    }
    public DataTable bs_statebind()
    {
        return db.db_statebind();
    }
    public DataTable bs_city(Business bs)
    {
        return db.db_city(bs);
    }

}
