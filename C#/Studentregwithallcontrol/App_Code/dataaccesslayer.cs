using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for dataaccesslayer
/// </summary>
public class dataaccesslayer
{
    string strstudent = ConfigurationManager.ConnectionStrings["str"].ToString();
    public DataTable dataaccessState()
    {
        SqlConnection con = new SqlConnection(strstudent);
        SqlDataAdapter adpter = new SqlDataAdapter("sp_selectstate", con);
        DataTable dt = new DataTable();
        adpter.Fill(dt);

        return dt;
    }
    public DataSet dataaccessCity(businesslayer business)
    {
        SqlConnection con = new SqlConnection(strstudent);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_selectcitystatevice";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@sid", business.stateid);

        SqlDataAdapter adpter = new SqlDataAdapter(cmd);
        DataSet dt = new DataSet();
        adpter.Fill(dt);
        return dt;
    }
}