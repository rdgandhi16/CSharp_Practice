using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BlueGreenButton : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ImageButton1.Attributes.Add("onmouseover", "this.src='/image/green.png'");
        ImageButton1.Attributes.Add("onmouseout", "this.src='/image/blue.jpg'");
        ImageButton1.Attributes.Add("onclick", "return confirm('are you sure')");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("server side click event handled");
    }
}