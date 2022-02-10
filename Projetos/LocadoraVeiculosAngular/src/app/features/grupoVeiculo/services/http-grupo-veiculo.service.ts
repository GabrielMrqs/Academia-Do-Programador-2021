import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { GrupoVeiculoCreateViewModel } from '../viewModels/GrupoVeiculoCreateViewModel';
import { GrupoVeiculoDetailsViewModel } from '../viewModels/GrupoVeiculoDetailsViewModel';
import { GrupoVeiculoEditViewModel } from '../viewModels/GrupoVeiculoEditViewModel';
import { GrupoVeiculoListViewModel } from '../viewModels/GrupoVeiculoListViewModel';
import { IHttpGrupoVeiculoService } from './IHttpGrupoVeiculoService';

@Injectable({
  providedIn: 'root'
})
export class HttpGrupoVeiculoService
extends HttpBaseService<GrupoVeiculoListViewModel, GrupoVeiculoDetailsViewModel, GrupoVeiculoCreateViewModel, GrupoVeiculoEditViewModel>
implements IHttpGrupoVeiculoService {

  diretorio = 'GrupoVeiculo'
}
