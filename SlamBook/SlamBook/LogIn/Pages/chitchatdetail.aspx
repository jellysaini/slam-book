<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="chitchatdetail.aspx.cs" Inherits="SlamBook.LogIn.Pages.WebForm2" Title="Untitled Page" %>
<%@ Register Src="~/LogIn/LogIn Controls/signupcontrol.ascx" TagPrefix="ucl" TagName="signupcontrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MasterTableMain">
        <tr>
            <td>
                <table class ="MasterTableMain">
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="12%"></td>
                                    <td width="76%"><ucl:signupcontrol ID="signupcontril" runat="server" /></td>
                                    <td width="12%"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr valign="top" >
                                    <td width="25%">
                                        <table width="100%">
                                            <tr><td><br /><br /><br /></td></tr>
                                            <tr align="center">
                                                <td>
                                                    <table width="50%">
                                                        <tr>
                                                            <td width="100%">
                                                                <img src="../../App_Themes/LogIn/Images/chitchat.jpg" alt="not Found"/>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                                
                                            </tr>                                            
                                        </table>
                                    </td>
                                    <td width="60%">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                
                                        <table width="100%">
                                            <tr><td><br /></td></tr>
                                            <tr><td><br /></td></tr>
                                            <tr align="center" >                                            
                                                <td width="100%">
                                                    <table width="80%">
                                                        <tr>   
                                                            <td width="100%"><font class="LogInFont">Chit-Chat Details</font></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr align="center" >
                                                <td width="100%">
                                                    <table width="80%">
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText ">During the years that ChitChat was in active development, a new trend in chat clients emerged; that of the multi-client. Multi-Clients connect to more than one service at once, this reduces the number of programs a user must simultaneously run on their computer. The only multi-client that can connect to Yahoo! Chat (as opposed to regular Instant Messaging) as of this writing is Adium.</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText ">ChitChat was an open source instant messaging client for OS protocol. It enabled users to chat with each other over the global chat system. The ChitChat had a more refined user interface, speed improvements, Address Book support. ChitChat was programmed in the REALBasic programming environment.</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>  
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr><td><br /></td></tr>  
                                        </table>
                                        </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="15%">&nbsp;</td>
                                </tr>
                                <tr><td><br /></td></tr>  
                            </table>
                        </td>
                    </tr>
                </table>
             </td>
         </tr>
     </table>
</asp:Content>
