<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MedidorEliminar.aspx.cs" Inherits="ASADAS.Forms.MedidorEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Cambiar el estado del Medidor</div>
            <br/>
            <table>
                <tr>
                    <td>Nombre</td>
                    <td><asp:DropDownList ID="ddlMedidor" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Habilitar" ID="btnHabilitar" OnClick="btnHabilitar_Click"/>
                        <asp:Button class="btn" runat="server" Text="Deshabilitar" ID="btnDeshabilitar" OnClick="btnDeshabilitar_Click"/>
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

