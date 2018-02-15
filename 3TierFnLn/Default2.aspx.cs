using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
public partial class Default2 : System.Web.UI.Page
{
    Business bs = new Business();
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
        DataBind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("") as Label;
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("Text_fn") as TextBox;
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("Text_ln") as TextBox;

        //int i = int.Parse(id.Text);
        //bs.id = i;
        bs.fname = fn.Text;
        bs.lname = ln.Text;

        int p = bs.bs_update(bs);
        if (p>0)
        {
            Response.Write("Update succesfullyyy..");
            GridView1.EditIndex = -1;
            bind();
        }
        else
        {
            Response.Write("Error..");
        }



    }
}