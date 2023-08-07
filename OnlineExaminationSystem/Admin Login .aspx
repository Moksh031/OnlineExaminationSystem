<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin Login .aspx.cs" Inherits="OnlineExaminationSystem.Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        body{
            background-color:darkcyan;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        </div>
        <br />
        <br />
        <div>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Email ID :-" Font-Bold="True" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="Enter your mail id " Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;
            <br />
            <br />
&nbsp; <asp:Label ID="Label2" runat="server" Text="Password :-" Font-Bold="True" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ToolTip="Enter Password" Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login " OnClick="Button1_Click" BackColor="LightYellow" Font-Size="X-Large" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="Invaild Login Details " Visible="False"></asp:Label>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        
    </form>
   
</body>
</html>
