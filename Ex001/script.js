const objt = [
    {
        "nome":"joao",
        "idade": 15,
        "trabalhando": false,
        "hobbies": ["jogar","nadar"]
    },
    {
        "nome":"matheus",
        "idade": 21,
        "trabalhando":true,
        "hobbies":["correr","pescar"]
    }
]
//JSON
//CONVERTER OBJETO PARA JSON
const json01 = JSON.stringify(objt)
console.log(json01)
console.log(typeof json01)

//CONVERTER JSON PARA OBJETO
const json02 =JSON.parse(json01)
console.log(json02)
console.log(typeof json02)

json02.map((pessoa) =>
console.log(pessoa.nome)
)