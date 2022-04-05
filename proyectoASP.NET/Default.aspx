<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proyectoASP.NET._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <p>
    <br />
    <asp:Button ID="btnDocsList" runat="server" OnClick="btnDocsList_Click" Text="Listar Medicos" />
    <asp:Button ID="btnAllList" runat="server" OnClick="btnAllList_Click" Text="Listar Todos" />
</p>
<p>
    <asp:ListBox ID="ListBox1" runat="server" Height="104px" Width="422px"></asp:ListBox>
</p>

</asp:Content>
