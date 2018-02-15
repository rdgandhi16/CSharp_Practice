using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["data"] != null)
        {
            Label1.Text = Session["data"].ToString();
        }
        else
        {
            Label1.Text = "Empty";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Session.Remove("data");
    }
}