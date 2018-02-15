using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class loginForm : System.Web.UI.Page
{
    business bus = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bus.uname = txtUname.Text;
        bus.pwd = txtPwd.Text;

        DataSet dt=new DataSet();
        dt.Tables.Add(bus.bs_login(bus));

        int p = dt.Tables[0].Rows.Count;
        if (p>0)
        {
            Session["txtUname"] = txtUname.Text;
            //Session["txtUname"] = dt.Tables[0].Rows[0]["txtUname"];
            Response.Redirect("home.aspx");
        }
        else
        {
            Response.Write("Login Failed");
        }

    }
}