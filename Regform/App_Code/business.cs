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
    database db = new database();
    public int id { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string email { get; set; }
    public string pwd { get; set; }
    public string cpwd { get; set; }
    public DateTime cal { get; set; }
    public string clas { get; set; }
    public string stream { get; set; }
    public string hobby { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string image { get; set; }
    public int sd { get; set; }
    public string sn { get; set; }
    public int cd { get; set; }
    public string cn { get; set; }
	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bs_statebind()
    {
        return db.db_statebind();
    }
    public DataTable bs_citybind(business bs)
    {
        return db.db_citybind(bs);
    }
    public int bs_insert(business bs)
    {
        return db.db_insert(bs);
    }
    public DataTable bs_bind()
    {
        return db.db_bind();
    }
}