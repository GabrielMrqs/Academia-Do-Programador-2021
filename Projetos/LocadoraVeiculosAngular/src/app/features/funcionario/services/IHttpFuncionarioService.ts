import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { FuncionarioCreateViewModel } from "../viewModels/FuncionarioCreateViewModel";
import { FuncionarioDetailsViewModel } from "../viewModels/FuncionarioDetailsViewModel";
import { FuncionarioEditViewModel } from "../viewModels/FuncionarioEditViewModel";
import { FuncionarioListViewModel } from "../viewModels/FuncionarioListViewModel";



export interface IHttpFuncionarioService 
extends IHttpBaseService<FuncionarioListViewModel, FuncionarioDetailsViewModel, FuncionarioCreateViewModel, FuncionarioEditViewModel>{

}