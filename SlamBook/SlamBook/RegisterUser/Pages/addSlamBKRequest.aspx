<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="addSlamBKRequest.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.addSlamBKRequest" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="maintable">
    <tr><td><br /><br /></td></tr>
    <tr>
        <td>
            <table width="100%">
                <tr align="center">
                    <td width="10%"></td>
                    <td width="80%"><font class="fonttext">List Of Friends,to whom Request is not sent Till Now.</font><br /><br />
                        <table width="100%">
                            <tr>
                                <td>
                                    <table width ="100%">
                                        <tr>
                                            <td>
                                                <asp:DataList ID="sbdlist" runat="server" Width="100%">
                                                    <HeaderStyle Font-Size="Medium" ForeColor="Red" HorizontalAlign="Center" BackColor="Gray" />
                                                    <HeaderTemplate>
                                                        <table width="100%" border="1px">
                                                            <tr align="center">
                                                                <td width="5%">SNo.</td>
                                                                <td width="15%">Image</td>
                                                                <td width="70%">Detail Information of Friend</td>
                                                                <td width="10%">Check</td>
                                                            </tr>
                                                        </table>
                                                    </HeaderTemplate>
                                                    <ItemStyle Font-Size="Medium" ForeColor="Gray" />
                                                    <ItemTemplate>
                                                        <table width="100%">
                                                            <tr align="left">
                                                                <td width="5%"><%#Eval("SNo") %></td>
                                                                <td width="15%"><img alt="not Found" src='../<%#Eval("ImageName") %>' width="100px" /></td>
                                                                <td width="70%">
                                                                    Name:-&nbsp;<%#Eval("FName") %> &nbsp;<%#Eval("LName") %><br />
                                                                    Sex:-&nbsp;<%#Eval("Sex") %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Age:-&nbsp;<%#Eval("Age") %><br />
                                                                    City:-&nbsp;<%#Eval("city") %>&nbsp;&nbsp;&nbsp;State:-&nbsp;<%#Eval("state") %>&nbsp;&nbsp;&nbsp;Country:-&nbsp;<%#Eval("country") %><br />
                                                                    Mobile No:-&nbsp;<%#Eval("mobno") %>&nbsp;&nbsp;&nbsp;EMail ID:-&nbsp;<%#Eval("EMail") %>                                                         
                                                                    <hr width="100%" />                                                                    
                                                                </td>
                                                                <td width="10%"><asp:CheckBox ID="sbchkbox" runat="server" /><asp:HiddenField ID="sbhdn" runat="server" Value='<%#Eval("userid") %>' /></td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>                            
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table width="100%">
                                        <tr>
                                            <td width="50%"><asp:Label ID="sbmsg" Text="No Record Found" runat="server" Visible="false"></asp:Label></td>
                                            <td width="50%"><asp:LinkButton ID="sbreqsubmit" Text="Click Here to Send, Request to Selected Records.." runat="server" onclick="sbreqsubmit_Click"></asp:LinkButton> </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table width="100%">
                                        <tr align="center">
                                            <td width="15%"></td>
                                            <td width="14%"><asp:Button ID="sbfirst" runat="server" Text="First" CssClass="button" onclick="sbfirst_Click" /></td>
                                            <td width="14%"><asp:Button ID="sbprev" runat="server" Text="Prev" CssClass="button" onclick="sbprev_Click" /></td>
                                            <td width="14%"><asp:Label ID="sbpno" runat="server" Text=" "></asp:Label></td>
                                            <td width="14%"><asp:Button ID="sbnext" Text="Next" runat="server" CssClass="button" onclick="sbnext_Click" /></td>
                                            <td width="14%"><asp:Button ID="sblast" Text="Last" runat="server" CssClass="button" onclick="sblast_Click" /></td>
                                            <td width="15%"></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>                            
                        </table>
                    </td>                   
                    <td width="10%"></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
