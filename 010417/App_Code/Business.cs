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
    public string lname { get; set; }
    public string datetime { get; set; }
    public string gender { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string sport { get; set; }
    public string height { get; set; }
    public string  image { get; set; }

	public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bs_insert(Business bs)
    {
        return db.db_insert(bs);
    }
    //public DataTable bs_State()
    //{
    //    return db.db_State();
    //}

}