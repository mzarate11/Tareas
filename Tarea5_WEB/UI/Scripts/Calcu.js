function ValidarNumero(e) {
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
            alert("No se pueden ingresar letras");
            return false;
        }
        else {
            return true;
        }
    }
}
function verificar() {
    var suma = 0;
    var los_cboxes = document.getElementsByName('c[]');
    for (var i = 0, j = los_cboxes.length; i < j; i++) {

        if (los_cboxes[i].checked == true) {
            suma++;
        }
    }

    if (suma == 0) {
        alert('debe seleccionar una casilla');
        return false;
    } else if (suma == 1)
    {
        return true;
    }

    else {
        alert('Solo una casilla a la vez');
        return false;
    }
}