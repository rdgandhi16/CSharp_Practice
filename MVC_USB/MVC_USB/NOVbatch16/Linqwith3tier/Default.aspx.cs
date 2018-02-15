using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = fname.Text;
        bs.lname = lname.Text;
        try
        {
            bs.bs_insert(bs);
            Label1.Text = "success..";
        }
        catch
        {
            Label1.Text = "failed";
        }
    }
}