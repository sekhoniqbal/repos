<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="Visitor_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
    <asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <script type="text/javascript">


     function show()
      {

         var a = 49, b = 65;
         var c = 100;
         var d = 70;
         if (a == 57)
          {
             a = 49;
         }
         var main = document.getElementById('txt1');
         var a1 = String.fromCharCode(a);
         var b1 = String.fromCharCode(b);
         var c1 = String.fromCharCode(c);
         var d1 = String.fromCharCode(d);
         main.value = a1 + b1 + c1 + d1;
         a = a + 1;
         b = b + 1;
         c = c + 1;
         d = d + 1;
     }
     function CheckPassword(password) {


         var strength = new Array();
         strength[0] = "Blank";
         strength[1] = "Very Weak";
         strength[2] = "Weak";
         strength[3] = "Medium";
         strength[4] = "Strong";
         strength[5] = "Very Strong";

         var score = 1;

         if (password.length < 1)
             return strength[0];

         if (password.length < 4)
             return strength[1];

         if (password.length >= 8)
             score++;
         if (password.length >= 12)
             score++;
         if (password.match(/\d+/))
             score++;
         if (password.match(/[a-z]/) &&
	        password.match(/[A-Z]/))
             score++;
         if (password.match(/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/))
             score++;

         return strength[score];
     }
     function PasswordChanged(field)
      {
         var span = document.getElementById("PasswordStrength");
         span.innerHTML = CheckPassword(field.value);
     }
 
	   
	    
	</script>

    <div style="background-color:Silver;width:800px;margin-left:197px;margin-top:7px">
   
    <div style="margin-left:70px">
    <table border="0" cellpadding="0" width="730px">
    <tr><td colspan="4">
    <div style="background-color:#598891; text-align:center;margin-left:-70px; width:700">
        <span class="style1"><strong 
            style="font-weight: normal">
        <span style="font-size: x-large; background-color: #598891;"> Registration Form</span></strong></span><br class="style1" />
        <hr style="margin-right: 0px"/>
       </div></td></tr>
       <tr>
       <td><b>Register&nbsp; As</b>
       </td><td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                   RepeatDirection="Horizontal" 
                   onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                   AutoPostBack="True">
                   <asp:ListItem Value="2">Publisher</asp:ListItem>
                   <asp:ListItem Value="3">Subscriber</asp:ListItem>
               </asp:RadioButtonList></td>

              <td style="width: 564px"> <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                   ErrorMessage="RequiredFieldValidator" ControlToValidate="RadioButtonList1" 
                   ForeColor="#FF3300"> *  Select Type</asp:RequiredFieldValidator>
               </td></tr>
               <tr><td colspan=3 style="color: #008080; font-size: medium">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td></tr>
       <tr><td colspan="3">
           <span class="style2" style="font-weight: bold">
           <span style="font-size: medium; background-color: #598891;">Login Information</span></span><br />        <br />
        </td></tr>
        <tr>
       <td style="height: 32px;width:109px"> Username(Email-ID):</td>
        <td style="width: 20px; height: 32px;">
        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox></td>
        <td style="height: 32px; width: 564px;">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtuname" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Enter Username</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtuname" ErrorMessage="RegularExpressionValidator" 
                ForeColor="#FF3300" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> * Enter Email-ID only</asp:RegularExpressionValidator>
       &nbsp;</td></tr>
       <tr><td style="height: 32px; width: 109px;">
       
        Password :
        </td>
        <td style="width: 243px; height: 32px;">
        <asp:TextBox ID="txtpwd" runat="server" CausesValidation="True" 
                TextMode="Password" Onkeyup="PasswordChanged(this)" ></asp:TextBox>&nbsp;
                </td><td><span id="PasswordStrength" style="color:Red"></span></td>
        <td style="height: 32px; width: 564px;">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpwd" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Enter Password</asp:RequiredFieldValidator>&nbsp;
            </td></tr>
<tr><td style="width: 109px">Confirm Password :</td>
       <td style="width: 243px"> <asp:TextBox ID="txtcpwd" runat="server" 
               TextMode="Password"></asp:TextBox></td>
        <td style="width: 564px"><asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtpwd" ControlToValidate="txtcpwd" 
            ErrorMessage="CompareValidator" ForeColor="#FF3300">* Password should be same</asp:CompareValidator>
        </td>
        </tr>
        <tr><td colspan="3">
            <strong>
            <span 
            style="font-size: medium; background-color: #598891;"> 
        Personal Information </span></strong> </td></tr>      
