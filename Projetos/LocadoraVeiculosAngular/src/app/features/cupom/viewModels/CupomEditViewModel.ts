import { IEditVM } from "src/app/shared/IEditVM";

export class CupomEditViewModel implements IEditVM{
    id: number;
    nome: string;  
    codigo: string;
    valor: number;
    tipo: number;
    validade: Date;
    idParceiro: number;
    meio: string
    valorMinimo: number;
}