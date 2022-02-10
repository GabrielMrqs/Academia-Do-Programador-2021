import { IEditVM } from "src/app/shared/IEditVM";

export class FuncionarioEditViewModel implements IEditVM {
    id: any
    nome: string
    salario: number
    dataEntrada: Date
    cpfFuncionario: string
    usuario: string
    senha: string
}