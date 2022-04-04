export class Cliente{
    get cpf(){
    return  this._cpf;  // deixando o atributo privado, assim ninguem consegue alterar fora desse documento
    }
    constructor(nome, cpf){
    this.nome = nome;
    this._cpf = cpf;
    }
}