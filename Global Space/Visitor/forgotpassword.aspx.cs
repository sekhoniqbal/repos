using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tUser;
using System.Net;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    clstuserfun obj= new clstuserfun();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        obj.p_strusername = txtemail.Text;
        Int32 k= obj.fgtpwd();
       
        if (k == 0)
        {
            literal1.Text = "New password has been sent to your email address"; 
            MailMessage mymail = new MailMessage("globalspace11@gmail.com", txtemail.Text, "here is your password", "your password is" + literal1.Text);
            NetworkCredential userpass = new NetworkCredential("globalspace11@gmail.com", "gspace12345");
            SmtpClient mygmail = new SmtpClient("smtp.gmail.com", 587);
            mygmail.Credentials = userpass;
            mygmail.EnableSsl = true;
            mygmail.Send(mymail);

        }
    }
        
}