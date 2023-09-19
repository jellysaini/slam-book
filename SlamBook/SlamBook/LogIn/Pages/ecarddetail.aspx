<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="ecarddetail.aspx.cs" Inherits="SlamBook.LogIn.Pages.ecarddetail" Title="Untitled Page" %>
<%@ Register Src="~/LogIn/LogIn Controls/signupcontrol.ascx" TagPrefix="ucl" TagName="signupcontrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="LogInFont">
        <tr>
            <td>
                <table class="LogInFont">
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
                                                                <img src="../../App_Themes/LogIn/Images/e-card.jpg" alt="not Found"/>
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
                                                <td>
                                                    <table width="80%">
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">An e-card is similar to a postcard or greeting card, with the primary difference being that it is created using digital media instead of paper or other traditional materials. E-cards are made available by publishers usually on various Internet sites, where they can be sent to a recipient, usually via e-mail. It also considered more environmentally friendly compared to traditional paper cards. E-card businesses are considered environmentally friendly because their carbon footprint is generally much lower compared to paper card companies and because paper is not used in the end product.</font>
                                                            </td>
                                                        </tr>
                                                        <tr><td><br /></td></tr>                                                                                                                <tr align="justify">   
                                                            <td width="100%">
                                                                <font class="NormalText">E-cards are digital "content", which makes them much more versatile than traditional greeting cards. For example unlike traditional greetings, e-cards can be easily sent to many people at once or extensively personalized by the sender. Conceivably they could be saved to any computer or electronic device or even viewed on a television set, however e-card digital content has not yet progressed as far as digital video or digital audio in terms of varied usage.</font>
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
