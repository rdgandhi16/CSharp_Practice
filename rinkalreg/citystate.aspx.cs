using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class citystate : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            State_Bind();
        }
    }
    protected void State_Bind()
    {      
        SqlConnection con = new SqlConnection(str);
        SqlDataAdapter ad = new SqlDataAdapter("dd_state", con);
        DataTable dt=new DataTable();
        ad.Fill(dt);

        DropDown_state.DataSource = dt;
        DropDown_state.DataTextField = "SNAME";
        DropDown_state.DataValueField = "SID";
        DropDown_state.DataBind();        
    }

    protected void DropDown_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(DropDown_state.SelectedItem.Value);
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "dd_city";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", id);

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        DropDown_city.DataSource = dt;
        DropDown_city.DataTextField = "CITY";
        DropDown_city.DataValueField = "SID";
        DropDown_city.DataBind();
    }
}