using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dataaccess
/// </summary>
public class dataaccess
{

    string stremp = ConfigurationManager.ConnectionStrings["stremp"].ToString();

    public int dataemp_Insert(business empbs)
    {
        SqlConnection con = new SqlConnection(stremp);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insertEmpdata";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fname", empbs.fname);
        cmd.Parameters.AddWithValue("@lname", empbs.lname);
        cmd.Parameters.AddWithValue("@gender", empbs.gender);
        cmd.Parameters.AddWithValue("@skill", empbs.skills);
       // cmd.Parameters.AddWithValue("@state", empbs.state);
        cmd.Parameters.AddWithValue("@department", empbs.department);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }

    public DataSet dataaccess_bindEmpdata()
    {
        SqlConnection con = new SqlConnection(stremp);
        SqlDataAdapter adpter = new SqlDataAdapter("select *from EmpData", con);
        DataSet dset = new DataSet();
        adpter.Fill(dset);
        return dset;
    }
    public int db_update(business empbs)
    {
        SqlConnection con = new SqlConnection(stremp);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_updateEmpdetail";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", empbs.eid);
        cmd.Parameters.AddWithValue("@fname", empbs.fname);
        cmd.Parameters.AddWithValue("@lname", empbs.lname);
        cmd.Parameters.AddWithValue("@gender", empbs.gender);
        cmd.Parameters.AddWithValue("@skill", empbs.skills);
        //cmd.Parameters.AddWithValue("@st", empbs.state);
        cmd.Parameters.AddWithValue("@department", empbs.department);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();
        return p;
    }
}