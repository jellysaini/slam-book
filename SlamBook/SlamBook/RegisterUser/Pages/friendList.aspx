<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="friendList.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.friendList" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../../javascripts files/jquery.js"></script>
    <script type="text/javascript" src="../../javascripts files/slider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable">
        <tr>
            <td>
                <table class="maintable">
                    <tr align="center">
                        <td width="10%"></td>
                        <td width="80%">                        
                            <table width="100%">
                                <tr><td><br /><br /></td></tr>
                                <tr align="center"><td><font class="fonttext">My Friends Details</font><hr width="30%" /></td></tr>
                                <tr>
                                    <td>    
                                        <table width="100%" border="1">
                                            <tr>
                                                <td>
                                                    <asp:DataList ID="fdl" runat="server" Width="100%" 
                                                        onitemdatabound="fdl_ItemDataBound">
                                                        <HeaderTemplate>
                                                            <table width="100%" border="1">
                                                                <tr align="center">
                                                                    <td width="10%">SNo</td>
                                                                    <td width="25%">Image</td>
                                                                    <td width="55%">Detail</td>
                                                                    <td width="10%">Status</td> 
                                                                </tr>                                                                
                                                            </table>    
                                                            <table width="100%">
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr align="center">                                                            
                                                                <td width="10%"><asp:Label ID="fserial" runat="server" Text='<%#Eval("SNo") %>'></asp:Label></td>
                                                                <td width="25%"><img alt="Not Found" src='../<%#Eval("ImageName")%>' class="imgtag" /></td>
                                                                <td width="55%">
                                                                    <div id='h<%# Container.ItemIndex %>' class="abc" onclick="getdata(<%# Container.ItemIndex %>)" style="display:block;">
                                                                        <asp:Label ID="name" Text='<%#Eval("FName") %>' runat="server"></asp:Label>
                                                                    </div>
                                                                    <div id='d<%# Container.ItemIndex %>' class="xyz">                                                               
                                                                       <font class="fonttext">Full Name :</font><asp:Label ID="fname1" Text='<%#Eval("FName") %>' runat="server"></asp:Label>&nbsp;<asp:Label ID="fname2" Text='<%#Eval("LName") %>' runat="server" ></asp:Label><br />                                                                        
                                                                       <font class="fonttext">Date of Birth : </font> <asp:Label ID="fdob" Text='<%#Eval("DOB") %>' runat="server" ></asp:Label><br />                                                                       
                                                                       <font class="fonttext">City : </font> <asp:Label ID="Label2" Text='<%#Eval("City") %>' runat="server" ></asp:Label>&nbsp;&nbsp;&nbsp;
                                                                       <font class="fonttext">State : </font> <asp:Label ID="fstate" Text='<%#Eval("State") %>' runat="server" ></asp:Label><br />
                                                                       <font class="fonttext">Country : </font> <asp:Label ID="fcountry" Text='<%#Eval("Country") %>' runat="server" ></asp:Label><br />
                                                                       <font class="fonttext">Mobile Number : </font> <asp:Label ID="fmob" Text='<%#Eval("MobNo") %>' runat="server" ></asp:Label><br />
                                                                       <font class="fonttext">Email ID : </font> <asp:Label ID="femail" Text='<%#Eval("EMail") %>' runat="server" ></asp:Label>
                                                                    </div>
                                                                    <hr width="100%" /><br />
                                                                </td>
                                                                <td width="10%">
                                                                   <asp:HiddenField ID="hdn" Value='<%#Eval("SetStatus") %>' runat="server" />
                                                                   <asp:Label ID="fststus" Text=" " runat="server"></asp:Label>
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
                        <td width="10%"></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