<tr><td style="width: 109px"> 
        First Name :</td>
        <td style="width: 243px">
        <asp:TextBox ID="txtfname" runat="server"></asp:TextBox></td>
        <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtfname" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Enter FirstName</asp:RequiredFieldValidator>
       &nbsp;<%--<asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
                runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="#FF3300" 
                ValidationExpression="&quot;[a-zA-Z]&quot; " ControlToValidate="txtfname"> *  Enter Characters only</asp:RegularExpressionValidator>--%>
       </td>
</tr>
<tr><td style="width: 109px; height: 26px;"> 
        Last Name :</td>

        <td style="width: 243px; height: 26px;">
        <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
        </td>
        
        </tr>
<tr><td style="width: 109px; height: 26px;" > 
        Date of Birth :</td>

        <td style="width: 243px; height: 26px;">
            <asp:DropDownList ID="drp1" runat="server" 
                onselectedindexchanged="drp1_SelectedIndexChanged">
                <asp:ListItem>-Day-</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                
                </asp:DropDownList>
             <asp:DropDownList ID="drp2" runat="server">
                 <asp:ListItem>-Month-</asp:ListItem>
                 <asp:ListItem>January</asp:ListItem>
                 <asp:ListItem>February</asp:ListItem>
                 <asp:ListItem>March</asp:ListItem>
                 <asp:ListItem>April</asp:ListItem>
                 <asp:ListItem>May</asp:ListItem>
                 <asp:ListItem>June</asp:ListItem>
                 <asp:ListItem>July</asp:ListItem>
                 <asp:ListItem>August</asp:ListItem>
                 <asp:ListItem>September</asp:ListItem>
                 <asp:ListItem>October</asp:ListItem>
                 <asp:ListItem>November</asp:ListItem>
                 <asp:ListItem>December</asp:ListItem>
            </asp:DropDownList>
              <asp:DropDownList ID="drp3" runat="server">
                  <asp:ListItem>-Year-</asp:ListItem>
                  <asp:ListItem>1970</asp:ListItem>
                  <asp:ListItem>1971</asp:ListItem>
                  <asp:ListItem>1972</asp:ListItem>
                  <asp:ListItem>1973</asp:ListItem>
                  <asp:ListItem>1974</asp:ListItem>
                  <asp:ListItem>1975</asp:ListItem>
                  <asp:ListItem>1976</asp:ListItem>
                  <asp:ListItem>1977</asp:ListItem>
                  <asp:ListItem>1978</asp:ListItem>
                  <asp:ListItem>1979</asp:ListItem>
                  <asp:ListItem>1980</asp:ListItem>
                  <asp:ListItem>1981</asp:ListItem>
                  <asp:ListItem>1982</asp:ListItem>
                  <asp:ListItem>1983</asp:ListItem>
                  <asp:ListItem>1984</asp:ListItem>
                  <asp:ListItem>1985</asp:ListItem>
                  <asp:ListItem>1986</asp:ListItem>
                  <asp:ListItem>1987</asp:ListItem>
                  <asp:ListItem>1988</asp:ListItem>
                  <asp:ListItem>1989</asp:ListItem>
                  <asp:ListItem>1990</asp:ListItem>
                  <asp:ListItem>1991</asp:ListItem>
                  <asp:ListItem>1992</asp:ListItem>
                  <asp:ListItem Value="1993">1993</asp:ListItem>
                  <asp:ListItem>1994</asp:ListItem>
                  <asp:ListItem>1995</asp:ListItem>
                  <asp:ListItem>1996</asp:ListItem>
                  <asp:ListItem>1997</asp:ListItem>
                  <asp:ListItem>1998</asp:ListItem>
                  <asp:ListItem>1999</asp:ListItem>
                  <asp:ListItem>2000</asp:ListItem>
            </asp:DropDownList>
            </td>
        <td>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                ControlToValidate="drp1" ErrorMessage="RequiredFieldValidator" 
                ForeColor="#FF3300">* Select Day</asp:RequiredFieldValidator>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                ControlToValidate="drp2" ErrorMessage="RequiredFieldValidator" 
                ForeColor="#FF3300">* Select Month</asp:RequiredFieldValidator>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                ControlToValidate="drp3" ErrorMessage="RequiredFieldValidator" 
                ForeColor="#FF3300"> * Select Year</asp:RequiredFieldValidator>--%>
    </td>
        </tr>
        <tr>
        <td>
            Company Name:</td><td>
                <asp:TextBox ID="txtcmpname" runat="server"></asp:TextBox>
            </td><td style="width: 564px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="txtcmpname" ErrorMessage="RequiredFieldValidator" 
                    ForeColor="#FF3300"> * Enter CompanyName</asp:RequiredFieldValidator>
            </td></tr>
        <tr><td style="width: 109px"> Permanent Address :</td>
        <td style="width: 243px">
        <asp:TextBox ID="txtpermadd" runat="server" style="margin-left: 0px" 
            TextMode="MultiLine" Width="243px"></asp:TextBox></td>
            <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtpermadd" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* This field cannot be left empty.</asp:RequiredFieldValidator>
       &nbsp;<%--<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                    ControlToValidate="txtpermadd" ErrorMessage="RegularExpressionValidator" 
                    ForeColor="#FF3300" ValidationExpression="&quot;(.|\r|\n){0,250}&quot; "> *  Enter Maximum 250 characters is</asp:RegularExpressionValidator>--%>
       </td>
      </tr>
      <tr><td style="width: 109px">  
 Correspondence Address :</td>
 <td style="width: 243px">
        <asp:TextBox ID="txtcorresadd" runat="server" TextMode="MultiLine" Width="243px"></asp:TextBox>
       </td></tr>
         <tr>      

   <td style="width: 109px">     Country :</td>
   <td style="width: 243px">
        <asp:DropDownList ID="drpcountry" runat="server">
            <asp:ListItem>Select </asp:ListItem>
            <asp:ListItem>America</asp:ListItem>
            <asp:ListItem>Australia</asp:ListItem>
            <asp:ListItem>Argentina</asp:ListItem>
            <asp:ListItem>Austria</asp:ListItem>
            <asp:ListItem>Bangladesh</asp:ListItem>
            <asp:ListItem>Belgium</asp:ListItem>
            <asp:ListItem>Brazil</asp:ListItem>
            <asp:ListItem>Bhutan</asp:ListItem>
            <asp:ListItem>Canada</asp:ListItem>
            <asp:ListItem>China</asp:ListItem>
            <asp:ListItem>Colombia</asp:ListItem>
            <asp:ListItem>Denmark</asp:ListItem>
            <asp:ListItem>Egypt</asp:ListItem>
            <asp:ListItem>France</asp:ListItem>
            <asp:ListItem>Germany</asp:ListItem>
            <asp:ListItem>Greece</asp:ListItem>
            <asp:ListItem>Hong Kong</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>Iran</asp:ListItem>
            <asp:ListItem>Italy</asp:ListItem>
            <asp:ListItem>Japan</asp:ListItem>
            <asp:ListItem>Kenya</asp:ListItem>
            <asp:ListItem>Libya</asp:ListItem>
            <asp:ListItem>New Zealand</asp:ListItem>
            <asp:ListItem>Pakistan</asp:ListItem>
            <asp:ListItem>Russia</asp:ListItem>
            <asp:ListItem>Singapore</asp:ListItem>
            <asp:ListItem>South Africa</asp:ListItem>
            <asp:ListItem>United States</asp:ListItem>
            <asp:ListItem>United Kingdom</asp:ListItem>
            <asp:ListItem>Zimbabwe</asp:ListItem>
        </asp:DropDownList></td>
        <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="drpcountry" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Please select Country.</asp:RequiredFieldValidator>
       </td></tr>
       <tr><td style="width: 109px">
        State :</td>
        <td style="width: 243px">
        <asp:DropDownList ID="drpstate" runat="server" 
                Width="121px">
                <asp:ListItem>Select </asp:ListItem>
            <asp:ListItem>Assam</asp:ListItem>
            <asp:ListItem>Andhra Pradesh</asp:ListItem>
            <asp:ListItem>Bihar</asp:ListItem>
            <asp:ListItem>Chandigarh</asp:ListItem>
            <asp:ListItem>Chhattisgarh</asp:ListItem>
            <asp:ListItem>Goa</asp:ListItem>
            <asp:ListItem>Gujarat</asp:ListItem>
            <asp:ListItem>Haryana</asp:ListItem>
            <asp:ListItem>Himachal Pradesh</asp:ListItem>
            <asp:ListItem>Jammu and Kashmir</asp:ListItem>
            <asp:ListItem>Jharkhand</asp:ListItem>
            <asp:ListItem>Karnataka</asp:ListItem>
            <asp:ListItem>Kerala</asp:ListItem>
            <asp:ListItem>Manipur</asp:ListItem>
            <asp:ListItem>Nagaland</asp:ListItem>
            <asp:ListItem>Orissa</asp:ListItem>
            <asp:ListItem>Punjab</asp:ListItem>
            <asp:ListItem>Rajasthan</asp:ListItem>
            <asp:ListItem>Sikkim</asp:ListItem>
            <asp:ListItem>Tamil Nadu</asp:ListItem>
            <asp:ListItem>Uttar Pradesh</asp:ListItem>
            <asp:ListItem>West Bengal</asp:ListItem>
        </asp:DropDownList></td>
        <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="drpstate" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Please select State.</asp:RequiredFieldValidator>
