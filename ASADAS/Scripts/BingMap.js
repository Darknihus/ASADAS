var map = null;
var noPins = true;

function LoadMap() {
    var options = {
        credentials: "AjcOtl_moqFDt9N57pe6Y5EMsGOgX4w7zJL_vAzFzegVWVX-dbst-5FEHyqYFwOr",
        mapTypeId: Microsoft.Maps.MapTypeId.aerial,
        center: new Microsoft.Maps.Location(10.65672975334863, -84.76763305664062),
        zoom: 12,
        enableClickableLogo: false,
        enableSearchLogo: false,
        showCopyright: false,
        showMapTypeSelector: false
    }
    // Initialize the map
    map = new Microsoft.Maps.Map(document.getElementById("myMap"), options);

    // Add a handler for the map click event.
    Microsoft.Maps.Events.addHandler(map, 'click', addPin);
    //  Microsoft.Maps.Events.addHandler(map.entities, 'entityadded', shadePins);  // Accesar los puntos anteiores
}