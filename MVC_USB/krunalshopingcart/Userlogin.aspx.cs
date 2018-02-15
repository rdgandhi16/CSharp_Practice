using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Userlogin : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.uname = uname.Text;
        bs.pwd = password.Text;

        DataSet ds = new DataSet();
        ds.Tables.Add(bs.bs_userlogin(bs));
        int p = ds.Tables[0].Rows.Count;

        if (p > 0)
        {
            Session["uname"] = uname.Text;
            Response.Redirect("userhome1.aspx");
        }
        else
        {
            Response.Write("Invalid Username or Password");
        }
    }
}