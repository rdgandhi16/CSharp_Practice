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
    protected void btn_submit_Click(object sender, EventArgs e)
    {

        Label1.Text = txt_fname.Text;
        Label2.Text = txt_lname.Text;

        if (rd_male.Checked == true)
        {
            Label3.Text = rd_male.Text;
        }
        else
        {
            Label3.Text = rd_female.Text;
        }

        string str = "";
        if (chk_cric.Checked == true)
        {
            if (str == "")
            {
                str = chk_cric.Text;

            }
            else
            {
                str = str + chk_foot.Text;
            }
            
        }
       if (chk_foot.Checked == true)
        {
            if (str == "")
            {
                str = chk_foot.Text;

            }
            else
            {
                str = str + chk_foot.Text;
            }
        }


        Label4.Text = str;

        Label5.Text = ListBox1.Text;
        Label6.Text = DropDownList1.Text;








    }
}