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
    public int id { get; set; }
    public Business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bs_bisnd()
    {
        return db.db_bind();
    }
}