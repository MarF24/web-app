document.querySelector("#formulario").addEventListener("submit", registro)

function registro(e) {
    e.preventDefault()

    if (get("nombre") == "" || get("apellido") == "" || get("email") == "" || get("pass") == "") {
        document.querySelector("#txt").innerHTML = "Los datos no pueden estar en blanco"
    } else {
        this.submit()
    }
}

function get(id) {
    return document.querySelector("#"+id).value
}