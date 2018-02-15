using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        bs.fname = fname.Text;
        bs.lname = lastname.Text;

        int q = bs.bs_insert(bs);
        if (q > 0)
        {
            Label1.Text = "Successfully";
        }
        else
        {
            Label1.Text = "Try Again";
        }
    }
}