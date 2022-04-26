
//Esto se ejecuta cuando la pagian empieza a cargar
window.onload = function () {
    listaTipoMedicamento();
}

async function listaTipoMedicamento() {


    try {
        var raiz = document.getElementById("hdfOculto").value;

        var urlCompleta = window.location.protocol + "//" + window.location.host +"/"+ raiz +"TipoMedicamento/listarTipoMedicamento"
        //Llamamos al metodo listarTipoMedicamento del controlador TipoMedicamento
        var res = await fetch(urlCompleta)
        //Pasamos a json la respuesta
        res = await res.json();
        alert(res);
        //Convertirmos el json a string
        alert(JSON.stringify(res));
    } catch (e) {
        alert("Ocurrio un error");
    }
    
}