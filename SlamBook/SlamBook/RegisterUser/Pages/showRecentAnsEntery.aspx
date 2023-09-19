<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="showRecentAnsEntery.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.showRecentAnsEntery" Title="Untitled Page" %>
<%@ Register src="~/User Controls/slamBKInfo.ascx" tagname="slamBKInfo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../../javascripts files/jquery.js"></script>
    <script type="text/javascript" src="../../javascripts files/slider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="maintable">
    <tr>
        <td>
            <table width="100%">
                <tr>
                    <td>
                        <uc1:slamBKInfo ID="slamBKInfo1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                        <tr align="center">
                            <td><font class="fonttext"><asp:Label ID="friendname" Text="Entries Made by Friend : -" runat="server"></asp:Label></font><br /><br /></td>
                         </tr>
                            <tr>
                                <td>
                                    <asp:DataList ID="dl1" runat="server" Width="100%" HorizontalAlign="Left" >
                                        <HeaderTemplate>
                                            <table width="100%" border="2">
                                                <tr>
                                                    <th width="10%">Sr.No.</th>
                                                    <th width="90%">Questions / Answers by the Friend</th>
                                                </tr>
                                            </table>
                                            <table width="100%">                                    
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr align="center">
                                                <td width="10%"><input class="input" type="text" value='<%#Eval("sno") %>' readonly="readonly" /><br /><br /></td>
                                                <td width="90%">                                        
                                                    <div id='h<%# Container.ItemIndex %>' class="abc" onclick="getdata(<%# Container.ItemIndex %>)" style="display:block;" >
                                                        <asp:Label ID="lbl" Text='<%#Eval ("question") %>' runat="server"></asp:Label> 
                                                    </div>
                                                    <div id='d<%# Container.ItemIndex %>' class="xyz">                                               
                                                        <asp:TextBox ID="tb1" Text='<%#Eval("answer") %>' TextMode="MultiLine" Width="100%" runat="server" ReadOnly="true"></asp:TextBox>
                                                    </div>
                                                    <hr width="100%" /><br />
                                                </td>
                                            </tr>
                                        </ItemTemplate>                                                              
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>                                
                                </asp:DataList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr align="center">
                    <td>
                        <table width="100%">
                            <tr align="center">
                                <td width="25%"></td>                                
                                <td width="10%"><asp:Button ID="first" Text="First" runat="server" Width="90%" 
                                        onclick="first_Click" /></td>
                                <td width="10%"><asp:Button ID="prev" Text="Previous" runat="server" Width="90%" 
                                        onclick="prev_Click" /></td>
                                <td width="10%"><asp:Label ID="pno" Text=" " runat="server"></asp:Label></td>
                                <td width="10%"><asp:Button ID="next" Text="Next" runat="server" Width="90%" 
                                        onclick="next_Click" /></td>
                                <td width="10%"><asp:Button ID="last" Text="Last" runat="server" Width="90%" 
                                        onclick="last_Click" /></td>
                                <td width="25%"></td>                                
                            </tr>
                        </table>
                    </td>
                </tr>
        </table>
    </td>
 </tr>
</table>    
</asp:Content>
