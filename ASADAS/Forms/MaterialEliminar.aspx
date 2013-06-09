﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaterialEliminar.aspx.cs" Inherits="ASADAS.Forms.MaterialEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Eliminar Material</div>
            <br/>
            <table>
                 <tr>
                    <td>ASADA</td>
                    <td><asp:DropDownList ID="ddlASADA" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar"/></td>
                </tr>
                <tr>
                    <td>Nombre</td>
                    <td><asp:DropDownList ID="ddlNombre" class="txt" runat="server"/></td>
                </tr>                     
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Eliminar" ID="btnRegistrar"/>
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" NavigateUrl="/Default.aspx" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                        <asp:Label ID="msgError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>