using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listview : System.Web.UI.Page
{
    businesslayer bs = new businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            display();
        }

    }
    public void display()
    {
        ListView1.DataSource = bs.bs_bind();
        ListView1.DataBind();
    }
    protected void ListView1_ItemEditing(object sender, ListViewEditEventArgs e)
    {
        ListView1.EditIndex = e.NewEditIndex;
        display();
    }
    protected void ListView1_ItemUpdating(object sender, ListViewUpdateEventArgs e)
    {
        Label id = (Label)ListView1.Items[e.ItemIndex].FindControl("lbl_edit_id");
        TextBox fn = (TextBox)ListView1.Items[e.ItemIndex].FindControl("TextBox1");
        TextBox ln = (TextBox)ListView1.Items[e.ItemIndex].FindControl("TextBox2");
        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;
        int p = bs.bs_update(bs);
        if (p > 0)
        {
            Response.Write("Success..");
            ListView1.EditIndex = -1;
            display();
        }
        else
        {
            Response.Write("Failed...");
        }
    }
    protected void ListView1_ItemDeleting(object sender, ListViewDeleteEventArgs e)
    {
        Label id = (Label)ListView1.Items[e.ItemIndex].FindControl("lbl_id");
        bs.id = int.Parse(id.Text);
   
        int p=     bs.bs_delete(bs);
        if (p > 0)
        {
            Response.Write("Success..");
            ListView1.EditIndex = -1;
            display();



        }
        else
        {
            Response.Write("Failed...");
        }

    }
    protected void ListView1_ItemInserting(object sender, ListViewInsertEventArgs e)
    {
        TextBox id = (TextBox)ListView1.InsertItem.FindControl("id");
        TextBox fn = (TextBox)ListView1.InsertItem.FindControl("fn");
        TextBox ln = (TextBox)ListView1.InsertItem.FindControl("ln");
        bs.id =int.Parse( id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;
      int p=  bs.bs_insert(bs);
        if (p > 0)
        {
            Response.Write("Success..");
            ListView1.EditIndex = -1;
            display();



        }
        else
        {
            Response.Write("Failed...");
        }

    }
}