using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gridreg : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();       
        }
    }
    public void Bind()
    {
        GridView1.DataSource = bs.bs_bind();
        GridView1.DataBind();
    }
    
}