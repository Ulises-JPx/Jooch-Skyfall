// Seleccionamos los formularios
const signupForm = document.querySelector('.signup form');
const loginForm = document.querySelector('.login form');

// Función para manejar el registro
signupForm.addEventListener('submit', function(event) {
    event.preventDefault(); // Evitamos que el formulario se envíe de la manera predeterminada

    const email = this.elements['email'].value;
    const password = this.elements['pswd'].value;

    // Aquí puedes hacer una petición a tu servidor para crear el usuario
    // Por ahora, solo vamos a guardar los datos en localStorage
    localStorage.setItem('email', email);
    localStorage.setItem('password', password);

    // Redirigimos a la otra página
    window.location.href = 'forms.html';
    return false;
});

// Función para manejar el inicio de sesión
loginForm.addEventListener('submit', function(event) {
    event.preventDefault(); // Evitamos que el formulario se envíe de la manera predeterminada

    const email = this.elements['email'].value;
    const password = this.elements['pswd'].value;

    // Aquí puedes hacer una petición a tu servidor para autenticar al usuario
    // Por ahora, solo vamos a verificar los datos en localStorage
    const storedEmail = localStorage.getItem('email');
    const storedPassword = localStorage.getItem('password');

    if (email === storedEmail && password === storedPassword) {
        // Si las credenciales son correctas, redirigimos a la otra página
        window.location.href = 'otra_pagina.html';
    } else {
        // Si las credenciales son incorrectas, mostramos un mensaje de error
        alert('Las credenciales son incorrectas');
    }
});