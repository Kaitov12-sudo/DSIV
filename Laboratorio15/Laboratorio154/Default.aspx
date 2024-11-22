<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio154.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 15-4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Suma de dos números</h2>
            <asp:TextBox ID="txtNumber1" runat="server" Placeholder="Ingrese el primer número"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtNumber2" runat="server" Placeholder="Ingrese el segundo número"></asp:TextBox><br /><br />
            <asp:Button ID="btnSum" runat="server" Text="Sumar" OnClick="btnSum_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

