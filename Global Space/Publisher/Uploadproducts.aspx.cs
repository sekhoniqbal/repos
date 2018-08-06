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

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {


        try
        {
            string ssp;
            string fn = FileUpload1.FileName;
            // string fnn = Guid.NewGuid().ToString() + FileUpload1.FileName.Substring(FileUpload1.FileName.LastIndexOf("."));
            string sp =Server.MapPath("~\\Publisher\\Productimages\\");

            //if (sp.EndsWith("\\") == false)
            //{
            //    sp += "\\";

            //}
             sp += fn;
              ssp = "~/Publisher/Productimages/"+fn;
            FileUpload1.PostedFile.SaveAs(sp);


            string userid =Session["uid"].ToString();
            obj.p_strprodname = TextBox1.Text;
            obj.p_strproddesc = TextBox2.Text;
            obj.p_intprodprc = Convert.ToInt32(TextBox3.Text);
            obj.p_strprodimg = ssp;
            obj.p_intcategoryid = Convert.ToInt32(drpcategory.SelectedValue);
            obj.p_intcatalogid = Convert.ToInt32(drpcatalog.SelectedValue);
            obj.p_intuserid = Convert.ToInt32(userid);
            obj.funtbproduct();

            Literal1.Text = "Your Product has been successfully uploaded";
            empty();

        }
        catch
        {
            Response.Redirect("publisheraccount.aspx");
        }
    }
    
    private void empty()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }



  
}