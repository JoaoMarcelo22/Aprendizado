const express = require('express');

const app = express();

let data = new Date();

app.get('/',(req, res) => {
    let mensagem = {mensagem: 'ola, mundo!'};
    res.json(mensagem);
});

app.listen(8080, () => {
    
    console.log('Servidor Node iniciado em. ' + data);
});