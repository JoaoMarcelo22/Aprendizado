const { response } = require('express');
const express = require('express');

const app = express();

app.get('/',(req, res) =>{
    response.send('Hello,Word!');
});

app.listen(8080, () =>{
    let data = new Date();
    console.log('Servidor Node iniciado em. ' + data)
});