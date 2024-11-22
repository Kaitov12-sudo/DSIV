<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio161._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <asp:Button runat="server" ID="btnMensaje" Text="Haz clic aquí" OnClick="btnMensaje_Click" />
        <asp:Label runat="server" ID="lblMensaje" Text="" />
    </div>
</asp:Content>

