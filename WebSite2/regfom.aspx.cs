using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class regfom : System.Web.UI.Page
{
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = TextBox_fn.Text;
        bs.lname = TextBox_ln.Text;
        bs.mname = TextBox_mn.Text;
        bs.gender = RadioButtonList1.Text;
        bs.clas = DropDownList1.Text;

        string str1 = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                if (str1 == "")
                {
                    str1 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str1 = str1 + "," + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str1;
        string str2 = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected == true)
            {
                if (str2 == "")
                {
                    str2 = item.Text;
                }
                else
                {
                    str2 = str2 + "," + item.Text;
                }
            }
        }
        bs.city = str2;
        int p = bs.bs_insertregform(bs);
        if (p > 0)
        {
            Response.Write("Insert Succesfullyy...");
        
        }
        else
        {
            Response.Write("Failed To register...");
        }
    }
}