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
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_3insertfnln";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);


        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;
    }

    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_3bindfnln", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);

        return dt;
    }
    public int db_update(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_3tierupdatefnln";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", bs.id);
        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);


        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;
    }

}