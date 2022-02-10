import { IEditVM } from "src/app/shared/IEditVM"

export class ClientePjEditViewModel implements IEditVM{
    id: any
    nome:string
    endereco:string 
    telefone:string
    cnpj:string
    email:string
}