using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Diplay_allControl : System.Web.UI.Page
{
    business blayer = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }

    public void Bind()
    {
        GridView1.DataSource = blayer.blayer_displayallcontrol();
        GridView1.DataBind();
    }
}