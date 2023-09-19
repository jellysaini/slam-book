<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="linkBarControl.ascx.cs" Inherits="SlamBook.User_Controls.linkBarControl" %>
<style type="text/css">
.linkstyle
{
	font-size:medium;
	color:White;
	font-family:Verdana;
	text-decoration:none;	            
}
.table
{
	width:100%;
	margin:0px;
	border:0px;
	padding:0px;		
	outline:0px;
}
</style>
<table class="table">
    <tr bgcolor="Sienna" align="center">
        <td>
            <table class="table">
                <tr align="center">
                    <td width="16%"><asp:LinkButton CssClass="linkstyle" ID="mp2r1lk1" Text="Profile" runat="server" onclick="mp2r1lk1_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r1lk2" CssClass="linkstyle" Text="Friends" runat="server" onclick="mp2r1lk2_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r1lk3" CssClass="linkstyle" Text="Chit-Chat" runat="server" onclick="mp2r1lk3_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r1lk4" CssClass="linkstyle" Enabled="false" Text="Messages" runat="server" onclick="mp2r1lk4_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r1lk5" CssClass="linkstyle" Enabled="false" Text="MyStuff" runat="server" onclick="mp2r1lk5_Click"></asp:LinkButton></td>
                    <td width="16%"><asp:LinkButton ID="mp2r1lk6" CssClass="linkstyle" Text="SlamBook" runat="server" onclick="mp2r1lk6_Click"></asp:LinkButton></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="center" bgcolor="LightSlateGray">
        <td>
            <table class="table">
                <tr align="center">
                    <td width="16%"><asp:LinkButton ID="mp2r2lk1" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk1_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r2lk2" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk2_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r2lk3" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk3_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r2lk4" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk4_Click"></asp:LinkButton></td>
                    <td width="17%"><asp:LinkButton ID="mp2r2lk5" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk5_Click"></asp:LinkButton></td>
                    <td width="16%"><asp:LinkButton ID="mp2r2lk6" CssClass="linkstyle" Text=" " runat="server" onclick="mp2r2lk6_Click"></asp:LinkButton></td>
                </tr>
            </table>
            <asp:HiddenField ID="checkval" runat="server" />
        </td>
    </tr>
</table>