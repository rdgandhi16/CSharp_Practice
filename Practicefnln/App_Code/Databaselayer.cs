using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Databaselayer
/// </summary>
public class Databaselayer
{
    Businesslayer bs = new Businesslayer();
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
	public Databaselayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int db_insert(Businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);
        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;
    }

}   