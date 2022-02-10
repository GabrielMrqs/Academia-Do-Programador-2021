import { IEditVM } from "src/app/shared/IEditVM"



export class VeiculoEditViewModel implements IEditVM{
    id: any
    nome: string
    numeroPlaca: string
    numeroChassi: string
    foto: string
    cor: string
    marca: string
    ano: number
    numeroPortas: number
    capacidadeTanque: number
    capacidadePessoas: number
    tamanhoPortaMalas: string
    kmInicial: number
    tipoCombustivel: string
    idGrupoVeiculo: number
}