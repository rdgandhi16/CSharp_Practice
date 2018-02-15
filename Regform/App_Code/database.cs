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
   
    public DataTable db_statebind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("sp_state", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public DataTable db_citybind(business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_citybind";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", bs.sd);

        SqlDataAdapter ad = new SqlDataAdapter(cm);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public int db_insert(business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sp_instreg";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);
        cm.Parameters.AddWithValue("@gn", bs.gender);
        cm.Parameters.AddWithValue("@em", bs.email);
        cm.Parameters.AddWithValue("@pw", bs.pwd);
        cm.Parameters.AddWithValue("@cp", bs.cpwd);
        cm.Parameters.AddWithValue("@cal", bs.cal);
        cm.Parameters.AddWithValue("@cl", bs.clas);
        cm.Parameters.AddWithValue("@strm", bs.stream);
        cm.Parameters.AddWithValue("@hb", bs.hobby);
        cm.Parameters.AddWithValue("@st", bs.state);
        cm.Parameters.AddWithValue("@ct", bs.city);
        cm.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p = cm.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataTable db_bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "select *from tbl_reg";
        cm.CommandType = CommandType.Text;
        cm.Connection = con;

        SqlDataAdapter ad = new SqlDataAdapter(cm);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

}