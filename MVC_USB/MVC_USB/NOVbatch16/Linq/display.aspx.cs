using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class display : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();   
        }
    }
    public void bind()
    {
        GridView1.DataSource = from n in dc.tbl_regs select n;
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
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("id");
        int i = int.Parse(id.Text);

        var p = (from n in dc.tbl_regs where n.id == i select n).FirstOrDefault();

        dc.tbl_regs.DeleteOnSubmit(p);
        dc.SubmitChanges();
        bind();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("id1");
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("fn1");
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("ln1");
       int i = int.Parse(id.Text);

       var p = (from n in dc.tbl_regs where n.id == i select n).FirstOrDefault();
       p.fname = fn.Text;
       p.lname = ln.Text;

       dc.SubmitChanges();
       GridView1.EditIndex = -1;
       bind();
       
        

    }
}