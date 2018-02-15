using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for dataaccess
/// </summary>
public class dataaccess
{
    string depstr = ConfigurationManager.ConnectionStrings["depstr"].ToString();
    
    public int Depinsert(business depbuss)
    {
        SqlConnection depcon = new SqlConnection(depstr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_depinsert";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = depcon;

        cmd.Parameters.AddWithValue("@dname", depbuss.depname);

        depcon.Open();
        int p = cmd.ExecuteNonQuery();
        depcon.Close();
        return p;
    }

    public DataTable depBind()
    {
        SqlConnection con = new SqlConnection(depstr);
        SqlDataAdapter adpter = new SqlDataAdapter("binddepartment", con);
        DataTable dt = new DataTable();
        adpter.Fill(dt);
        return dt;

    }
    public int depupdate(business depbuss)
    {
        SqlConnection con = new SqlConnection(depstr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "updatedep";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@did", depbuss.depid);
        cmd.Parameters.AddWithValue("@dname", depbuss.depname);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
    public DataTable db_Binddep()
    {
        SqlConnection con = new SqlConnection(depstr);
        SqlDataAdapter ad = new SqlDataAdapter("Binddepart", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public int db_insertempdata(business buss)
    {
        SqlConnection con = new SqlConnection(depstr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_insertempdata";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@ename", buss.ename);
        cmd.Parameters.AddWithValue("@add", buss.address);
        cmd.Parameters.AddWithValue("@city", buss.city);
        cmd.Parameters.AddWithValue("@depart", buss.depart);
        cmd.Parameters.AddWithValue("@jdate", buss.jdate);
        cmd.Parameters.AddWithValue("@bdate", buss.bdate);
        cmd.Parameters.AddWithValue("@gender", buss.gender);
        cmd.Parameters.AddWithValue("@isact", buss.isact);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }

    public DataSet db_bindemp()
    {
        SqlConnection con = new SqlConnection(depstr);
        SqlDataAdapter ad = new SqlDataAdapter("sp_bindempdata", con);
        DataSet dt = new DataSet();
        ad.Fill(dt);
        return dt;

    }
}