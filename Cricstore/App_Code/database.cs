using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
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

    public DataTable db_statebind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_state", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        return dt;
    }

    public DataTable db_city(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_city";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id",bs.id);

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public int db_insert()
    {
        Business bs = new Business();
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd=new SqlCommand();
        cmd.CommandText = "sp_insert123";
        cmd.CommandType=CommandType.StoredProcedure;
        cmd.Connection=con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@ln", bs.lname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@ct", bs.city);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
}