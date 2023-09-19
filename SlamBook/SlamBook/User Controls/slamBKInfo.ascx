<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="slamBKInfo.ascx.cs" Inherits="SlamBook.User_Controls.slamBKInfo" %>
<style type="text/css" >
    font.headtext
    {
	    font-family:Verdana;
	    color:Olive;
	    font-weight:bold;	
    } 
    font.fonttext
    {
	    font-family:Verdana;
	    color:Gray;
	    font-weight:bold;
    }
</style>
<table width="100%">
    <tr>
        <td>
            <table width="100%" >
                <tr align="center" >
                    <td width="80%">
                        <table width="100%">
                            <tr align="left">
                                <td width="5%"></td>
                                <td width="35%"><font class="headtext">Slam Book Name</font></td>
                                <td width="10%"><font class="headtext"> : - </font></td>
                                <td width="45%"><font class="fonttext"><asp:Label ID="sbname" Text=" " runat="server" ></asp:Label></font></td>
                                <td width="5%"></td>
                            </tr>
                            <tr><td><br /></td></tr>
                            <tr align="left">
                                <td width="5%"></td>
                                <td width="35%"><font class="headtext">Title Message</font></td>
                                <td width="10%"><font class="headtext"> : - </font></td>
                                <td width="45%"><font class="fonttext"><asp:Label ID="sbtitle" Text=" " runat="server" ></asp:Label></font></td>
                                <td width="5%"></td>
                            </tr>                                            
                        </table>
                    </td>
                    <td width="20%">
                        <table width="100%">
                            <tr align="center"><td><asp:Image ID="SlamImage" ImageUrl="" runat="server" Width="100px" Height="130px" BorderColor="Gray" BorderWidth="2" /></td></tr>
                            <tr align="center"><td><font class="fonttext"><asp:Label ID="sbUserName" text="My Slam Book" runat="server"></asp:Label></font></td></tr>
                        </table>
                    </td>
                </tr>    
            </table>
        </td>
    </tr>
    <tr><td><hr /></td></tr>
</table>