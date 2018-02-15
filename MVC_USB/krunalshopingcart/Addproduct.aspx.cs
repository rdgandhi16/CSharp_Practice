using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addproduct : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.pname = pname.Text;
        bs.pprice = int.Parse(pprice.Text);
        bs.pdetail = pdetail.Text;
        bs.pcategory = DropDownList1.SelectedValue;
        string path, fullpath, filename, temp;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/image/");
            fullpath = path + "//" + filename;

            FileUpload1.SaveAs(fullpath);
            temp = "~/image/" + filename;
            bs.pimg = temp;
        }

        int p = bs.bs_addprod(bs);
        if (p > 0)

        {
            Response.Write("Product Added Successfully...");
        }
    }
}