</td></tr>
       <tr><td style="width: 109px"> City :</td>
       <td style="width: 243px">
        <asp:DropDownList ID="drpcity" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Height="16px" 
               Width="124px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Amritsar</asp:ListItem>
            <asp:ListItem>Agra</asp:ListItem>
            <asp:ListItem>Bangalore </asp:ListItem>
            <asp:ListItem>Chandigarh</asp:ListItem>
            <asp:ListItem>Dehradun </asp:ListItem>
            <asp:ListItem>Delhi </asp:ListItem>
            <asp:ListItem>Ghaziabad</asp:ListItem>
            <asp:ListItem>Goa </asp:ListItem>
            <asp:ListItem>Gurgaon </asp:ListItem>
            <asp:ListItem>Guwahati </asp:ListItem>
            <asp:ListItem>Hyderabad</asp:ListItem>
            <asp:ListItem> Indore</asp:ListItem>
            <asp:ListItem>Jaipur </asp:ListItem>
            <asp:ListItem>Jalandhar</asp:ListItem>
            <asp:ListItem>Patna</asp:ListItem>
            <asp:ListItem>Kolkata</asp:ListItem>
            <asp:ListItem>Ludhiana </asp:ListItem>
            <asp:ListItem>Nagpur</asp:ListItem>
            <asp:ListItem>Noida</asp:ListItem>
            <asp:ListItem>Pune </asp:ListItem>
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Shimla</asp:ListItem>
            <asp:ListItem>Srinagar</asp:ListItem>
            <asp:ListItem>Vishakapatnam</asp:ListItem>
            <asp:ListItem>Udaipur</asp:ListItem>
        </asp:DropDownList></td>
