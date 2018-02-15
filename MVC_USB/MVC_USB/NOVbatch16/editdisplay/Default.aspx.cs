using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    string filename, path, fulpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        bs.fname = txt_fname.Text;
        bs.gender = RadioButtonList1.Text;

        string str = "";

        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                if (str == "")
                {
                    str = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str = str + "," + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str;

        string str1 = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected==true)
            {
                if (str1 == "")
                {
                    str1 = item.Text;
                }
                else
                {
                    str1 = str1 + "," + item.Text;

                }
            }
        }
        bs.subject = str1;
        bs.state = DropDownList1.Text;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/image/");
            fulpath = path + "\\" + filename;
            FileUpload1.SaveAs(fulpath);
            temp = "~/image/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;

        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("Successfully...");
        }
        else
        {
            Response.Write("Failed..");
        }
    }
}