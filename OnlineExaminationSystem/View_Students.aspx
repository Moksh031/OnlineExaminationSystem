<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Students.aspx.cs" Inherits="OnlineExaminationSystem.View_Students" %>

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
        <div style="background-color:antiquewhite">
            <br />
            <center>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Online Examination System Project"></asp:Label>
            </center>
               
            </div>
         <br />
        <center>
            <br />
         <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Students Details "></asp:Label>
            </center>
         <br />
            <br/>
        <div>
            <center>
                <br />
            <asp:GridView ID="GridView1" runat="server" Font-Size="X-Large">
        </asp:GridView>
                </center>
        </div>
        
        <p>
&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back" BackColor="LightGoldenrodYellow" Font-Size="X-Large" />
        </p>
        
    </form>
</body>
</html>
