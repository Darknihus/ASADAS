<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mapa.aspx.cs" Inherits="ASADAS.Mapa" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
   <head>
      <title></title>
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>

      <script type="text/javascript">
          var map = null;
          Microsoft.Maps.loadModule('Microsoft.Maps.Overlays.Style', { callback: LoadMap });
          var noPins = true;
          var layertuberias = new Microsoft.Maps.EntityCollection();
          var layerllaves = new Microsoft.Maps.EntityCollection();
          //http://www.garzilla.net/vemaps/Layers-via-the-Entity-Collection-with-Bing-Maps-7.aspx

          function LoadMap() {
              //mapOptions 
              var options = {
                  credentials: "AjcOtl_moqFDt9N57pe6Y5EMsGOgX4w7zJL_vAzFzegVWVX-dbst-5FEHyqYFwOr",
                  mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                  center: new Microsoft.Maps.Location(10.65672975334863, -84.76763305664062),
                  zoom: 12,
                  customizeOverlays: true,
                  enableClickableLogo: false,
                  enableSearchLogo: false,
                  showCopyright: false,
                  showMapTypeSelector: false
                  // disableBirdseye: true
              }
              // Initialize the map
              map = new Microsoft.Maps.Map(document.getElementById("myMap"), options);

              // Add a handler for the map click event.
              Microsoft.Maps.Events.addHandler(map, 'click', addPin);


              //  Microsoft.Maps.Events.addHandler(map.entities, 'entityadded', shadePins);  // Accesar los puntos anteiores
          }

          function UnloadMap() {
              if (myMap != null) {
                  myMap.Dispose();
              }
          }

          //Agrega un Pin al mapa
          function addPin(e) {
              if (e.targetType == "map") {
                  var point = new Microsoft.Maps.Point(e.getX(), e.getY());//Devuelve la ubicacion del punto donde se encuentra el punter
                  var loc = e.target.tryPixelToLocation(point);
                  var nombre = prompt("Ingrese el nombre de la ASADA", "");
                  if ((nombre != null) && (nombre != "")) {
                      var pin = new Microsoft.Maps.Pushpin
                          (
                              loc, //localizacion del punto
                              {
                                  draggable: true,
                                  htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + nombre + "<br/><img src='/images/water.png'/></div>"
                              }
                          );
                      document.getElementById("textBox").value = loc.latitude + ", " + loc.longitude; //carga el textbox con la latitud y longitud del ping actual
                      Microsoft.Maps.Events.addHandler(pin, 'click', removePin); // Attach a handler to the pin so that it is removed when it is clicked
                      Microsoft.Maps.Events.addHandler(pin, 'mouseover', showPinInformation);
                      map.entities.push(pin);//agrega el pin
                  }
              }
          }

          //Elimina un Pin del mapa
          function removePin(e) {
              var r = confirm("¿Desea eliminar esa ASADA?!");
              if (r == true) {
                  var indexOfPinToRemove = map.entities.indexOf(e.target);
                  map.entities.removeAt(indexOfPinToRemove);
              }
          }

          function shadePins(e) {
              if (noPins) {

                  // If there aren't yet any pins on the map, do not grey the pin out.   
                  noPins = false;

              }
              else {
                  var pin = null;

                  // Loop through the collection of pushpins on the map and grey out 
                  //    all but the last one added (which is at the end of the array). 
                  var i = 0;
                  for (i = 0; i < e.collection.getLength() - 1; i++) {
                      pin = e.collection.get(i);
                      pin.setOptions({ icon: "/images/water.png" });
                  }
              }
          }

          function showPinInformation(e) {
              if (e.targetType == 'pushpin') {
                  // var pinLoc = e.target.getLocation();
                  // alert("The location of the pushpin is now " + pinLoc.latitude + ", " + pinLoc.longitude);
                  //
              }
          }



          function loadASADAS() {
              array
              map.entities.clear();

              var pushpin = new Microsoft.Maps.Pushpin(map.getCenter(), null);
              map.entities.push(pushpin);
          }
      </script>
   </head>
   <body>
      <div id='myMap' style="position:relative; width:600px; height:600px;"></div> 
       <br/><br /><br/><asp:Label runat="server" ID="patito"/>
   </body>
</html>