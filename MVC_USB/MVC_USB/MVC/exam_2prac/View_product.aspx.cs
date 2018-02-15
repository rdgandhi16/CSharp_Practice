using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_product : System.Web.UI.Page
{
    BusinessLayer bs = new BusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dl_bind();
            bind();
        }
    }

    public void dl_bind()
    {
        DropDownList1.DataSource = bs.bl_getCat();
        DropDownList1.DataTextField = "CategoryName";
        DropDownList1.DataValueField = "CategoryId";
        DropDownList1.DataBind();

    }


    public void bind()
    {
        bs.product_cat_id = int.Parse(DropDownList1.SelectedValue);
        DataList1.DataSource = bs.bl_get_product(bs);
        DataList1.DataBind();
    }
     

   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        bind();
        
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "show")
        {
            Response.Redirect("Details.aspx");
           
        }

    }
}