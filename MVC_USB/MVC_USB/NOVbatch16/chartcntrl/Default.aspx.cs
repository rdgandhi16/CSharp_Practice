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
    string str = @"Data Source=PC-PC2\SQL2008;Initial Catalog=db_28dec;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();            
        }
    }
    public void bind()
    {
        try
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_char", con);
            DataSet dt = new DataSet();
            da.Fill(dt);
            Chart1.DataSource = dt;
            Chart1.DataBind();
        }
        catch(Exception ex)
        {
            Response.Write(ex);
         //   Response.Redirect("404.aspx");
        }
        finally { }
    }
}