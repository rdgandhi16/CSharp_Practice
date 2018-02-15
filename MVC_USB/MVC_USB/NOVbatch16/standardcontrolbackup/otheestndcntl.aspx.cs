using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class otheestndcntl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 //   protected void Button1_Click(object sender, EventArgs e)
   // {
    //    string str = "";
    //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    //    {
    //        if (CheckBoxList1.Items[i].Selected==true)
    //        {
    //            if (str == "")
    //            {
    //                str = CheckBoxList1.Items[i].Text;
    //            }
    //            else
    //            {
    //                str = str + CheckBoxList1.Items[i].Text;
    //            }
    //        }
    //    }
    //    Label1.Text = str;
    //}
    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
    //    string str = "";
    //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    //    {
    //        if (CheckBoxList1.Items[i].Selected == true)
    //        {
    //            if (str == "")
    //            {
    //                str = CheckBoxList1.Items[i].Text;
    //            }
    //            else
    //            {
    //                str = str + CheckBoxList1.Items[i].Text;
    //            }
    //        }
    //    }
    //    Label1.Text = str;
    //}
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    string str = "";
    //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    //    {
    //        if (CheckBoxList1.Items[i].Selected == true)
    //        {
    //            if (str == "")
    //            {
    //                str = CheckBoxList1.Items[i].Text;
    //            }
    //            else
    //            {
    //                str = str + CheckBoxList1.Items[i].Text;
    //            }
    //        }
    //    }
    //    Label1.Text = str;
    //}
    //protected void Button2_Click(object sender, EventArgs e)
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
    //    Label1.Text = str;
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = RadioButtonList1.SelectedItem.Text;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
    }
}