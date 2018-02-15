using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Business
/// </summary>
public class Business
{
    Database db = new Database();
    public int rollno { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string datetime { get; set; }
    public string gender { get; set; }
    public string hobby { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string image { get; set; }
	public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bs_rgform(Business bs)
    {
        return db.db_rgform(bs);
    }

    public DataSet bs_bind()
    {
        return db.db_bind();
    }
    public int bs_updaterinkalreg(Business bs)
    {
        return db.db_updaterinkalreg(bs);
    }

}