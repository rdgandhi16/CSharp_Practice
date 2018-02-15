using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            state_bind();
        }
    }
    public void state_bind()
    {
        DropDownList1.DataSource = from n in dc.tbl_states select n;
        DropDownList1.DataTextField = "statename";
        DropDownList1.DataValueField = "id";
        DropDownList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(DropDownList1.SelectedValue);
        DropDownList2.DataSource = from n in dc.tbl_cities where n.sid==id select n;
        DropDownList2.DataTextField = "cityname";
        DropDownList2.DataValueField = "cityname";
        DropDownList2.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        tbl_linq_join tr = new tbl_linq_join();

        tr.name = fname.Text;
        tr.stateid = int.Parse(DropDownList1.Text);
        tr.city = DropDownList2.Text;

        dc.tbl_linq_joins.InsertOnSubmit(tr);
        dc.SubmitChanges();
    }
}