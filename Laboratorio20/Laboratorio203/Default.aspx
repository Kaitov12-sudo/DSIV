<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio203._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestión de Productos</h2>
    <p>CRUD para la tabla Laptops</p>
    <asp:TextBox ID="txtId" runat="server" placeholder="ID"></asp:TextBox><br />
    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
    <asp:TextBox ID="txtPrecio" runat="server" placeholder="Precio"></asp:TextBox><br />
    <asp:TextBox ID="txtStock" runat="server" placeholder="Stock"></asp:TextBox><br />

    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /><br /><br />

    <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="True"></asp:GridView>
</asp:Content>

