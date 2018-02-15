using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Regform : System.Web.UI.Page
{
    Business bs = new Business();
    string fullpath, filename, temp, path;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            State_Bind();
        }
    }
    public void State_Bind()
    {
        DropDownList_state.DataSource = bs.bs_statebind();
        DropDownList_state.DataTextField = "SNAME";
        DropDownList_state.DataValueField = "SID";
        DropDownList_state.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = TextBox_fn.Text;
        bs.lname = TextBox_ln.Text;
        bs.gender = RadioButtonList1.Text;

        bs.state = DropDownList_state.Text;
        bs.city = DropDownList_city.Text;

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
                    str1 = str1 +","+CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str1;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/im");
            fullpath = path + "\\" + filename;

            FileUpload1.SaveAs(fullpath);

            temp = "~/im" + filename;
        }
        else
        {
            temp = "";
        }

        int p = bs.bs_insert();
        if (p>0)
        {
            Response.Write("<script>alert('Data inserted Succesfully..')</script>");
        }
        else
        {
            Response.Write("Failed to insert Data try later please..");
        }
    }

    protected void DropDownList_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        int id =int.Parse(DropDownList_state.SelectedItem.Value);
        bs.id = id;
        DropDownList_city.DataSource = bs.bs_city(bs);
        DropDownList_city.DataTextField = "CNAME";
        DropDownList_city.DataValueField = "CID";
        DropDownList_city.DataBind();
    }
}