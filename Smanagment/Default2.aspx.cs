using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"]==null)
        {
            Label1.Text = "not availabel";
        }
        else
        {
            Label1.Text = Session["name"].ToString();
        }
        if (Session["surname"]==null)
        {
            Label2.Text = "Not Available..";
        }
        else
        {
            Label2.Text = Session["surname"].ToString();
        }

    }
}