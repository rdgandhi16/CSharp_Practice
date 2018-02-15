using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datalist : System.Web.UI.Page
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
        DataList1.DataSource = bs.bs_bind();
        DataList1.DataBind();
    }
    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        bind();

    }
    protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = -1;
        bind();
    }
    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        Label id = (Label)DataList1.Items[e.Item.ItemIndex].FindControl("lbl_edit_id");
        TextBox fn = (TextBox)DataList1.Items[e.Item.ItemIndex].FindControl("TextBox1");
        TextBox ln = (TextBox)DataList1.Items[e.Item.ItemIndex].FindControl("TextBox2");
        bs.id = int.Parse(id.Text);
        bs.fname = fn.Text;
        bs.lname = ln.Text;
        int p = bs.bs_update(bs);
        if (p > 0)
        {
            Response.Write("Success..");
        }
        else
        {
            Response.Write("Failed..");
        }
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        Label id = (Label)DataList1.Items[e.Item.ItemIndex].FindControl("lbl_id");
        bs.id = int.Parse(id.Text);
        bs.bs_delete(bs);
        bind();

    }
}