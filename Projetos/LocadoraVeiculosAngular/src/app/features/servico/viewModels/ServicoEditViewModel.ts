import { IEditVM } from "src/app/shared/IEditVM";


export class ServicoEditViewModel implements IEditVM {
    id: any
    nome: string;
    preco: number
    calculoTipo: number
}