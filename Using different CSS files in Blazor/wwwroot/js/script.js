function includeCss(url) {
    var element = document.createElement("link");
    element.setAttribute("rel", "stylesheet");
    element.setAttribute("type", "text/css");
    element.setAttribute("href", url);
    document.getElementsByTagName("head")[0].appendChild(element);
}