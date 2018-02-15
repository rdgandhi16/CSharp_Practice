using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblLogin.Text = Session["txtUname"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("loginForm.aspx");
    }
}