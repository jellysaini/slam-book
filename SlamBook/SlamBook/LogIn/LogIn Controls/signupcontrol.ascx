<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="signupcontrol.ascx.cs" Inherits="SlamBook.signupcontrol" %>
<table width="100%">
    <tr align="center" >
        <td width="5%"></td>
        <td width="10%"><asp:Button Width="100px" Height="40px" ID="ucsupbtn" 
                Text="Sign Up"  BackColor="DarkGray" ForeColor="LightBlue" runat="server" 
                onclick="ucsupbtn_Click" /></td>
        <td width="10%"><asp:Button Width="100px" Height="40px" ID="ucsinbtn" 
                Text="Sign In"  BackColor="DarkGray" ForeColor="LightBlue" runat="server" 
                onclick="ucsinbtn_Click" /></td>
        <td width="70%"><asp:Label ID="msglbl" Font-Size="Medium" color="DarkGray" runat="server" Text="SlamBook Website helps you connect and share with the peoples in your life." ></asp:Label></td>
        <td width="5%"></td>
    </tr>
</table>

