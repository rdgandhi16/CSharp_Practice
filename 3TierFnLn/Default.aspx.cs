using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = Text_fname.Text;
        bs.lname = Text_lname.Text;

        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("Add succesfully..");
        }
        else
        {
            Response.Write("Try Again..");
        }
    }

}