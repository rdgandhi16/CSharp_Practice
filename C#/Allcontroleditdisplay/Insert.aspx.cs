using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insert : System.Web.UI.Page
{
    business empbussiness = new business();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Empsubmit_Click(object sender, EventArgs e)
    {
        empbussiness.fname = txtFname.Text;
        empbussiness.lname = txtLname.Text;
        empbussiness.gender = radioGender.Text;
        empbussiness.department = ddlDept.Text;

        string strskill = "";
        for (int i = 0; i < chkSkill.Items.Count; i++)
        {
            if (chkSkill.Items[i].Selected==true)
            {
                strskill = chkSkill.Items[i].Text;
            }
            else
            {
                strskill = strskill + "," + chkSkill.Items[i].Text;
            }
        }
        empbussiness.skills = strskill;
        string strstate = "";
        foreach (ListItem item in listState.Items)
        {
            if (item.Selected==true)
            {
                if (strstate=="")
                {
                    strstate = item.Text;
                }
                else
                {
                    strstate = strstate + "," + item.Text;
                }
            }
        }
        empbussiness.state = strstate;
        int p = empbussiness.bussemp_Insert(empbussiness);
        if (p>0)
        {
            Response.Write("Insert Sucessfully..");   
        }
        else
        {
            Response.Write("Failed to Insert try again please..");
        }
    }
}