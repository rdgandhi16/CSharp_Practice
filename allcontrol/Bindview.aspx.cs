using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bindview : System.Web.UI.Page
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
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();

        HiddenField gn = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
        HiddenField cn = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField2") as HiddenField;
        HiddenField ct = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField3") as HiddenField;
        HiddenField hb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField4") as HiddenField;

        RadioButtonList rd = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList_gender") as RadioButtonList;
        DropDownList ddl = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList_country") as DropDownList;
        ListBox lst = GridView1.Rows[e.NewEditIndex].FindControl("ListBox1") as ListBox;
        CheckBoxList chk = GridView1.Rows[e.NewEditIndex].FindControl("CheckBoxList1") as CheckBoxList;

        rd.SelectedValue = gn.Value;
        ddl.SelectedValue = cn.Value;


        string c = ct.Value;
        string[] arr = c.Split(',');
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < lst.Items.Count; j++)
            {
                if (arr[i] == lst.Items[j].Text)
                {
                    lst.Items[j].Selected = true;
                }
            }
        }

        string h = hb.Value;
        string[] arr1 = h.Split(',');

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < chk.Items.Count; j++)
            {
                if (arr1[i] == chk.Items[j].Text)
                {
                    chk.Items[j].Selected = true;
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
        Label id = GridView1.Rows[e.RowIndex].FindControl("Label_id") as Label;

        bs.id = int.Parse(id.Text);
        TextBox fn = GridView1.Rows[e.RowIndex].FindControl("Text_fn") as TextBox;
        bs.fname = fn.Text;
        TextBox ln = GridView1.Rows[e.RowIndex].FindControl("Text_ln") as TextBox;
        bs.lname = ln.Text;
        RadioButtonList rd1 = GridView1.Rows[e.RowIndex].FindControl("RadioButtonList_gender") as RadioButtonList;
        bs.gender = rd1.Text;
        DropDownList ddl = GridView1.Rows[e.RowIndex].FindControl("DropDownList_country") as DropDownList;
        bs.country = ddl.Text;
        ListBox lst = GridView1.Rows[e.RowIndex].FindControl("ListBox1") as ListBox;
        string str1 = "";
        foreach (ListItem item in lst.Items)
        {
            if (item.Selected == true)
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
        bs.city = str1;

        CheckBoxList hb = GridView1.Rows[e.RowIndex].FindControl("CheckBoxList1") as CheckBoxList;
        string str2 = "";
        for (int i = 0; i < hb.Items.Count; i++)
        {
            if (hb.Items[i].Selected == true)
            {
                if (str2 == "")
                {
                    str2 = hb.Items[i].Text;
                }
                else
                {
                    str2 = str2 + "," + hb.Items[i].Text;
                }
            }
        }
        bs.hobby = str2;

        int p = bs.bs_update(bs);
        if (p > 0)
        {
            Response.Write("UPdate Succesfullyy...");
            GridView1.EditIndex = -1;
            Bind();
        }
        else
        {
            Response.Write("Try Again please...");
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = GridView1.Rows[e.RowIndex].FindControl("Label_id") as Label;
        bs.id = int.Parse(id.Text);


        int p = bs.bs_delete(bs);
        if (p>0)
        {
            Response.Write("Delete Succesfully...");
            GridView1.EditIndex = -1;
            Bind();
        }
        else
        {
            Response.Write("Try Again please failed to Delete..");
        }
    }
}