<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineExaminationSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:cyan;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <center>
        <asp:Label ID="Label1" runat="server" Text="Welcome To Online Examination System " Font-Size="X-Large"></asp:Label>
            
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Log in as:-"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Student Login " BackColor="LightYellow" Font-Size="X-Large" />
        &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin Login " BackColor="LightYellow" Font-Size="X-Large" />
        </p>
        <p>
            &nbsp;</p>
            </center >
            </div>
    </form>
</body>
</html>
