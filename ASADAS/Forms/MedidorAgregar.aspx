<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MedidorAgregar.aspx.cs" Inherits="ASADAS.Forms.MedidorAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Agregar Medidor</div>
            <br/>
            <table>
                <tr>
                    <td>ASADA</td>
                    <td><asp:DropDownList ID="ddlASADA" class="txt" runat="server"/></td>
                </tr>
                 <tr>
                    <td>Cedula</td>
                    <td><asp:DropDownList ID="ddlCedula" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Codigo</td>
                    <td><asp:TextBox ID="txtCodigo" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Garantia</td>
                    <td><asp:TextBox ID="txtGarantia" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Marca</td>
                    <td><asp:TextBox ID="txtMarca" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Tipo</td>
                    <td><asp:TextBox ID="txtTipo" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2">mapa</td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnAgregar"/>
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" NavigateUrl="~/Default.aspx" />
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
    &nbsp;&nbsp;&nbsp;
    </form>
</asp:Content>

