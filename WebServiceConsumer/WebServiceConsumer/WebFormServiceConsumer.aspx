<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormServiceConsumer.aspx.cs" Inherits="WebServiceConsumer.WebFormServiceConsumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 187px;
        }
    </style>
</head>
<body style="height: 202px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hello World!" />
        <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="123px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Invoke hello + name" />
        <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Invoke p1 + p2" />
        <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
    </form>
</body>
</html>
