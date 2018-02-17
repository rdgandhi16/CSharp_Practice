using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FnameLname : System.Web.UI.Page
{
    Businesslayer bslayer = new Businesslayer();
     
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bslayer.fname = txtFname.Text;
        bslayer.mname = txtMname.Text;
        bslayer.lname = txtLname.Text;
        bslayer.state = ddlState.Text;
        bslayer.gender = rdGender.Text;

        string str1 = "";
        for (int i = 0; i < chHobby.Items.Count; i++)
        {
            if (chHobby.Items[i].Selected==true)
            {
                if (str1=="")
                {
                    str1 = chHobby.Items[i].Text;
                }
                else
                {
                    str1 = str1 +","+ chHobby.Items[i].Text;
                }
            }
        }
        bslayer.hobby = str1;

        int p = bslayer.bs_insertform(bslayer);
        if (p>0)
        {
            Response.Write("Insert Succesfully...");
        }
        else
        {
            Response.Write("Failed to Insert...");
        }
    }
}