const contraseña1 = document.getElementById("password1")
const contraseña2 = document.getElementById("password2")

let llave = false;

const formulario = document.getElementById("formulario")

const boton = document.getElementById("boton")

contraseña1.addEventListener("change", () => {

    if (contraseña2.value != "") {

        if (contraseña1.value != contraseña2.value) {

            alert("Las contraseñas no coinciden")
            boton.disabled = true

        } else {

            boton.disabled = false
        }
    }
})

contraseña2.addEventListener("change", () => {

    if (contraseña1.value != "") {

        if (contraseña1.value != contraseña2.value) {
            alert("Las contraseñas no coinciden")

            boton.disabled = true

        } else {

            boton.disabled = false
        }

    }
})



