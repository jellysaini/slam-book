<%@ Page Language="C#" MasterPageFile="~/LogIn/Pages/MyLogInMaster.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="SlamBook.LogIn.Pages.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="ContentTableMain">
        <tr>
            <td>
                <div style="width:100%">
                    <div style="width:70%;" class="common">
                        <div class="LogInDivL">
                                <table class="ContentTableMain">
                                <tr><td><br /></td></tr>
                                <tr><td><br /></td></tr>
                                <tr align="center" >
                                    <td width="10%"></td>
                                    <td width="80%">                                    
                                        <table>
                                            <tr align="center"><td><img src="../../App_Themes/LogIn/Images/MainImg.jpg" alt="Not Found" /></td></tr>                                            
                                            <tr align="center" ><td><img src="../../App_Themes/LogIn/Images/welcome-line.jpg" alt="Not Found" /><hr width="70%" /><br /></td></tr>
                                            <tr align="center" >
                                                <td>
                                                    <table width="80%">
                                                        <tr align="justify" >
                                                            <td>
                                                                <p class="NormalText">Welcome to our <strong>Online SlamBook</strong>. Our <em>online 
											                    slambook</em> is comprised of all aged people from all over the world 
											                    coming together and sharing the gift of emotions and sentiments.&nbsp; Here are 
											                    heartwarming <strong>free online slambook</strong> for you to reach out to your 
											                    friends and let 'em know how special they are and also what they think about 
											                    you.
									                            </p>
                                                                <p class="NormalText">Its universal truth that "Friends have a great deal to do 
										                        with our' happiness and well-being. It's through friendships that we can learn 
											                    how to navigate the rough waters of our social development." So let's take a 
											                    closer look at the true value of friends and friendships through our <em>free 
											                    online slam book</em>.</p>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="10%"></td>
                                </tr>                                
                            </table>
                            </div>
                    </div>
                    <div style="width:30%;" class="common">
                        <div class="LogInDivR">
                                <table class="LogInTable ">
                                    <tr>
                                        <td>
                                            <table class="LogInInTable ">
                                                <tr align="center" ><td><font class="LogInFont ">Member LogIn</font></td></tr>
                                                <tr><td><br /></td></tr>
                                                <tr align="center" ><td><asp:TextBox CssClass="textbox" Text="User EMail-ID" ID="Emailtxt" runat="server" Onclick="if(this.value == 'User EMail-ID') {this.value=''}" onblur="if(this.value == '') {this.value='User EMail-ID'}"></asp:TextBox></td></tr>
                                                <tr><td><br /></td></tr>
                                                <tr align="center" ><td><asp:TextBox CssClass="textbox" TextMode="Password" 
                                                        ID="Passwdtxt" runat="server" > password</asp:TextBox></td></tr>
                                                <tr><td><br /></td></tr>
                                                <tr align="left"><td>&nbsp;&nbsp;&nbsp;&nbsp;<a class="linklogtxt" href="ForgetUser.aspx" ><font class="linkbtn">Forget Password?</font></a></td></tr>
                                                <tr align="right" ><td><asp:Button ID="signinbtn" Text="SignIn" runat="server" onclick="signinbtn_Click" />&nbsp;&nbsp;<asp:Button ID="cancelbtn" Text="Cancel" runat="server" onclick="cancelbtn_Click" /></td></tr>                                                
                                                <tr><td><br /></td></tr>
                                                <tr><td><hr width="100%" /></td></tr>                                                
                                                <tr>
                                                    <td>
                                                        <table class="LogInInTable">
                                                            <tr align="center" >
                                                                <td><font class="LogInFont ">Not Register Yet?</font></td>                                                    
                                                            </tr>
                                                            <tr><td><br /></td></tr>
                                                            <tr>
                                                                <td>
                                                                    <table width="100%">
                                                                        <tr align="center" >
                                                                            <td width="50%"></td>
                                                                            <td width="50%"><font class="linkbtn "><a class="linklogtxt" href="SignUp.aspx">SignUp Now</a></font></td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>    
                                        </td>
                                    </tr>                             
                                </table>                                
                            </div>
                    </div>
                </div>               
            </td>
        </tr>
        <tr><td></td></tr>
        <tr>
            <td>
                <table class="ContentTableMain ">
                    <tr align="center" >
                        <td width="5%"></td>
                        <td width="18%"><a class="linkstyle" href="chatdetails.aspx"><img alt="Not Found" src="../../App_Themes/LogIn/Images/chat.jpg" /></a></td>
                        <td width="18%"><a class="linkstyle" href="ecarddetail.aspx" ><img alt="Not Found" src="../../App_Themes/LogIn/Images/e-card.jpg" /></a></td>
                        <td width="18%"><a class="linkstyle" href="chitchatdetail.aspx"><img alt="Not Found" src="../../App_Themes/LogIn/Images/chitchat.jpg" /></a></td>
                        <td width="18%"><a class="linkstyle" href="remainderdetail.aspx" ><img alt="Not Found" src="../../App_Themes/LogIn/Images/reminder.jpg" /></a></td>
                        <td width="18%"><a class="linkstyle" href="smsdetail.aspx"><img alt="Not Found" src="../../App_Themes/LogIn/Images/sms-zone.jpg" /></a></td>
                        <td width="5%"></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr><td></td></tr>
    </table>
</asp:Content>
