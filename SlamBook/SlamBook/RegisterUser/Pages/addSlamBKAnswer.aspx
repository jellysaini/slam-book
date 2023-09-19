<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="addSlamBKAnswer.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.addanswer" Title="Untitled Page" %>
<%@ Register src="~/User Controls/slamBKInfo.ascx" tagname="slamBKInfo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="maintable">
    <tr align="center">
        <td>
            <table width="100%">
                <tr>
                    <td>            
                        <uc1:slamBKInfo ID="slamBKInfo1" runat="server" />            
                    </td>
                </tr>
            </table>
            <table width="100%">
                <tr align="center">
                    <td>
                        <table width="75%">
                            <tr align="right">
                                <td class="backImg">         
                                    <br /><br /><br /><br /><br /><br />                                 
                                        <table width="73%">
                                            <tr align="left">
                                                <td>
                                                    <asp:DataList Font-Size="Medium" Font-Names="Comic Sans MS" ForeColor="Brown" 
                                                        BorderWidth="0" ID="userAnsDL" Width="90%" runat="server">
                                                        <HeaderTemplate>
                                                            <table width="100%" border="0">                                                                                                                            
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr>
                                                                <td width="10%"><%#Eval("sno") %></td>
                                                                <td width="90%">
                                                                    <asp:Label ID="userQL" Text='<%#Eval("question") %>' runat="server"></asp:Label><br />
                                                                    <asp:HiddenField ID="qid" Value='<%#Eval("id") %>' runat="server" />
                                                                    Give Your's Best Answer:-<br />
                                                                    <asp:TextBox CssClass="textbox" ID="userATB" Text='<%#Eval("answer") %>' TextMode="MultiLine" Width="90%" Height="70px" runat="server"></asp:TextBox><hr width="80%" />
                                                                </td>
                                                            </tr>
                                                        </ItemTemplate>
                                                        <FooterTemplate>                                                            
                                                            </table>
                                                        </FooterTemplate>
                                                    </asp:DataList>
                                                </td>
                                            </tr>
                                            <tr align="left"><td><font class="NormalText">Click here to:--</font><asp:LinkButton ID="ansSave" Text="Save/Update" Font-Bold="true" ForeColor="Red" Font-Underline="false" runat="server" onclick="ansSave_Click"></asp:LinkButton> </td></tr>
                                        </table>                        
                                    <br /><br /><br /><br /><br />                                  
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td>
                        <table width="70%">
                            <tr>
                                <td width="20%"></td>                                
                                <td width="10%"><asp:Button ID="first" Text="First" runat="server" Width="90%" 
                                        onclick="first_Click" /></td>
                                <td width="10%"><asp:Button ID="prev" Text="Previous" runat="server" Width="90%" 
                                        onclick="prev_Click" /></td>
                                <td width="10%"><asp:Label ID="pno" Text=" " runat="server"></asp:Label></td>
                                <td width="10%"><asp:Button ID="next" Text="Next" runat="server" Width="90%" 
                                        onclick="next_Click" /></td>
                                <td width="10%"><asp:Button ID="last" Text="Last" runat="server" Width="90%" 
                                        onclick="last_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>           
        </td>
    </tr>
</table>
</asp:Content>
