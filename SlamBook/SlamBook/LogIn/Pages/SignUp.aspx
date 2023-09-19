<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SlamBook.LogIn.Pages.SignUp" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="Stylesheet" href="../../App_Themes/LogIn/epoch_styles.css" />
        <script type="text/javascript" src="../../javascripts files/epoch_classes.js"></script> 
        <script type="text/javascript"  >
            /*You can also place this code in a separate file and link to it like epoch_classes.js*/
	            var bas_cal,dp_cal,ms_cal;      
                window.onload = function () {	
	            dp_cal  = new Epoch('epoch_popup','popup',document.getElementById('popup_container'));	
                };
                function dobret()
                {
                  
                    var dobvalue = document.getElementById("popup_container").value;                     
                    document.getElementById("ctl00_ContentPlaceHolder1_hdnfield").value=dobvalue;                                           
                };
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MasterTableMain">
        <tr>
            <td>
                <div class="common ">
                    <div style="width:65%" class="common">
                        <table class="MasterTableMain ">
                            <tr><td><br /></td></tr>
                            <tr align="center" ><td><img src="../../App_Themes/LogIn/Images/signuplogo.gif" alt="Not Found" /><hr width="80%" /></td></tr>
                            <tr><td><br /></td></tr>
                            <tr align="center"><td><font class="normalFont">Fields Marked With * are Mandatory...</font></td></tr>
                            <tr><td><br /></td></tr>
                            <tr>
                                <td>
                                    <table width="100%">
                                        <tr>
                                <td width="10%"></td>
                                <td width="80%">
                                    <table class="MasterTableMain ">
                                        <tr><td><font class="normalFont">Name *</font></td></tr>
                                        <tr>
                                            <td>
                                                <table width="100%">
                                                    <tr>
                                                        <td width="5%"></td>
                                                        <td width="40%"><font class="normalFont">First Name</font></td>
                                                        <td width="10%"></td>
                                                        <td width="40%"><font class="normalFont">Last Name</font></td>
                                                        <td width="5%"></td>
                                                    </tr>
                                                    <tr align="center" >
                                                        <td width="5%"></td>
                                                        <td width="40%"><asp:TextBox ID="FNtxt" runat ="server" CssClass="textboxsignup " 
                                                                ValidationGroup="a"></asp:TextBox></td>
                                                        <td width="10%">
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                ControlToValidate="FNtxt" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                        </td>
                                                        <td width="40%"><asp:TextBox ID="LNtxt" runat="server" CssClass="textboxsignup " 
                                                                ValidationGroup="a"></asp:TextBox></td>
                                                        <td width="5%">
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                ControlToValidate="LNtxt" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr><td><br /></td></tr>
                                        <tr>
                                            <td>
                                                <div style="width:100%; border:solid 1px gray;">
                                                <table width="100%">
                                                    <tr>
                                                        <td>
                                                            <table width="100%">                                                 
                                                                <tr align="justify" >
                                                                    <td width="50%"><font class="normalFont ">E-Mail Address*</font></td>
                                                                    <td width="50%"><asp:TextBox ID="EMtxt" runat="server" CssClass="textboxsignup" 
                                                                            ValidationGroup="a" ></asp:TextBox>
                                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                                            ControlToValidate="EMtxt" ErrorMessage="*" 
                                                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                                            ValidationGroup="a"></asp:RegularExpressionValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr><td><br /></td></tr>
                                                                <tr align="justify" >
                                                                    <td width="50%"><font class="normalFont ">Password*</font></td>
                                                                    <td width="50%"><asp:TextBox ID="Passtxt" runat="server" CssClass="textboxsignup" 
                                                                            TextMode="Password" ValidationGroup="a" ></asp:TextBox>
                                                                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                                            ControlToCompare="Passtxt" ControlToValidate="Contxt" ErrorMessage="*" 
                                                                            ValidationGroup="a"></asp:CompareValidator>
                                                                                                                </td>
                                                                </tr>
                                                                <tr align="justify">
                                                                    <td width="50%"><font class="normalFont ">Confirm Password*</font></td>
                                                                    <td width="50%"><asp:TextBox ID="Contxt" runat="server" CssClass="textboxsignup" 
                                                                            TextMode="Password" ValidationGroup="a" ></asp:TextBox></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table width="100%">   
                                                    
                                                    <tr><td><br /></td></tr>
                                                    <tr align="justify" >
                                                        <td width="50%">
                                                            <table width="100%">
                                                                <tr align="left">
                                                                    <td width="50%"><font class="normalFont ">Date of Birth*</font></td>
                                                                    <td width="50%">
                                                                        <form id="placeholder" method="get" action="#">
                                                                            <input id="popup_container" type="text" style="width:100%" />
                                                                        </form>  
                                                                        <asp:HiddenField ID="hdnfield" runat="server" />
                                                                    </td>
                                                                </tr>                                                                
                                                            </table>
                                                        </td>                                                 
                                                        <td width="50%">
                                                            <table width="100%">
                                                                <tr align="justify">
                                                                    <td width="50%"><font class="normalFont ">Gender*</font></td>
                                                                    <td width="50%"><asp:DropDownList ID="gendd" runat="server" 
                                                                            CssClass="textboxsignup " ValidationGroup="a"></asp:DropDownList></td>
                                                                </tr>                                                                
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    
                                                    <tr align="justify">
                                                        <td width="50%"><font class="normalFont ">Mailing Address*</font></td>
                                                        <td width="50%"><asp:TextBox ID="addtxt1" runat="server" CssClass="textboxsignup" 
                                                                ValidationGroup="a"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                ControlToValidate="addtxt1" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                                                </td>
                                                    </tr>
                                                    <tr align="justify">
                                                        <td width="50%"></td>
                                                        <td width="50%"><asp:TextBox ID="addtxt2" runat="server" CssClass="textboxsignup"></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="justify">
                                                        <td width="50%"></td>
                                                        <td width="50%"><asp:TextBox ID="addtxt3" runat="server" CssClass="textboxsignup"></asp:TextBox></td>
                                                    </tr>

                                                    <tr><td><br /></td></tr>
                                                    <tr align="justify" >
                                                        <td width="50%"><font class="normalFont ">City*</font></td>
                                                        <td width="50%"><asp:TextBox ID="ctytxt" runat="server" CssClass="textboxsignup" 
                                                                ValidationGroup="a" ></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                ControlToValidate="ctytxt" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    <tr align="justify" >
                                                        <td width="50%"><font class="normalFont ">State*</font></td>
                                                        <td width="50%"><asp:TextBox ID="statxt" runat="server" CssClass="textboxsignup" 
                                                                ValidationGroup="a" ></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                ControlToValidate="statxt" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    <tr align="justify">
                                                        <td width="50%"><font class="normalFont ">Country*</font></td>
                                                        <td width="50%"><asp:DropDownList ID="coundd" runat="server" 
                                                                CssClass="textboxsignup " ValidationGroup="a"></asp:DropDownList></td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    <tr align="justify" >
                                                        <td width="50%"><font class="normalFont ">Pin Code</font></td>
                                                        <td width="50%"><asp:TextBox ID="pintxt" runat="server" CssClass="textboxsignup " 
                                                                ValidationGroup="a" ></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                ControlToValidate="pintxt" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                                                </td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>                                                    
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table width="100%">
                                                    <tr align="left">
                                                        <td width="10%"><asp:CheckBox ID="chbox" runat="server" Text=" " 
                                                                ValidationGroup="a" /></td>
                                                        <td width="60%"><h4>I accept all <a href="Terms.aspx" style="text-decoration:none; color:Black;">terms</a> for Use.</h4></td>
                                                        <td width="30%"></td>
                                                    </tr>
                                                    <tr align="center" >
                                                        <td width="10%"></td>
                                                        <td width="60%"></td>
                                                        <td width="30%">
                                                            <asp:Button ID="savebtn" Text="Submit" runat="server" Width="60%" 
                                                                onclick="savebtn_Click" ValidationGroup="a" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr><td><br /></td></tr>
                                    </table>
                                </td>
                                <td width="10%"></td>
                            </tr>
                                    </table>
                                </td>
                            </tr>                      
                        </table>
                    </div>
                    <div style="width:35%; top:200px;" class="common">
                        <table class="MasterTableMain">
                            <tr align="center" >
                                <td>
                                    <img src="../../App_Themes/LogIn/Images/slambooksignup.jpg" alt="Not Found" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
