using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace tUser
{
    public class clstUser
    {
        private int intuserid;
        private string strfirstname;
        private string strlastname;
        private int introleid;
        private string dtdob;
        private string strcontactemail;
        private string strpermaddr;
        private string strcorresaddr;
        private string strcity;
        private string strstate;
        private string strcountry;
        private int intpincode;
        private string strcontactnumber;
        private string strfaxnumber;
        private string strusername;
        private string strpassword;
        private string strcompanyname;
        private int intprodid;
        private string strprodname;
        private string strproddesc;
        private string strprodimage;
        private int intprodprc;
        private int intcategoryid;
        private int intcatalogid;
        private int intcommentid;
        private string strcommentdesc;
        private string postedate;

        public int p_intcategoryid
        {
            get
            {
                return intcategoryid;

            }
            set
            {
                intcategoryid = value;
            }
        }
        public int p_intcatalogid
        {
            get
            {
                return intcatalogid;

            }
            set
            {
                intcatalogid = value;
            }
        }
        public int p_intprodid
        {
            get
            {
                return intprodid;

            }
            set
            {
                intprodid = value;
            }
        }

        public string p_strprodname
        {
            get
            {
                return strprodname;
            }
            set
            {
                strprodname = value;
            }





        }
        public int p_intuserid
        {
            get
            {
                return intuserid;
            }
           set
            {
                intuserid =value;
            }
           

        }
        public string p_strfirstname
        {
            get
            {
                return strfirstname;
            }
            set
            {
                strfirstname = value;
            }
        }
        public string p_strlastname
        {
            get
            {
                return strlastname;
            }
            set
            {
                strlastname = value;
            }
        }
        public int p_introleid
        {
            get
            {
                return introleid;
            }
            set
            {
                introleid = value;
            }
        }
        public string p_dtdob
        {
            get
            {
                return dtdob;
            }
            set
            {
                dtdob = value;
            }
        }
        public string p_strcontactemail
        {
            get
            {
                return strcontactemail;
            }
            set
            {
                strcontactemail = value;
            }

        }
        public string p_strpermaddr
        {
            get
            {
                return strpermaddr;
            }
            set
            {
                strpermaddr = value;
            }

        }
        public string p_strprodimg
        {
            get
            {
                return strprodimage;
            }
            set
            {
                strprodimage = value;
            }

        }
        public string p_strcorresaddr
        {
            get
            {
                return strcorresaddr;
            }
            set
            {
                strcorresaddr = value;
            }

        }
        public string p_strcity
        {
            get
            {
                return strcity;
            }
            set
            {
                strcity = value;
            }

        }
        public string p_strstate
        {
            get
            {
                return strstate;
            }
            set
            {
                strstate = value;
            }

        }
        public string p_strcountry
        {
            get
            {
                return strcountry;
            }
            set
            {
                strcountry = value;
            }

        }
        public int p_intpincode
        {
            get
            {
                return intpincode;
            }
            set
            {
                intpincode= value;
            }

        }
        public int p_intprodprc
        {
            get
            {
                return intprodprc;
            }
            set
            {
                intprodprc = value;
            }

        }
        public string p_strcontactnumber
        {
            get
            {
                return strcontactnumber;
            }
            set
            {
                strcontactnumber = value;
            }

        }
        public string p_strfaxnumber
        {
            get
            {
                return strfaxnumber;
            }
            set
            {
                strfaxnumber = value;
            }

        }
        public string p_strusername
        {
            get
            {
                return strusername;
            }
            set
            {
                strusername = value;
            }
        }

        public string p_strpassword
        {
            get
            {
                return strpassword;
            }
            set
            {
                strpassword = value;
            }
        }
        public string p_strcompanyname
        {
            get
            {
                return strcompanyname;
            }
            set
            {
                strcompanyname = value;
            }

        }
        public string p_strproddesc
        {
            get
            {
                return strproddesc;
            }
            set
            {
                strproddesc = value;
            }

        }

        public int p_intcommentid
        {
            get
            {
                return intcommentid;
            }
        }
        public string p_strcommentdesc
        {
            get
            {
                return strcommentdesc;
            }
            set
            {
                strcommentdesc = value;
            }
        }
        public string p_posteddate
        {
            get
            {
                return postedate;
            }
            set
            {
                postedate = value;
            }
        }


    }

    public class clstuserfun : clstUser
    {
       

        public void adduser()   
        {
            SqlParameter[] array = new SqlParameter[17];

            array[0] = new SqlParameter("@intuserid", p_intuserid);
            array[1] = new SqlParameter("@strfirstname", p_strfirstname);
            array[2] = new SqlParameter("@strlastname", p_strlastname);
            array[3] = new SqlParameter("@introleid", p_introleid);
            array[4] = new SqlParameter("@dtdob", p_dtdob);
            array[5] = new SqlParameter("@strcontactemail", p_strcontactemail);
            array[6] = new SqlParameter("@strpermaddr", p_strpermaddr);
            array[7] = new SqlParameter("@strcorresaddr", p_strcorresaddr);
            array[8] = new SqlParameter("@strcity", p_strcity);
            array[9] = new SqlParameter("@strstate", p_strstate);
            array[10] = new SqlParameter("@strcountry", p_strcountry);
            array[11] = new SqlParameter("@intpincode", p_intpincode);
            array[12] = new SqlParameter("@strcontactnumber", p_strcontactnumber);
            array[13] = new SqlParameter("@strfaxnumber", p_strfaxnumber);
            array[14] = new SqlParameter("@strusername", p_strusername);
            array[15] = new SqlParameter("@strpassword", p_strpassword);
            array[16] = new SqlParameter("@strcompanyname", p_strcompanyname);

            AppLib.ExecuteNonQueryBySP("Proc_insuser", array);
        }

        public Int32 fgtpwd()
        {
            SqlParameter[] array = new SqlParameter[1];

            array[0] = new SqlParameter("@usname", p_strusername);
            AppLib.ExecuteNonQueryBySP("Proc_forgotpwd", array);
            SqlParameter p1 = new SqlParameter("@ret", SqlDbType.Int);
            p1.Direction = ParameterDirection.ReturnValue;
            return Convert.ToInt32(p1.Value);
            
        }
         public int login()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@uname", p_strusername);
            array[1] = new SqlParameter("@pwd", p_strpassword);
            return AppLib.ExecuteScalar("Proc_login", array);
  
        }
         public void funtbproduct()
         {
             SqlParameter[] array = new SqlParameter[8];
             array[0] = new SqlParameter("@intprodid", p_intprodid);
             array[1] = new SqlParameter("@strprodname", p_strprodname);
             array[2] = new SqlParameter("@strproddesc", p_strproddesc);
             array[3] = new SqlParameter("@intprodprice", p_intprodprc);
             array[4] = new SqlParameter("@intuserid", p_intuserid);
             array[5] = new SqlParameter("@intcategoryid", p_intcategoryid);
             array[6] = new SqlParameter("@intcatalogid", p_intcatalogid);
             array[7] = new SqlParameter("@strprodimage", p_strprodimg);



             AppLib.ExecuteNonQueryBySP("Proc_insprod", array);
         }


         public SqlDataReader manageproduct()
         {

             SqlParameter[] array = new SqlParameter[1];
             array[0] = new SqlParameter("@userid", p_intuserid);
             SqlDataReader dr;
             dr = AppLib.GetSqlDataReaderBySP("Proc_selectproduct", array);
             return dr;
         }
         public void deleteproduct(int prodid)
         {

             SqlParameter[] array = new SqlParameter[1];
             array[0] = new SqlParameter("@prodid", prodid);
             AppLib.ExecuteNonQueryBySP("Proc_delproduct", array);

         }

         public void funcomment()
         {
             SqlParameter[] array = new SqlParameter[8];
             array[0] = new SqlParameter("@strcommentdesc", p_strcommentdesc);
             array[1] = new SqlParameter("@posteddate", p_posteddate);
             array[2] = new SqlParameter("@intprodid", p_intprodid);
             array[3] = new SqlParameter("@strname", p_strfirstname);
             array[4] = new SqlParameter("@strprodimage", p_strprodimg);
             array[5] = new SqlParameter("@strprodname", p_strprodname);
             array[6] = new SqlParameter("@intuserid", p_intuserid);
             array[7] = new SqlParameter("@strusername", p_strusername);
             AppLib.ExecuteNonQueryBySP("Proc_instbcomment", array);

         }

         public void upduser()
         {
             SqlParameter[] arr = new SqlParameter[13];
             //  arr[0] = new SqlParameter("@intuserid", p_intuserid);

             arr[0] = new SqlParameter("@strfirstname", p_strfirstname);
             arr[1] = new SqlParameter("@strlastname", p_strlastname);
             /// arr[] = new SqlParameter("@introleid", p_introleid);
             ///  arr[4] = new SqlParameter("@dtdob", p_dtdob);
             arr[2] = new SqlParameter("@strcontactemail", p_strcontactemail);
             arr[3] = new SqlParameter("@strpermaddr", p_strpermaddr);
             arr[4] = new SqlParameter("@strcorresaddr", p_strcorresaddr);
             arr[5] = new SqlParameter("@strcity", p_strcity);
             arr[6] = new SqlParameter("@strstate", p_strstate);
             arr[7] = new SqlParameter("@strcountry", p_strcountry);
             arr[8] = new SqlParameter("@intpincode", p_intpincode);
             arr[9] = new SqlParameter("@strcontactnumber", p_strcontactnumber);
             arr[10] = new SqlParameter("@strfaxnumber", p_strfaxnumber);

             //   arr[15] = new SqlParameter("@strpassword", p_strpassword);
             arr[11] = new SqlParameter("@strcompanyname", p_strcompanyname);
             arr[12] = new SqlParameter("@strusername", p_strusername);
             AppLib.ExecuteNonQueryBySP("Proc_updateuser", arr);
         }

    }
}
       
      
    





    
