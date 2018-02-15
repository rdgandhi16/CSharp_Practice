using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display : System.Web.UI.Page
{
    business bs = new business();
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
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_edit_id");
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_fname");
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_lname");

        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;

        try
        {
            bs.bs_update(bs);
            GridView1.EditIndex = -1;
            bind();
            Response.Write("Success..");
        }
        catch {
            Response.Write("Failed");
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_id");
        bs.id = int.Parse(id.Text);

        bs.bs_delete(bs);
        bind();

    }
}