using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class formview : System.Web.UI.Page
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
        FormView1.DataSource = bs.bs_bind();
        FormView1.DataBind();
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {
        FormView1.PageIndex = e.NewPageIndex;
        bind();
    }
    protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)
    {
        FormView1.ChangeMode(e.NewMode);
        bind();
    }
    protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
    {
        Label id = (Label)FormView1.FindControl("lbl_edit_id");
        TextBox fn = (TextBox)FormView1.FindControl("TextBox1");
        TextBox ln = (TextBox)FormView1.FindControl("TextBox2");

        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;

      int p=  bs.bs_update(bs);
        if (p>0)
        {
            Response.Write("Success..");
            FormView1.ChangeMode(FormViewMode.ReadOnly);
            bind();
        }
        else
        {
            Response.Write("Failed...");
        }
        
    }
    protected void FormView1_ItemDeleting(object sender, FormViewDeleteEventArgs e)
    {
        Label id = (Label)FormView1.FindControl("lbl_id");
        bs.id = int.Parse(id.Text);
     int p=   bs.bs_delete(bs);
        if (p > 0)
        {
            Response.Write("Success..");
          
            bind();
        }
        else
        {
            Response.Write("Failed...");
        }
        

    }
    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        TextBox id = (TextBox)FormView1.FindControl("id");
        TextBox fn = (TextBox)FormView1.FindControl("fn");
        TextBox ln = (TextBox)FormView1.FindControl("ln");

        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;
      int p=  bs.bs_insert(bs);
      if (p > 0)
      {
          Response.Write("Success..");
          FormView1.ChangeMode(FormViewMode.ReadOnly);


          bind();
      }
      else
      {
          Response.Write("Failed...");
      }
    }
}