<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="questionTable.ascx.cs" Inherits="SlamBook.User_Controls.questionTable" %>
<style type="text/css" >
    .div
    {
    	border: solid 1px gray;
    }
    .textbox
    {
    	width:90%;
    	font-family:Verdana;
    }    
    .button
    {
        width:80%;
    }
</style>
<table width="100%">
    <tr align="center">
        <td width="5%"></td>
        <td width="80%">
            <table width="100%">
                <tr>
                    <td>
                        <div style="border: solid 1px gray;">
                            <asp:GridView ID="questionGrid" runat="server" AutoGenerateColumns="false" Width="100%" Visible="true" >
                            <HeaderStyle BackColor="ControlLight" BorderStyle="Solid" BorderColor="Gray" Font-Size="Small" Font-Names="Verdana" ForeColor="ForestGreen" />
                                <Columns>                    
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkbox" runat="server" />
                                        </ItemTemplate> 
                                    </asp:TemplateField>
                                </Columns>
                                <Columns >
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Left">
                                        <HeaderTemplate>
                                            Question List
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:HiddenField id="quesHdn" runat="server" Value='<%#Eval("Id") %>' />
                                            <font style="font-family:Verdana; font-size:medium; color:Olive;">
                                                <%#Eval("Question") %>
                                            </font>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                        </asp:GridView>
                        <asp:GridView ID="questionGrid1" runat="server" AutoGenerateColumns="false" Width="100%" Visible="false" >
                            <HeaderStyle BackColor="ControlLight" BorderStyle="Solid" BorderColor="Gray" Font-Size="Small" Font-Names="Verdana" ForeColor="ForestGreen" />
                                <Columns>                    
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkbox" runat="server" />
                                        </ItemTemplate> 
                                    </asp:TemplateField>
                                </Columns>
                                <Columns >
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Left">
                                        <HeaderTemplate>
                                            Question List
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:HiddenField id="quesHdn" runat="server" Value='<%#Eval("Id") %>' />
                                            <font style="font-family:Verdana; font-size:medium; color:Olive;">
                                                <%#Eval("Question") %>
                                            </font>
                                            <asp:HiddenField ID="select" runat="server" Value='<%#Eval("select") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                        </asp:GridView>
                        </div>
                    </td>
                </tr>                
                <tr>
                    <td>
                        <table width="100%">
                            <tr align="center">
                                <td width="20%"></td>
                                <td width="20%"></td>
                                <td width="20%"></td>
                                <td width="20%"><asp:Button ID="saveQuest" Text="Save" runat="server" Width="60%" 
                                        onclick="saveQuest_Click" /></td>
                                <td width="20%"><asp:Button ID="cancelQuest" Text="Cancel" runat="server" Width="60%" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr><td><hr width="100%" /></td></tr>
                <tr align="right">
                    <td><asp:LinkButton ID="newQuestion" Text="Click here to add your Own Question" 
                            Font-Underline="false" runat="server" onclick="newQuestion_Click"></asp:LinkButton> </td>
                </tr>
                <tr>
                    <td>
                        <div id="newQuest" class="div" visible="false" runat="server">
                            <table width="100%">
                                <tr align="center">
                                    <td width="5%"></td>
                                    <td width="60%"><asp:TextBox CssClass="textbox" ID="newQuesttxt" runat="server"></asp:TextBox></td>
                                    <td width="15%"><asp:Button ID="newquestSave" CssClass="button" runat="server" 
                                            Text="Save" onclick="newquestSave_Click" /></td>
                                    <td width="15%"><asp:Button ID="newquestCancel" runat="server" CssClass="button" Text="Cancel" /></td>
                                    <td width="5%"></td>
                                </tr>
                            </table>
                        </div>
                    </td>
                </tr>
            </table>
        </td>        
        <td width="15%"><asp:LinkButton ID="grdEdit" runat="server" Text="Edit" 
                Visible="false" onclick="grdEdit_Click" ></asp:LinkButton></td>
    </tr>
</table>