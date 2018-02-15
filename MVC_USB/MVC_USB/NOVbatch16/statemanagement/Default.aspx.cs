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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ViewState["data"] = txt_view.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ViewState["data"] == null)
        {
            lbl_view.Text = "Nothing";
        }
        else
        {
            lbl_view.Text = ViewState["data"].ToString();

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Display.aspx?fname="+fname.Text + "&lname=" + lname.Text);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Cookies["val"].Value = txt_c.Text;

        HttpCookie ck = new HttpCookie("val");
        ck.Value = txt_c.Text;
        Response.Cookies.Add(ck);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["val"] == null)
        {
            lbl_c.Text = "Nothing";
        }
        else
        {
            lbl_c.Text = Request.Cookies["val"].Value;
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Cookies["val"].Expires = DateTime.Now.AddDays(-1);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        hd.Text = HiddenField1.Value;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["data"] = txt_ses.Text;
        Response.Redirect("Display.aspx");
    }
}