using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class display : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            data_display();
        }
    }

    public void data_display()
    {
        var p = from n in dc.tbl_linq_joins join m in dc.tbl_states on n.stateid equals m.id select new {n.id,n.name,m.statename,n.city };

        GridView1.DataSource =p ;
        GridView1.DataBind();
    }

}