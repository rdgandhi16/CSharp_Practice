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
    string str=ConfigurationManager.ConnectionStrings["str"].ToString();
	public Database()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int db_insertregform(Business bs)
    {
        SqlConnection con=new SqlConnection(str);
        SqlCommand cmd=new SqlCommand();
        cmd.CommandText="sp_insert_stregform";
        cmd.CommandType=CommandType.StoredProcedure;
        cmd.Connection=con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@mn", bs.mname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@cl", bs.clas);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@ct", bs.city);

        con.Open();
        int p=cmd.ExecuteNonQuery();
       // con.Close();
        return p;

    }
    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindregform", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;
    }

    public int db_deletestentry(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_deletestentry";
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
        cmd.CommandText = "sp_updatestrgform";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.Rollno);
        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@mn", bs.mname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@cl", bs.clas);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@ct", bs.city);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
}