<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioEliminar.aspx.cs" Inherits="ASADAS.Forms.UsuarioEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Eliminar Usuario</div>
            <br/>
            <table>
                <tr>
                    <td>Usuario</td>
                    <td><asp:DropDownList ID="ddlNombre" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Eliminar" ID="btnEliminar"/>
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" NavigateUrl="/Default.aspx" />
                    </td>
                </tr>
                 <tr>
                    <td colspan="2">
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                        <asp:Label ID="lblError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table>
            <br />
            <div id="Div1" runat="server">
                <asp:GridView ID="gvBuscar" runat="server"/>
                <br/>
                <asp:Image ID="imgError2" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                <asp:Label ID="lblError2" class="error" runat="server" Text="" />                 
            </div> 
        </div>
    </form>
</asp:Content>
