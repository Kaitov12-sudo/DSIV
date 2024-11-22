<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio201._Default" %>


   <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Generar Tabla de Multiplicar</h2>
    <p>Ingrese un número para generar la tabla de multiplicar hasta el 25:</p>
    <asp:TextBox ID="txtNumero" runat="server" placeholder="Ingrese un número"></asp:TextBox>
    <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
    <br />
    <asp:Literal ID="litTabla" runat="server"></asp:Literal>


</asp:Content>
