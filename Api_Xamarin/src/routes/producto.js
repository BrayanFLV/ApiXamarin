const express = require('express');

const router = express.Router();
const pool = require('../database.js');

//Productos play
router.get('/play', async (req, res) => {
  const play = await pool.query('SELECT * FROM play');
  res.json(play);
});

router.get('/play1', async (req, res) => {
  const play = await pool.query('SELECT * FROM play WHERE id_play = 1');
  res.json(play);
});

router.get("/play:id",async(req, res) => {
  const { id } = req.params;
  const play1 = await pool.query('SELECT * FROM play WHERE id_play = ?',[id]);
  res.json(play1);
});

//productos xbox
router.get('/xbox', async (req, res) => {
  const xbox = await pool.query('SELECT * FROM xbox');
  res.json(xbox);
});
  
router.get("/xbox:id",async(req, res) => {
  const { id } = req.params;
  const xbox1 = await pool.query('SELECT * FROM play WHERE id_xbox = ?',[id]);
  res.json(xbox1);
});
module.exports = router;

//productos Nintendo
router.get('/nintendo', async (req, res) => {
  const Nintendo = await pool.query('SELECT * FROM nintendo');
  res.json(Nintendo);
});
  
router.get("/nintendo:id",async(req, res) => {
  const { id } = req.params;
  const Nintendo1 = await pool.query('SELECT * FROM play WHERE id_nintendo = ?',[id]);
  res.json(Nintendo1);
});

// usuarios
router.get('/usuarios', async (req, res) => {
  const Nintendo = await pool.query('SELECT * FROM usuarios');
  res.json(Nintendo);
});
  
router.get("/usuarios:id",async(req, res) => {
  const { id } = req.params;
  const usuario1 = await pool.query('SELECT * FROM play WHERE id_usuario = ?',[id]);
  res.json(usuario1);
});
module.exports = router;