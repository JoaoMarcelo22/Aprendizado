const express = require('express');
const app = express();

app.get('/',(req,res) => {

    let medida = req.query.medida;
    let distancia = req.query.distancia;
});



app.listen(8080 , () => {
    let data = new Date();
    console.log('Servidor node iniciado em: ' + data);
});