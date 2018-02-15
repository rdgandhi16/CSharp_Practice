using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind_State();
        }
    }
    public void Bind_State()
    {
        DropDownList_state.DataSource = bs.bs_bisnd();
        DropDownList_state.DataTextField = "SNAME";
        DropDownList_state.DataValueField = "SID";
        DropDownList_state.DataBind();
    }

    protected void DropDownList_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(DropDownList_state.SelectedValue);
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "ddl_city";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        cm.Parameters.AddWithValue("@id", id);

        SqlDataAdapter ad = new SqlDataAdapter(cm);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        DropDownList_city.DataSource = dt;
        DropDownList_city.DataTextField = "CNAME";
        DropDownList_city.DataValueField = "CNAME";
        DropDownList_city.DataBind();
    }
}