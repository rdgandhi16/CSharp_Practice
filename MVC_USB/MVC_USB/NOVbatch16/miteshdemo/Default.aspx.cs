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
    string str = @"Data Source=PC-PC2\SQL2008;Initial Catalog=db_mitesh1;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void sub_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into tbl_reg(fname,lname) values(@fn,@ln)";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@fn", fn.Text);
        cmd.Parameters.AddWithValue("@ln", ln.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}