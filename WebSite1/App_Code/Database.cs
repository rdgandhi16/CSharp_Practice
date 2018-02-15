using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

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
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_inflln";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindfnln", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;
    }
    public int db_delete(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_deletefnln";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.Rollno);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;        
    }

    public int db_update(Business bs)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_updatefnln";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.Rollno);
        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
}