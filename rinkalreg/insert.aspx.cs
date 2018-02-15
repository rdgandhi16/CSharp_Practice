using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class insert : System.Web.UI.Page
{
    Business bs = new Business();

    string str = ConfigurationManager.ConnectionStrings["str"].ToString();


    string path, filename, temp, fullpath;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            StateBind();
        }
    }
    protected void StateBind()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "dd_state";
        cm.CommandType = CommandType.StoredProcedure;
        cm.Connection = con;

        SqlDataAdapter ad = new SqlDataAdapter(cm);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        DropDownList_state.DataSource = dt;
        DropDownList_state.DataTextField = "SNAME";
        DropDownList_state.DataValueField = "SID";
        DropDownList_state.DataBind();
    }
    protected void DropDownList_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(DropDownList_state.SelectedItem.Value);

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "dd_city";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@id", id);


        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);


        DropDownList_city.DataSource = dt;
        DropDownList_city.DataTextField = "CITY";
        DropDownList_city.DataValueField = "SID";
        DropDownList_city.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bs.fname = Text_fname.Text;
        bs.lname = Text_lname.Text;
        bs.datetime = TextBox1.Text;
        bs.gender = RadioButtonList1.Text;

        string str1 = "";

        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                if (str1 == "")
                {
                    str1 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str1 = str1 + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str1;
        bs.state = DropDownList_state.Text;
        bs.city = DropDownList_city.Text;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/image/");
            fullpath = path + "\\" + filename;

            FileUpload1.SaveAs(fullpath);
            temp = "~/image/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;

        int p = bs.bs_rgform(bs);
        if (p>0)
        {
            Response.Write("Data has been Save sucecsfullyy..");
        }
        else
        {
            Response.Write("Try Again failed to save..");
        }
    }
   
}