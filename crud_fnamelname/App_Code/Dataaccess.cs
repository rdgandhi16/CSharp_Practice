using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Dataaccess
/// </summary>
public class Dataaccess
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
    //  Businesslayer bs=new Businesslayer();
	public Dataaccess()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int db_insertform(Businesslayer bslayer)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert_fullregform";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fname",bslayer.fname);
        cmd.Parameters.AddWithValue("@mname",bslayer.mname);
        cmd.Parameters.AddWithValue("@lname",bslayer.lname);
        cmd.Parameters.AddWithValue("@gender",bslayer.gender);
        cmd.Parameters.AddWithValue("@hobby",bslayer.hobby);
        cmd.Parameters.AddWithValue("@state", bslayer.state);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataTable db_displayfnamelname()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("diplay_fnamelname", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }
    public int db_updatefnamelname(Businesslayer blayer)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update_fnamelname";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", blayer.sid);
        cmd.Parameters.AddWithValue("@fname", blayer.fname);
        cmd.Parameters.AddWithValue("@mname", blayer.mname);
        cmd.Parameters.AddWithValue("@lname", blayer.lname);
        cmd.Parameters.AddWithValue("@gender", blayer.gender);
        cmd.Parameters.AddWithValue("@hobby", blayer.hobby);
        cmd.Parameters.AddWithValue("@state", blayer.state);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public int db_deletefnamelname(Businesslayer blayer)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", blayer.sid);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }

}