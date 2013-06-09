<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbonadoEliminar.aspx.cs" Inherits="ASADAS.Forms.AbonadoEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Eliminar Abonado</div>
            <br/>
            <table>
                <tr>
                    <td>Cedula</td>
                    <td><asp:DropDownList ID="ddlCedula" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright"><asp:Button class="btn" runat="server" Text="Buscar" ID="Buscar"/></td>
                </tr>
                <tr>
                    <td>Nombre Completo</td>
                    <td><asp:Label ID="lblNombre" runat="server"/></td>
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
                        <asp:Label ID="msgError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table>
            <br />
            <div runat="server">
                <asp:GridView ID="gvBuscar" runat="server"/>
                <br/>
                <asp:Image ID="imgError2" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                <asp:Label ID="msgError2" class="error" runat="server" Text="" />                 
            </div> 
        </div>
    </form>
</asp:Content>