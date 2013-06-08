﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbonadoAgregar.aspx.cs" Inherits="ASADAS.Forms.AbonadoAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
        <div class="titulo">Registrar Usuario</div>
        <br/>
        <table>
            <tr>
                <td>Nombre Completo:</td>
                <td><asp:TextBox ID="txtNombre" class="txt" runat="server" Height="20px" Width="200px" /></td>
            </tr>
            <tr>
                <td>Contraseña:</td>
                <td><asp:TextBox ID="txtContrasenia" TextMode="Password" class="txt" runat="server" Height="20px" Width="200px" /></td>
            </tr>
            <tr>
                <td>Correo electrónico:</td>
                <td><asp:TextBox ID="txtCorreo" Class="txt" runat="server" placeholder="example@mail.com" Height="20px" Width="200px" /></td>
            </tr>
            <tr>
                <td>Teléfono:</td>
                <td><asp:TextBox ID="txtTelefono" class="txt" runat="server" placeholder="506-4354-4323" Height="20px" Width="200px"/></td>
            </tr>
            <tr>
                <td>Ciudad:</td>
                <td><asp:TextBox ID="txtCiudad" class="txt" runat="server" placeholder="" Height="20px" Width="200px" /></td>
            </tr>
            <tr>
                <td>Estado:</td>
                <td><asp:TextBox ID="txtEstado" class="txt" runat="server" placeholder="" Height="20px" Width="200px"/></td>
            </tr>
            <tr>
                <td>Codigo Postal:</td>
                <td><asp:TextBox ID="txtCodigoPostal" class="txt" runat="server" placeholder="" Height="20px" Width="200px"/></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" class="lblRegistrar" runat="server" Text="Dirección:" /></td>
                <td><asp:TextBox ID="txtDireccion" class="txta" runat="server" TextMode="MultiLine" Width="200px" /></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error1.png" />
                    &nbsp;<asp:Label ID="msgError" class="error" runat="server" Text="" /></td>
            </tr>
            <tr>
                <td><br /><asp:Button class="btn" runat="server" Text="Registrarse" ID="btnRegistrar" OnClick="btnRegistrar_Click" /></td>
                <td><br /><asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" OnClick="btnCancelar_Click" NavigateUrl="~/Default.aspx" /></td>
            </tr>
        </table>
    </div>
    </form>
    
</asp:Content>