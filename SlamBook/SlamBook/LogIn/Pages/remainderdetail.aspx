<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="remainderdetail.aspx.cs" Inherits="SlamBook.LogIn.Pages.remainderdetail" Title="Untitled Page" %>
<%@ Register Src="~/LogIn/LogIn Controls/signupcontrol.ascx" TagPrefix="ucl" TagName="signupcontrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MasterTableMain">
        <tr>
            <td>
                <table class="MasterTableMain ">
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td width="12%"></td>
                                    <td width="76%"><ucl:signupcontrol ID="signupcontrol" runat="server" /></td>
                                    <td width="12%"></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr valign="top" >
                                    <td width="25%">
                                        <table width="100%">
                                            <tr><td><br /><br /><br /></td></tr>
                                            <tr align="center">
                                                <td>
                                                    <table width="50%">
                                                        <tr>
                                                            <td width="100%">
                                                                <img src="../../App_Themes/LogIn/Images/reminder.jpg"alt="not Found"/>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>                                                
                                            </tr>                                            
                                        </table>
                                    </td>
                                    <td width="60%">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                
                                        <table width="100%">
                                            <tr><td><br /></td></tr>
                                            <tr><td><br /></td></tr>
                                            <tr align="center" >                                            
                                                <td width="100%">
                                                    <table width="80%">
                                                        <tr>   
                                                            <td width="100%"><font class="LogInFont">Online E-Card</font></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr align="center" >
                                                <td width="100%">
                                                    <table width="80%">
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">Reminder - a message that helps you remember something; "he ignored his wife's reminders" subject matter, content, message, substance - what a communication that is about something is about phylactery, tefillin - (Judaism) either of two small leather cases containing texts from the Hebrew Scriptures (known collectively as tefillin); traditionally worn (on the forehead and the left arm) by Jewish men during morning prayer</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">Reminder - an experience that causes you to remember something</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>  
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr><td><br /></td></tr>  
                                        </table>
                                        </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="15%">6</td>
                                </tr>
                                <tr><td><br /></td></tr>  
                            </table>
                        </td>
                    </tr>
                </table>
             </td>
         </tr>
     </table>
</asp:Content>
