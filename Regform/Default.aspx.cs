using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    business bs = new business();
    string filename, path, fullpath, temp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    public void Bind()
    {
        dd_state.DataSource = bs.bs_statebind();
        dd_state.DataTextField = "Sname";
        dd_state.DataValueField = "Sid";
        dd_state.DataBind();
    } 

    protected void dd_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(dd_state.SelectedItem.Value);
        bs.sd = id;
        dd_city.DataSource = bs.bs_citybind(bs);
        dd_city.DataTextField = "cname";
        dd_city.DataValueField = "cname";
        dd_city.DataBind();     
        
    }
    protected void Button1_Click1(object sender, EventArgs e)
   {
        bs.fname = Text_fn.Text;
        bs.lname = Text_ln.Text;
        bs.gender = RadioButtonList1.Text;
        bs.email = Text_Email.Text;
        bs.pwd = Text_pwd.Text;
        bs.cpwd = Text_cpwd.Text;
        bs.cal = Convert.ToDateTime(Calendar1.ToString());
        bs.clas = DropDownList1.Text;
        string str1 = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected == true)
            {
                if (str1 == "")
                {
                    str1 = item.Text;
                }
                else
                {
                    str1 = str1 + "," + item.Text;
                }
            }
        }
        bs.stream = str1;
        string str2 = "";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                if (str2 == "")
                {
                    str2 = CheckBoxList1.Items[i].Text;
                }
                else
                {
                    str2 = str2 + "," + CheckBoxList1.Items[i].Text;
                }
            }
        }
        bs.hobby = str2;
        bs.state = dd_state.SelectedItem.Value;
        bs.city = dd_city.SelectedItem.Value;

        if (FileUpload1.HasFile)
        {
            filename = FileUpload1.FileName;
            path = Server.MapPath("~/i/");
            fullpath = path + "//" + filename;

            FileUpload1.SaveAs(fullpath);
            temp = "~/i/" + filename;
        }
        else
        {
            temp = "";
        }
        bs.image = temp;
        int p = bs.bs_insert(bs);
        if (p>0)
        {
            Response.Write("Insert Succesfully..");
        }
        else
        {
            Response.Write("Try Again..");
        }
    }
}