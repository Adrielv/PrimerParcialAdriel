<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="rEvaluacion.aspx.cs" Inherits="PrimerParcialAdriel.Registro.rEvaluacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br>
 <div class="container ">
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" class="text-info text-center" Text="EvaluacionId"></asp:Label>
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidatorEvaluacion" runat="server"ControlToValidate="evaluacionIdTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
        <asp:TextBox class="form-control" ID="EvaluacionIdTextBox" type="number" runat="server"></asp:TextBox>
        <br>
        <asp:Button class="btn btn-info" CausesValidation ="False" ID="BuscarButton" runat="server" Text="Buscar" AutoPostBack = "True" OnClick="buscarButton_Click" />
       
     
    </div>
 </div>
      <%--<asp:RequiredFieldValidator ID="RequiredFieldValidatorEstudiante" runat="server" ControlToValidate= "EstudianteIdTextBox" ErrorMessage="RequiredFieldValidator"Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>--%>
    <br>
  <div class="container ">
    <div class="form-group">
     <asp:Label ID="Label2" runat="server" class="text-info text-center" Text="Fecha"></asp:Label>
        <asp:TextBox class="form-control" ID="FechaTextBox" type="date" runat="server"></asp:TextBox>
  </div>
 </div>
      <br>
    <div class="container ">
    <div class="form-group">
     <asp:Label ID="Label3" runat="server" class="text-info text-center" Text="Estudiante"></asp:Label>
        <asp:TextBox class="form-control" ID="EstudianteTextBox" type="text" runat="server"></asp:TextBox>    
  </div>
 </div>
     <div class="container ">
    <div class="form-group">
     <asp:Label ID="Label4" runat="server" class="text-info text-center" Text="Categoria"></asp:Label>
        <asp:TextBox class="form-control" ID="CategoriaTextBox" type="text" runat="server"></asp:TextBox>
        </div>
 </div>
      <br>
      <div class="container ">
    <div class="form-group">
     <asp:Label ID="Label5" runat="server" class="text-info text-center" Text="Valor"></asp:Label>
        <asp:TextBox class="form-control" ID="ValorTextBox" type="number" runat="server"></asp:TextBox>
          </div>
 </div>
      <br>
  <div class="container ">
    <div class="form-group">
         <asp:Label ID="Label6" runat="server" class="text-info text-center" Text="Logrado"></asp:Label>
        <asp:TextBox class="form-control" ID="LogradoTextBox" type="number" runat="server"></asp:TextBox>
     <br>
             </div>
 </div>
    <asp:Button class="btn btn-info" CausesValidation ="False" ID="AgregarButton" runat="server" Text="Agregar" AutoPostBack = "True" OnClick="AgregarButton_Click" />
     <br>
    
            <div class="container ">
    <div class="form-group">
     <asp:Label ID="Label7" runat="server" class="text-info text-center" readOnly ="true"  Text="Total"></asp:Label>
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
        <asp:TextBox class="form-control" ID="ToTalTextBox" type="number" runat="server"></asp:TextBox>
        </div>
 </div>
   
   
   

       <asp:GridView ID="GridView" runat="server">
      </asp:GridView>
   
   
   

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
