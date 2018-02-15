using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment_satyasir
{
    public partial class Admin : System.Web.UI.Page
    {
        string filename, path, fulpath, temp;
        Businesslogic bs = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
        public void Bind()
        {
            GridView1.DataSource = bs.bs_admin();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label_id") as Label;
            bs.stdid = int.Parse(id.Text);

            int p = bs.bs_delete(bs);
            if (p>0)
            {
                Response.Write(" return confirm('Are you sure want to Delete..')");
                GridView1.EditIndex = -1;
                Bind();
            }
            else
            {
                Response.Write("Failed to Delete..");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind();

            HiddenField gen = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
            RadioButtonList rd = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList1") as RadioButtonList;
            rd.SelectedValue = gen.Value;

            HiddenField age = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField2") as HiddenField;
            DropDownList ddage = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList1") as DropDownList;
            ddage.SelectedValue = age.Value;

            HiddenField st = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField3") as HiddenField;
            DropDownList ddst = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList_state") as DropDownList;


            ddst.DataSource = bs.bs_state();
            ddst.DataTextField = "STATE";
            ddst.DataValueField = "SID";
            ddst.DataBind();

            HiddenField ct = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField4") as HiddenField;
            DropDownList ddct = GridView1.Rows[e.NewEditIndex].FindControl("DropDownList_city") as DropDownList;

            int id = int.Parse(ddst.SelectedItem.Value);
            bs.sid = id;

            ddct.DataSource = bs.bs_city(bs);
            ddct.DataTextField = "CITY";
            ddct.DataValueField = "CITY";
            ddct.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label_edit_id") as Label;             
            bs.stdid =int.Parse(id.Text);

            TextBox fname = GridView1.Rows[e.RowIndex].FindControl("TextBox_fname") as TextBox;
            bs.fname = fname.Text;

            TextBox lname = GridView1.Rows[e.RowIndex].FindControl("TextBox_lname") as TextBox;
            bs.lname = lname.Text;

            RadioButtonList gen = GridView1.Rows[e.RowIndex].FindControl("RadioButtonList1") as RadioButtonList;
            bs.gender = gen.Text;

            DropDownList age = GridView1.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
            bs.age = age.Text;

            DropDownList state = GridView1.Rows[e.RowIndex].FindControl("DropDownList_state") as DropDownList;
            bs.state = state.Text;

            DropDownList city = GridView1.Rows[e.RowIndex].FindControl("DropDownList_city") as DropDownList;
            bs.city = city.Text;

            TextBox address = GridView1.Rows[e.RowIndex].FindControl("Text_address") as TextBox;
            bs.address = address.Text;

            //HiddenField pic = GridView1.FindControl("HiddenField5") as HiddenField;
            FileUpload img = GridView1.Rows[e.RowIndex].FindControl("FileUpload1") as FileUpload;

            if (img.HasFile)
            {
                filename = img.FileName;
                path = Server.MapPath("~/im");
                fulpath = path + "\\" + filename;

                img.SaveAs(fulpath);
                temp = "~/im" + filename;
            }
            else
            {
                temp = "";
            }
            bs.image = temp;

            int p = bs.bs_update(bs);
            if (p>0)
            {
                Response.Write("<script>alert('Data Inserted Succesfully')</script>");
                GridView1.EditIndex = -1;
                Bind();
            }
            else
            {
                Response.Write("Failed To Update...");

            }
        }
    }
}