// Lista de países del continente americano
const paisesAmerica = [
    { nombre: 'Selecciona un país', codigo: '' },
    { nombre: 'México', codigo: 'MX' },
    { nombre: 'Estados Unidos', codigo: 'US' },
    { nombre: 'Canadá', codigo: 'CA' },
    // ...resto de los países...
];

// Lista de estados de México
const estadosMexico = [
    'Selecciona un estado',
    'Aguascalientes',
    'Baja California',
    'Baja California Sur',
    // ...resto de los estados...
];

// Encuentra los selectores en tu HTML
const paisSelect = document.querySelector('select[name="pais"]');
const estadoSelect = document.querySelector('select[name="estado"]');

// Llena el selector de países con una opción para cada país
paisesAmerica.forEach((pais) => {
    // Crea una nueva opción
    const option = document.createElement('option');
    option.value = pais.codigo;
    option.text = pais.nombre;

    // Añade la opción al selector
    paisSelect.appendChild(option);
});

// Llena el selector de estados con una opción para cada estado
estadosMexico.forEach((estado) => {
    // Crea una nueva opción
    const option = document.createElement('option');
    option.value = estado;
    option.text = estado;

    // Añade la opción al selector
    estadoSelect.appendChild(option);
});

// Cuando el país cambie, verifica si se seleccionó México
paisSelect.addEventListener('change', function() {
    if (this.value === 'MX') {
        // Si se seleccionó México, habilita el selector de estados
        estadoSelect.disabled = false;
    } else {
        // Si se seleccionó otro país, deshabilita el selector de estados y selecciona la opción inicial
        estadoSelect.disabled = true;
        estadoSelect.value = 'Selecciona un estado';
    }
});