<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio161.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click" />
            <asp:TextBox runat="server" ID="txtNombre" />
            <asp:Label runat="server" ID="lblSaludo" Text="" />
        </div>
    </form>
</body>
</html>

