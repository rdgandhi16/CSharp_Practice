using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class showproduct : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            prod_bind();
        }
    }

    public void prod_bind()
    {
        DataList1.DataSource = bs.bs_showprod();
        DataBind();
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        Response.Redirect("showproductdetail.aspx");
    }
}