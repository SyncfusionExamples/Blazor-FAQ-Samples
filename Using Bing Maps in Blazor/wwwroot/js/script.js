function loadBingMap() {
    var map = new Microsoft.Maps.Map(document.getElementById('map'), {});
    var pushpin = new Microsoft.Maps.Pushpin(map.getCenter(), null);
    map.entities.push(pushpin);
    return "";
}