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

    public int db_insert(businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_insert";
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
        SqlDataAdapter da = new SqlDataAdapter("sp_display", con);
        DataSet dt = new DataSet();
        da.Fill(dt);

        return dt;
    }

    public int db_update(businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_update";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.id);
        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);

        con.Open();
        int p= cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }

    public int db_delete(businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_delete";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.id);
        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }

}