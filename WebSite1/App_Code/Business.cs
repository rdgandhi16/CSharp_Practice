using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Business
/// </summary>
public class Business
{
    Database db = new Database();
    public int Rollno { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
	//public Business()
	//{
		//
		// TODO: Add constructor logic here
		//
	//}
    public int bs_insert(Business bs)
    {
        return db.db_insert(bs);
    }

    public DataSet bs_bind()
    {
        return db.db_bind();
    }
    public int bs_delete(Business bs)
    {
        return db.db_delete(bs);
    }
    public int bs_update(Business bs)
    {
        return db.db_update(bs);
    }


}