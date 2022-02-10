import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { CupomCreateViewModel } from "../viewModels/CupomCreateViewModel";
import { CupomDetailsViewModel } from "../viewModels/CupomDetailsViewModel";
import { CupomEditViewModel } from "../viewModels/CupomEditViewModel";
import { CupomListViewModel } from "../viewModels/CupomListViewModel";

export interface IHttpCupomService 
extends IHttpBaseService<CupomListViewModel, CupomDetailsViewModel, CupomCreateViewModel, CupomEditViewModel>{

    
}