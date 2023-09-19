<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogOutControl.ascx.cs" Inherits="SlamBook.User_Controls.LogOutControl" %>
<table width="100%">
    <tr>
        <td>
            <table width="100%">
                <tr>
                    <td width="5%"></td>
                    <td width="90%">
                        <table width="100%">
                            <tr>
                                <td width="60%">
                                    <font style="font-family:Verdana; color:Black; font-size:medium; font-weight:lighter;">Welcome :- </font>
                                    <font style="font-family:Verdana; color:Purple; font-size:medium;"><asp:Label ID="usrlbl" Text=" " runat="server" ></asp:Label></font>
                                
                                </td>
                                <td width="30%"><asp:LinkButton ID="logoutlnk" Text="LogOut" runat ="server" 
                                        style="text-decoration:none;" onclick="logoutlnk_Click" ></asp:LinkButton></td>
                            </tr>
                        </table>
                    </td>
                    <td width="5%"></td>
                </tr>
                <tr align="justify">
                    <td width="5%"></td>
                    <td width="90%">
                        <table width="100%">
                            <tr>
                                <td width="35%"><font style="font-family:Verdana; color:Black; font-size:medium; font-weight:lighter;">Date & Time :- </font></td>
                                <td width="65%">
                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">                                    
                                        <ContentTemplate>
                                            <asp:Timer ID="Timer1" runat="server" Interval="1000"></asp:Timer>
                                            <font style="font-family:Arial; color:Black; font-size:medium;"><asp:Label ID="watch" Text=" " runat="server" ></asp:Label></font>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>                 
                            </tr>
                        </table>
                    </td>                    
                    <td width="5%"></td>
                </tr>
            </table>
        </td>
    </tr>
</table>