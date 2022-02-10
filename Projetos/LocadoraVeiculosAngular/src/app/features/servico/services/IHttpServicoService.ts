import { IHttpBaseService } from "src/app/shared/services/IHttpBaseService";
import { ServicoCreateViewModel } from "../viewModels/ServicoCreateViewModel";
import { ServicoDetailsViewModel } from "../viewModels/ServicoDetailsViewModel";
import { ServicoEditViewModel } from "../viewModels/ServicoEditViewModel";
import { ServicoListViewModel } from "../viewModels/ServicoListViewModel";

export interface IHttpServicoService
extends IHttpBaseService<ServicoListViewModel, ServicoDetailsViewModel, ServicoCreateViewModel, ServicoEditViewModel> {

}