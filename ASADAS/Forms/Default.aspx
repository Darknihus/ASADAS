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
                        <asp:Label ID="lblError" class="error" runat="server" Text="" />
                    </div>
                </div>
   
    </form>
</asp:Content>


