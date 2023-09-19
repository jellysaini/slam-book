<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="usersSlamBook.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.newSlamBook" Title="Untitled Page" %>
<%@ Register src="~/User Controls/questionTable.ascx" tagname="questionTable" tagprefix="uc1" %>
<%@ Register src="~/User Controls/slamBKInfo.ascx" tagname="slamBKInfo" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="maintable">
        <tr>
            <td>
                <table class="maintable">
                    <tr>
                        <td>                            
                            <uc2:slamBKInfo ID="slamBKInfo1" runat="server" />                            
                        </td>
                    </tr>                    
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="5%"></td>
                                    <td width="90%">
                                        <table width="100%">
                                            <tr align="left">
                                                <td width="30%"><font class="fonttext">Name of Slam Book</font></td>
                                                <td width="5%"><font class="fonttext">: - </font></td>
                                                <td width="45%"><asp:TextBox ID="sbnametb" CssClass="textbox" runat="server" ></asp:TextBox></td>
                                                <td width="20%"></td>
                                            </tr>
                                            <tr><td><br /></td></tr>
                                            <tr align="left">
                                                <td width="30%"><font class="fonttext">Title Message</font></td>
                                                <td width="5%"><font class="fonttext">: - </font></td>
                                                <td width="45%"><asp:TextBox ID="sbtitletb" CssClass="textbox" runat="server" ></asp:TextBox></td>
                                                <td width="20%">
                                                    <table width="100%">
                                                        <tr align="center">
                                                            <td>
                                                                <asp:LinkButton ID="edit1" Text="Edit" Visible="false" Font-Underline="false" 
                                                                    runat="server" onclick="edit1_Click" ></asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr><td><br /></td></tr>
                                            <tr align="left">
                                                <td width="30%"><font class="fonttext">Select Slam Book Image</font></td>
                                                <td width="5%"><font class="fonttext">: - </font></td>
                                                <td width="45%"><asp:DropDownList ID="ddselectimg" CssClass="textbox" 
                                                        runat="server" onselectedindexchanged="ddselectimg_SelectedIndexChanged" ></asp:DropDownList></td>
                                                <td width="20%"></td>
                                            </tr>                                            
                                            <tr><td><br /></td></tr>                                                    
                                        </table>
                                    </td>
                                    <td width="5%"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr align="right">
                                    <td width="32%"></td>
                                    <td width="20%"><asp:Button ID="save" Text="Save" runat="server" Width="60%" 
                                            onclick="save_Click" /></td>
                                    <td width="17%"><asp:Button ID="cancel" Text="Cancel" Width="60%" runat="server" /></td>
                                    <td width="31%"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr><td><hr /><br /></td></tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="5%"></td>
                                    <td width="70%">
                                        <font class="fonttext">
                                            <asp:Label ID="queslbl" Text="Create" runat="server"></asp:Label>&nbsp; Question List for Slam Book...                                                                                          
                                        </font>
                                    </td>
                                    <td width="20%"><asp:LinkButton ID="clikhere" Text="Click Here" 
                                            Font-Underline="false" runat="server" onclick="clikhere_Click" ></asp:LinkButton></td>
                                    <td width="5%"></td>
                                </tr>
                            </table>
                        </td>                        
                    </tr>
                    <tr>
                        <td>
                            <uc1:questionTable ID="questionTable1" runat="server" Visible="false" />
                        </td>
                    </tr>             
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
