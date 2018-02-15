using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Ddl : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            statebind();
        }

    }

    public void statebind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_statebind";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        state.DataSource = dt;
        state.DataTextField = "statename";
        state.DataValueField = "stateid";
        state.DataBind();

        


    }
    protected void state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(state.SelectedValue);
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "citybind";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
       
        cmd.Parameters.AddWithValue("@id", id);


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        city.DataSource = dt;
        city.DataTextField = "cityname";
        city.DataValueField = "cityname";
        city.DataBind();


    }
}