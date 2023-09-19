<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="confirmlogin.aspx.cs" Inherits="SlamBook.LogIn.Pages.confirmlogin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" bgcolor="white" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td width="100%">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td width="100%">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td width="100%"><br /><br /><br /></td>                                    
                                </tr>
                                <tr>
                                    <td width="100%">
                                        <table width="100%">
                                            <tr>
                                                <td width="15%"></td>
                                                <td width="70%"><font class="headingtext ">Welcome User</font><br /><br /></td>
                                                <td width="15%"></td>
                                            </tr>
                                            <tr align="justify">
                                                <td width="15%"></td>
                                                <td width="70%">
                                                    <p class="NormalText">
                                                        Welcome to OnlineSlamBook.com. Online Slambook is comprised of all aged people
                                                        from all over the world coming together and sharing the gift of
                                                        emotions . Here are heartwarming free online slambook for you to reach
                                                        out to your friends and let 'em know how special they are and also what
                                                        they think about you. 
                                                    </p>
                                                    <p class="NormalText">
                                                        Its universal truth that "Friends have a great deal to do with our'
                                                        happiness and well-being. It's through friendships that we can learn
                                                        how to navigate the rough waters of our social development." So let's
                                                        take a closer look at the true value of friends and friendships through
                                                        our free online slam book.
                                                    </p>
                                                    <p class="NormalText">
                                                        OnlineSlambook.com provides unique web based application that allows young adults to
                                                        enhance their Customized Webpage, communicate with friends and meet new
                                                        people online. 
                                                    </p>
                                                    <p class="NormalText">
                                                        Here, we can exchange our emotions and sentiments by this online community.
                                                        It is not merely a slam book, but like a "Bridge" which merges the
                                                        distance between two people's heart and soul.
                                                    </p>                                                    
                                                    <p class="NormalText">Thanks for being a part of OnlineSlambook.</p>
                                                    <p class="NormalText">&nbsp;</p>
                                                </td>
                                                <td width="15%"></td>                                            
                                            </tr>
                                        </table>
                                    </td>                                   
                                </tr>
                                <tr>
                                    <td width="100%">
                                        <table width="100%">
                                        <tr>
                                            <td width="15%"></td>
                                            <td width="40%">
                                                <p><font class="headingtext ">Tasks to do :-- </font></p>
                                                <ul>
                                                    <li class="NormalText">Create a Slambook.</li>
                                                    <li class="NormalText">Invite Buddy.</li>
                                                    <li class="NormalText">Create Profile.</li>
                                                    <li class="NormalText">Create Album.</li>
                                                    <li class="NormalText">Search Buddies.</li>
                                                    <li class="NormalText">Set Alerts.</li>
                                                    <li class="NormalText">Chitchat zone.</li>
                                                    <li class="NormalText">Send Messages.</li>
                                                </ul>
                                            </td>
                                            <td width="30%"><img alt="Not Found" src="../../App_Themes/LogIn/Images/Kids.gif" /></td>
                                            <td width="15%"></td>
                                        </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>    
                        </td>
                    </tr>
                    <tr align="center" >
                        <td><h2><font color="#ff6600"><asp:LinkButton ID="lnkbtn" runat="server" 
                                Text="Goto Your Mail Account to Confirm" onclick="lnkbtn_Click"></asp:LinkButton></font></h2>
                        </td>
                    </tr>
                    <tr><td><br />&nbsp;</td></tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
