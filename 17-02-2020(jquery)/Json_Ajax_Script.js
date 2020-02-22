
function load() {
    var xmlrequest = new XMLHttpRequest();
    xmlrequest.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            myfunction(this);
            console.log("status is redy");
        }
    };
    xmlrequest.open("GET", "students.json", true);
    xmlrequest.send();
}

function myfunction(json) {
    var obj = JSON.parse(json.responseText);
    var tdata = "<table border=5><tr><th>name</th><th>Age</th><th>Location</th></tr>";
    for (var i in obj.students) {
        tdata += "<tr><td>" + obj.students[i].Name + "</td><td>" + obj.students[i].Age + "</td><td>" + obj.students[i].Location + "</td></tr>";
    }
    tdata += "</table>";
    document.getElementById("demo").innerHTML = tdata;
}


