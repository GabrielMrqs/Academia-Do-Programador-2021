import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { ServicoCreateViewModel } from '../viewModels/ServicoCreateViewModel';
import { ServicoDetailsViewModel } from '../viewModels/ServicoDetailsViewModel';
import { ServicoEditViewModel } from '../viewModels/ServicoEditViewModel';
import { ServicoListViewModel } from '../viewModels/ServicoListViewModel';
import { IHttpServicoService } from './IHttpServicoService';

@Injectable({
  providedIn: 'root'
})
export class HttpServicoService 
extends HttpBaseService<ServicoListViewModel, ServicoDetailsViewModel, ServicoCreateViewModel, ServicoEditViewModel> 
implements IHttpServicoService {

  diretorio='Servico'
}
