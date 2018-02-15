using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

public partial class Bindfnln : System.Web.UI.Page
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
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("Label_Id");

        int i = int.Parse(id.Text);
        bs.Rollno = i;

        int p = bs.bs_delete(bs);
        if (p > 0)
        {
            Response.Write("Successfully");
            
            Bind();
        }
        else
        {
            Response.Write("Try Again");
        }
        
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("Label_Id") as Label;
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox_fn") as TextBox;
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox_ln") as TextBox;

        int i = int.Parse(id.Text);
        
        bs.Rollno = i;
        
        bs.fname = fn.Text;
        bs.lname = ln.Text;

        int p = bs.bs_update(bs);
        if (p>0)
        {
            Response.Write("Update Succesfullyy..");
            GridView1.EditIndex = -1;            
            Bind();
        }
        else
        {
            Response.Write("Failed to Update...");
        }
        
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
}