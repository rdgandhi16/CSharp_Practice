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
    public int pid { get; set; }
    public string pname { get; set; }
    public int pprice { get; set; }
    public string pdetail{ get; set; }
    public string pcategory { get; set; }
    public string pimg { get; set; }
    public string uname { get; set; }
    public string pwd { get; set; }


    
	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int bs_addprod(business bs)
    {
        return db.db_addprod(bs);
    }

    public DataTable bs_userlogin(business bs)
    {
        return db.db_userlogin(bs);
    }

    public DataSet bs_showprod()
    {
        return db.db_showprod();
    }

    public DataSet bs_showproddetail(business bs)
    {
        return db.db_showproddetails(bs);
    }
}