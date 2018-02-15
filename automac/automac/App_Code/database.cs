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
    string constr = ConfigurationManager.ConnectionStrings["str"].ToString();

    public database()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public int dept_insert(business bs)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_insert_dept";
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@dn", bs.deptname);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();

        return i;

    }



    public int emp_insert(business bs)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_emp_insert";
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@n", bs.ename);
        cmd.Parameters.AddWithValue("@a", bs.addr);
        cmd.Parameters.AddWithValue("@c", bs.city);
        cmd.Parameters.AddWithValue("@d", bs.deptid);
        cmd.Parameters.AddWithValue("@jd", bs.jdate);
        cmd.Parameters.AddWithValue("@bd", bs.bdate);
        cmd.Parameters.AddWithValue("@g", bs.gender);
        cmd.Parameters.AddWithValue("@is", bs.isact);

        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();

        return i;

    }


    public DataTable grid_dept()
    {

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_dept";
        cmd.Connection = con;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;

    }


    public DataTable grid_emp()
    {

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_emp";
        cmd.Connection = con;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;

    }



    public int update_dept(business bs)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_update_dept";
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@did", bs.deptid);
        cmd.Parameters.AddWithValue("@dn", bs.deptname);

        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();

        return i;

    }




}