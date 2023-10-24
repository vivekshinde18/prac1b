using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pract1b : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs
    e)
    {
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        String str1 = textBox1.Text.ToString();
        String str2 = textBox2.Text.ToString();
        if (DropDownList1.SelectedItem.Text.Equals("Concate"))
        {
            result.Text = "Concatinate String : " + (str1 + str2);
        }
        else if (DropDownList1.SelectedItem.Text.Equals("UpperCase"))
        {
            result.Text = "<br>" + "Upper case of String :" + "<br>" + (str1.ToUpper() + " " +
            str2.ToUpper());
        }
        else if (DropDownList1.SelectedItem.Text.Equals("LowerCase"))
        {
            result.Text = "<br>" + "Lower case of String :" + "<br>" + str1.ToLower() + " " +
            str2.ToLower();
        }
        else if (DropDownList1.SelectedItem.Text.Equals("Length"))
        {
            result.Text = "<br>" + "Length of first string " + str1 + ":<br>" + str1.Length;
        }
        else if (DropDownList1.SelectedItem.Text.Equals("IsEmpty"))
        {
            if (String.IsNullOrEmpty(str1) && String.IsNullOrEmpty(str2))
            {
                result.Text = "<br>" + "Both the textbox is empty";
            }
            else if (String.IsNullOrEmpty(str1))
            {
                result.Text = "TextBox 1 is Empty";
            }
            else if (String.IsNullOrEmpty(str2))
            {
                result.Text = "TextBox 2 is Empty";
            }
            else
            {
                result.Text = "None of the TextBox is Empty";
            }
        }
        else
        {
            String reverse1 = new string(str1.Reverse().ToArray());
            String reverse2 = new string(str2.Reverse().ToArray());
            result.Text = "Reverse of 1st string :" + reverse1;
        }
    }
}