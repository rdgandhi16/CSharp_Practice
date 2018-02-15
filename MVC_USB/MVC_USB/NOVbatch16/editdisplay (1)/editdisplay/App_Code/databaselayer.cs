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
        cmd.CommandText = "sp_all_insert";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@sb", bs.subject);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@im", bs.image);
        con.Open();
      int p=  cmd.ExecuteNonQuery();
      con.Close();
      return p;
    }
    public DataSet db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter da = new SqlDataAdapter("sp_all_bind", con);
        DataSet dt = new DataSet();
        da.Fill(dt);
        return dt;
    }

    public int db_update(businesslayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update tbl_all_in_one set fname='"+bs.fname+"',gender=@gn,hobby=@hb,subject=@sb,state=@st,image=@im where id=@id";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.id);
        cmd.Parameters.AddWithValue("@fn", bs.fname);
        cmd.Parameters.AddWithValue("@gn", bs.gender);
        cmd.Parameters.AddWithValue("@hb", bs.hobby);
        cmd.Parameters.AddWithValue("@sb", bs.subject);
        cmd.Parameters.AddWithValue("@st", bs.state);
        cmd.Parameters.AddWithValue("@im", bs.image);
        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;

        
    }
}