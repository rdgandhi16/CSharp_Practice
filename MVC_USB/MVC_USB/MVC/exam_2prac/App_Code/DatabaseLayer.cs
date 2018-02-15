using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DatabaseLayer
/// </summary>
public class DatabaseLayer
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();

    public DatabaseLayer()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int dl_add_category(BusinessLayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_cat_insert";
        cmd.Connection = con;

        cmd.Parameters.Add("@cat_name", bs.category_name);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();

        return p;

    }


    public int dl_add_product(BusinessLayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_addproduct";
        cmd.Connection = con;

        cmd.Parameters.Add("@p_name", bs.product_name);
        cmd.Parameters.Add("@p_desc", bs.product_description);
        cmd.Parameters.Add("@p_price", bs.product_price);
        cmd.Parameters.Add("@p_qty", bs.product_qty);
        cmd.Parameters.Add("@p_img", bs.product_image);
        cmd.Parameters.Add("@p_catid", bs.product_cat_id);

        con.Open();
        int p = cmd.ExecuteNonQuery();
        con.Close();

        return p;

    }

    public DataSet get_cat()
    {
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter da = new SqlDataAdapter("sp_getCat", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet get_product(BusinessLayer bs)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_getProduct";
        cmd.Connection = con;
        cmd.Parameters.Add("@cat_id", bs.product_cat_id);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

}