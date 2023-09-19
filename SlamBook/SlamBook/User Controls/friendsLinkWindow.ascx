<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="friendsLinkWindow.ascx.cs" Inherits="SlamBook.User_Controls.friendsLinkWindow" %>
<div style="border:solid 1px gray; float:left; position:relative; width:100%; margin:0px;">
    <table width="100%" bgcolor="MistyRose">
        <tr>
            <td>
                <table width="100%">
                    <tr align="center">
                        <td>
                            <table width="70%">
                                <tr><td></td></tr>
                                <tr align="center" ><td><asp:Image BorderWidth="3" BorderColor="Gray" ImageUrl=" " ID="myimg" runat="server" Width="125px" Height="125px" /></td></tr>
                                <tr><td></td></tr>
                            </table>
                        </td>
                    </tr>
                    <tr align="center"><td><font style="font-size:medium; color:Maroon;">My Image</font></td></tr>
                </table>
            </td>
        </tr>
        <tr><td><br /><br /></td></tr>
        <tr align="center"><td><font style="font-size:medium; color:Green;">Friends Window</font></td></tr>
        <tr align="center">
            <td>
                <table width="100%">
                    <tr align="center">
                        <td width="33%"><font style="font-size:medium; color:Gray;">Total  </font></td>
                        <td width="33%"><font style="font-size:medium; color:Gray;">Friends : - </font></td>
                        <td width="34%"><asp:Label ID="fclbl" runat="server" Text=" "></asp:Label></td>
                    </tr>
                    <tr align="center" valign="middle" >                              
                        <td width="33%"><img src="../../App_Themes/RegisterUser/Images/red.JPG" height="20px" alt="Not Found" /></td>
                        <td width="33%"><img src="../../App_Themes/RegisterUser/Images/yellow.JPG" height="20px" alt="Not Found" /></td>
                        <td width="34%"><img src="../../App_Themes/RegisterUser/Images/green.JPG" height="20px" alt="Not Found" /></td>
                    </tr>
                    <tr align="center" valign="middle" >        
                        <td width="33%"> OffLine </td>
                        <td width="33%"> Busy </td>
                        <td width="34%"> Available</td>
                    </tr>        
                </table>
            </td>
        </tr>
        <tr align="center">
            <td>
                <div style=" border:solid 1px gray; float:left; position:relative; width:100%; margin:0px;">
                    <asp:DataList ID="flDL" runat="server" RepeatColumns="3" CellPadding ="0" 
                        CellSpacing="0" GridLines="None" Width ="0" 
                        onitemdatabound="flDL_ItemDataBound" RepeatDirection="Horizontal" >
                        <ItemTemplate>
                            <table cellpadding="0" cellspacing="0" border="0">
                                <tr align="center">
                                    <td><asp:Image ID="simg" runat="server" ImageUrl=" " Height="10px" Width="10px" />&nbsp;:&nbsp;<font>Status</font>
                                        <asp:HiddenField ID="hdnfrstatus" Value='<%#Eval("SetStatus") %>' runat="server" />
                                    </td>
                                </tr>
                                <tr align="center">
                                    <td><a style="text-decoration:none;" href="../LogIn/Pages/LogIn.aspx"><img src='../<%#Eval("ImageName") %>' width="60px" height="70px" alt="Not Found" /></a></td>
                                </tr>
                                <tr align="center">
                                    <td><%#Eval("FName")%></td>
                                </tr>
                            </table>                            
                        </ItemTemplate>
                    </asp:DataList>              
                </div>
            </td>
        </tr>
        <tr align="center">
            <td>
                <table width="100%">
                    <tr align="center">
                        <td width="5%"></td>
                        <td width="10%"><asp:LinkButton ID="First" Text="<<" Font-Size="Large" 
                                Font-Overline="false" ForeColor="Black" runat="server" onclick="First_Click"></asp:LinkButton></td>
                        <td width="10%"><asp:LinkButton ID="Previous" Text="<" Font-Size="Large" 
                                Font-Overline="false" ForeColor="Black" runat="server" onclick="Previous_Click"></asp:LinkButton></td>
                        <td width="50%"></td>
                        <td width="10%"><asp:LinkButton ID="Next" Text=">" Font-Size="Large" 
                                Font-Overline="false" ForeColor="Black" runat="server" onclick="Next_Click"></asp:LinkButton></td>
                        <td width="10%"><asp:LinkButton ID="Last" Text=">>" Font-Size="Large" 
                                Font-Overline="false" ForeColor="Black" runat="server" onclick="Last_Click"></asp:LinkButton></td>
                        <td width="5%"></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr><td><br /><br /><br /></td></tr>
    </table>
</div>