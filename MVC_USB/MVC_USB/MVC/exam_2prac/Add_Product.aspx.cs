using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_Product : System.Web.UI.Page
{
    BusinessLayer bs = new BusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cat_bind();
        }
    }

    public void cat_bind()
    {
        DropDownList1.DataSource = bs.bl_getCat();
        DropDownList1.DataTextField = "CategoryName";
        DropDownList1.DataValueField = "CategoryId";
        DropDownList1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.product_cat_id = int.Parse(DropDownList1.SelectedValue);
        bs.product_name = P_name.Text;
        bs.product_price = float.Parse(p_price.Text);
        bs.product_qty = int.Parse(p_qty.Text);
        bs.product_description = P_Desc.Text;

        string filename = FileUpload1.FileName;
        string path = Server.MapPath("~/Images/");
        string fullpath = path + filename;
        FileUpload1.SaveAs(fullpath);


        string temp = "~/Images/" + filename;
        bs.product_image = temp;

        int q = bs.bl_add_product(bs);

        if (q>0)
        {
            ClientScript.RegisterStartupScript(GetType(), "msg", "alert('Product Added');", true);
        }
        //Response.Write(temp);
    }
}