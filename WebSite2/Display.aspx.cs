using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Display : System.Web.UI.Page
{
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }

    public void Bind()
    {
        GridView1.DataSource = bs.bs_bind();
        DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("Label_rollno") as Label;

        int i = int.Parse(id.Text);
        bs.Rollno = i;

        int p = bs.bs_deletestentry(bs);
        if (p > 0)
        {
            Response.Write("Delete Succesfullyyy...");
            GridView1.EditIndex = -1;
            Bind();
        }
        else
        {
            Response.Write("Failed To Delete...");
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();

        HiddenField gn = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
        HiddenField cl = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("class") as HiddenField;
        HiddenField hb = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("hobby") as HiddenField;
        HiddenField ct = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("city") as HiddenField;

        RadioButtonList rd = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList1") as RadioButtonList;
        DropDownList dl = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList1") as DropDownList;
        ListBox lb = (ListBox)GridView1.Rows[e.NewEditIndex].FindControl("ListBox1") as ListBox;
        CheckBoxList chk = GridView1.Rows[e.NewEditIndex].FindControl("CheckBoxList1") as CheckBoxList;

        rd.SelectedValue = gn.Value;
        dl.SelectedValue = cl.Value;


        string s = hb.Value;
        string[] arr = s.Split(',');

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < chk.Items.Count; j++)
            {
                if (arr[i] == chk.Items[j].Text)
                {
                    chk.Items[j].Selected = true;
                }
            }
        }

        string c = ct.Value;
        string[] arr1 = c.Split(',');

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < lb.Items.Count; j++)
            {
                if (arr1[i] == lb.Items[j].Text)
                {
                    lb.Items[j].Selected = true;
                }
            }
        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = GridView1.Rows[e.RowIndex].FindControl("Label_rollno") as Label;
        TextBox fntx = GridView1.Rows[e.RowIndex].FindControl("TextBox_fn") as TextBox;
        TextBox mntx = GridView1.Rows[e.RowIndex].FindControl("TextBox_mn") as TextBox;
        TextBox lntx = GridView1.Rows[e.RowIndex].FindControl("TextBox_ln") as TextBox;
        RadioButtonList gnrd = GridView1.Rows[e.RowIndex].FindControl("RadioButtonList1") as RadioButtonList;
        DropDownList cldd = GridView1.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
        CheckBoxList hbch = GridView1.Rows[e.RowIndex].FindControl("CheckBoxList1") as CheckBoxList;
        ListBox ctlb = GridView1.Rows[e.RowIndex].FindControl("ListBox1") as ListBox;

        bs.Rollno = int.Parse(id.Text);
        bs.fname = fntx.Text;
        bs.mname = mntx.Text;
        bs.lname = lntx.Text;
        bs.gender = gnrd.Text;
        bs.clas = cldd.Text;



        string str3 = "";
        for (int i = 0; i < hbch.Items.Count; i++)
        {
            if (cldd.Items[i].Selected == true)
            {
                if (str3 == "")
                {
                    str3 = hbch.Items[i].Text;
                }
                else
                {
                    str3 = str3 + "," + hbch.Items[i].Text;
                }
            }
        }
        string str4 = "";
        for (int i = 0; i < ctlb.Items.Count; i++)
        {
            if (ctlb.Items[i].Selected==true)
            {
                if (str4=="")
                {
                    str4 = ctlb.Items[i].Text;
                }
                else
                {
                    str4 = str4 + "," + ctlb.Items[i].Text;
                }
            }
        }
        int p = bs.bs_update(bs);
        if (p>0)
        {
            Response.Write("Update sucecsfully...");
            GridView1.EditIndex = -1;
            Bind();
        }
        else
        {
            Response.Write("Failed To update");
        }

    }
}