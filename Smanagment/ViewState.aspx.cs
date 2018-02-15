using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ViewState["fname"] = TextBox_fname.Text;
        ViewState["lname"] = TextBox_lname.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ViewState["fname"]==null)
        {
            Label_view.Text = "nothing Added";
        }
        else
        {
            Label_view.Text = ViewState["fname"].ToString();
        }
        if (ViewState["lname"]==null)
        {
            Label_view1.Text = "Nothing Saved";
        }
        else
        {
            Label_view1.Text = ViewState["lname"].ToString();
        }
    }
}