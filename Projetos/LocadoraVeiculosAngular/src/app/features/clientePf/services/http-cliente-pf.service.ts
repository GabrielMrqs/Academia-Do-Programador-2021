import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { ClientePfCreateViewModel } from '../viewModels/ClientePfCreateViewModel';
import { ClientePfDetailsViewModel } from '../viewModels/ClientePfDetailsViewModel';
import { ClientePfEditViewModel } from '../viewModels/ClientePfEditViewModel';
import { ClientePfListViewModel } from '../viewModels/ClientePfListViewModel';
import { IHttpClientePfService } from './IHttpClientePfService';

@Injectable({
  providedIn: 'root'
})
export class HttpClientePfService
extends HttpBaseService<ClientePfListViewModel, ClientePfDetailsViewModel, ClientePfCreateViewModel, ClientePfEditViewModel>
implements IHttpClientePfService{

  diretorio='ClienteCPF'
}
