<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AB3._Default" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent"  runat="server">
    <form id="Principal" runat="server">
        <div class="inicio" >
                    <div id="Login" class="login" runat="server">
                        <asp:TextBox class="txtLogin" ID="txtCorreo" runat="server" Placeholder="Correo" />
                        <asp:TextBox class="txtLogin" ID="txtContrasena" runat="server" TextMode="Password" Placeholder="Contraseña" />
                        <asp:Button class="btn" ID="btnIniciarSesion" Text="Login" runat="server" />
                        <asp:Label class="" ID="LblLogin" Text="" runat="server" Visible="true"></asp:Label>
                         <br /><br />
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error1.png" />
                        <asp:Label ID="msgError" class="error" runat="server" Text="" />
                    </div>
                </div>
        <div class="registrar">
    <div class="titulo">Libros</div><br/>
                <asp:Image ID="imgError2" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                    &nbsp;<asp:Label ID="msgError2" class="error" runat="server" Text="" />
        <br/>
            <asp:GridView ID="gvLibros" runat="server">
            </asp:GridView>

         </div>
        <br/><br/>
        <div class="registrar">
    <div class="titulo">BestSeller</div>
        <br/>
            <asp:GridView ID="gvBest" runat="server">
            </asp:GridView>

        </div>
    </form>
</asp:Content>


