window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {

    fetchGet("Medicamento/saludos", "text", function (res) {
        alert(res);

    })
    fetchGet("Medicamento/numero", "text", function (res) {
        alert(res);

    })

}
