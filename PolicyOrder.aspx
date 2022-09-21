<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PolicyOrder.aspx.cs" MasterPageFile="~/User/UserHome.Master" Inherits="InsuranceProject.User.PolicyOrder" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <table align="center" border ="2" BorderColor ="Red" CellPadding ="20" BorderStyle="Groove">
        <tr>
            <td align="center" style="height: 33px">
                <strong><span style="font-size: 28pt; color: #3300ff; font-family: Verdana;">Policy Order</span></strong></td>
        </tr>
        <tr>
            <td>
                <table >
                    <tr>
                    </tr>
                     <tr>
                    </tr>
                     <tr>
                    </tr>
                     <tr>
                    </tr>
                     <tr>
                    </tr>


                    <tr>
                        <td align="right" style="font-size: 20px; font-family: Verdana">
                            <asp:Label ID="Label2" runat="server" Text="PolicyName:"></asp:Label>
                        </td>

                        <td align="left" style="width: 3px">
                             <asp:DropDownList ID="DropDownList1" Font-Size="16" runat="server" 
                                 BackColor ="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Width ="200px">  
                                <asp:ListItem>Health Insurance </asp:ListItem>  
                                <asp:ListItem>Life Insurance</asp:ListItem>  
                                <asp:ListItem>Travel Insurance</asp:ListItem>  
                            </asp:DropDownList>  
                            
        <asp:DropDownList >
             <asp:ListItem Text="Health Insurance" Value="1" />
             <asp:ListItem Text="Life Insurance" Value="2" />
             <asp:ListItem Text="Travel Insurance" Value="3" />
        </asp:DropDownList>
                      </td>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>

                        <tr>
                      <td align="left" style="font-size: 20px; font-family: Verdana">
                            <asp:Label ID="Label3" runat="server" Text="Amount:"></asp:Label>
                      </td>

                      <td align="left" style="width: 3px">
                            <asp:TextBox ID="txtamount" Font-Size="15" runat="server" BackColor ="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Width ="200px"
                                ></asp:TextBox>
                       </td>
                       <td align="left" style="width: 40px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*"
                                ControlToValidate="txtamount"></asp:RequiredFieldValidator>
                        </td>
                            </tr>
                    </tr>
                    <tr>
                    </tr>
           </table>
             
        </tr>
       <tr>
           
        </tr>
        <tr>
           
            <td align="center">
                <asp:Button ID="btnadd" runat="server" Text="Add" Font-Size="16" BackColor="#3300ff" OnClick="btnadd_Click" ForeColor ="White" Font-Bold ="true" Width ="100px" />
                <asp:Button ID="btnCancel" runat="server" Text="CANCEL"  Font-Size="16"  ForeColor ="White"   BackColor="#3300ff" OnClick="btnCancel_Click" CausesValidation="False" 
                    Width ="100px" /></td>
        </tr>
    </table>


    <div>
    </div>
</asp:Content> 
