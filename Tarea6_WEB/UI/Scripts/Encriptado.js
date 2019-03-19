/// <reference path="Encriptado.js" />
function controlEspacio() {

    var evento_key = window.event.keyCode;
    if (evento_key == '32') //comparo tecla space
    {
        alert("No se pueden usar espacios");
        return false;
        
        
    }
    else {
        return true;
    }

}