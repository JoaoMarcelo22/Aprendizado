import {Cliente} from "./Cliente.js";
import{ContaCorrente} from "./ContaCorrente.js";
import {ContaPoupanca} from "./ContaPoupanca.js";

const cliente1 = new Cliente("Ricardo",11122233309 );

const cliente2 = new Cliente("Alice",88822233309);

const ContaCorrenteRicardo = new ContaCorrente(cliente1,1001);
ContaCorrenteRicardo.depositar(500);
ContaCorrenteRicardo.sacar(100);

const contaPoupanca = new ContaPoupanca(50,cliente1,1001);
contaPoupanca.sacar(10);

console.log(contaPoupanca);
console.log(ContaCorrenteRicardo);

//console.log(ContaCorrente.numeroDeContas);
// Boas praticas as classes São no maximo 1 por arquivo