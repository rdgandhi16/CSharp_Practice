using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for database
/// </summary>
public class database
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
	public database()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_state", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    
}