using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Add_Category : System.Web.UI.Page
{
    BusinessLayer bs = new BusinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    public void add_cat()
    {
        bs.category_name = cat_name.Text;
        int q = bs.bl_add_category(bs);
        if (q>0)
        {
           // Response.Write("Category Added");
            ClientScript.RegisterStartupScript(GetType(), "msg", "alert('Category Added');", true);
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        add_cat();
    }
}