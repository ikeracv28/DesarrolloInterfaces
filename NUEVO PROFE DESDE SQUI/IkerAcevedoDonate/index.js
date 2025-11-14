
// declaracion de variables asociadas al id
const nombre = document.getElementById("nombre")
const apellidos = document.getElementById("apellido")
const email = document.getElementById("email")
const telefono = document.getElementById("telefono")
const nombreUsuario = document.getElementById("nombreUsuario")


const contraseña1 = document.getElementById("password1")
const contraseña2 = document.getElementById("password2")

const formulario = document.getElementById("formulario")

const boton = document.getElementById("boton")



const listaInputs = [];


// funciones para validar la contraseña y que coincidan, y tambien para que muestre el boton si esta bien
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


// funcion para mostrar por consola los datos que recogemos
formulario.addEventListener("submit", (e) => {

    // hacemos que no se recargue la pagina para mostrarlos por consola
    e.preventDefault();
    listaInputs.push({ id: "nombre", valor: nombre.value })
    listaInputs.push({ id: "apellidos", valor: apellidos.value })
    listaInputs.push({ id: "email", valor: email.value })
    listaInputs.push({ id: "telefono", valor: telefono.value })
    listaInputs.push({ id: "nombreUsuario", valor: nombreUsuario.value })

    //esto solo guarda o moodifica, si no existe si te lo guarda, pero si existe algo sobreescribe
    localStorage.setItem("misDatos", JSON.stringify(listaInputs))

    console.log(localStorage.getItem("misDatos"))


    // mostrar mensaje de que ya lo hemos recogido
    setTimeout(() => {
        alert("Ya he recodigo tus datos")
    }, 500)


})
