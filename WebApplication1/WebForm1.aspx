<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1 число:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            2 число:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Прибавить" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Вычесть" />
&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Умножить" />
&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Разделить" />
&nbsp;<asp:Label ID="Label4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
