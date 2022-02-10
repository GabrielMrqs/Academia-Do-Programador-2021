import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { ClientePjCreateViewModel } from "../viewModels/ClientePjCreateViewModel";
import { ClientePjDetailsViewModel } from "../viewModels/ClientePjDetailsViewModel";
import { ClientePjEditViewModel } from "../viewModels/ClientePjEditViewModel";
import { ClientePjListViewModel } from "../viewModels/ClientePjListViewModel";

export interface IHttpClientePjService 
extends IHttpBaseService<ClientePjListViewModel, ClientePjDetailsViewModel, ClientePjCreateViewModel, ClientePjEditViewModel>{

}