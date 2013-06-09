<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbonadoAgregar.aspx.cs" Inherits="ASADAS.Forms.AbonadoAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="Form" runat="server">
        <div id="DivRegistrar" class="Registrar" runat="server">
            <div class="titulo">Registrar Abonado</div>
            <br/>
            <table>
                <tr>
                    <td>Nombre Completo</td>
                    <td><asp:TextBox ID="txtNombre" class="txt" runat="server" placeholder="Carlos Rodriguez Rodriguez"/></td>
                </tr>
                <tr>
                    <td>Cedula</td>
                    <td><asp:TextBox ID="txtCedula" Class="txt" runat="server" placeholder="206660666" /></td>
                </tr>
                <tr>
                    <td>Teléfono</td>
                    <td><asp:TextBox ID="txtTelefono" class="txt" runat="server" placeholder="506-4354-4323"/></td>
                </tr>
                <tr>
                    <td>ASADA</td>
                    <td><asp:DropDownList ID="dllASADA" class="txt" runat="server"/></td>
                </tr>
                <tr>
                    <td>Dirección</td>
                    <td><asp:TextBox ID="txtDireccion" class="txta" runat="server" TextMode="MultiLine"/></td>
                </tr>           
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnRegistrar" 
                            onclick="btnRegistrar_Click"/>
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