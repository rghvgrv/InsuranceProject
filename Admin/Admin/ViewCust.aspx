﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/AdminHome.Master" CodeBehind="ViewCust.aspx.cs" Inherits="InsuranceProject.Admin.ViewCust" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <h1 style="text-align: center">All Policy Holders</h1>
        </div>
        <asp:GridView runat="server" ID ="grdView" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />

        </asp:GridView>
      
    </asp:Content>