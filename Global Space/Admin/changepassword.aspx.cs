using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tadmin;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class Admin_Default : System.Web.UI.Page
{
    clstadminfun obj = new clstadminfun();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnchpwd_Click(object sender, EventArgs e)
    {
        obj.p_strusername = "jitsimran89@gmail.com";
        obj.p_stroldpassword = txtcpwd.Text.Trim();
        obj.p_strnewpassword = txtnpwd.Text.Trim();
        Int32 k = obj.chkpwdadv();
        if (k == 0)
            {
                literal1.Text = "Your password has been changed successfully";
                txtnpwd.Text = "";
                txtcpwd.Text = "";
                txtconpwd.Text = "";
            }
            else
            {
     
                literal1.Text = "Enter correct old password";
            }
        
}
}