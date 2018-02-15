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
    public int id { get; set; }
    public string uname { get; set; }
    public string pwd { get; set; }

    database db = new database();

	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable bs_login(business buss)
    {
        return db.db_login(buss);
    }
}