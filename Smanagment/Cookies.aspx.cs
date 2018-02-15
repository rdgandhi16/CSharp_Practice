using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Request.Cookies["first"].Value = TextBox1.Text;
        Request.Cookies["last"].Value = TextBox2.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["first"].Value==null)
        {
           Label1.Text = "EMPTY";
        }
        else
        {
           Label1.Text = Request.Cookies["first"].Value;
        }
        if (Request.Cookies["last"].Value==null)
        {
           Label2.Text = "EMPTY";
        }
        else
        {
           Label2.Text = Request.Cookies["last"].Value;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Request.Cookies["first"].Expires = DateTime.Now.AddDays(-1);
        Request.Cookies["last"].Expires = DateTime.Now.AddDays(-1);
    }
}