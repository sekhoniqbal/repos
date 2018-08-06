using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if (Page.IsPostBack == false)

{

DirectoryInfo dir = new DirectoryInfo(MapPath("~//HTML Pages//"));

FileInfo[] files = dir.GetFiles();

foreach (FileInfo oItem in files)

{

if (oItem.Extension == ".htm" || oItem.Extension == ".html")

{
drp1.Items.Add(oItem.ToString());

drp1.DataBind();

}

}

drp1.Items.Insert(0,
"--Select--");

}


    }
  
   

protected void drp1_SelectedIndexChanged(object sender, EventArgs e)

{

string var = drp1.SelectedValue.ToString();

StreamReader StreamReader1 = new StreamReader(Server.MapPath("~//HTML Pages//" + var));

txt1.Text = StreamReader1.ReadToEnd();

StreamReader1.Close();
    

}
protected void but_Click(object sender, EventArgs e)
{

    string var = drp1.SelectedValue.ToString();

    string strHTMLfile = "~//HTML Pages//" + var;

    string strFileName = Server.MapPath(strHTMLfile);

    StreamWriter stWrite = new StreamWriter(strFileName,false);

    stWrite.Write(txt1.Text);

    stWrite.Close();

}
}

