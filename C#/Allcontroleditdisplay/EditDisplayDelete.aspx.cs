using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditDisplayDelete : System.Web.UI.Page
{
    business buss = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    public void Bind()
    {
        GridView1.DataSource = buss.business_bindEmpdata();
        GridView1.DataBind();
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();

        HiddenField hdnGender = GridView1.Rows[e.NewEditIndex].FindControl("hdnGender") as HiddenField;
        HiddenField hdndept = GridView1.Rows[e.NewEditIndex].FindControl("hdnDept") as HiddenField;
        HiddenField hdnSkill = GridView1.Rows[e.NewEditIndex].FindControl("hdnSkill") as HiddenField;
       // HiddenField hdnState = GridView1.Rows[e.NewEditIndex].FindControl("hdnState") as HiddenField;

       // TextBox fname = GridView1.Rows[e.NewEditIndex].FindControl("txtFname") as TextBox;
       // TextBox lname = GridView1.Rows[e.NewEditIndex].FindControl("txtLname") as TextBox;        
        RadioButtonList radiogender = GridView1.Rows[e.NewEditIndex].FindControl("radioGender") as RadioButtonList;
        DropDownList ddlDept = GridView1.Rows[e.NewEditIndex].FindControl("ddlDept") as DropDownList;
        CheckBoxList chkSkill = GridView1.Rows[e.NewEditIndex].FindControl("chkSkill") as CheckBoxList;
      //  ListBox listState = GridView1.Rows[e.NewEditIndex].FindControl("listState") as ListBox;


        radiogender.SelectedValue = hdnGender.Value;
        ddlDept.SelectedValue = hdndept.Value;

        string empskill = hdnSkill.Value;
        string[] arr = empskill.Split(',');

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < chkSkill.Items.Count; j++)
            {
                if (arr[i] == chkSkill.Items[j].Text)
                {
                    chkSkill.Items[j].Selected = true;
                }
            }
        }

        //string empstate = hdnState.Value;
        //string[] arr1 = empstate.Split(',');

        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    for (int j = 0; j < listState.Items.Count; j++)
        //    {
        //        if (arr1[1] == listState.Items[j].Text)
        //        {
        //            listState.Items[j].Selected = true;
        //        }
        //    }
        //}
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = GridView1.Rows[e.RowIndex].FindControl("lbleditId") as Label;
        TextBox fname = GridView1.Rows[e.RowIndex].FindControl("txtFname") as TextBox;
        TextBox lname = GridView1.Rows[e.RowIndex].FindControl("txtLname") as TextBox;
        RadioButtonList radioGender = GridView1.Rows[e.RowIndex].FindControl("radioGender") as RadioButtonList;
        DropDownList ddlDept = GridView1.Rows[e.RowIndex].FindControl("ddlDept") as DropDownList;
        CheckBoxList ckhSkill = GridView1.Rows[e.RowIndex].FindControl("chkSkill") as CheckBoxList;
        ListBox lstState = GridView1.Rows[e.RowIndex].FindControl("listState") as ListBox;


        buss.eid = int.Parse(id.Text);
        buss.fname = fname.Text;
        buss.lname = lname.Text;
        buss.gender = radioGender.Text;
        buss.department = ddlDept.Text;

        string strskil = "";
        for (int i = 0; i < ckhSkill.Items.Count; i++)
        {
            if (ckhSkill.Items[i].Selected == true)
            {
                if (strskil == "")
                {
                    strskil = ckhSkill.Items[i].Text;
                }
                else
                {
                    strskil = strskil + ',' + ckhSkill.Items[i].Text;
                }
            }
        }
        buss.skills = strskil;

        //string strstate = "";
        //foreach (ListItem item in lstState.Items)
        //{
        //    if (item.Selected == true)
        //    {
        //        if (strstate == "")
        //        {
        //            strstate = item.Text;
        //        }
        //        else
        //        {
        //            strstate = strstate + '.' + item.Text;
        //        }
        //    }
        //}
        
        try
        {
            buss.bussemp_update(buss);
            Response.Write("Update Succesfully");
            GridView1.EditIndex = -1;
            Bind();
        }
        catch (Exception)
        {
            Response.Write("Failed to Update");
            GridView1.EditIndex = -1;
            Bind();
           // throw;
        }
    }
}