using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class remaincntrl : System.Web.UI.Page
{
    string f, path, fullpath;
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    //Panel1.Visible = false;
    //    //Panel2.Visible = true;
    //}
    protected void btn_Click(object sender, EventArgs e)
    {
        f = FileUpload1.FileName;
        path = Server.MapPath("~/file/");
        fullpath = path + "\\" + f;

        FileUpload1.SaveAs(fullpath);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
}