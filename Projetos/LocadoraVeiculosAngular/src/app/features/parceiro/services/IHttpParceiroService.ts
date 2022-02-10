import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { ParceiroCreateViewModel } from "../viewModels/ParceiroCreateViewModel";
import { ParceiroDetailsViewModel } from "../viewModels/ParceiroDetailsViewModel";
import { ParceiroEditViewModel } from "../viewModels/ParceiroEditViewModel";
import { ParceiroListViewModel } from "../viewModels/ParceiroListViewModel";

export interface IHttpParceiroService 
extends IHttpBaseService<ParceiroListViewModel, ParceiroDetailsViewModel, ParceiroCreateViewModel, ParceiroEditViewModel>{

}