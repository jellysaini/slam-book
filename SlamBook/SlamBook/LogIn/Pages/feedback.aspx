<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="SlamBook.LogIn.Pages.feedback" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MasterTableMain">
        <tr><td><br /></td></tr>
        <tr><td><br /></td></tr>
        <tr>        
            <td>
                <table width="100%">
                    <tr align="center" valign ="top">
                        <td width="70%">
                            <table width="100%">
                                <tr align="right">
                                    <td width="30%"><font class="LogInFont">Feedback</font></td>
                                    <td width="70%"><font class="normalFont">All fields marked with * are mandatory.</font></td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"><table width="100%"><tr align="right" ><td><font class="NormalText">Name*</font></td></tr></table></td>
                                    <td width="70%"><asp:TextBox ID="fnametxt" runat="server" CssClass="textbox"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fnametxt" 
                                            ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"><table width="100%"><tr align="right" ><td><font class="NormalText">Address*</font></td></tr></table></td>
                                    <td width="70%"><asp:TextBox ID="adresstxt" runat="server" CssClass="textbox "></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="adresstxt"
                                            ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"><table width="100%"><tr align="right" ><td><font class="NormalText">Email*</font></td></tr></table></td>
                                    <td width="70%"><asp:TextBox ID="emailtxt" runat="server" CssClass="textbox "></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailtxt" 
                                            ErrorMessage="*"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ErrorMessage="*" ControlToValidate="emailtxt" 
                                            ToolTip="Enter Valid Email Id" 
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"><table width="100%"><tr align="right" ><td><font class="LogInFont">Rate Our Website*</font></td></tr></table></td>
                                    <td width="70%"></td>
                                </tr>                                
                                <tr align="right">
                                    <td width="30%"></td>
                                    <td width="70%">
                                        <table width="100%">
                                            <tr>
                                                <td align="justify" >
                                                    <font class="NormalText">&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:RadioButtonList ID="rank" Width="100%" RepeatDirection="Horizontal" runat="server">
                                                            <asp:ListItem id="e" Selected="True" Enabled="true" Value="Excellent" runat="server"></asp:ListItem>                                                            
                                                            <asp:ListItem id="v" Value="Very Good" runat="server"></asp:ListItem>
                                                            <asp:ListItem id="g" Value="Good" runat="server"></asp:ListItem>
                                                            <asp:ListItem id="a" Value="Average" runat="server"></asp:ListItem>
                                                            <asp:ListItem id="b" Value="Bad" runat="server"></asp:ListItem>
                                                        </asp:RadioButtonList>
                                                    </font>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"><table width="100%"><tr align="right" ><td><font class="NormalText">Suggestions*</font></td></tr></table></td>
                                    <td width="70%"><asp:TextBox ID="suggestionstxt" TextMode="MultiLine" runat="server" Width="80%" Height="80px" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="suggestionstxt"
                                            ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                                <tr align="center">
                                    <td width="30%"></td>
                                    <td width="70%">
                                        <table width="100%">
                                            <tr align="left" >
                                                <td width="8%"></td>
                                                <td width="32%"><asp:Button ID="emailbtn" Text="Send" BackColor="Gray" ForeColor="White" Width="100%" runat="server" onclick="emailbtn_Click"  /></td>
                                                <td width="60%"><asp:Label ID="result" Text=" " runat="server"></asp:Label></td>
                                            </tr>
                                         </table>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>
                            </table>
                        </td>
                        <td width="30%"><img alt="Not Found" src="../../App_Themes/LogIn/Images/slambook.jpg" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
