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

        Label1.Text = txt_fname.Text;
        Label2.Text = txt_lname.Text;

        if (rdo_male.Checked == true)
        {
            Label3.Text = rdo_male.Text;
        }
        else
        {
            Label3.Text = rdo_female.Text;
        }

        string str = "";
        if (chk_cri.Checked == true)
        {
            str = chk_cri.Text;
        }

        if (chk_foot_.Checked==true)
        {
            str = str + chk_foot_.Text;
        }
        Label4.Text = str;

        Label5.Text = ListBox1.Text;
        Label6.Text = DropDownList1.Text;
       


    }
}