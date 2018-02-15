using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Gridreg : System.Web.UI.Page
{
    Business bs = new Business();

    string filename, path, fullpath, temp, str;
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
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();

        HiddenField gn = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
        HiddenField hb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField2") as HiddenField;
        HiddenField st = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField3") as HiddenField;
        HiddenField ct = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField4") as HiddenField;

        RadioButtonList rb = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList1") as RadioButtonList;
        CheckBoxList cb = GridView1.Rows[e.NewEditIndex].FindControl("CheckBoxList1") as CheckBoxList;
        DropDownList dd1 = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList1") as DropDownList;
        DropDownList dd2 = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList2") as DropDownList;

        rb.SelectedValue = gn.Value;
        dd1.SelectedValue = st.Value;
        dd2.SelectedValue = ct.Value;

        string h = hb.Value;
        string[] arr = h.Split(',');
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < cb.Items.Count; j++)
            {
                if (arr[i] == cb.Items[j].Text)
                {
                    cb.Items[j].Selected = true;
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
        bs.rollno = int.Parse(id.Text);

        TextBox fn = GridView1.Rows[e.RowIndex].FindControl("Text_fname") as TextBox;
        bs.fname = fn.Text;
        TextBox ln = GridView1.Rows[e.RowIndex].FindControl("Text_lname") as TextBox;
        bs.lname = ln.Text;

        TextBox dt = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
        bs.datetime = dt.Text;

        RadioButtonList rd = GridView1.Rows[e.RowIndex].FindControl("RadioButtonList1") as RadioButtonList;
        bs.gender = rd.Text;
        DropDownList dd1 = GridView1.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
        bs.state = dd1.Text;

        DropDownList dd2 = GridView1.Rows[e.RowIndex].FindControl("DropDownList2") as DropDownList;
        bs.city = dd2.Text;

        CheckBoxList cb = GridView1.Rows[e.RowIndex].FindControl("CheckBoxList1") as CheckBoxList;

        string str1 = "";
        for (int i = 0; i < cb.Items.Count; i++)
        {
            if (cb.Items[i].Selected == true)
            {
                if (str1 == "")
                {
                    str1 = cb.Items[i].Text;
                }
                else
                {
                    str1 = str1 + "," + cb.Items[i].Text;
                }
            }
        }

        bs.hobby = str1;

        HiddenField im = GridView1.Rows[e.RowIndex].FindControl("HiddenField5") as HiddenField;
        FileUpload im1 = GridView1.Rows[e.RowIndex].FindControl("FileUpload1") as FileUpload;
        if (im1.HasFile)
        {
            filename = im1.FileName;
            path = Server.MapPath("~/image/");
            fullpath = path + "\\" + filename;

            im1.SaveAs(fullpath);
            temp = "~/image/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;

        int p = bs.bs_updaterinkalreg(bs);
        if (p > 0)
        {
            Response.Write("Update Succesfully..");
            GridView1.DataBind();
            Bind();
        }
        else
        {
            Response.Write("Failed To Update...");
            GridView1.EditIndex = -1;
            Bind();
        }
    }

}