using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class productdetail : System.Web.UI.Page
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
        bs.pid=int.Parse(Request.QueryString["id"]);
        
        DetailsView1.DataSource = bs.bs_showproddetail(bs);
        DetailsView1.DataBind();
    }
   
}