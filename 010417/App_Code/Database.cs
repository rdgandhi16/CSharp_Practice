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
    //public DataTable db_State()
    //{
    //    SqlConnection con = new SqlConnection(str);
    //    SqlDataAdapter ad = new SqlDataAdapter("state_bind", con);
    //    DataTable dt = new DataTable();
    //    ad.Fill(dt);
    //    return dt;
    //}


    public int db_insert(Business bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "sport_insertreg";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@fn", bs.fname);
        cm.Parameters.AddWithValue("@ln", bs.lname);
        cm.Parameters.AddWithValue("@dt", bs.datetime);
        cm.Parameters.AddWithValue("@gn", bs.gender);
        cm.Parameters.AddWithValue("@st", bs.state);
        cm.Parameters.AddWithValue("@ct", bs.city);
        cm.Parameters.AddWithValue("@sp", bs.sport);
        cm.Parameters.AddWithValue("@hg", bs.height);
        cm.Parameters.AddWithValue("@im", bs.image);

        con.Open();
        int p = cm.ExecuteNonQuery(str);
        con.Close();
        return p;
    }
}