<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="sendtoMany.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.sendtoMany" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable">
        <tr align="center">
            <td>
                <table width="80%">
                    <tr align="left">
                        <td><font class="NormalText">Enter Text for Combined Massage:--</font></td>
                    </tr>
                    <tr align="center">
                        <td>
                            <asp:TextBox ID="slamtb" TextMode="MultiLine" runat="server" Width="80%" Height="80px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr align="center">
            <td><br /><font class="fonttext">Yours Friend List, Choose to send Scrap</font><hr width="60%" /><br />
                <table width="100%">
                    <tr align="center">
                        <td width="10%"></td>
                        <td width="80%">
                            <table width="100%">
                                <tr>
                                    <td>
                                        <asp:DataList ID="scrapdlist" Width="100%" runat="server" >
                                            <HeaderStyle BackColor="BurlyWood" ForeColor="AliceBlue" />
                                            <HeaderTemplate>
                                                <table width="100%">
                                                    <tr align="center">
                                                        <td width="5%">SNo.</td>
                                                        <td width="15%">Image</td>
                                                        <td width="70%">Name of Friend</td>
                                                        <td width="10%">Choose</td>
                                                    </tr>
                                                </table>
                                                <table width="100%">                                         
                                            </HeaderTemplate>
                                            <ItemStyle Font-Bold="true" ForeColor="GrayText" BackColor="AliceBlue" />
                                            <ItemTemplate>
                                                <tr align="center">
                                                        <td width="5%"><%#Eval("SNo") %></td>
                                                        <td width="15%"><img alt="not found" src='../<%#Eval("ImageName") %>' width="50px" /></td>
                                                        <td width="70%"><%#Eval("FName") %>&nbsp;<%#Eval("LName") %><hr /></td>
                                                        <td width="10%"><asp:CheckBox ID="slamcheck" runat="server" /><asp:HiddenField ID="slamhdn" Value='<%#Eval("UserId") %>' runat="server" /></td>
                                                    </tr>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>
                                        </asp:DataList><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table width="100%">
                                            <tr align="center">
                                                <td width="50%"><asp:Label ID="slamlbl" Text=" " runat="server"></asp:Label></td>
                                                <td width="50%">
                                                    <asp:Button ID="scrapsend" Text="Send" runat="server" 
                                                        onclick="scrapsend_Click" />&nbsp;&nbsp;
                                                    <asp:Button ID="scrapcancel" Text="Cancel" runat="server" />
                                                </td>
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
