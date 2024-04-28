// rutas/unityRoutes.js
const express = require('express');

module.exports = (db) => {
    const router = express.Router();
    let ultimoPost = null;

    router.post('/unity', (req, res) => {
        const { nombre, puntos } = req.body;
        console.log(`Nombre: ${nombre}, Puntos: ${puntos}`);
        ultimoPost = { nombre, puntos };
        res.json({ message: 'Datos recibidos con éxito', nombre: nombre, puntos: puntos });
    });

    router.get('/ultimoPost', (req, res) => {
        if (ultimoPost) {
            res.json(ultimoPost);
        } else {
            res.status(404).send('No se ha realizado ningún POST todavía');
        }
    });

    return router;
};