using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_satyasir
{
    public partial class student : System.Web.UI.Page
    {

        string filename, path, fullpath, temp;
        Businesslogic bs = new Businesslogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                state();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bs.fname = Text_fname.Text;
            bs.lname = Text_lname.Text;
            bs.gender = RadioButtonList1.Text;
            bs.address = Text_address.Text;
            bs.age = DropDownList1.Text;
            bs.state = DropDownList_state.Text;
            bs.city = DropDownList_city.Text;

            if (FileUpload1.HasFile)
            {
                filename = FileUpload1.FileName;
                path = Server.MapPath("~/im");
                fullpath = path + "\\" + filename;

                FileUpload1.SaveAs(fullpath);
                temp = "~/im" + filename;
            }
            else
            {
                temp = "";
            }
            bs.image = temp;

            int p = bs.bs_insert(bs);
            if (p > 0)
            {
                //ScriptManager.RegisterClientScriptBlock(this, GetType(), "Are you sure Want to Submit.")
                Response.Write("<script>alert('Update Succesfully..')</script>");
                lblMessage.Text = "update succesfully..";
                Text_fname.Text = "";
                Text_lname.Text = "";
                Text_address.Text = "";
            }
            else
            {
                Response.Write("Failed to Submitt");
            }
        }

        public void state()
        {
            DropDownList_state.DataSource = bs.bs_state();
            DropDownList_state.DataTextField = "STATE";
            DropDownList_state.DataValueField = "SID";
            DropDownList_state.DataBind();

        }

        protected void DropDownList_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList_state.SelectedItem.Value);
            bs.sid=id;

            DropDownList_city.DataSource = bs.bs_city(bs);
            DropDownList_city.DataTextField = "CITY";
            DropDownList_city.DataValueField = "CITY";
            DropDownList_city.DataBind();
        }
    }
}