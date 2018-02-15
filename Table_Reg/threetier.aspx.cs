using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class threetier : System.Web.UI.Page
{
    Business bs = new Business();
    string filename, path, fullpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = TextBox_fn.Text;
        bs.lname = TextBox_ln.Text;
        bs.gender = RadioButtonList1.Text;
        bs.city = DropDownList1.Text;
        bs.state = DropDownList2.Text;

        string str1 = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected==true)
            {
                if (str1=="")
                {
                    str1 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str1 =str1+"," +CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str1;
        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/im/");
            fullpath = path + "\\" + filename;

            FileUpload1.SaveAs(fullpath);

            temp = "~/im/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;

        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("<script>alert('Data Inserted Succesfully..')</script>");
        }
        else
        {
            Response.Write("Failed to insert Data try Again please..");
        }
    }
}