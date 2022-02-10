import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { ClientePfCreateViewModel } from "../viewModels/ClientePfCreateViewModel";
import { ClientePfDetailsViewModel } from "../viewModels/ClientePfDetailsViewModel";
import { ClientePfEditViewModel } from "../viewModels/ClientePfEditViewModel";
import { ClientePfListViewModel } from "../viewModels/ClientePfListViewModel";

export interface IHttpClientePfService 
extends IHttpBaseService<ClientePfListViewModel, ClientePfDetailsViewModel, ClientePfCreateViewModel, ClientePfEditViewModel>{

}