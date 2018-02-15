using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Display : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["str"].ToString();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();

        }
      
    }

    public void bind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_bind";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_edit_id");
        TextBox fn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_fnamenew");
        TextBox ln = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_lnamenew");

        int i = int.Parse(id.Text);
        string fname = fn.Text;
        string lname = ln.Text;
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_update";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", i);
        cmd.Parameters.AddWithValue("@f", fname);
        cmd.Parameters.AddWithValue("@l", lname);

        con.Open();
       int p= cmd.ExecuteNonQuery();
       if (p>0)
       {
           Response.Write("Update Successfully");
           GridView1.EditIndex = -1;
           bind();
       }
       else
       {
           Response.Write("Try Again");
       }
        con.Close();
    
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_id");

        int i=int.Parse(id.Text);
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_delete";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", i);

        con.Open();
        int p=cmd.ExecuteNonQuery();
        if (p>0)
        {
            bind();
        }
        con.Close();
    }
}