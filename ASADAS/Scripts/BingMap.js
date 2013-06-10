var map = null, dataLayer;
var getLat = null;
var getLong = null;
var noPins = true;

function LoadMap()
    {
        //mapOptions 
        var options =
            {
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
        Microsoft.Maps.Events.addHandler(map, 'click', addPin);

        dataLayer = new Microsoft.Maps.EntityCollection();
        map.entities.push(dataLayer);
        AddData();

        // Add a handler for the map click event.       
      }

function AddData() {
    var pin1 = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(10.65672975334863, -84.76763305664062), { htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + "nombre" + "<br/><img src='/images/water.png'/></div>" });
    dataLayer.push(pin1);

    var pin2 = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(0, -30));
    Microsoft.Maps.Events.addHandler(pin2, 'click', removePin);
    dataLayer.push(pin2);
    //, { htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + "nombre" + "<br/><img src='/images/water.png'/></div>" }
    //var pin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(10, -84));
    //Microsoft.Maps.Events.addHandler(pin, 'click', removePin);
    var pin3 = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(0, 29));
    Microsoft.Maps.Events.addHandler(pin2, 'click', removePin);
    dataLayer.push(pin3);
}

function UnloadMap()
    {
        if (myMap != null)
            {
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
            //localizacion del punto
            var pin = new Microsoft.Maps.Pushpin(loc, {htmlContent: "<div style='font-size:20px; color:Black; font-weight:bold;'>" + nombre + "<br/><img src='/images/water.png'/></div>"});
            document.getElementById("textBox").value = loc.latitude + ", " + loc.longitude; //carga el textbox con la latitud y longitud del ping actual
            document.getElementById("textBox2").value = e.getX() + ", " + e.getY();
            document.getElementById("textBox3").value = e.target.getLat + ", " + e.target.getLat;
            Microsoft.Maps.Events.addHandler(pin, 'click', removePin); // Borrar
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

/*function loadASADAS() {
    
    //agrega el pin
}*/