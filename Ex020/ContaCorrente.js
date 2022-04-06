import { Conta } from "./Conta.js";
export class ContaCorrente extends Conta{  
    static numeroDeContas = 0;
    constructor(Cliente, agencia){
        super(0, Cliente, agencia); 
        ContaCorrente.numeroDeContas += 1;
    }
    sacar(valor){
        let taxa =1.1;
        return this._sacar(valor,taxa);
    }
}
// #saldo =0 https://github.com/tc39/proposal-class-fields#private-fields
// usando os acessores, recebe os atributos para a criação das class "Objetos". apenas no momento da criação por esse motivo o "This."
// Construtor da classe pai (Conta)
// erança da class Conta