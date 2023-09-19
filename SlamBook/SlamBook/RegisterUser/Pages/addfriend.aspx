<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="addfriend.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.addfriend" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable">
        <tr>
            <td>
                <table class="maintable">
                    <tr>
                        <td width="10%"></td>
                        <td width="80%">
                            <br /><font class="fonttext">Add New Friends to Make Your Contact Circle Larger.</font><br /><br />                            
                            <table width="100%">
                                <tr align="left">
                                    <td width="40%"><font class="headtext">Click for Search Contacts as</font></td>
                                    <td width="5%"><font class="headtext"> : -</font></td>
                                    <td width="15%"><asp:LinkButton ID="byname" Text="By Name" runat="server" 
                                            onclick="byname_Click"></asp:LinkButton></td>
                                    <td width="15%"><asp:LinkButton ID="bystate" Text="By State" runat="server" 
                                            onclick="bystate_Click"></asp:LinkButton></td>
                                    <td width="15%"><asp:LinkButton ID="bycountry" Text="By Country" runat="server" 
                                            onclick="bycountry_Click"></asp:LinkButton></td>
                                    <td width="10%"></td>
                                </tr>
                            </table><br />
                            <table width="100%">
                                <tr>
                                    <td width="5%"></td>
                                    <td width="30%"><asp:Label ID="searchlbl" Text="Enter Name for Searching" runat="server"></asp:Label></td>
                                    <td width="30%"><asp:TextBox ID="searchtb" Text=" " runat="server" Width="100%"></asp:TextBox></td>
                                    <td width="15%"><asp:Button ID="searchbtn" Text="Search" Enabled="false" runat="server" Width="90%" onclick="searchbtn_Click" /></td>
                                    <td width="15%"><asp:Button ID="cancelbtn" Text="Cancel" runat="server" Enabled="false" Width="90%" /></td>
                                    <td width="5%"></td>
                                </tr>
                            </table><br />
                            <table width="100%">
                                <tr align="center">
                                    <td>
                                        <asp:GridView RowStyle-HorizontalAlign="Center" ID="grdview" runat="server" AutoGenerateColumns="false" Width="100%" >
                                        <HeaderStyle BackColor="LightGray" Font-Size="Medium" Font-Bold="false" ForeColor="Brown" />
                                            <Columns>
                                                <asp:BoundField HeaderText="SNo" DataField="SNo" />                                                
                                                <asp:TemplateField HeaderText="Image">
                                                    <ItemTemplate>
                                                        <img alt="not foung" src='../<%#Eval("ImageName") %>' width="100px" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Name and another Detail of Person">
                                                    <ItemTemplate>
                                                        <table width="100%">
                                                            <tr align="left">
                                                                <td><font class="NormalText">Name : - </font>&nbsp;<%#Eval("Fname" )%>&nbsp;&nbsp;<%#Eval("LName") %></td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td><font class="NormalText">Sex : - </font>&nbsp;<%#Eval("Sex") %> &nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <font class="NormalText">Age : - </font>&nbsp;<%#Eval("Age") %></td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td><font class="NormalText">State : - </font>&nbsp;<%#Eval("State") %></td>
                                                            </tr>
                                                            <tr align="left">
                                                                <td><font class="NormalText">Country : - </font>&nbsp;<%#Eval("Country") %></td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Choose">
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="grdchk" runat="server" />
                                                        <asp:HiddenField ID="searchid" Value='<%#Eval("UserId") %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                                                                                                               
                                            </Columns>                                                                                       
                                        </asp:GridView>
                                        <asp:Label ID="searchmsg" Text=" " runat="server"></asp:Label>                                        
                                    </td>
                                </tr>                                
                            </table><br />
                            <div id="msgarea" runat="server" visible="false">
                                <table width="100%">
                                    <tr align="center">
                                        <td width="5%"></td>
                                        <td width="20%"><font class="fonttext">Message Text</font></td>
                                        <td width="45%"><asp:TextBox ID="msgtxt" TextMode="MultiLine" Text="Hi add me as friend." runat="server" Width="100%"></asp:TextBox></td>
                                        <td width="5%"></td>
                                        <td width="10%"><asp:Button ID="msgabtn" Text="Add" runat="server" Width="90%" 
                                                onclick="msgabtn_Click" /></td>
                                        <td width="10%"><asp:Button ID="msgcbtn" Text="Cancel" runat="server" Width="90%" /></td>
                                        <td width="5%"></td>
                                    </tr>
                                </table><br />
                            </div>                      
                        </td>
                        <td width="10%"></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
