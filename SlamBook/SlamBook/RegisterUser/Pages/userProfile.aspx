<%@ Page Language="C#" MasterPageFile="~/RegisterUser/Pages/RegisterUser.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="SlamBook.RegisterUser.Pages.userProfile" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script runat="server">
    protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
    {
        multiTabs.ActiveViewIndex = Int32.Parse(menuTabs.SelectedValue);
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">         
    <div class="divstyle">    
        <asp:Menu id="menuTabs" CssClass="menuTabs" StaticMenuItemStyle-CssClass="tab" StaticSelectedStyle-CssClass="selectedTab" Orientation="Horizontal" OnMenuItemClick="menuTabs_MenuItemClick" Runat="server">
            <Items>
                <asp:MenuItem Text="Personal Detail" Value="0" Selected="true" />
                <asp:MenuItem Text="Social Detail" Value="1"/>
                <asp:MenuItem Text="Professional Details" Value="2" />
                <asp:MenuItem Text="Contact Details" Value="3" />
            </Items>
        </asp:Menu>    
        <div class="tabBody">
            <asp:MultiView id="multiTabs" ActiveViewIndex="0" Runat="server">
                <asp:View ID="view1" runat="server">
                    <table class="maintable">
                        <tr align="left">
                            <td width="10%"></td>
                            <td width="80%"><br /><font class="headingtxt">Details</font><br /></td>
                            <td width="10%"></td>
                        </tr>
                        <tr>
                            <td width="10%"></td>
                            <td width="80%">
                                <div class="divstyle">
                                    <table class="maintable">
                                        <tr align="right" >
                                            <td width="25%"><font class="fonttext">First Name : - </font></td>
                                            <td width="25%"><asp:TextBox ID="FName" Text=" " runat="server" ReadOnly ="true" ></asp:TextBox></td>
                                            <td width="25%"><font class="fonttext">Last Name : - </font></td>
                                            <td width="25%"><asp:TextBox ID="LName" Text=" " runat="server" ReadOnly ="true" ></asp:TextBox></td>
                                        </tr>
                                        <tr align="right" >
                                            <td width="25%"><font class="fonttext">Date of Birth : - </font></td>
                                            <td width="25%"><asp:TextBox ID="dob" Text=" " runat="server" ReadOnly ="true" ></asp:TextBox></td>
                                            <td width="25%"><font class="fonttext">Sex : - </font></td>
                                            <td width="25%"><asp:TextBox ID="sex" Text=" " runat="server" ReadOnly ="true" ></asp:TextBox></td>     
                                        </tr>
                                    </table>                
                                </div>                
                            </td>                            
                        </tr>
                    </table> 
                    <table class="maintable">
                        <tr>
                            <td width="10%"></td>
                            <td width="80%">
                                <table class="maintable">
                                    <tr align="left">
                                        <td width="50%"><font class="headingtxt">Image Details</font></td>
                                        <td width="50%"></td>
                                    </tr>
                                    <tr>
                                        <td width="50%"><br /><font class="fonttext">Upload Your Image : - </font><br /><br /></td>
                                        <td width="50%"><br /><asp:FileUpload ID="imgUp" runat="server" />&nbsp;<asp:Button ID="imgUpBtn" Text="Upload" runat="server" onclick="imgUpBtn_Click" /> 
                                        <br /><asp:Label  ID="upmsg" runat="server" Text=" "></asp:Label><br /></td>
                                    </tr>
                                    <tr align="left">
                                        <td><br /><font class="headingtxt">Looks Details</font><br /></td>
                                    </tr>
                                </table>
                                <div class="divstyle">
                                    <table class="maintable">
                                    <tr align="center" >
                                        <td width="10%"></td>
                                        <td width="80%">
                                            <table class="maintable">
                                                <tr><td><br /><br /></td></tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Height : - </font> </td>
                                                    <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="httxt" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Hair Color : - </font></td>
                                                    <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="haircol" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Body Art : - </font></td>
                                                    <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="bart" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Looks : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="Looks" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Feature About Me : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="feaboutme" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">First Notice My : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="thing" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Five Things abut Me : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="five" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Looking for Quality : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="lookfor" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Ideal Match : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="match" runat="server" ReadOnly="true" ></asp:TextBox></td>                                                    
                                                </tr>
                                            </table>
                                        </td>
                                        <td width="10%">
                                            <asp:LinkButton ID="edit1" runat="server" Text="Edit" onclick="edit1_Click"></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr><td><br /></td></tr>
                                </table>
                                </div>
                                <table width="100%">
                                    <tr align="right" >
                                        <td>
                                            <asp:Button ID="save1" Text="Save Changes" runat="server" 
                                                onclick="save1_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="cancel1" Text="Cancel" runat="server" onclick="cancel1_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="10%"></td>
                        </tr>
                        <tr><td><br /><br /></td></tr>
                    </table>                    
                </asp:View>
                <asp:View ID="view2" runat="server">
                    <table class="maintable" >
                    <tr align="left"><td><br /><br /><font class="headingtxt">Detail</font></td></tr>
                        <tr>
                            <td>
                                <div class="divstyle" >
                                    <table class="maintable">
                                        <tr align="center" >
                                            <td width="15%"></td>
                                            <td width="70%"><br />
                                                <table class="maintable">
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Relation Status : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="reltxt" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">First Language : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Flan" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Second Language : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Slan" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Thirld Language : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Tlan" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>         
                                                    <tr><td><br /></td></tr>                                           
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Religion : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="religion" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Home Town : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="hometxt" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>                                                    
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Lines about Me : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="linesaboutme" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Smoking : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Smoking" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Drinking : - </font></td>
                                                        <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Drinking" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr><td><br /></td></tr>                                                    
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Supports : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="supp" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Books : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="Books" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Music : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="music" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>                                                    
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Television Shows : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="tvshow" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Movies : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="movies" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>
                                                    <tr align="left" >
                                                        <td width="50%"><font class="fonttext">Cuision : - </font></td>
                                                        <td width="50%"><asp:TextBox TextMode="MultiLine" CssClass="textboxstyle" ID="cuision" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                    </tr>                   
                                                    <tr><td><br /></td></tr>                                                                                   
                                                </table>
                                            </td>
                                            <td width="15%">
                                                <asp:LinkButton ID="edit2" runat="server" Text="Edit" onclick="edit2_Click"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <table width="100%">
                                    <tr align="right" >
                                        <td>
                                            <asp:Button ID="save2" Text="Save Changes" runat="server" 
                                                onclick="save2_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="cancel2" Text="Cancel" runat="server" onclick="cancel2_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr><td><br /><br /></td></tr>
                    </table>   
                </asp:View>
                <asp:View ID="view3" runat="server">
                    <table class="maintable">
                    <tr align="left"><td><br /><br /></td></tr>
                        <tr>
                            <td>
                                <table class="maintable">
                                    <tr align="left">
                                        <td width="15%"></td>
                                        <td width="70%"><font class="headingtxt">Detail</font></td>
                                        <td width="15%"></td>
                                    </tr>
                                    <tr align="center" >
                                        <td width="15%"></td>
                                        <td width="70%">
                                            <div class="divstyle">
                                                <table class="maintable">
                                                <tr><td><br /></td></tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Education Level : - </font></td>
                                                    <td width="50%"><asp:TextBox  CssClass="textboxstyle" ID="edu" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">High School : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="HighSch" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">College / University : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="college" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr><td><br /></td></tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Occupation : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="occupa" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Skill : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" ID="skill" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Intrest : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" ID="intrest" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr><td><br /></td></tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Job Designation : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" ID="jobdes" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Industry : - </font></td>
                                                    <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="Industry" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Industry Name : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="indname" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Industry Address : - </font></td>
                                                    <td width="50%"><asp:TextBox TextMode="MultiLine" ID="indadd" runat="server" CssClass="textboxstyle" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Job Phone Number : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="jobphone" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr align="left" >
                                                    <td width="50%"><font class="fonttext">Job EMail : - </font></td>
                                                    <td width="50%"><asp:TextBox ID="jobEmail" CssClass="textboxstyle" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                </tr>
                                                <tr><td><br /></td></tr>
                                            </table>
                                            </div>
                                            <table width="100%">
                                    <tr align="right" >
                                        <td>
                                            <asp:Button ID="save3" Text="Save Changes" runat="server" 
                                                onclick="save3_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="cancel3" Text="Cancel" runat="server" onclick="cancel3_Click" />
                                        </td>
                                    </tr>
                                </table>
                                        </td>
                                        <td width="15%"><asp:LinkButton ID="edit3" runat="server" Text="Edit" 
                                                onclick="edit3_Click"></asp:LinkButton></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr><td><br /><br /></td></tr>
                    </table>
                </asp:View>
                <asp:View ID="view4" runat="server">
                    <table class="maintable">
                        <tr align="left"><td><br /><font class="headingtxt">Detail</font></td></tr>
                        <tr>
                            <td>
                                <div class="divstyle">
                                    <table class="maintable">
                                        <tr><td><br /><br /></td></tr>
                                        <tr>
                                            <td width="15%"></td>
                                                <td width="70%">
                                                    <table class="maintable">
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">E-Mail : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="email" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">Address : - </font></td>
                                                            <td width="50%"><asp:TextBox  CssClass="textboxstyle" TextMode="MultiLine" ID="address" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">City : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="city" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">State : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="state" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">Country : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="country" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">PinCode : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="pincode" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">Telephone Number : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="telno" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                        <tr align="left" >
                                                            <td width="50%"><font class="fonttext">Mobile Number : - </font></td>
                                                            <td width="50%"><asp:TextBox CssClass="textboxstyle" ID="mobno" runat="server" ReadOnly="true" ></asp:TextBox></td>
                                                        </tr>
                                                    </table>            
                                                </td>
                                            <td width="15%">
                                                <asp:LinkButton ID="edit4" runat="server" Text="Edit" onclick="edit4_Click"></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr><td><br /><br /></td></tr>
                                    </table>
                                </div>
                                <table width="100%">
                                    <tr align="right" >
                                        <td>
                                            <asp:Button ID="save4" Text="Update Changes" runat="server" 
                                                onclick="save4_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="cancel4" Text="Cancel" runat="server" onclick="cancel4_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr><td><br /></td></tr>
                    </table> 
                </asp:View>
            </asp:MultiView>    
        </div>    
    </div>
</asp:Content>