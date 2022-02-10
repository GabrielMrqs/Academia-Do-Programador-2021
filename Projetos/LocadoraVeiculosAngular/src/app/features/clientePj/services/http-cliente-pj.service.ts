import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { ClientePjCreateViewModel } from '../viewModels/ClientePjCreateViewModel';
import { ClientePjDetailsViewModel } from '../viewModels/ClientePjDetailsViewModel';
import { ClientePjEditViewModel } from '../viewModels/ClientePjEditViewModel';
import { ClientePjListViewModel } from '../viewModels/ClientePjListViewModel';
import { IHttpClientePjService } from './IHttpClientePjService';

@Injectable({
  providedIn: 'root'
})
export class HttpClientePjService
extends HttpBaseService<ClientePjListViewModel, ClientePjDetailsViewModel, ClientePjCreateViewModel, ClientePjEditViewModel>
implements IHttpClientePjService{

  diretorio='ClienteCNPJ'
}
