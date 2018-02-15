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
    Database db = new Database();
    public int Rollno { get; set; }
    public string fname { get; set; }
    public string mname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string clas { get; set; }
    public string hobby { get; set; }
    public string city { get; set; }
	
    public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int bs_insertregform(Business bs)
    {
        return db.db_insertregform(bs);
    }
    public DataSet bs_bind()
    {
        return db.db_bind();
    }
    public int bs_deletestentry(Business bs)
    {
        return db.db_deletestentry(bs);
    }
    public int bs_update(Business bs)
    {
        return db.db_update(bs);
    }


}