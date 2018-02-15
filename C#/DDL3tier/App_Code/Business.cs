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
    database db = new database();
    public int sid { get; set; }
    public string sn { get; set; }
    public int cid { get; set; }
    public string cn { get; set; }
	public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bs_bind()
    {
        return db.db_bind();
    }
    public DataTable bs_citybind(Business bs)
    {
        return db.db_citybind(bs);
    }

}