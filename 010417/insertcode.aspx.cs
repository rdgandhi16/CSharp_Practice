using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insertcode : System.Web.UI.Page
{
    Business bs = new Business();
    string filename, path, fullpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    State_Bind();
        //}
    }
    //public void State_Bind()
    //{
    //    DropDownList_state.DataSource = bs.bs_State();
    //    DropDownList_state.DataTextField = "SNAME";
    //    DropDownList_state.DataValueField = "SID";
    //    DropDownList_state.DataBind();
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        bs.fname = Text_fname.Text;
        bs.lname = Text_lname.Text;
        bs.datetime = TextBox_cal.Text;
        bs.gender = RadioButtonList1.Text;
        bs.state = DropDownList_state.Text;
        bs.city = DropDownList_City.Text;

        string str1 = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected==true)
            {
                if (str1=="")
                {
                    str1 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str1 = str1 + "," + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.sport = str1;
        bs.height = TextBox1.Text;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/image");
            fullpath = path + "\\" + filename;

            FileUpload1.SaveAs(fullpath);

            temp = "~/image" + filename;
        }
        else
        {
            temp = "";
        }
        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("Save Succesfully..");
        }
        else
        {
            Response.Write("Failed to Submit try again please ");
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox_cal.Text = Calendar1.SelectedDate.ToString();
    }
}