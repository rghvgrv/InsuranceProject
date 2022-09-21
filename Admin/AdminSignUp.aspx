<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainPage.Master" CodeBehind="AdminSignUp.aspx.cs" Inherits="InsuranceProject.AdminSignUp" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>&nbsp;SIGN UP! ADMIN</h1>
    <div id ="Admin">
        <p>
            Name:<asp:TextBox ID="AdminName" runat="server"></asp:TextBox>
        </p>
        <p>
            Email Address:<asp:TextBox ID="AdminEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ErrorMessage="Email is not in a proper format" ForeColor="IndianRed" ControlToValidate="AdminEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        
        </p>
        <p>
            Contact Number:<asp:TextBox ID="AdminCon" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:<asp:TextBox type="password" ID="AdminPwd" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ErrorMessage="Password is a must" ControlToValidate="AdminPwd" runat="server" ForeColor="IndianRed" />
        </p>
        <p>
            Confirm Password:<asp:TextBox type="password" ID="signCfm" runat="server"></asp:TextBox>
             <asp:CompareValidator ErrorMessage="Password Mismatch" ControlToValidate="signCfm" ControlToCompare="AdminPwd" Type="String" runat="server" ForeColor="IndianRed" />
        </p>
        <p>
            <asp:Button ID="signBtn" runat="server" Text="SIGN UP" Width="218px" OnClick="signBtn_Click" />
        </p>
        </div>


 </asp:Content>
