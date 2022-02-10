import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { CupomCreateViewModel } from '../viewModels/CupomCreateViewModel';
import { CupomDetailsViewModel } from '../viewModels/CupomDetailsViewModel';
import { CupomEditViewModel } from '../viewModels/CupomEditViewModel';
import { CupomListViewModel } from '../viewModels/CupomListViewModel';
import { IHttpCupomService } from './IHttpCupomService';

@Injectable({
  providedIn: 'root'
})
export class HttpCupomService
extends HttpBaseService<CupomListViewModel, CupomDetailsViewModel, CupomCreateViewModel, CupomEditViewModel> 
implements IHttpCupomService {

  diretorio='Desconto'

}
