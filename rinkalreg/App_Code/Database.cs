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

    public int db_rgform(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert_rinkalreg";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@dt",bs.datetime);
        cmd.Parameters.AddWithValue("@gn",bs.gender);
        cmd.Parameters.AddWithValue("@hb",bs.hobby);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@ct",bs.city);
        cmd.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;      
    }
    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindreg", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;
    }
    public int db_updaterinkalreg(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "edit_rinkalrg";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.rollno);
        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@dt", bs.datetime);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@ct", bs.city);
        cmd.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    //protected DataSet db_state()
    //{
    //    SqlConnection con = new SqlConnection(str);
    //    SqlDataAdapter ad = new SqlDataAdapter("dd_state", con);
    //    DataSet dt = new DataSet();
    //    ad.Fill(dt);
    //    return dt;
    //}
}