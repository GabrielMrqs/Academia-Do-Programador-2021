import { IEditVM } from "src/app/shared/IEditVM";

export class GrupoVeiculoEditViewModel implements IEditVM{
    id: any
    nomeTipo: string
    valorDiarioPDiario: number
    valorKmRodadoPDiario: number
    valorDiarioPControlado: number
    limitePControlado: number
    valorKmRodadoPControlado: number
    valorDiarioPLivre: number
}