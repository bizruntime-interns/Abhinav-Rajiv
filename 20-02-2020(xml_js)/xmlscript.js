var xmldoc, out = "", val;
window.onload = function () {
    console.log("entry ");
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            xmldoc = this.responseXML;
            console.log("process ajax");
        }
    };
    xhttp.open("GET", "books.xml", true);
    xhttp.send();
};
function load() {
    console.log("entry2");
    val = document.getElementById("input").value;
    var c = xmldoc.getElementsByTagName("book");

    if (val < c.length) {
        out = "";
        out += "<br>Category :" + c[val].getAttribute("category") + "<br>";
        out += "Author :" + c[val].getElementsByTagName("author")[0].childNodes[0].nodeValue + "<br>";
        out += "Title :" + c[val].getElementsByTagName("name")[0].childNodes[0].nodeValue + "<br>";
        out += "Price :" + c[val].getElementsByTagName("rupees")[0].childNodes[0].nodeValue + "<br>";
        document.getElementById("innerp").innerHTML = out;
    }
    else {
        alert("values Not Available.");
        document.getElementById("innerp").innerHTML = "";
        out = "";
    }
}
function remove() {
    val = document.getElementById("input").value;
    var c = xmldoc.getElementsByTagName("book")[val];
    xmldoc.documentElement.removeChild(c);
    alert("Nodes removed");

}
function replace() {
    val = document.getElementById("input").value;
    var ne = document.getElementById("new").value;
    try {
        var c = xmldoc.getElementsByTagName("book")[val].getElementsByTagName("rupees")[0].childNodes[0].nodeValue = ne;
        alert("Price updated");
    } catch (exc) {
        alert("Cant Change Price");
    }
    

}