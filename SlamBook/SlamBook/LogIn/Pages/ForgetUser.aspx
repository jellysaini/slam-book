<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="ForgetUser.aspx.cs" Inherits="SlamBook.LogIn.Pages.ForgetUser" Title="Untitled Page" %>
<%@ Register src="~/LogIn/LogIn Controls/signupcontrol.ascx" tagname="signupcontrol" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="MasterTableMain" >
        <tr>
            <td>
                <table class="MasterTableMain">
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="12%"></td>
                                    <td width="76%"><uc1:signupcontrol ID="signupcontrol1" runat="server" /> </td>                                    
                                    <td width="12%"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td width="100%"><hr /><br /><br /></td>
                    </tr>
                    <tr align="center" >
                        <td width="100%">
                            <table border="2" width="70%">
                                
                                <tr align="center" >
                                    <td><br /><font class="headingtext">Trouble Accessing Your Account?</font><br /><br /></td>
                                </tr>
                                
                                <tr align="left">
                                    <td>
                                        <table width="100%">
                                            <tr align="justify">
                                                <td width="10%"></td>
                                                <td width="80%"><br /><font class="NormalText">Forgot your password? Enter your login username and email below. We will send you an email with a link to reset your password.<p>Username and Email should be same as given at signup.</p></font><p></p></td>
                                                <td width="10%"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td><br />
                                        <table width="100%">
                                            <tr>
                                                <td width="20%"></td>
                                                <td width="60%">
                                                    <table>
                                                        <tr><td><br /></td></tr>
                                                        <tr>
                                                            <td width="50%"><font class="normalFont">Email-ID :- </font></td>
                                                            <td width="50%"><asp:TextBox ID="usrtxt" runat="server" Width="200px" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>
                                                        <tr>
                                                            <td width="50%"></td>
                                                            <td width="50%"><asp:Button ID="resetbtn" runat="server" Font-Size="Medium" 
                                                                    BackColor="Gray" ForeColor="LightPink" Text="Send Mail" 
                                                                    onclick="resetbtn_Click"/><br />
                                                                <asp:Label ID="result" Text=" " runat="server"></asp:Label>        
                                                            </td>
                                                        </tr>             
                                                        <tr><td><br /><br /></td></tr>                                           
                                                    </table>
                                                </td>
                                                <td width="20%"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr><td><br /><br /><br /></td></tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
