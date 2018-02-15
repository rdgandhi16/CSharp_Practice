using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for databaselayer
/// </summary>
public class databaselayer
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
	public databaselayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable db_login(businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_login";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@un", bs.uname);
        cmd.Parameters.AddWithValue("@ps", bs.pwd);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}