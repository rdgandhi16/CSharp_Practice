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
    string str = ConfigurationManager.ConnectionStrings["strallcontrol"].ToString();
	public Dataaccess()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int daccess_allcontrolinsert(business blayer)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert_allcontrol";
        cmd.CommandType=CommandType.StoredProcedure;
        cmd.Connection=con;

        cmd.Parameters.AddWithValue("@fname", blayer.fname);
        cmd.Parameters.AddWithValue("@lname", blayer.lname);
        cmd.Parameters.AddWithValue("@gender", blayer.gender);
        cmd.Parameters.AddWithValue("@stream",blayer.stream);
        cmd.Parameters.AddWithValue("@hobby",blayer.hobby);
        cmd.Parameters.AddWithValue("@state", blayer.state);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataSet db_displayallcontrol()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("diplay_allcontrol", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;
    }
}