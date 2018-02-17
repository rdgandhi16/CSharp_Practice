using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insert : System.Web.UI.Page
{
    business blayer = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        blayer.fname = txtFname.Text;
        blayer.lname = txtLname.Text;
        blayer.gender = rdGender.SelectedItem.Text;

        string str1 = "";
        for (int i = 0; i < chStream.Items.Count; i++)
        {
            if (chStream.Items[i].Selected == true)
            {
                if (str1 == "")
                {
                    str1 = chStream.Items[i].Text;
                }
                else
                {
                    str1 = str1 + "," + chStream.Items[i].Text;
                }
            }
        }
        blayer.stream = str1;
        string str2 = "";
        foreach (ListItem item in lsHobby.Items)
        {
            if (item.Selected == true)
            {
                if (str2 == "")
                {
                    str2 = item.Selected.ToString();
                }
                else
                {
                    str2 = str2 + "," + item.Selected.ToString();
                }
            }
        }
        blayer.hobby = str2;

        blayer.state = ddlState.Text;

        int p = blayer.blayer_allcontrolinsert(blayer);
        if (p > 0)
        {
            Response.Write("Insert Succesfully..");
        }
        else
        {
            Response.Write("failed to insert Please try Again..");
        }

    }
}