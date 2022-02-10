import { IEditVM } from "src/app/shared/IEditVM"

export class ClientePfEditViewModel implements IEditVM{
    id: any
    nome:string
    endereco:string 
    telefone:string
    cpf:string
    email:string
    rg:string
    cnh:string
    dataValidade:Date
    idCliente:number
}