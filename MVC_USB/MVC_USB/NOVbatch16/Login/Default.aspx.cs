using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        bs.uname = uname.Text;
        bs.pwd = pwd.Text;

        DataSet dt = new DataSet();
        dt.Tables.Add(bs.bs_login(bs));

        int p = dt.Tables[0].Rows.Count;
        if (p > 0)
        {
            //  Session["uname"] = uname.Text;
            Session["uname"] = dt.Tables[0].Rows[0]["uname"];
            Response.Redirect("home.aspx");
        }
        else
        {
            Response.Write("Login Failed");
        }

    }
}