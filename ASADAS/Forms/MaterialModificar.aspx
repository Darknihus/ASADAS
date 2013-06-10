<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaterialModificar.aspx.cs" Inherits="ASADAS.Forms.MaterialModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Modificar Material</div>
            <br/>
            <table>
                <tr>
                    <td>ASADA</td>
                    <td><asp:DropDownList ID="ddlASADA" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar" OnClick="Buscar_Click"/></td>
                </tr>
                 <tr>
                    <td>Nombre</td>
                    <td><asp:DropDownList ID="ddlNombre" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar2" OnClick="Buscar2_Click"/></td>
                </tr>
                <tr>
                    <td>Stock</td>
                    <td><asp:TextBox ID="txtStock" class="txt" runat="server" placeholder="506-4354-4323"/></td>
                </tr>          
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Modificar" ID="btnRegistrar" OnClick="btnRegistrar_Click"/>
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" NavigateUrl="/Default.aspx" OnClick="btnCancelar_Click" />
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