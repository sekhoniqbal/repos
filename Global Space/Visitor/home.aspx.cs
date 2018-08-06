using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tUser;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Visitor_Default : System.Web.UI.Page
{
    clstuserfun obj = new clstuserfun();


    protected void Page_Load(object sender, EventArgs e)
    {
        datab();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        obj.p_strusername = TextBox1.Text.Trim();
        obj.p_strpassword = TextBox2.Text.Trim();
        Int32 k = obj.login();

        if (k == 1)
        {

            Session["ss"] = TextBox1.Text;
            Response.Redirect("~//Admin//manageCMS.aspx");

        }
        if (k == 2)
        {

            Session["ss"] = TextBox1.Text;
            Response.Redirect("~//Publisher//publisheraccount.aspx");

        }
        if (k == 3)
        {
            Session["ss"] = TextBox1.Text;
            Response.Redirect("~//Subscriber//subscriberaccount.aspx");
        }

        if (k == -2)
        {
            ltpwd.Text = "wrong password";
        }
        if (k == -1)
        {
            ltuname.Text = "username is wrong";
        }
    }
    private void datab()
    {

        SqlDataAdapter adp = new SqlDataAdapter("select strimage from tbadvertisement", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        datalist1.DataSource = ds;
        datalist1.DataBind();
    }


}