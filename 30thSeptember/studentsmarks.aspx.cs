using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentsmarks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = Text_name.Text;
        Label2.Text = Text_surname.Text;
        Label3.Text = Text_Class.Text;
        Label4.Text = Text_Result.Text;
        Label5.Text = RadioButtonList1.Text;
    }
}