<td style="width: 564px"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="drpcity" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Please select city.</asp:RequiredFieldValidator>
        </td>
        </tr>
        

       <tr><td style="width: 109px">
        Fax :</td>
        <td style="width: 243px">
        <asp:TextBox ID="txtfax" runat="server"></asp:TextBox>
        </td><td style="width: 564px">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                   ControlToValidate="txtfax" ErrorMessage="RequiredFieldValidator" 
                   ForeColor="#FF3300"> * Enter FaxNumber</asp:RequiredFieldValidator>
&nbsp;</td></tr>
        <tr><td style="width: 109px">
        Pincode :</td>
        <td style="width: 243px">
        <asp:TextBox ID="txtpincode" runat="server"></asp:TextBox></td>
        <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
            ControlToValidate="txtpincode" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300"> * Enter Pincode</asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator7" 
                runat="server" ControlToValidate="txtpincode" 
                ErrorMessage="RegularExpressionValidator" ForeColor="#FF3300" 
                ValidationExpression="\d{6}"> * Enter valid Pincode</asp:RegularExpressionValidator>
        </td></tr>
        <tr><td style="width: 109px"> Contact Number :</td>
        <td style="width: 243px"><asp:TextBox ID="txtcontactno" runat="server"></asp:TextBox></td>
        <td style="width: 564px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
            ControlToValidate="txtcontactno" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Enter Contact Number</asp:RequiredFieldValidator>
        &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                ControlToValidate="txtcontactno" ErrorMessage="RegularExpressionValidator" 
                ForeColor="#FF3300" 
                ValidationExpression="^([9]{1})([234789]{1})([0-9]{8})$"> * Enter valid  Contact Number</asp:RegularExpressionValidator>
