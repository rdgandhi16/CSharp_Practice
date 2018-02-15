using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    Business bs = new Business();
    string str = @"Data Source=SAIPC\SQLEXPRESS;Initial Catalog=db_rinkal;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
            
        }
    }
    public void Bind()
    {
        GridView1.DataSource = bs.bs_Bind(bs);
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex=e.NewEditIndex;
         Bind();

         HiddenField gn = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField1") as HiddenField;
         HiddenField hb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField2") as HiddenField;
         HiddenField sb = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField3") as HiddenField;
         HiddenField st = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField4") as HiddenField;
         HiddenField ct = GridView1.Rows[e.NewEditIndex].FindControl("HiddenField5") as HiddenField;

         RadioButtonList rd1 = GridView1.Rows[e.NewEditIndex].FindControl("RadioButtonList1") as RadioButtonList;
         CheckBoxList chk1 = GridView1.Rows[e.NewEditIndex].FindControl("CheckBoxList1") as CheckBoxList;
         ListBox list1 = GridView1.Rows[e.NewEditIndex].FindControl("ListBox1") as ListBox;
         DropDownList ddct = GridView1.Rows[e.NewEditIndex].FindControl("DropDown_city") as DropDownList;
         DropDownList state = GridView1.Rows[e.NewEditIndex].FindControl("DropDown_state") as DropDownList;

         rd1.SelectedValue = gn.Value;


        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select *from tbl_city";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);


        state.DataSource = bs.bs_state();
        state.DataTextField = "StateName";
        state.DataValueField = "SID";
        state.DataBind();

    
        ddct.DataSource = dt;
        ddct.DataTextField = "CityName";
        ddct.DataValueField = "CityName";
        ddct.DataBind();

        string h = hb.Value;
        string[] arr = h.Split(',');

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < chk1.Items.Count; j++)
            {
                if (arr[i] == chk1.Items[j].Text)
                {
                    chk1.Items[j].Selected = true;
                }
            }
        }
        string s = sb.Value;
        string[] arr1 = s.Split(',');
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < list1.Items.Count; j++)
            {
                if (arr1[i] == list1.Items[j].Text)
                {
                    list1.Items[j].Selected = true;
                }
            }
        }

    }
}