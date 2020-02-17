
function validation()
{
var name=document.getElementById("UserName").value;
var password=document.getElementById("pwd").value;
console.log(name);
console.log(password);
if(name=="abhi@gmail" && password=="abhi")
{
    alert("welcome");
    window.location.href = "";
}
else{
    
    alert("invalid");
    return false;
}
}