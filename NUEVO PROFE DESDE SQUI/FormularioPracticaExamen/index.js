const nombre = document.getElementById("nombre")
const apellidos = document.getElementById("apellido")
const correo = document.getElementById("correo")
const contraseña = document.getElementById("contraseña")
const formulario = document.getElementById("formulario")


const dni = document.getElementById("dni")
const nie = document.getElementById("nie")


const radioDni = document.getElementById("radioDni")
const radioNie = document.getElementById("radioNie")

const boton = document.getElementById("boton")

const listaInputs = [];


//ocultar contenedores

contenedorDni.style.display = "grid";
contenedorNie.style.display = "none";


radioDni.addEventListener("click", () => {

    contenedorDni.style.display = "grid";
    contenedorNie.style.display = "none";

})

radioNie.addEventListener("click", () => {

    contenedorDni.style.display = "none";
    contenedorNie.style.display = "grid";

})


formulario.addEventListener("submit", (e) => {
    e.preventDefault();

    listaInputs.push({ id: "nombre", valor: nombre.value })
    listaInputs.push({ id: "apellidos", valor: apellidos.value })
    listaInputs.push({ id: "correo", valor: correo.value })
    listaInputs.push({ id: "contraseña", valor: contraseña.value })


    if (radioDni.checked) {
        listaInputs.push({ id: "dni", valor: dni.value })
    }
    if (radioNie.checked) {
        listaInputs.push({ id: "nie", valor: nie.value })
    }

    //esto solo guarda o moodifica, si no existe si te lo guarda, pero si nexiste algo sobreescribe
    localStorage.setItem("misDatos", JSON.stringify(listaInputs))

    console.log(localStorage.getItem("misDatos"))

    setTimeout(() => {
        alert("Ya he recodigo tus datos")
    }, 5000)

})