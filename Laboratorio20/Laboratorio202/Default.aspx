<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio202._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Generar Matriz \(N \times N\)</h2>
    <p>Ingrese el tamaño \(N\) de la matriz:</p>
    <asp:TextBox ID="txtN" runat="server" placeholder="Ingrese un número"></asp:TextBox>
    <asp:Button ID="btnGenerarMatriz" runat="server" Text="Generar Matriz" OnClick="btnGenerarMatriz_Click" />
    <br /><br />
    <asp:Literal ID="litMatriz" runat="server"></asp:Literal>
</asp:Content>
