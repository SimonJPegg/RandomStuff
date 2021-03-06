
function createDrivingDirectionsMap()
{
    if(navigator.geolocation)
    {
        navigator.geolocation.getCurrentPosition(OnSuccess, OnError, {
            enableHighAccuracy: true,
            maximumAge: 1000,
            timeout: 500
        });
    }
    else
    {
        document.getElementById('map').innerHTML = "No Geolocation support, we can't find you";
    }
}

function OnSuccess(position)
{
    showMap(
      position.coords.latitude,
      position.coords.longitude
    );
}

function OnError(error)
{
    var mapDiv = document.getElementById('map');

    switch (error.code)
    {
        case error.PERMISSION_DENIED:
            mapDiv.innerHTML = "User denied request for location";
            break;
        case error.POSITION_UNAVAILABLE:
            mapDiv.innerHTML = "Location information unavailable";
            break;
        case error.TIMEOUT:
            mapDiv.innerHTML = "The location request timed out";
            break;
        case error.UNKNOWN_ERR:
            mapDiv.innerHTML = "An unknown error occurred";
            break;
    }
}

function showMap(lat, lng)
{
    var directionsService = new google.maps.DirectionsService();
    var directionsRenderer = new google.maps.DirectionsRenderer();

    var route = {
        origin: new google.maps.LatLng(lat,lng),
        destination: 'Royal Avenue, Belfast',
        travelMode: google.maps.DirectionsTravelMode.DRIVING
    };

    var mapOptions = {
        zoom: 10,
        center: new google.maps.LatLng(54.6014881, -5.9313141),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var map = new google.maps.Map(document.getElementById('map'), mapOptions);
    directionsRenderer.setMap(map);
    directionsRenderer.setPanel(document.getElementById('driving-directions'));
    directionsService.route(route, function(result, status)
    {
       if (status == google.maps.DirectionsStatus.OK)
       {
           directionsRenderer.setDirections(result);
       }
    });
}