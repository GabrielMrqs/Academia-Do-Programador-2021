import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { FuncionarioCreateViewModel } from '../viewModels/FuncionarioCreateViewModel';
import { FuncionarioDetailsViewModel } from '../viewModels/FuncionarioDetailsViewModel';
import { FuncionarioEditViewModel } from '../viewModels/FuncionarioEditViewModel';
import { FuncionarioListViewModel } from '../viewModels/FuncionarioListViewModel';
import { IHttpFuncionarioService } from './IHttpFuncionarioService';

@Injectable({
  providedIn: 'root'
})
export class HttpFuncionarioService
extends HttpBaseService<FuncionarioListViewModel, FuncionarioDetailsViewModel, FuncionarioCreateViewModel, FuncionarioEditViewModel>
implements IHttpFuncionarioService {
  diretorio = 'Funcionario'

}
