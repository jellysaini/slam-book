<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="inviteFriend.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.inviteFriend" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable" >            
        <tr><td><br /><br /><br /></td></tr>
        <tr><td><font class="headingtxt">Enter the Email Id You Want to Invite</font></td></tr>
        <tr align="center">    
            <td>                
                <table width="70%" bgcolor="gray">
                    <tr align="center">
                        <td>
                            <br /><br />
                               <font class="NormalText">EMail ID:-</font>&nbsp; <asp:TextBox CssClass="textboxstyle" ID="to" runat="server"></asp:TextBox>            
                            <br /><br />
                        </td>
                    </tr>
                    <tr align="center">
                        <td><asp:Button CssClass="button" ID="send" Text="send" runat="server" onclick="send_Click" /><br /></td>                        
                    </tr>
                    <tr align="center"><td><asp:Label ID="result" Text=" " runat="server"></asp:Label><br /><br /></td></tr>
                </table>                 
            </td>
        </tr>
    </table>
</asp:Content>
