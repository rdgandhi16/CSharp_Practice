using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class display : System.Web.UI.Page
{
    string str = @"Data Source=PC-PC2\SQL2008;Initial Catalog=db_mitesh1;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }

    public void bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from tbl_reg";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
}