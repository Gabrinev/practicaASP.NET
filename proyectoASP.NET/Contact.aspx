<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="proyectoASP.NET.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        
      <form method="post" >
        <fieldset>
          <legend>Add/Mod Medico</legend>
          <div>
            <label for="dni">DNI: </label>
            <input type="text" name="dni" value="" />
          </div>
          <div>
            <label for="nombre">Nombre:</label>
            <input type="text" name="nombre" value="" />
          </div>
          <div>
            <label for="apellido">Apellido:</label>
     <input type="text" name="apellido" value="" /><br />
&nbsp;     &nbsp;
          </div>
             <div>
            <label for="id_doc">ID_Medico:</label>
            <input type="text" name="id_doc" value="" />
          </div>
          <div>
            <label>&nbsp;</label>
            <input type="submit" value="Submit" class="submit" />
          </div>
        </fieldset>
      </form>
    
    </div>
</asp:Content>
