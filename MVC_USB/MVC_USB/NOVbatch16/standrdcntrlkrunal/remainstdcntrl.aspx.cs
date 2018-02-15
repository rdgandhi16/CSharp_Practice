using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class remainstdcntrl : System.Web.UI.Page
{
    string filename, path, fullpath;

    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    if (FileUpload1.HasFile)
    //    {
    //        filename = FileUpload1.FileName;
    //        path = Server.MapPath("~/images/");
    //        fullpath = path + "\\" + filename;

    //        FileUpload1.SaveAs(fullpath);
    //    }
    //    else
    //    {

    //    }
       
    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    string str = "";
    //    foreach (ListItem item in ListBox1.Items)
    //    {
    //        if (item.Selected==true)
    //        {
    //            if (str == "")
    //            {
    //                str = item.Text;
    //            }
    //            else
    //            {
    //                str = str + item;
    //            }
                
    //        }
    //    }

    //    lbl.Text = str;
    //}
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Panel2.Visible = true;
    //    Panel1.Visible = false;
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
}