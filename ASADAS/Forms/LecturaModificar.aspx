<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LecturaModificar.aspx.cs" Inherits="ASADAS.Forms.LecturaModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Modificar Lectura</div>
            <br/>
            <table>
                <tr>
                    <td>Fecha</td>
                    <td><asp:Label ID="lblFecha" class="txt" runat="server"/></td>
                </tr>
               <tr>
                    <td>Medidor</td>
                    <td><asp:DropDownList ID="ddlMedidor" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar"/></td>
                </tr>
                <tr>
                    <td>Lectura</td>
                    <td><asp:TextBox ID="txtLectura"  class="txt" runat="server"/></td>
                </tr>                
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnAgregar"/>
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
        </div>
    </form>
</asp:Content>