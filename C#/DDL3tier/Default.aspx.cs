using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Business bs = new Business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            state_bind();
        }
    }
    public void state_bind()
    {
        DropDown_state.DataSource = bs.bs_bind();
        DropDown_state.DataTextField = "State";
        DropDown_state.DataValueField = "Sid";
        DropDown_state.DataBind();
    }
    protected void DropDown_state_SelectedIndexChanged(object sender, EventArgs e)
    {

        int id=int.Parse(DropDown_state.SelectedItem.Value);        
        bs.sid=id;
        DropDown_city.DataSource = bs.bs_citybind(bs);
        DropDown_city.DataTextField = "City";
        DropDown_city.DataValueField = "City";
        DropDown_city.DataBind();
    }
}