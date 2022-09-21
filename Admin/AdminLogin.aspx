<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" MasterPageFile="~/MainPage.Master" Inherits="InsuranceProject.AdminLogin"%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <h2>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Hey Admin !! Welcome 
        </h2>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" style="font-weight: 700"></asp:Label>
    </div>

    <p>
        Enter Mail ID :-<asp:TextBox ID="AdminMail" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter Your Password :-<asp:TextBox type="password" ID="AdminPwd" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="AdminBtn" runat="server" OnClick="Button1_Click" Text="Login" />
    </p>
    <p>
        &nbsp;</p>




</asp:Content>
