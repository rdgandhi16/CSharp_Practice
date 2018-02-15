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
}