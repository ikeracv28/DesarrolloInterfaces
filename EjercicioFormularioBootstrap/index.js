let formulario = document.getElementById("formulario");

let nombre = document.getElementById("nombre")

let apellido = document.getElementById("apellido")

let email = document.getElementById("email");

let password = document.getElementById("password");

let enviar = document.getElementById("enviar");

console.log(formulario, email, password, enviar);

enviar.addEventListener("click", (e) => {

    e.preventDefault();

    console.log(nombre.value);
    console.log(apellido.value);
    console.log(email.value);
    console.log(password.value);



    if (password.value == 123) {
        alert("Eres tonto, te van a robar")

        document.body.style.background = "red"
    } else {
        document.body.style.background = "green"
    }

})

