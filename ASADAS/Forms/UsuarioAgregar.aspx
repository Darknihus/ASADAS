<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioAgregar.aspx.cs" Inherits="ASADAS.Forms.UsuarioAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Registrar Usuario</div>
            <br/>
            <table>
                <tr>  
                    <td>Usuario</td>
                    <td><asp:TextBox ID="txtNombre" class="txt" runat="server" placeholder="Carlos Rodriguez Rodriguez"/></td>
                </tr>
                <tr>
                    <td>Contraseña</td>
                    <td><asp:TextBox ID="txtContrasenia" class="txt" TextMode="Password"  runat="server"/></td>
                </tr>        
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnRegistrar" OnClick="btnRegistrar_Click"/>
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