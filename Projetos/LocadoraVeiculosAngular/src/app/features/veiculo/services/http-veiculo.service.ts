import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { VeiculoCreateViewModel } from '../viewModels/VeiculoCreateViewModel';
import { VeiculoDetailsViewModel } from '../viewModels/VeiculoDetailsViewModel';
import { VeiculoEditViewModel } from '../viewModels/VeiculoEditViewModel';
import { VeiculoListViewModel } from '../viewModels/VeiculoListViewModel';
import { IHttpVeiculoService } from './IHttpVeiculoService';

@Injectable({
  providedIn: 'root'
})
export class HttpVeiculoService
extends HttpBaseService<VeiculoListViewModel, VeiculoDetailsViewModel, VeiculoCreateViewModel, VeiculoEditViewModel>
implements IHttpVeiculoService {

  diretorio = 'Veiculo'
}
