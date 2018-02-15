using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class emp_details : System.Web.UI.Page
{
    business bs = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            jdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            emp_grid();
            dept_bind();
        }
    }


    public void emp_grid()
    {
        GridView1.DataSource = bs.bs_emp_grid();
        GridView1.DataBind();

    }

    public void dept_bind()
    {
        DropDownList1.DataSource = bs.bs_dept_grid();
        DropDownList1.DataTextField = "deptname";
        DropDownList1.DataValueField = "deptid";
        DropDownList1.DataBind();
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.ename = ename.Text;
        bs.addr = addr.Text;
        bs.city = city.Text;
        bs.deptid = int.Parse(DropDownList1.SelectedItem.Value);
        bs.jdate = jdate.Text;
        bs.bdate = bdate.Text;
        string str = "";
        if (male.Checked == true)
        {
            str = male.Text;
        }
        else
        {
            str = female.Text;
        }

        bs.gender = str;

        bool str1;
        if (yes.Checked == true)
        {
            str1 = true;
        }
        else
        {
            str1 = false;
        }
        bs.isact = str1;


        bs.bs_emp_insert(bs);
        emp_grid();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        eid.Text = (GridView1.SelectedRow.FindControl("eid") as Label).Text;
        ename.Text = (GridView1.SelectedRow.FindControl("ename") as Label).Text;
        addr.Text = (GridView1.SelectedRow.FindControl("addr") as Label).Text;
        city.Text = (GridView1.SelectedRow.FindControl("city") as Label).Text;
        DropDownList1.SelectedValue = (GridView1.SelectedRow.FindControl("HiddenField1") as HiddenField).Value;
      //  jdate.Text = (GridView1.SelectedRow.FindControl("jdate") as Label).Text;
        string str10 = (GridView1.SelectedRow.FindControl("jdate") as Label).Text;
        jdate.Text = DateTime.Parse(str10).ToShortDateString();
        bdate.Text = (GridView1.SelectedRow.FindControl("bdate") as Label).Text;
        string str = (GridView1.SelectedRow.FindControl("gen") as Label).Text;
        if (str == "Male")
        {
            male.Checked = true;

        }
        else
        {
            female.Checked = true;
        }

        string str1 = (GridView1.SelectedRow.FindControl("isa") as Label).Text;
        if (str1 == "True")
        {
            yes.Checked = true;
            no.Checked = false;
        }
        else
        {
            no.Checked = true;
            yes.Checked = false;
        }

    }
}