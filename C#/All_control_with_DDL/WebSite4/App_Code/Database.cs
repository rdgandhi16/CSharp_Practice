using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Database
/// </summary>
public class Database
{
    string str = @"Data Source=SAIPC\SQLEXPRESS;Initial Catalog=db_rinkal;Integrated Security=True";
	public Database()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable db_state()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "selectstate";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }
    public DataTable db_city(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select *from tbl_city where SID=@id";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.sid);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }
    public int db_ins(Business bs)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_table1insert";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@sb", bs.subject);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@ct", bs.city);
        cmd.Parameters.AddWithValue("@im", bs.image);
        
        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataTable db_Bind(Business bs)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select *from Table_1";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }
   
}