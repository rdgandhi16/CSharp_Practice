using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Empdetail : System.Web.UI.Page
{

    business buss = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDep();
            BindEmpdata();
        }
    }
    public void BindDep()
    {
        ddlDep.DataSource = buss.buss_Binddep();
        ddlDep.DataTextField = "DepName";
        ddlDep.DataValueField = "DeptId";
        ddlDep.DataBind();
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        buss.ename = txtEname.Text;
        buss.address = txtAddress.Text;
        buss.city = ddlCity.Text;
        buss.depart = ddlDep.Text;
        buss.jdate = txtJdate.Text;
        buss.bdate = txtJdate.Text;
        buss.gender = RadioButtonList1.Text;

        bool stractive;
        if (chkYes.Checked == true)
        {
            stractive = true;
        }
        else
        {
            stractive = false;
        }
        buss.isact = stractive;

        int p = buss.buss_insertempdata(buss);
        if (p > 0)
        {
            Response.Write("Emp Detail has been Saved");
        }
        else
        {
            Response.Write("Failed to Save Employee Detail");
        }
    }

    public void BindEmpdata()
    {
        GridView1.DataSource = buss.bs_bindemp();
        GridView1.DataBind();
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblEid.Text = (GridView1.SelectedRow.FindControl("lblId") as Label).Text;
        txtEname.Text = (GridView1.SelectedRow.FindControl("lblEname") as Label).Text;
        txtAddress.Text = (GridView1.SelectedRow.FindControl("lbladd") as Label).Text;
        ddlCity.Text = (GridView1.SelectedRow.FindControl("lblCity") as Label).Text;
        ddlDep.SelectedValue = (GridView1.SelectedRow.FindControl("hdnDep") as HiddenField).Value;
        txtJdate.Text = (GridView1.SelectedRow.FindControl("lblJdate") as Label).Text;
        txtBdate.Text = (GridView1.SelectedRow.FindControl("lblBdate") as Label).Text;
        RadioButtonList1.Text = (GridView1.SelectedRow.FindControl("lblGender") as Label).Text;

        string str = (GridView1.SelectedRow.FindControl("lblIsact") as Label).Text;
        if (str == "True")
        {
            chkYes.Checked = true;
            chkNo.Checked = false;
        }
        else
        {
            chkNo.Checked = true;
            chkYes.Checked = false;
        }

        //buss.bs_textbox(buss);
        //BindEmpdata();

    }
}