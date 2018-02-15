using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["f"]==null)
        { 
            Label1.Text = "";
        }
        else
        {
            Label1.Text = Request.QueryString["f"].ToString();
        }
        if (Request.QueryString["l"]==null)
        {
            Label2.Text = "";
        }
        else
        {
            Label2.Text = Request.QueryString["l"].ToString();
        }

    }
}