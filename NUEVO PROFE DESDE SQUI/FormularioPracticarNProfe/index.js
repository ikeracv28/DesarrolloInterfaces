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

const formulario = document.getElementById("miFormulario");

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
    listaInputs.push({ id: "apellidos", valor: nombre.value })
    listaInputs.push({ id: "edad", valor: nombre.value })
    listaInputs.push({ id: "politica", valor: nombre.value })


    if (radioDni.checked) {
        listaInputs.push({ id: "dni", valor: dni.value })
    }
    if (radioNie.checked) {
        listaInputs.push({ id: "nie", valor: nie.value })
    }

    //esto solo guarda o moodifica, si no existe si te lo guarda, pero si nexiste algo sobreescribe
    localStorage.setItem("misDatos", JSON.stringify(listaInputs))

    console.log(localStorage.getItem("misDatos"))


})
