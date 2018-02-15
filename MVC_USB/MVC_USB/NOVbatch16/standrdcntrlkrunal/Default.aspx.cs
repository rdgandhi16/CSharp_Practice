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
    protected void btn_sub_Click(object sender, EventArgs e)
    {
        lbl_fname.Text = txt_fname.Text;
        lbl_lname.Text = txt_lname.Text;

        if (rd_male.Checked == true)
        {
            lbl_gen.Text = rd_male.Text;
        }
        else
        {
            lbl_gen.Text = rd_female.Text;
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
                str = str + chk_cric;

            }
        }

        if (chk_foot.Checked==true)
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

        lbl_hb.Text = str;

        lbl_sub.Text = ListBox1.Text;

        lbl_st.Text = DropDownList1.Text;




    }
}