using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for database
/// </summary>
public class database
{
    string str = @"Data Source=RINKAL-PC\SQLEXPRESS;Initial Catalog=db_fnln;Integrated Security=True";
	public database()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("Select *from tbl_state", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public DataTable db_citybind(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_cbind";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", bs.sid);
        SqlDataAdapter ad = new SqlDataAdapter(cm);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }
}