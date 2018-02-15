using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class StudentRegform : System.Web.UI.Page
{
    businesslayer business = new businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlState.DataSource = business.bussiness_state();
            ddlState.DataTextField = "Statename";
            ddlState.DataValueField = "SID";
            ddlState.DataBind();
        }
    }

    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(ddlState.SelectedItem.Value);
        business.stateid=id;

        ddlCity.DataSource = business.businessCity(business);
        ddlCity.DataTextField = "Cityname";
        ddlCity.DataValueField = "Cid";
        ddlCity.DataBind();
    }
}