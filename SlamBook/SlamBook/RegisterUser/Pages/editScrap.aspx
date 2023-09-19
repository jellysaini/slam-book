﻿<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="editScrap.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.editScrap" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../../javascripts files/jquery.js"></script>
    <script type="text/javascript" src="../../javascripts files/slider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="maintable">
        <tr>
            <td><br /><br />
                <table width="100%">
                    <tr align="center">
                        <td width="5%"></td>
                        <td width="90%">
                            <table width="100%">
                                <tr align="center">
                                    <td>
                                        <font class="fonttext">Scraps Posted by your's Friends</font><hr width="50%" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DataList ID="scrapDList" runat="server" Width="100%" DataKeyField="UserId" 
                                            onitemdatabound="scrapDList_ItemDataBound" 
                                            onitemcommand="scrapDList_ItemCommand" >
                                            <HeaderStyle BackColor="#E6E6E6" Font-Size="Medium" BorderWidth="1" ForeColor="Highlight" />
                                            <HeaderTemplate>
                                                <table width="100%">
                                                    <tr align="center">
                                                        <td width="5%">SNo.</td>
                                                        <td width="10%">Image</td>
                                                        <td width="60%">Sender Detail</td>
                                                        <td width="10%">Delete</td>
                                                        <td width="15%">Days</td>                                                        
                                                    </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr align="center">
                                                    <td width="5%"><%#Eval("SNo") %></td>
                                                    <td width="10%"><img alt="Not Found" src='../<%#Eval("ImageName") %>' width="100px"/></td>
                                                    <td width="60%">
                                                        <div id='h<%# Container.ItemIndex %>' class="abc" onclick="getdata(<%# Container.ItemIndex %>)"  style="display:block;"  >
                                                            <font class="NormalText">Name&nbsp;:-&nbsp;</font> <%#Eval("FName")  %>&nbsp;<%#Eval("LName") %> &nbsp;&nbsp;&nbsp;&nbsp;
                                                            <font class="NormalText">Sent Date&nbsp;:-&nbsp;</font> <%#Eval("Date")%>
                                                        </div>
                                                        <div id='d<%# Container.ItemIndex %>' class="xyz">
                                                            <table width="100%">
                                                                <tr>
                                                                    <td><font class="NormalText">Deliver Message:-</font></td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label1" Width="70%" Text='<%#Eval("Msg") %>' runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>                                                   
                                                        </div>
                                                        <hr width="100%" /><br /> 
                                                    </td>
                                                    <td width="10%">
                                                        <asp:LinkButton ID="delete" runat="server" Font-Underline="false" CommandName="dalete" CommandArgument='<%#Eval("id") %>' Text="Delete"></asp:LinkButton>
                                                    </td>
                                                    <td width="15%">
                                                        <asp:Label ID="slamDate" Text=" " runat="server"></asp:Label>
                                                        <asp:HiddenField ID="scrapHdn" Value='<%#Eval("TotalDays") %>' runat="server" /> 
                                                    </td>
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
                                                <td width="15%"></td>
                                                <td width="14%"><asp:LinkButton ID="first" Text="First" runat="server" onclick="first_Click" ></asp:LinkButton></td>
                                                <td width="14%"><asp:LinkButton ID="prev" Text="Previous" runat="server" onclick="prev_Click" ></asp:LinkButton></td>
                                                <td width="14%"><asp:Label ID="pno" Text=" " runat="server"></asp:Label></td>
                                                <td width="14%"><asp:LinkButton ID="next" Text="Next" runat="server" onclick="next_Click" ></asp:LinkButton></td>
                                                <td width="14%"><asp:LinkButton ID="last" Text="Last" runat="server" onclick="last_Click" ></asp:LinkButton></td>
                                                <td width="15%"></td>
                                            </tr>                                            
                                        </table>
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
</asp:Content>
