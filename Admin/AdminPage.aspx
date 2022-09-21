<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="InsuranceProject.AdminPage"  MasterPageFile="~/MainPage.Master"%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1 class="auto-style1">
    <strong>Admin Page
</strong>
</h1> 

 <div style="margin-left:570px">

     <asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Button1_Click1" BackColor="#66FF99" />
     <asp:Button ID="Button2" runat="server" Text="SignUp" OnClick="Button2_Click" BackColor="#66FF99" />

 </div>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
    </style>
</asp:Content>
