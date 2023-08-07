<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_login.aspx.cs" Inherits="OnlineExaminationSystem.Student_login" %>

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
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Student Login "></asp:Label>
           </center>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <div>
            <center>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Email ID :-" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="Enter your mail id " Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;
                <br />
            <br />
            <br />
&nbsp; <asp:Label ID="Label2" runat="server" Text="Password :-" Font-Size="X-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ToolTip="Enter you Password " Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <center>     <asp:Button ID="Button1" runat="server" Text="Login " OnClick="Button1_Click" Font-Size="X-Large" />   </center>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <center>    <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="Invaild Login Details " Visible="False"></asp:Label>   </center>
                </center>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
