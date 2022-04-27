window.onload = function () {
    listarTipoMedicamento();
}

function listarTipoMedicamento() {

    pintar({
        url: "TipoMedicamento/listarTipoMedicamento",
        cabeceras: ["Id tipo medicamento", "Nombre", "Descripcion"],
        propiedades: ["idtipomedicamento", "nombre","descripcion"]
    })
}