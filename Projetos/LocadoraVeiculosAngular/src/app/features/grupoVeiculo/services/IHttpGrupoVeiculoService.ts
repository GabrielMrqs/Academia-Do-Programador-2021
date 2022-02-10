import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { GrupoVeiculoCreateViewModel } from "../viewModels/GrupoVeiculoCreateViewModel";
import { GrupoVeiculoDetailsViewModel } from "../viewModels/GrupoVeiculoDetailsViewModel";
import { GrupoVeiculoEditViewModel } from "../viewModels/GrupoVeiculoEditViewModel";
import { GrupoVeiculoListViewModel } from "../viewModels/GrupoVeiculoListViewModel";

export interface IHttpGrupoVeiculoService 
extends IHttpBaseService<GrupoVeiculoListViewModel, GrupoVeiculoDetailsViewModel, GrupoVeiculoCreateViewModel, GrupoVeiculoEditViewModel>{

}