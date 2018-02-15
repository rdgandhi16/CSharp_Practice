using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display : System.Web.UI.Page
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
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_edi_id");
        TextBox f = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_edit_fname");
        TextBox l = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_edit_lname");

        int i = int.Parse(id.Text);
        bs.id = i;
        bs.fname = f.Text;
        bs.lname = l.Text;

        int p = bs.bs_update(bs);

        if (p>0)
        {
            Response.Write("Successfully");
            GridView1.EditIndex = -1;
            bind();
        }
        else
        {
            Response.Write("Try Again");
        }
        
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_id");
        int i = int.Parse(id.Text);
        bs.id = i;
      int p=  bs.bs_delete(bs);
      if (p > 0)
      {
          Response.Write("Successfully");
         
          bind();
      }
      else
      {
          Response.Write("Try Again");
      }
    }
}