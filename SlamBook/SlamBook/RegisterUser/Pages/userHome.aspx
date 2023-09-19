<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="userHome.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.userHome" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable">
        <tr>
            <td>
                <table width="100%">
                    <tr valign="top">
                        <td width="70%">
                            <div class="divstyle">
                                <table width="100%">
                                    <tr align="center">
                                        <td><br /><font class="fonttext">Latest Messages for you!</font><hr width="50%" /></td>
                                    </tr>
                                    <tr align="center">
                                        <td>
                                            <asp:Repeater ID="scrapRep" runat="server">
                                                <HeaderTemplate>
                                                    <table width="100%">
                                                        <tr align="center">
                                                            <td width="10%">SNo.</td>
                                                            <td width="15%">Image</td>
                                                            <td width="60%">Details</td>
                                                            <td width="15%">Day</td>
                                                        </tr>
                                                    </table>
                                                    <table width="100%">
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td width="10%"><%#Eval("SNo") %></td>
                                                        <td width="15%"><img alt="Not Found" src='../<%#Eval("ImageName") %>' height="80px" /></td>
                                                        <td width="60%">
                                                            <font class="NormalText">
                                                                Send By:&nbsp;<%#Eval("FName") %>&nbsp;<%#Eval("LName") %><br />
                                                                Msg Text:&nbsp;<%#Eval("Msg") %>
                                                            </font>
                                                        </td>
                                                        <td width="15%"><%#Eval("TotalDays") %>&nbsp;ago</td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </table>
                                                </FooterTemplate>
                                            </asp:Repeater>
                                        </td>
                                    </tr>
                                    <tr><td><br /><hr /><br /></td></tr>
                                </table>
                                <table width="100%">
                                    <tr align="center">
                                        <td><font class="fonttext">Latest Friends Request for you!</font><hr width="55%" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:DataList ID="fReqRep" Width="100%" runat="server" onitemcommand="fReqRep_ItemCommand">
                                                <HeaderTemplate>
                                                    <table width="100%">
                                                        <tr align="center">                                                            
                                                            <td width="15%">Image</td>
                                                            <td width="70%">Details</td>
                                                            <td width="15%">Days</td>
                                                        </tr>
                                                    </table>
                                                    <table width="100%">
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>                                                        
                                                        <td width="15%"><img alt="Not Found" src='../<%#Eval("ImageName") %>' height="80px" /></td>
                                                        <td width="70%">
                                                            <font class="NormalText">
                                                                Send By:&nbsp;<%#Eval("FName") %>&nbsp;<%#Eval("LName") %><br />
                                                                Msg Text:&nbsp;<%#Eval("msg") %>
                                                            </font><br />
                                                            <asp:Button CommandArgument='<%#Eval("ReqOutId") %>' CommandName="Select" ID="accReq" Text="Accept" runat="server" />
                                                            <asp:Button CommandArgument='<%#Eval("ReqOutId") %>' CommandName="Cancel" ID="denyReq" Text="Deny" runat="server" />                                                                                                                    
                                                        </td>
                                                        <td width="15%"><%#Eval("days") %>&nbsp;ago</td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </table>
                                                </FooterTemplate>
                                            </asp:DataList> 
                                        </td>
                                    </tr>
                                    <tr><td><br /><hr /><br /></td></tr>
                                </table>
                                <table width="100%">
                                    <tr align="center">
                                        <td><font class="fonttext">Latest SlamBook Request for you!</font><hr width="60%" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Repeater ID="sbReqRep" runat="server" onitemcommand="sbReqRep_ItemCommand">
                                                <HeaderTemplate>
                                                    <table width="100%">
                                                        <tr align="center">                                                            
                                                            <td width="15%">Image</td>
                                                            <td width="70%">Details</td>
                                                            <td width="15%">Date</td>
                                                        </tr>
                                                    </table>
                                                    <table width="100%">
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>                                                        
                                                        <td width="15%"><img alt="Not Found" src='../<%#Eval("ImageName") %>' height="80px" /></td>
                                                        <td width="70%">
                                                            <font class="NormalText">
                                                                Send By:&nbsp;<%#Eval("FName") %>&nbsp;<%#Eval("LName") %><br />
                                                                State Name:&nbsp;<%#Eval("State") %>&nbsp;&nbsp;Country:&nbsp;<%#Eval("country") %><br />
                                                                SlamBook Name:&nbsp;<%#Eval("slambkname") %>                                                                
                                                            </font><br />                                                            
                                                            <asp:Button ID="acSlamBKReq" CommandArgument='<%#Eval("slambkid") %>' CommandName="accept" Text="Accept" runat="server" />
                                                            <asp:Button ID="deSlamBKReq" CommandArgument='<%#Eval("slambkid") %>' CommandName="deny" Text="Deny" runat="server" />                                                                                                                    
                                                        </td>
                                                        <td width="15%"><%#Eval("days") %>&nbsp;ago</td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </table>
                                                </FooterTemplate>
                                            </asp:Repeater>
                                        </td>
                                    </tr>
                                    <tr><td><br /><hr /><br /></td></tr>
                                </table>                                
                            </div>
                        </td>
                        <td width="30%">
                            <div class="divstyle">                                                                
                                <table width="100%">
                                    <tr align="center">
                                        <td>
                                            <font class="headingtxt">Alerts Messages</font><hr />
                                        </td>
                                    </tr>
                                    <tr align="center">
                                        <td>
                                            <br /><font style=" color:Red; font-size:medium; text-decoration:blink;"><asp:Label ID="slamBK" Text="Go and Create Your SlamBook" runat="server"></asp:Label></font><br /><br />
                                        </td>
                                    </tr>
                                    <tr align="center">
                                        <td>    
                                            <br /><hr /><font class="NormalText">SlamBook Acceptance for you</font><hr /><br />                                            
                                        </td>
                                    </tr>
                                    <tr align="left">
                                        <td>
                                            <asp:Repeater ID="sbAccRep" runat="server" onitemcommand="sbAccRep_ItemCommand"> 
                                                <ItemTemplate>
                                                    <font class="alerttext">
                                                        <br /><%#Eval("FName") %>&nbsp;<%#Eval("LName") %>&nbsp;
                                                        <br />Click to Insert your Views:-&nbsp;&nbsp;<asp:LinkButton ID="edit" CommandName="new" CommandArgument='<%#Eval("slambkid") %>' Text="New/Edit" runat="server"></asp:LinkButton><br />
                                                    </font>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </td>
                                    </tr>
                                    <tr align="center">
                                        <td><br /><hr /><font class="NormalText">Latest SlamBooK Visitor</font><hr /><br /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Repeater ID="vistorRep" runat="server" 
                                                onitemcommand="vistorRep_ItemCommand">
                                                <HeaderTemplate>
                                                    <table width="100%">                                                    
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td width="70%">
                                                            <font class="NormalText"><%#Eval("fname") %>&nbsp;<%#Eval("lname") %></font><br />
                                                            <asp:HiddenField ID="fname" Value='<%#Eval("fname") %>' runat="server" />
                                                            <asp:HiddenField ID="lname" Value='<%#Eval("lname") %>' runat="server" />
                                                            Enter's a new Entery:-<asp:LinkButton CommandName="redirect" CommandArgument='<%#Eval("userid") %>' ID="goLink" runat="server" Text="SeeIt"></asp:LinkButton> 
                                                        </td>
                                                        <td width="30%"><%#Eval("days") %>&nbsp;Day&nbsp;ago</td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </table>
                                                </FooterTemplate>
                                            </asp:Repeater>
                                        </td>
                                    </tr>                                        
                                </table>                                  
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
