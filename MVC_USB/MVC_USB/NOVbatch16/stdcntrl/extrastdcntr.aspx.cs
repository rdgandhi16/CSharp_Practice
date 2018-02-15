using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class extrastdcntr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str ="";
        for (int i = 0; i <CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected==true)
            {
                if (str == "")
                {
                    str = CheckBoxList1.Items[i].Text;

                }
                else
                {
                    str = str + CheckBoxList1.Items[i].Text;
                }
                
            }
        }

        abc.Text = str;
    }
    //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    //{
    //    abc.Text = Calendar1.SelectedDate.ToShortTimeString();
    //}
    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
    //    Response.Redirect("Default.aspx");
    //}
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Default.aspx");

    //}
    //protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string str = "";


    //    foreach (ListItem item in ListBox1.Items)
    //    {
    //        if (item.Selected==true)
    //        {
    //            if (str == "")
    //            {
    //                str = item.Text;
    //            }
    //            else
    //            {
    //                str = str + item.Text;
    //            }
    //        }
    //    }
    //    abc.Text = str;
    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    abc.Text = RadioButtonList1.SelectedItem.Text;
    //}
}