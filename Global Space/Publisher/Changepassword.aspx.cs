using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Publisher_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
        
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnchpwd_Click(object sender, EventArgs e)
    {   con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        string ss = Session["ss"].ToString();
        cmd.Connection = con;
        cmd.CommandText = "Proc_changepassword";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@uname", SqlDbType.VarChar).Value = ss;
        cmd.Parameters.Add("@opwd", SqlDbType.VarChar).Value = txtcpwd.Text;
        cmd.Parameters.Add("@npwd", SqlDbType.VarChar).Value = txtnpwd.Text;
        SqlParameter p1=new SqlParameter("@ret",SqlDbType.Int);
        p1.Direction = ParameterDirection.ReturnValue;
        cmd.Parameters.Add(p1);
        
        SqlDataReader dr = cmd.ExecuteReader();
        
        Int32 k = Convert.ToInt32(cmd.Parameters["@ret"].Value);
        if (k == 1)
        {
            Label1.Text = "your password has been changed successfully";
            txtcpwd.Text = "";
            txtnpwd.Text = "";
        }
        else
        {
            Label1.Text = "wrong old password";
        }


    }
}