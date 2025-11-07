const nombre = document.getElementById("nombre")
const apellidos = document.getElementById("apellidos")
const dni = document.getElementById("dni")
const nie = document.getElementById("nie")


const radioDni = document.getElementById("radioDni")
const radioNie = document.getElementById("radioNie")

const edad = document.getElementById("edad")
const politica = document.getElementById("politica")
const contenedorDni = document.getElementById("contenedorDni")
const contenedorNie = document.getElementById("contenedorNie")


//ocultar contenedores

contenedorDni.style.display = "none";
contenedorNie.style.display = "none";

radioDni.addEventListener("click", () => {

    contenedorDni.style.display = "grid";
    contenedorNie.style.display = "none";



})

radioNie.addEventListener("click", () => {

    contenedorDni.style.display = "none";
    contenedorNie.style.display = "grid";



})