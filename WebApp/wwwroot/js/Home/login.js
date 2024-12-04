document.querySelector("#login").addEventListener("submit", login)

function login(e) {
    e.preventDefault()

    if (get("email") == "" || get("pass") == "") {
        document.querySelector("#txt").innerHTML = "Los datos no pueden estar en blanco"
    } else {
        this.submit()
    }
}

function get(id) {
    return document.querySelector("#" + id).value
}