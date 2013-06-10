<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArregloEliminar.aspx.cs" Inherits="ASADAS.Forms.ArregloEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Eliminar Arreglo</div>
            <br/>
            <table>
                <tr>
                    <td>Cedula</td>
                    <td><asp:DropDownList ID="ddlCedula" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar" OnClick="Buscar_Click"/></td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Completo</td>
                    <td class="auto-style1"><asp:Label ID="lblNombre" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Deuda</td>
                    <td><asp:Label ID="lblDeuda" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Eliminar" ID="btnEliminar" OnClick="btnEliminar_Click"/>
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" NavigateUrl="~/Default.aspx" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                        <asp:Label ID="lblError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>
