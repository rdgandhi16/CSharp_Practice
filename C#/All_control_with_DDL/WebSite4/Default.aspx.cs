using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    Business bs = new Business();
    string filename, path, fullpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDown_state.DataSource = bs.bs_state();
            DropDown_state.DataTextField = "StateName";
            DropDown_state.DataValueField = "SID";
            DropDown_state.DataBind();
        }
    }
    protected void DropDown_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(DropDown_state.SelectedItem.Value);
        bs.sid = id;

        DropDown_city.DataSource = bs.bs_city(bs);
        DropDown_city.DataTextField = "CityName";
        DropDown_city.DataValueField = "CityName";
        DropDown_city.DataBind();
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        bs.fname = txt_fname.Text;
        bs.gender = RadioButtonList1.Text;

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
                    str1 = str1 + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str1;

        string str2 = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected==true)
            {
                if (str2=="")
                {
                    str2 = item.Text;
                }
                else
                {
                    str2 = str2 + item.Text;
                }
            }
        }
        bs.subject = str2;
        bs.state = DropDown_state.Text;
        bs.city = DropDown_city.Text;
        if (FileUpload1.HasFiles)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/i/");
            fullpath = path + filename;

            FileUpload1.SaveAs(fullpath);
            temp = "~/i/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;
        int p = bs.bs_ins(bs);
        if (p>0)
        {
            Response.Write("Insert Succesfully..");
        }
        else
        {
            Response.Write("try Again..");
        }
    }
}