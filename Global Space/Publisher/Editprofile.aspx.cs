using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using tUser;

public partial class Publisher_Default : System.Web.UI.Page
{
    clstuserfun obj = new clstuserfun();
    //clsupduser objupd = new clsupduser();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // objupd.upduser();
            fillUserDetails();
        }

       
        
    }


    private void fillUserDetails()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Proc_sltuser";
        cmd.CommandType = CommandType.StoredProcedure;
        string uname = Session["ss"].ToString();

        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = uname;
        cmd.Connection = con;
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            txtfname.Text = dr["strfirstname"].ToString();
            txtlname.Text = dr["strlastname"].ToString();
            txtcmpname.Text = dr["strcompanyname"].ToString();
            txtpermadd.Text = dr["strpermaddr"].ToString();
            txtcorresadd.Text = dr["strcorresaddr"].ToString();
            drpcountry.Text = dr["strcountry"].ToString();
            drpstate.Text = dr["strstate"].ToString();
            drpcity.Text = dr["strcity"].ToString();
            txtfax.Text = dr["strfaxnumber"].ToString();
            txtpincode.Text = dr["intpincode"].ToString();
            txtcontactno.Text = dr["strcontactnumber"].ToString();
            txtcontactemail.Text = dr["strcontactemail"].ToString();


        }
        else
        {
            txtfname.Text = "enter data";
        }
        dr.Close();
        cmd.Dispose();
    }


    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //con.Open();
        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "Proc_upduser";
        //cmd.CommandType = CommandType.StoredProcedure;
        string uname = Session["ss"].ToString();
        //cmd.Parameters.Add("@strusername", SqlDbType.VarChar).Value = uname;
        
        //cmd.Connection = con;
        
        
        
        if (chk.Checked)
        
        {

            
            obj.p_strfirstname = txtfname.Text;
            obj.p_strlastname = txtlname.Text;
           // objupd.p_dtdob = drp2.SelectedValue + "/" + drp1.SelectedValue + "/" + drp3.SelectedValue;
            obj.p_strcontactemail = txtcontactemail.Text;
           
            obj.p_strpermaddr = txtpermadd.Text;
            obj.p_strcorresaddr = txtcorresadd.Text;
            
            obj.p_strcity = drpcity.SelectedValue;
            obj.p_strstate = drpstate.SelectedValue;
            obj.p_strcountry = drpcountry.SelectedValue;
            obj.p_intpincode = Convert.ToInt32(txtpincode.Text);
            obj.p_strcontactnumber = txtcontactno.Text;
            obj.p_strfaxnumber = txtfax.Text;            
            obj.p_strcompanyname = txtcmpname.Text;
            obj.p_strusername = uname;

            obj.upduser();
        }

        fillUserDetails();
        
    }


    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (RadioButtonList1.SelectedIndex == 0)
        {
            obj.p_introleid = 2;        // for Publisher
            Literal1.Text = " You are going to registered as Publisher";
        }
        else
        {
            obj.p_introleid = 3;       // for Subscriber
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