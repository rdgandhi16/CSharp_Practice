using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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

    public int db_addprod(business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_addprod";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@pn", bs.pname);
        cmd.Parameters.AddWithValue("@ppr", bs.pprice);
        cmd.Parameters.AddWithValue("@pdt", bs.pdetail);
        cmd.Parameters.AddWithValue("@pcat", bs.pcategory);
        cmd.Parameters.AddWithValue("@pimg", bs.pimg);

        con.Open();
        int p=cmd.ExecuteNonQuery();
        con.Close();

        return p;
    }

    public DataTable db_userlogin(business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_userlogin";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@uname", bs.uname);
        cmd.Parameters.AddWithValue("@pwd", bs.pwd);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }

    public DataSet db_showprod()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter da = new SqlDataAdapter("sp_showprod", con);
        DataSet ds=new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet db_showproddetails(business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_proddetail";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", bs.pid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds=new DataSet();
        da.Fill(ds);
        return ds;
    }

    

}