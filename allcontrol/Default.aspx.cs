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
        bs.gender = RadioButtonList_gender.Text;
        bs.country = DropDownList_country.Text;


        string str1 = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected==true)
            {
                if (str1=="")
                {
                    str1 = item.Text;
                }
                else
                {
                    str1 = str1 + "," + item.Text;
                }
            }
        }
        bs.city = str1;
        string str2 = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected==true)
            {
                if (str2=="")
                {
                    str2 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str2 = str2 + "," + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str2;

        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("Insert Succesfully...");
        }
        else
        {
            Response.Write("Try Again please...");
        }

    }
}