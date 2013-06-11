<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="MedidorAgregar.aspx.cs" Inherits="ASADAS.Forms.MedidorAgregar" %>
<!DOCTYPE html>
<html lang="es">
    <head id="Head1" runat="server">
        <meta http-equiv="Content-Type" content="text/html" charset="utf-8"/>
        <title>Empleos TEC</title>
        <link href="../Css/Styles.css" rel="stylesheet" />
        <link href="../Css/Images.css" rel="stylesheet" />
        <link href="../Css/btn.css" rel="stylesheet" />
        <link href="../Css/txt.css" rel="stylesheet" />
        <link href="../Css/Site.css" rel="stylesheet" />
        <link href="../Css/tables.css" rel="stylesheet" />
        <link rel="stylesheet" href="~/Css/menu-bar.css" type="text/css" media="screen">
      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>
      <script type="text/javascript">
          var map = null;
          var pincount = 0;
          function LoadMap() {
              var options =
                  {
                      credentials: 'AjcOtl_moqFDt9N57pe6Y5EMsGOgX4w7zJL_vAzFzegVWVX-dbst-5FEHyqYFwOr',
                      mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                      center: new Microsoft.Maps.Location(10.65672975334863, -84.76763305664062),
                      zoom: 12,
                      enableClickableLogo: false,
                      enableSearchLogo: false,
                      showCopyright: false,
                      showMapTypeSelector: false
                  }
              // Initialize the map
              map = new Microsoft.Maps.Map(document.getElementById('myMap'), options);
              Microsoft.Maps.Events.addHandler(map, 'click', addPin);
          }

          function addPin(e) {
              if (e.targetType == "map") {
                  var point = new Microsoft.Maps.Point(e.getX(), e.getY());//Devuelve la ubicacion del punto donde se encuentra el punter
                  var loc = e.target.tryPixelToLocation(point);
                  if (pincount > 0) {
                      map.entities.pop();
                  }
                  pincount = 1;
                  var pin = new Microsoft.Maps.Pushpin(loc, { htmlContent: "<img src='/images/water.png'/>" });
                  map.entities.push(pin);
                  var data = ([loc.latitude, loc.longitude]);
                  document.getElementById('bd').value = data;
              }
          }
      </script>
    </head>
    <body class="fondo" onload="LoadMap();">
        <div class="body">
            <div class="imgp">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Forms/Default.aspx">
                    <asp:Image ID="Image2" runat="server" ImageUrl="/Images/head2.jpg" />
                </asp:HyperLink>

            </div>  
            <div id="content">
            <ul id="vertical-navigation">
                <li class=""><a href="/Forms/Default.aspx">Home</a> </li>
                <li class=""><a>Abonado</a>
                    <ul>
                        <li class=""><a href="/Forms/AbonadoAgregar.aspx" runat="server" id="prueba">Agregar</a> </li>
                        <li class=""><a href="/Forms/AbonadoModificar.aspx">Modificar</a> </li>
                        <li class=""><a href="/Forms/AbonadoEliminar.aspx">Eliminar</a> </li>
                    </ul>
                </li>
                <!-- Begin parent item -->
                <li class=""><a>Arreglo</a>
                    <!-- Begin Child Items Group-->
                    <ul>
                        <!-- Begin Child Item-->
                        <li class=""><a href="/Forms/ArregloAgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/ArregloModificar.aspx">Modificar</a> </li>
                        <li class=""><a href="/Forms/ArregloEliminar.aspx">Eliminar</a> </li>
                    </ul>
                    <!-- End Child Items Group-->
                <li class=""><a>ASADA</a>
                    <ul>
                        <li class=""><a href="/Forms/ASADAAgzregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/ASADAEliminar.aspx">Eliminar</a> </li>
                    </ul>
                </li>
                <li class=""><a>Fuente</a>
                    <ul>
                        <li class=""><a href="/Forms/FuenteAgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/FuenteEliminar.aspx">Eliminar</a> </li>
                    </ul>
                <li class=""><a>Lectura</a>
                    <ul>
                        <li class=""><a href="/Forms/LecturaAzgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/LecturaModificar.aspx">Modificar</a> </li>
                    </ul>
                <li class=""><a href="/Forms/Factura.aspx">Factura</a> </li>
                <li class=""><a>Material</a>
                    <ul>
                        <li class=""><a href="/Forms/MaterialAgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/MaterialModificar.aspx">Modificar</a> </li>
                    </ul>
                <li class=""><a>Medidor</a>
                    <ul>
                        <li class=""><a href="/Forms/MedidorAgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/MedidorEliminar.aspx">Eliminar</a> </li>
                    </ul>
                <li class=""><a>Usuario</a>
                    <ul>
                        <li class=""><a href="/Forms/UsuarioAgregar.aspx">Agregar</a> </li>
                        <li class=""><a href="/Forms/UsuarioModificar.aspx">Modificar</a> </li>
                        <li class=""><a href="/Forms/UsuarioEliminar.aspx">Eliminar</a> </li>
                    </ul>
                    <!-- End Items Group-->
            </ul>
        </div>
            <form id="Form" runat="server">
            <div id="DivRegistrar" class="Registrar" runat="server">
             <div class="titulo">Agregar Fuente</div>
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
                    <td colspan="2">
                       <div id='myMap' style="position:relative; width:400px; height:400px;"></div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" />
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                        <asp:Label ID="lblError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table><!--type="hidden"-->
               <input type="hidden" id="bd" runat="server" value=""/>
                </div>
            </form>  
            <footer>

            </footer>
        </div> 
        
    </body>
</html>

