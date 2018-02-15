using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detailsview : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    databaselayer db = new databaselayer();
    protected void Page_Load(object sender, EventArgs e)
    {        if (!IsPostBack)
        {
            bind();
        }
    }

    public void bind()
    {
        DetailsView1.DataSource = bs.bs_bind();
        DetailsView1.DataBind();
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        DetailsView1.PageIndex = e.NewPageIndex;
        bind();
    }
    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        DetailsView1.ChangeMode(e.NewMode);
        bind();

    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        Label id = (Label)DetailsView1.Rows[0].FindControl("lbl_edit_id");
        TextBox fname = (TextBox)DetailsView1.Rows[1].FindControl("txt_fname");
        TextBox lname = (TextBox)DetailsView1.Rows[2].FindControl("txt_lname");

        bs.id = int.Parse(id.Text);
        bs.fname = fname.Text;
        bs.lname = lname.Text;
        int p = bs.bs_update(bs);
        
        if (p > 0)
        {
            DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
            bind();
            Response.Write("Success..");
        }
        else
        {
            Response.Write("Failed");
        }

    }
    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        Label id = (Label)DetailsView1.Rows[0].FindControl("lbl_id");
        bs.id = int.Parse(id.Text);

      int p=  bs.bs_delete(bs);
        if (p > 0)
        {
            DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
            bind();
            Response.Write("Success..");
        }
        else
        {
            Response.Write("Failed");
        }

    }
    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        TextBox id = (TextBox)DetailsView1.Rows[0].FindControl("txt_insert_id");
        TextBox fn = (TextBox)DetailsView1.Rows[1].FindControl("txt_insert_fn");
        TextBox ln = (TextBox)DetailsView1.Rows[2].FindControl("txt_insert_ln");
        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;
        int p = bs.bs_insert(bs);
        if (p > 0)
        {
            DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
            bind();
            Response.Write("Success..");
        }
        else
        {
            Response.Write("Failed");
        }
    }
}