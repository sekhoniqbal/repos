using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tUser;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Visitor_Default : System.Web.UI.Page
{
    clstuserfun obj = new clstuserfun();


    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        if (chk.Checked)
        {

            obj.p_strusername = txtuname.Text;
            obj.p_strpassword = txtpwd.Text;
            obj.p_strfirstname = txtfname.Text;
            obj.p_strlastname = txtlname.Text;
            obj.p_dtdob = drp2.SelectedValue + "/" + drp1.SelectedValue + "/" + drp3.SelectedValue;
            obj.p_strcompanyname = txtcmpname.Text;
            obj.p_strpermaddr = txtpermadd.Text;
            obj.p_strcorresaddr = txtcorresadd.Text;
            obj.p_strcountry = drp1.SelectedValue;
            obj.p_strstate = drp2.SelectedValue;
            obj.p_strcity = drp3.SelectedValue;
            obj.p_strfaxnumber = txtfname.Text;
            obj.p_intpincode = Convert.ToInt32(txtpincode.Text);
            obj.p_strcontactnumber = txtpincode.Text;
            obj.p_strcontactemail = txtcontactemail.Text;

            if (RadioButtonList1.SelectedIndex == 0)
                obj.p_introleid = Convert.ToInt32(RadioButtonList1.SelectedValue);// for Publisher
            else
                obj.p_introleid = Convert.ToInt32(RadioButtonList1.SelectedValue);      // for Subscriber

            obj.adduser();
        }
        else
        {
            Literal1.Text = "Accept terms and conditions.";
     }
        
        txtuname.Text="";
        txtpwd.Text="";
        txtfname.Text="";
        txtlname.Text="";
        drp2.SelectedValue = "";
        txtcmpname.Text="";
        txtpermadd.Text="";
        txtcorresadd.Text="";
        drp1.SelectedValue="";
        drp2.SelectedValue="";
        drp3.SelectedValue="";
        txtfname.Text="";
        txtpincode.Text = "";
        txtcontactemail.Text="";
    }


    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (RadioButtonList1.SelectedIndex == 0)
        {

            Literal1.Text = " You are going to registered as Publisher";
        }
        else
        {
           
            Literal1.Text = " You are going to registered as Subscriber";
            
        }
    }
    protected void drp1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void But_Click(object sender, EventArgs e)
    {
        if (txtverification.Text == txt1.Text)
        {
            lblmsg.Text = "Successfull";
        }
        else
        {
            lblmsg.Text = "Failure";
        }
    }
}