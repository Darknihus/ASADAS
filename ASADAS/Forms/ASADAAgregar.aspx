<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="ASADAAgregar.aspx.cs" Inherits="ASADAS.Forms.ASADAAgregar" %>
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
          var data = new Array();
          function LoadMap() {
              var options =
                  {
                      credentials: 'AjcOtl_moqFDt9N57pe6Y5EMsGOgX4w7zJL_vAzFzegVWVX-dbst-5FEHyqYFwOr',
                      mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                      center: new Microsoft.Maps.Location(10.65672975334863, -84.76763305664062),
                      zoom: 12,
                      customizeOverlays: true,
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
                  var nombre = prompt("Ingrese el nombre de la ASADA", "");
                  if ((nombre != null) && (nombre != '')) {
                      var pin = new Microsoft.Maps.Pushpin(loc, { htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + nombre + "<br/><img src='/images/water.png'/></div>" });
                      data.push([nombre, loc.latitude, loc.longitude,"\n"]);
                      Microsoft.Maps.Events.addHandler(pin, "click", removePin); // Borrar
                      map.entities.push(pin);//agrega el pin
                    //  document.getElementById("Button1").textContent=data;
                  }
              }
          }

          function removePin(e) {
              var r = confirm("¿Desea eliminar esa ASADA?");
              if (r == true) {
                  var indexOfPinToRemove = map.entities.indexOf(e.target);
                  map.entities.removeAt(indexOfPinToRemove);
                  delete data[indexOfPinToRemove];
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
             <div class="titulo">Agregar ASADA</div>
            <br/>
            <table>
                
                <tr>
                    <td>
                       <div id='myMap' style="position:relative; width:400px; height:400px;"></div>
                    </td>
                </tr>
                <tr>
                    <td class="tdright">
                        <asp:Button class="btn" runat="server" Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click("Button1.value")" />
                        <asp:Button class="btn" runat="server" Text="Cancelar" ID="btnCancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="tdright">
                        <asp:Label runat="server" ID="Button1" name="Button1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="imgError" Visible="false" class="imgError" runat="server" ImageUrl="/Images/error.png" />
                        <asp:Label ID="lblError" class="error" runat="server" Text="" />
                    </td>
                </tr>
            </table>
               
                </div>
            </form>  
            <footer>

            </footer>
        </div> 
        
    </body>
</html>
