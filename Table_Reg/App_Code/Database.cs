using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Database
/// </summary>
public class Database
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();

	public Database()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int db_insert(Business bs)
    {
        SqlConnection con=new SqlConnection(str);
        SqlCommand cmd=new SqlCommand();
        cmd.CommandText="inserttable_reg";
        cmd.CommandType=CommandType.StoredProcedure;
        cmd.Connection=con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@ct", bs.city);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p=cmd.ExecuteNonQuery();
        con.Close();
        return p;        
    }
    public DataTable db_bindreg()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindrg", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        return dt;
    }
}