<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="smsdetail.aspx.cs" Inherits="SlamBook.LogIn.Pages.smsdetail" Title="Untitled Page" %>
<%@ Register Src="~/LogIn/LogIn Controls/signupcontrol.ascx" TagPrefix="ucl" TagName="signupcontrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MasterTableMain">
        <tr>
            <td>
                <table class="MasterTableMain">
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="12%"></td>
                                    <td width="76%"><ucl:signupcontrol ID="signupcontrol" runat ="server" /></td>
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
                                                                <img src="../../App_Themes/LogIn/Images/sms-zone.jpg"alt="not Found"/>
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
                                                            <td width="100%"><font class="LogInFont">Online E-Card</font></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr align="center" >
                                                <td>
                                                    <table width="80%">
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">Instant Messaging (IM) is a collection of technologies that create the possibility of real-time text-based communication between two or more participants over the internet or some form of internal network/intranet. It is important to understand that what separates chat and instant messaging from technologies such as e-mail is the perceived synchronicity of the communication by the user - Chat happens in real-time. Some systems allow the sending of messages to people not currently logged on (offline messages), thus removing some of the differences between Instant Messaging and e-mail (often this is done by sending the message to the associated e-mail account).</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">IM allows effective and efficient communication, allowing immediate receipt of acknowledgment or reply. In many cases Instant Messaging includes additional features, which make it even more popular. For example, users can see each other by using web-cams, or talk directly for free over the Internet using a microphone and headphones (or speakers). Many clients allow file transfer as well, although they are typically limited in the file-size allowed.</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">It is typically possible to save a conversation for later reference. Instant messages are often logged in a local message history, making it similar to the persistent nature of e-mails.</font>
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
