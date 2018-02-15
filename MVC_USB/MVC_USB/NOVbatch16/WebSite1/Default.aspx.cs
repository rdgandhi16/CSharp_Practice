using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string str = @"Data Source=PC-PC2\SQL2008;Initial Catalog=db_rajesh;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fn=fname.Text;
        string ln = lname.Text;

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into tbl_rajesh(fname,lname) values('" + fn + "','" + ln + "')";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // if (DropDownList1.SelectedItem=="1")
        //{
            
        //}
        if (true)
        {

        }
       // for (int i = 0; i < length; i++)
        {

        }
    }
}