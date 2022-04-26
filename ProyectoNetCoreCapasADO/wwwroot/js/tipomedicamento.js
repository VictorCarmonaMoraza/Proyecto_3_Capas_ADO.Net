
//Esto se ejecuta cuando la pagian empieza a cargar
window.onload = function () {
    listaTipoMedicamento();
}

async function listaTipoMedicamento() {


    try {
        //Llamamos al metodo listarTipoMedicamento del controlador TipoMedicamento
        var res = await fetch("TipoMedicamento/listarTipoMedicamento")
        //Pasamos a json la respuesta
        res = await res.json();
        alert(res);
        //Convertirmos el json a string
        alert(JSON.stringify(res));
    } catch (e) {
        alert("Ocurrio un error");
    }
    
}