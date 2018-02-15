using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Department : System.Web.UI.Page
{
    business depbuss = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddepartment();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
       // btnUpdate.Visible = false;
        depbuss.depname = txtDepname.Text;
        int p = depbuss.business_Depinsert(depbuss);
        if (p>0)
        {
            Response.Write("Department name is Saved");
            GridView1.EditIndex = -1;
            Binddepartment();
        }
        else
        {
            Response.Write("Failed to save department name");
        }
    }

    public void Binddepartment()
    {
        GridView1.DataSource = depbuss.business_depBind();
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnSave.Visible = false;
        btnUpdate.Visible = true;
        Label1.Text = (GridView1.SelectedRow.FindControl("lblId") as Label).Text;
        txtDepname.Text = (GridView1.SelectedRow.FindControl("lblDname") as Label).Text;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        depbuss.depid = int.Parse(Label1.Text);
        depbuss.depname = txtDepname.Text;
        int p = depbuss.business_depupdate(depbuss);
        if (p>0)
        {
            Response.Write("Updated Succesfully");
            GridView1.EditIndex = -1;
            Binddepartment();
        }
        else
        {
            Response.Write("Failed to Update");
            GridView1.EditIndex = -1;
            Binddepartment();
        }

    }
}