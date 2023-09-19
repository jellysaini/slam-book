<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="chatdetails.aspx.cs" Inherits="SlamBook.LogIn.Pages.chatdetails" Title="Untitled Page" %>
<%@ Register src="~/LogIn/LogIn Controls/signupcontrol.ascx" tagname="signupcontrol" tagprefix="uc1" %>
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
                                <tr align="left" >
                                    <td width="12%"></td>                                    
                                    <td width="76%">
                                        <uc1:signupcontrol ID="signupcontrol1" runat="server" />
                                    </td>
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
                                                                <img src="../../App_Themes/LogIn/Images/chat.jpg" alt="not Found"/>
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
                                                            <td width="100%"><font class="LogInFont">Online Chat Window</font></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr align="center" >
                                                <td width="100%">
                                                    <table width="80%">
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText ">Online chat can refer to any kind of communication over the Internet, but is primarily meant to refer to direct one-on-one chat or text-based group chat (formally also known as synchronous conferencing), using tools such as instant messengers, Internet Relay Chat, talkers and possibly MUDs. The expression online chat comes from the word chat which means "informal conversation".</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText ">Messenger is an instant messaging client and associated protocol. Messenger is provided free of charge and can be used with a generic. Which also allows access to other Yahoo! services, such as Yahoo! Mail, where users can be automatically notified when they receive new email. Yahoo! also offers PC-PC, PC-Phone and Phone-to-PC service, file transfers, webcam hosting, text messaging service, and chat rooms in various categories.</font>
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
