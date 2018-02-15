using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Regform : System.Web.UI.Page
{
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = Text_fn.Text;
        bs.lname = Text_ln.Text;

        int p = bs.bs_insert(bs);
        if (p > 0)
        {
            Response.Write("Save Succesfully..");
        }
        else
        {
            Response.Write("Failed to Reg...");
        }
    }
}