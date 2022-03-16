let data = new Date();

let hora = data.getHours();

let min = data.getMinutes();

let saudacao;

if (hora <= 11){
    saudacao = "BOM DIA."; 
} else if (hora <= 17){
    saudacao = "BOA TARDE."
} else {
    saudacao = "BOA NOITE."
}

console.log("Olá! " + saudacao)

console.log("Agora São " + hora + "Horas e" + min + "minutos" )

;;