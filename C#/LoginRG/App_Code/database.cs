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
    public DataTable db_login(business buss)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_login";
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@un", buss.uname);
        cmd.Parameters.AddWithValue("@pwd", buss.pwd);

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
}