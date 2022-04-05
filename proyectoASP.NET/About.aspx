<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="proyectoASP.NET.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        
      <form method="post" >
        <fieldset>
          <legend>Add/Mod Paciente</legend>
          <div>
            <label for="dni">DNI: </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;        
                    <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
                </div>
          <div>
            <label for="nombre">Nombre:</label>
                    &nbsp; &nbsp;&nbsp;    
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;          </div>
          <div>
            <label for="apellido">Apellido:</label>
                    &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <br />
                </div>
            <div>
            <label for="id_pat">ID_Paciente:</label>&nbsp;&nbsp;
                <asp:TextBox ID="txtIdPat" runat="server"></asp:TextBox>
&nbsp;          
                <br />
                </div>
             <div>
            <label for="id_doc">ID_Medico asignado:</label>
                 &nbsp; &nbsp;
                 <asp:TextBox ID="txtIdDoc" runat="server"></asp:TextBox>
&nbsp;          </div>
          <div>
            <label>&nbsp;</label>
     <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Enviar" />
&nbsp;     &nbsp;
          </div>
        </fieldset>
      </form>
    
    </div>
</asp:Content>
