<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="rUsuario.aspx.cs" Inherits="PrimerParcialAdriel.Registro.rUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
 <div class="container ">
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" class="text-info text-center" Text="UsuarioId"></asp:Label>
        <asp:TextBox class="form-control" ID="IdTextBox" type="number" runat="server"></asp:TextBox>
        <br>
        <asp:Button class="btn btn-info" CausesValidation ="False" ID="BuscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
    </div>
 </div>
    <br>
   

       <br>
       
            <div class="panel-footer">
               <div class="text-center">
                 <div class="form-group" style="display: inline-block">
                       <asp:Button Text="Nuevo" class="btn btn-primary" runat="server" ID="nuevoButton" OnClick="nuevoButton_Click" />
                       <asp:Button Text="Guardar" class="btn btn-success" runat="server" ID="guadarButton" OnClick="guardarButton_Click" />
                       <asp:Button Text="Eliminar" class="btn btn-danger" runat="server" ID="eliminarButton" OnClick="eliminarButton_Click" />
                 </div>
               </div>
            </div>
</asp:Content>
