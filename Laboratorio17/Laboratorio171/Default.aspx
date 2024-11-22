<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="True" 
        DataKeyNames="ProductID" 
        DataSourceID="SqlDataSource1">
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=LAPTOP-V0HABNQ2\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"
        SelectCommand="SELECT * FROM Products"
        UpdateCommand="UPDATE Products SET ProductName = @ProductName, UnitPrice = @UnitPrice WHERE ProductID = @ProductID"
        DeleteCommand="DELETE FROM Products WHERE ProductID = @ProductID">
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="ProductID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
