import {Cliente} from "./Cliente.js";
export class ContaCorrente{
    static numeroDeContas = 0;
     // #saldo =0 https://github.com/tc39/proposal-class-fields#private-fields

    set Cliente(novoValor){
        if(novoValor instanceof Cliente){
            this._cliente = novoValor;
        }
    }

    get Cliente(){
        return this._cliente;
    }

    get Saldo(){
        return this._saldo;
    }
    constructor(Cliente, agencia){
        this.agencia = agencia;
        this.Cliente = Cliente; 
        this._Saldo = 0;
        ContaCorrente.numeroDeContas += 1;// usando os acessores, recebe os atributos para a criação das class "Objetos". apenas no momento da criação por esse motivo o "This."
    }

    sacar(valor){
        if(this._saldo >= valor){
            this._saldo -= valor;
            return valor;
        }
    }

    depositar(valor){
        if(valor <= 0)
        {
            return;
        } 
        this._saldo += valor;           
    }
    transferir(valor, conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }
}