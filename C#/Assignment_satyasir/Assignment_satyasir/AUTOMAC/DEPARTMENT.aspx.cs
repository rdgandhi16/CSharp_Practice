using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Assignment_satyasir.AUTOMAC
{
    public partial class DEPARTMENT : System.Web.UI.Page
    {
        Businesslogic bs = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        public void Bind()
        {
            Button1.Visible = true;
            Button2.Visible = false;
            GridView1.DataSource = bs.bs_depbind();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Button2.Visible = true;
            Label1.Text = (GridView1.SelectedRow.FindControl("Label_id") as Label).Text;
            TextBox_dname.Text =(GridView1.SelectedRow.FindControl("Label_dname") as Label).Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bs.dname = TextBox_dname.Text;

            int p = bs.bs_insertdepartment(bs);
            if (p>0)
            {
                Response.Write("Department is Addded Succesfully..");
            }
            else
            {
                Response.Write("Failed to Add Department..");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bs.dname = TextBox_dname.Text;

            int p = bs.bs_updatedepartment(bs);
            if (p>0)
            {
                Response.Write("Department detail is updated..");
                GridView1.EditIndex = -1;
                Bind();
            }
            else
            {
                Response.Write("Failed to Update..");
            }
        }
    }
}