&nbsp;
        </td></tr>
        <tr><td style="width: 109px"> Contact Email :</td>
        <td style="width: 243px">
        <asp:TextBox ID="txtcontactemail" runat="server"></asp:TextBox></td>
        <td style="width: 564px">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtcontactemail" ErrorMessage="RegularExpressionValidator" 
            ForeColor="#FF3300" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">* Enter valid Email-ID</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
            ControlToValidate="txtcontactemail" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300"> * Enter EmailID</asp:RequiredFieldValidator></td></tr>
 
       </table>
       <table>
       <tr> <div><td  colspan=2 style="height: 41px">
       
           <asp:TextBox  id="txt1" runat="server"
       style="border-style: none; border-color: inherit; border-width: medium; background-color:black; color:red; font-family: 'Curlz MT'; font-size: x-large; font-weight: bold; font-variant: normal; letter-spacing:12px; width: 120px; background-image: url('glitter_background_b4.gif');"
            value="5AbD" ></asp:TextBox>&nbsp;&nbsp;<input type="button" value="Change"  onclick="show()" /></td></tr>
       <tr><td style="width: 109px; height: 26px;">
            <asp:TextBox ID="txtverification" runat="server"></asp:TextBox>
        &nbsp;&nbsp;<asp:Button ID="But" runat="server" Text="Verification" 
                onclick="But_Click" ></asp:Button></td><td><asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></td>
                </div></tr>
         <tr><td> <asp:TextBox ID="txttos" runat="server" Width="314px" 
                 ReadOnly="True" TextMode="MultiLine">Terms of Service 

Welcome to Global Space!&nbsp; This document explains how the agreement is made up, and sets out some of the terms of that agreement. 1.2 Unless otherwise agreed in writing with Global Space, your agreement with Global Space will always include, at a minimum, the terms and conditions set out in this document. These are referred to below as the “Universal Terms”.&nbsp;

1.&nbsp; THIS SHALL INCLUDE, BUT NOT BE LIMITED TO, ANY LOSS OF PROFIT (WHETHER INCURRED DIRECTLY OR INDIRECTLY), ANY LOSS OF GOODWILL OR BUSINESS REPUTATION, ANY LOSS OF DATA SUFFERED, COST OF PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES, OR OTHER INTANGIBLE LOSS; (B) ANY LOSS OR DAMAGE WHICH MAY BE INCURRED BY YOU, INCLUDING BUT NOT LIMITED TO LOSS OR DAMAGE AS A RESULT OF: (I) ANY RELIANCE PLACED BY YOU ON THE COMPLETENESS, ACCURACY OR EXISTENCE OF ANY ADVERTISING, OR AS A RESULT OF ANY RELATIONSHIP OR TRANSACTION BETWEEN YOU AND ANY ADVERTISER OR SPONSOR WHOSE ADVERTISING APPEARS ON THE SERVICES; (II) ANY CHANGES WHICH Global Space MAY MAKE TO THE SERVICES, OR FOR ANY PERMANENT OR TEMPORARY CESSATION IN THE PROVISION OF THE SERVICES (OR ANY FEATURES WITHIN THE SERVICES); (III) THE DELETION OF, CORRUPTION OF, OR FAILURE TO STORE, ANY CONTENT AND OTHER COMMUNICATIONS DATA MAINTAINED OR TRANSMITTED BY OR THROUGH YOUR USE OF THE SERVICES; (III) YOUR FAILURE TO PROVIDE GOOGLE WITH ACCURATE ACCOUNT INFORMATION; (IV) YOUR FAILURE TO KEEP YOUR PASSWORD OR ACCOUNT DETAILS SECURE AND CONFIDENTIAL; 15.2 THE LIMITATIONS ON GOOGLE’S LIABILITY TO YOU IN PARAGRAPH 15.1 ABOVE SHALL APPLY WHETHER OR NOT GOOGLE HAS BEEN ADVISED OF OR SHOULD HAVE BEEN AWARE OF THE POSSIBILITY OF ANY SUCH LOSSES ARISING.&nbsp; April 15, 2011 </asp:TextBox>
           &nbsp;</td></tr>
        <tr><td>
        <asp:CheckBox ID="chk" runat="server" 
            Text="   I accept terms and conditions specified." />
       </td><td>
                &nbsp;</td></tr>
        <tr><td><asp:Literal ID="literal2" runat="server"></asp:Literal></td><td>
                &nbsp;</td></tr>
<tr><td>
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="73px" 
            onclick="btnsubmit_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncan" runat="server" Text="Cancel" Width="69px" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnreset" runat="server" Text="Reset" Width="68px" /></td>
        </tr>
        
        </table>
 </div>
    </div>
</asp:Content>

