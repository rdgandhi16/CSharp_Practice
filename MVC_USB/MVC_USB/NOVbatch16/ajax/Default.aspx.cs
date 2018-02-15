using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = DateTime.Now.ToString();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.Text;
    }

   
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(5000);
        Label2.Text = "update Successfully..";
    }
}