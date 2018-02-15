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
    public int id { get; set; }
    public string fname { get; set; }
    public string gender { get; set; }
    public string hobby { get; set; }
    public string subject { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string image { get; set; }

    public int sid { get; set; }
    public string stname { get; set; }

    public int cid { get; set; }
    public string ctname { get; set; }
	public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bs_state()
    {
        return db.db_state();
    }
    public DataTable bs_city(Business bs)
    {
        return db.db_city(bs);
    }
    public int bs_ins(Business bs)
    {
        return db.db_ins(bs);
    }
    public DataTable bs_Bind(Business bs)
    {
        return db.db_Bind(bs);
    }


}