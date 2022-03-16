const express = require('express');
const app = express();

const efetuarCalculoIMC = require('./calculadoraIMC'); 

app.get('/', (req,res) => {

    let peso = req.query.peso;
    let altura = req.query.altura;

    let imc = efetuarCalculoIMC.efetuarCalculoIMC(peso,altura);

    res.json({imc : imc});
});
app.listen(8080 ,() => {
    let data = new Date();
    console.log('Servidor node iniciado em' +data);
});