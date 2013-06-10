<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mapa.aspx.cs" Inherits="ASADAS.Mapa" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
   <head>
      <title></title>
       <link href="/CSS/btn.css" rel="stylesheet" />
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>
      <script type="text/javascript">
          var map = null;
          var data= new Array();
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
              // Add a handler for the map click event.       
          }

          function addPin(e) {
              if (e.targetType == "map") {
                  var point = new Microsoft.Maps.Point(e.getX(), e.getY());//Devuelve la ubicacion del punto donde se encuentra el punter
                  var loc = e.target.tryPixelToLocation(point);
                  var nombre = prompt("Ingrese el nombre de la ASADA", "");
                  if ((nombre != null) && (nombre != '')) {
                      var pin = new Microsoft.Maps.Pushpin(loc, { htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + nombre + "<br/><img src='/images/water.png'/></div>" });
                      data.push([nombre, loc.latitude, loc.longitude]);
                      Microsoft.Maps.Events.addHandler(pin, "click", removePin); // Borrar
                      map.entities.push(pin);//agrega el pin
                      document.getElementById('<%= Data.ClientID %>').innerText = data;
                      
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
   <body onload="LoadMap();">
      <div id='myMap' style="position:relative; width:400px; height:400px;"></div>
      <b>Drag the pushpin to a new location.</b> 
       <form id="Form" runat="server">
           <asp:Label ID="Data" runat="server" />
       </form>    
   </body>
</html>