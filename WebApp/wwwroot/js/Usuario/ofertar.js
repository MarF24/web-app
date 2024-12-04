document.querySelector("#ofertar").addEventListener("submit", ofertar)

function ofertar(e) {
    e.preventDefault()

    if (get("monto") == "" || get("monto") <= 0) {
        document.querySelector("#txt").innerHTML = "El monto no puede ser 0/negativo"
    } else {
        this.submit()
    }
}

function get(id) {
    return document.querySelector("#" + id).value
}