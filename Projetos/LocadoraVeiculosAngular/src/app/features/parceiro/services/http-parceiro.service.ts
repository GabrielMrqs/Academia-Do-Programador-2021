
import { Injectable } from '@angular/core';
import { HttpBaseService } from 'src/app/shared/services/http-base.service';
import { ParceiroCreateViewModel } from '../viewModels/ParceiroCreateViewModel';
import { ParceiroDetailsViewModel } from '../viewModels/ParceiroDetailsViewModel';
import { ParceiroEditViewModel } from '../viewModels/ParceiroEditViewModel';
import { ParceiroListViewModel } from '../viewModels/ParceiroListViewModel';
import { IHttpParceiroService } from './IHttpParceiroService';

@Injectable({
    providedIn: 'root'
})
export class HttpParceiroService
extends HttpBaseService<ParceiroListViewModel, ParceiroDetailsViewModel, ParceiroCreateViewModel, ParceiroEditViewModel> 
implements IHttpParceiroService
{
    diretorio='Parceiro'
}