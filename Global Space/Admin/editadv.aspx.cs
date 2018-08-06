using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tadmin;

public partial class Admin_Default : System.Web.UI.Page
{
    clstadminfun obj = new clstadminfun();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void butcancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("manageadv.aspx");
    }
    protected void butupdate_Click(object sender, EventArgs e)
    {
        obj.p_strproductname = lbprd.Text;   
        obj.p_strlocation = rdloc.SelectedValue;
        obj.updadv();
    }
}