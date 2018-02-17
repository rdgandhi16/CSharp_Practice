using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display_fnamelname : System.Web.UI.Page
{
    Businesslayer blayer = new Businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    public void Bind()
    {
        GridView1.DataSource = blayer.blayer_displayfnamelname();
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();

        HiddenField gender = GridView1.Rows[e.NewEditIndex].FindControl("hfGender") as HiddenField;
        HiddenField hobby = GridView1.Rows[e.NewEditIndex].FindControl("hfHobby") as HiddenField;
        HiddenField state = GridView1.Rows[e.NewEditIndex].FindControl("hfState") as HiddenField;

        RadioButtonList rdgender = GridView1.Rows[e.NewEditIndex].FindControl("rdEditGender") as RadioButtonList;
        CheckBoxList chhobby = GridView1.Rows[e.NewEditIndex].FindControl("chEditHobby") as CheckBoxList;
        DropDownList ddlstate = GridView1.Rows[e.NewEditIndex].FindControl("ddlEditState") as DropDownList;

        rdgender.SelectedValue = gender.Value;
        //chhobby.SelectedValue = hobby.Value;
        ddlstate.SelectedValue = state.Value;

        string str1 = hobby.Value;
        string[] array = str1.Split(',');

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < chhobby.Items.Count; j++)
            {
                if (array[i]==chhobby.Items[j].Text)
                {
                    chhobby.Items[j].Selected = true;
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
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lblEditId");
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditFname");
        TextBox mn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditMname");
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditLname");
        RadioButtonList gen = (RadioButtonList)GridView1.Rows[e.RowIndex].FindControl("rdEditGender");
        CheckBoxList hb = (CheckBoxList)GridView1.Rows[e.RowIndex].FindControl("chEditHobby");
        DropDownList st = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlEditState");

        blayer.sid = int.Parse(id.Text);
        blayer.fname = fn.Text;
        blayer.mname = mn.Text;
        blayer.lname = ln.Text;
        blayer.gender = gen.Text;

        string str1 = "";
        for (int i = 0; i < hb.Items.Count; i++)
        {
            if (hb.Items[i].Selected==true)
            {
                if (str1=="")
                {
                    str1 = hb.Items[i].Text;
                }
                else
                {
                    str1 = str1 + "," + hb.Items[i].Text;
                }
            }
        }
        blayer.hobby = str1;
        blayer.state = st.Text;

        int p = blayer.blayer_updatefnamelname(blayer);
        if (p>0)
        {
            Response.Write("Update Succesfullyy..");
            GridView1.EditIndex = -1;
            Bind();

        }
        else
        {
            GridView1.EditIndex = -1;
            Bind();
            Response.Write("Failed to Update..");
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lblID");

        blayer.sid = int.Parse(id.Text);

        int p = blayer.blayer_deletefnamelname(blayer);
        if (p>0)
        {
            Response.Write("Delete succesfully...");
            GridView1.EditIndex = -1;
            Bind();
        }
        else
        {
            Response.Write("Failed to delete...");
        }
    }
}