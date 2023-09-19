<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="showUsersSlamBK.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.showUsersSlamBK" Title="Untitled Page" %>
<%@ Register src="~/User Controls/slamBKInfo.ascx" tagname="slamBKInfo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript" src="../../javascripts files/jquery.js"></script>
    <script type="text/javascript" src="../../javascripts files/slider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="headTable">
        <tr>
            <td>
                <table width="100%">
                    <tr>
                        <td><uc1:slamBKInfo ID="slamBKInfo1" runat="server" /></td>
                    </tr>
                </table>
            </td>            
        </tr>
        <tr>
            <td>
                <table width="100%">
                    <tr>
                        <td>
                            <asp:DataList ID="dl1" runat="server" Width="100%" HorizontalAlign="Left" 
                                onselectedindexchanged="dl1_SelectedIndexChanged" >
                                <HeaderTemplate>
                                    <table width="100%" border="2">
                                        <tr>
                                            <th width="10%">Sr.No.</th>
                                            <th width="90%">Question</th>
                                        </tr>
                                    </table>
                                    <table width="100%">                                    
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr align="center">
                                        <td width="10%"><input class="input" type="text" id='Srno<%# Container.ItemIndex %>' readonly="readonly" /><br /><br /></td>
                                        <td width="90%">                                        
                                            <div id='h<%# Container.ItemIndex %>' class="abc" onclick="getdata(<%# Container.ItemIndex %>)" style="display:block;" >
                                               <asp:Label ID="lbl" Text='<%#Eval ("Question") %>' runat="server"></asp:Label> 
                                            </div>
                                            <div id='d<%# Container.ItemIndex %>' class="xyz">                                               
                                               <asp:TextBox ID="tb1" TextMode="MultiLine" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
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
    </table>
</asp:Content>
