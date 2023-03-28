
function initialize() {
    var latlng = new google.maps.LatLng(40.716948, -74.003563);
    var options = {
        zoom: 14, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);
}