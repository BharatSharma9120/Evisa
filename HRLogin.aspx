<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HRLogin.aspx.cs" Inherits="BharatSharma05.HRLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightyellow;">
    <form id="form2" runat="server">
        <br />
        <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="XX-Large">HR  Log / Sign Up page</asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="User Name "></asp:Label>
        <html xmlns="http://www.w3.org/1999/xhtml">
        <body>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <p>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Enter Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Enter ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="Button1" runat="server" Text="Login" BackColor="Lime" Font-Bold="True" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign Up " BackColor="Lime" Font-Bold="True" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</body>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Home" BackColor="Lime" Font-Bold="True" />
</html>
        <div>
            <br />
        </div>
        <p>
            <asp:Label ID="Label4" runat="server" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
