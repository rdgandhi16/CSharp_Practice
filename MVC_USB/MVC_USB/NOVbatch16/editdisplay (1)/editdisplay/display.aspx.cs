using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class display : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    string filename, path, fullpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    public void bind()
    {
        GridView1.DataSource = bs.bs_bind();
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();

        HiddenField gn = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
        HiddenField hb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField2") as HiddenField;
        HiddenField sb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField3") as HiddenField;
        HiddenField st = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField4") as HiddenField;

        RadioButtonList rdl = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList1") as RadioButtonList;
        CheckBoxList chk = GridView1.Rows[e.NewEditIndex].FindControl("CheckBoxList1") as CheckBoxList;
        ListBox lst = GridView1.Rows[e.NewEditIndex].FindControl("ListBox1") as ListBox;
        DropDownList ddl = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList1") as DropDownList;

        ddl.SelectedValue = st.Value;
        rdl.SelectedValue = gn.Value;
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

        string p = sb.Value;
        string[] arr1 = p.Split(',');

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < lst.Items.Count; j++)
            {
                if (arr1[i] == lst.Items[j].Text)
                {
                    lst.Items[j].Selected = true;
                }
            }
        }
    
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType==DataControlRowType.DataRow && GridView1.EditIndex==e.Row.RowIndex)
        //{
        //    RadioButtonList rdo = (RadioButtonList)e.Row.FindControl("RadioButtonList1");
        //    CheckBoxList chk = (CheckBoxList)e.Row.FindControl("CheckBoxList1");
        //    ListBox lst = (ListBox)e.Row.FindControl("ListBox1");
        //    DropDownList drop = (DropDownList)e.Row.FindControl("DropDownList1");

        //    DataRowView dr = e.Row.DataItem as DataRowView;

        //    drop.SelectedValue = dr["state"].ToString();
        //    rdo.SelectedValue = dr["gender"].ToString();

        //    string s = dr["hobby"].ToString();
        //    string[] arr = s.Split(',');

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < chk.Items.Count; j++)
        //        {
        //            if (arr[i]==chk.Items[j].Text)
        //            {
        //                chk.Items[j].Selected = true;
        //            }
        //        }
        //    }

        //    string p = dr["subject"].ToString();
        //    string[] arr1 = p.Split(',');


        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        for (int j = 0; j < lst.Items.Count; j++)
        //        {
        //            if (arr1[i] == lst.Items[j].Text)
        //            {
        //                lst.Items[j].Selected = true;
        //            }
        //        }
        //    }
        // }
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("Labeledid");
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxfn");
        RadioButtonList gen = (RadioButtonList)GridView1.Rows[e.RowIndex].FindControl("RadioButtonList1");
        CheckBoxList hobby = (CheckBoxList)GridView1.Rows[e.RowIndex].FindControl("CheckBoxList1");
        ListBox sub = (ListBox)GridView1.Rows[e.RowIndex].FindControl("ListBox1");
        DropDownList state = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownList1");
        FileUpload img = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1");
        HiddenField h1 = (HiddenField)GridView1.Rows[e.RowIndex].FindControl("HiddenField5");



        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.gender = gen.Text;

        string str = "";

        for (int i = 0; i < hobby.Items.Count; i++)
        {
            if (hobby.Items[i].Selected == true)
            {
                if (str == "")
                {
                    str = hobby.Items[i].Text;
                }
                else
                {
                    str = str + "," + hobby.Items[i].Text;
                }
            }
        }
        bs.hobby = str;
        string str1 = "";
        foreach (ListItem item in sub.Items)
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
        bs.subject = str1;
        bs.state = state.Text;


        if (img.HasFile)
        {
            filename = img.FileName;
            path = Server.MapPath("~/image/");
            fullpath = path + "\\" + filename;

            img.SaveAs(fullpath);
            temp = "~/image/" + filename;
        }
        else
        {
            temp = h1.Value;
        }
        bs.image = temp;

        try
        {
            bs.bs_update(bs);
            GridView1.EditIndex = -1;
            bind();

        }
        catch (Exception)
        {
            Response.Redirect("Default.aspx");
            
            //throw;
        }

    }
}