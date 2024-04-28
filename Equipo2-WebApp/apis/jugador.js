// rutas/jugadorRoutes.js
const express = require('express');

module.exports = (db) => {
    const router = express.Router();

    router.get('/', async (req, res) => {
        try {
            const results = await db.query('SELECT * FROM Jugadores');
            res.json(results);
        } catch (err) {
            console.error('Error al obtener los jugadores:', err);
            res.status(500).send('Error al obtener los jugadores');
        }
    });

    return router;
};