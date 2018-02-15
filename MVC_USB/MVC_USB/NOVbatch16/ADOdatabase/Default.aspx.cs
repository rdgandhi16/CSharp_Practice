using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into tbl_reg(fname,lname) values(@fn,@ln)";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
       
        cmd.Parameters.AddWithValue("@fn", fname.Text);
        cmd.Parameters.AddWithValue("@ln", lastname.Text);

        con.Open();
        int p=cmd.ExecuteNonQuery();
        if (p>0)
        {
            Label1.ForeColor = System.Drawing.Color.Green;
            Label1.Text = "Insert successfully";
            //Response.Write("Insert successfully");            
        }
        else
        {
            Label1.ForeColor = Color.Red;
            Label1.Text = "Try Again";
           // Response.Write("Try Again");
        }
        con.Close();

    }
}