export class Conta{
     constructor(saldoInicial, cliente, agencia){
        this._saldo = saldoInicial;
        this._cliente = cliente;
        this._agencia = agencia;
    }
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
    sacar(valor){
        let taxa =1
        return this._sacar(valor,taxa)
    }
    _sacar(valor,taxa){
        const valorSacado = taxa * valor;
        if(this._saldo >= valorSacado){
            this._saldo -= valorSacado;
            return valorSacado;
        }
        return 0;
    }
    depositar(valor){
        this._saldo += valor;           
    }
    transferir(valor, conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }
}