import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { VeiculoCreateViewModel } from "../viewModels/VeiculoCreateViewModel";
import { VeiculoDetailsViewModel } from "../viewModels/VeiculoDetailsViewModel";
import { VeiculoEditViewModel } from "../viewModels/VeiculoEditViewModel";
import { VeiculoListViewModel } from "../viewModels/VeiculoListViewModel";



export interface IHttpVeiculoService 
extends IHttpBaseService<VeiculoListViewModel, VeiculoDetailsViewModel, VeiculoCreateViewModel, VeiculoEditViewModel>{

}