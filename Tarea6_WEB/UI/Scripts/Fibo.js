﻿function Valida(e)
{
    key = e.keyCode || e.which;

    teclado = String.fromCharCode(key).toLowerCase();

    letras = "0123456789";

    especiales = "42-43-44-45-47";

    teclado_especiales = false;

    for (var i in especiales) {
        if (key == especiales[i]) {
            teclado_especiales = true;
            break;
        }

        if ((letras.indexOf(teclado) == -1) && (!teclado_especiales)) {
        
                alert("Solo Se permiten Números");
                return false
            }
            else {
                return true;
            }
    }
  
   
}