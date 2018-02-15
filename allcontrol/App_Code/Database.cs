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
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm=new SqlCommand();
        cm.CommandText = "sp_insertallctrl";
        cm.CommandType=CommandType.StoredProcedure;
        cm.Connection=con;

        cm.Parameters.AddWithValue("@fn", bs.fname );
        cm.Parameters.AddWithValue("@ln", bs.lname);
        cm.Parameters.AddWithValue("@gn", bs.gender);
        cm.Parameters.AddWithValue("@cn", bs.country);
        cm.Parameters.AddWithValue("@ct",bs.city);
        cm.Parameters.AddWithValue("@hb",bs.hobby);

        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;        
    }
    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindallctrl", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;
    }
    public int db_update(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_updateallctrl";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", bs.id);
        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);
        cm.Parameters.AddWithValue("@gn", bs.gender);
        cm.Parameters.AddWithValue("@cn", bs.country);
        cm.Parameters.AddWithValue("@ct", bs.city);
        cm.Parameters.AddWithValue("@hb", bs.hobby);

        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p; 
    }

    public int db_delete(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_deleteallctrl";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", bs.id);

        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;
    }
}