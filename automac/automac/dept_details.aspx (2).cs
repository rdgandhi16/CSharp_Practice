using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dept_details : System.Web.UI.Page
{

    business bs = new business();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            dept_grid();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.deptname = dname1.Text;
        bs.bs_dept_insert(bs);
        dept_grid();
    }


    public void dept_grid()
    {
        Button1.Visible = true;
        Button2.Visible = false;
        GridView1.DataSource = bs.bs_dept_grid();
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Button1.Visible = false;
        Button2.Visible = true;
        Label1.Text = (GridView1.SelectedRow.FindControl("id") as Label).Text;
        dname1.Text = (GridView1.SelectedRow.FindControl("dname") as Label).Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bs.deptid = int.Parse(Label1.Text);
        bs.deptname = dname1.Text;
        bs.bs_update_dept(bs);
        dept_grid();
    }
}