<%@ Page Language="C#" MasterPageFile="~/Admin/AdminHome.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="InsuranceProject.Admin.AddUser" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 style="background-color: #CC99FF">ADD EMPLOYEE</h1>
    <p>
        &nbsp;</p>
        <div>
        </div>
        <p>
            First Name:<asp:TextBox ID="addFirst" runat="server"></asp:TextBox>
            
&nbsp;</p>
        <p>
            Last Name:<asp:TextBox ID="addLast" runat="server"></asp:TextBox>
        </p>
        <p>
            Email Address:<asp:TextBox ID="addEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ErrorMessage="Email is not in a proper format" ForeColor="IndianRed" ControlToValidate="addEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
        </p>
    <p>
            Date of Birth :<asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
        </p>
        <p>
            Contact Number:<asp:TextBox ID="addCon" runat="server"></asp:TextBox>
        </p>
        <p>
            Permanent Address:<asp:TextBox ID="addAdd" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:<asp:TextBox ID="addPwd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="Password is a must" ControlToValidate="addPwd" runat="server" ForeColor="IndianRed" />
        </p>
        <p>
            Policy Name:<asp:DropDownList ID="addDrop" runat="server" Width="292px" OnSelectedIndexChanged ="GenerateCode" AutoPostBack ="true">
                <asp:ListItem Value="Life Insurance">Life Insurance</asp:ListItem>
                <asp:ListItem Value="Health Insurance">Health Insurance</asp:ListItem>
                <asp:ListItem Value="Travel Insurance">Travel Insurance</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp; 
            <asp:Button ID="Button1" CommandName="addIns" runat="server"  Text="Add" OnClick="Button1_Click" />
        </p>
    <p>
            Amount:<asp:TextBox ID="addAmt" runat="server" Height="28px" Width="96px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="registerBtn"  runat="server" Height="65px" Text="Register" Width="179px" BackColor="#CC99FF" ForeColor="Black" OnClick="registerBtn_Click" />

        </p>
    <script>

    </script>
  
</asp:Content>